namespace Packing.Service;

class Converter(Context.IBundle context,
                IPalletOperation palletOperation,
                Factory.IUnits factory) : IConverter
{
    public Context.IBundle Context { get; } = context;
    public Factory.IUnits Factory { get; } = factory;
    public IPalletOperation PalletOperation { get; } = palletOperation;

    public Unit.ILabel ToLabel(Unit.IPalletProperties source) {
        var boxes = PalletOperation.GetPendingBoxes(source, Context.LoteParameters);
        return Factory.NewLabel(boxes + Context.LabelPack.Minor);
    }

    public Unit.IPalletProperties ToPalletProperties(Unit.ILabel source) {
        int boxes = PalletOperation.GetProducedBoxes(source, Context.LabelPack);
        int levels = Math.DivRem(boxes, Context.LoteParameters.BoxesByLevel, out boxes);
        return Factory.NewPalletProperties(levels, boxes);
    }
}
