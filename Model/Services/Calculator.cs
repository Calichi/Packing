namespace Packing.Model.Services;

public class Calculator(IContext context, ICalculatorTools tools) : ICalculator
{
    public ICalculatorTools Tool { get; } = tools;
    public IPalletProperties GetPalletProperties(ILabelPack labelPack) {
        var label = new Label(labelPack.Major);
        var palletProperties = ToPalletProperties(label);
        return Validate(palletProperties);
    }

    public ILabel ToLabel(IPalletProperties palletProperties) {
        var labelMinor = context.LabelPack.Minor;
        var boxesPending = GetBoxesPending(palletProperties);
        var label = new Label(boxesPending - labelMinor);
        return Validate(label);
    }

    public IPalletProperties ToPalletProperties(ILabel label) {
        int boxes = GetBoxesProduced(label);
        int levels = Math.DivRem(boxes, context.LoteParameters.BoxesByLevel, out boxes);
        var palletProperties = new PalletProperties(boxes, levels);
        return Validate(palletProperties);
    }

    int GetBoxesPending(IPalletProperties palletProperties) =>
        Tool.PalletOperation.GetBoxesPending(palletProperties, context.LoteParameters);

    int GetBoxesProduced(ILabel label) =>
        Tool.PalletOperation.GetBoxesProduced(label, context.LabelPack);
    
    ILabel Validate(ILabel label) =>
        Tool.Validator.Validate(label, context.LabelPack);

    IPalletProperties Validate(IPalletProperties palletProperties) =>
        Tool.Validator.Validate(palletProperties, context.LoteParameters);
}
