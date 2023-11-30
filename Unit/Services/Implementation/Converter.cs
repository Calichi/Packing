namespace Packing.Unit.Service;

public class Converter(Context.IBundle context,
                       IFactory factory,
                       IPalletOperation palletOperation) : IConverter
{
    public Context.IBundle Context { get; } = context;
    public IFactory Factory { get; } = factory;
    public IPalletOperation PalletOperation { get; } = palletOperation;

    public ILabel ToLabel(IPalletProperties source) {
        var boxes = PalletOperation.GetPendingBoxes(source, Context.LoteParameters);
        return Factory.NewLabel(boxes + Context.LabelPack.Minor);
    }

    public IPalletProperties ToPalletProperties(ILabel source) {
        int boxes = PalletOperation.GetProducedBoxes(source, Context.LabelPack);
        int levels = Math.DivRem(boxes, Context.LoteParameters.BoxesByLevel, out boxes);
        return Factory.NewPalletProperties(boxes, levels);
    }
}
