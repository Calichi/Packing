namespace Packing.Model.Services;

public class Calculator(IContext context, ICalculatorTools tools) : ICalculator
{
    public IContext Context { get; } = context;
    public ICalculatorTools Tool { get; } = tools;

    public IPalletProperties GetPalletProperties(ILabelPack labelPack) {
        var label = Tool.Factory.NewLabel(labelPack.Major);
        return ToPalletProperties(label);
    }

    public ILabel ToLabel(IPalletProperties palletProperties) {
        var labelMinor = Context.LabelPack.Minor;
        var boxesPending = GetBoxesPending(palletProperties);
        return Tool.Factory.NewLabel(boxesPending + labelMinor);
    }

    public IPalletProperties ToPalletProperties(ILabel label) {
        int boxes = GetBoxesProduced(label);
        int levels = Math.DivRem(boxes, Context.LoteParameters.BoxesByLevel, out boxes);
        return Tool.Factory.NewPalletProperties(levels, boxes);
    }

    int GetBoxesPending(IPalletProperties palletProperties) =>
        Tool.PalletOperation.GetBoxesPending(palletProperties, Context.LoteParameters);

    int GetBoxesProduced(ILabel label) =>
        Tool.PalletOperation.GetBoxesProduced(label, Context.LabelPack);
}
