namespace Packing.Unit.Service;

class PalletOperation : IPalletOperation
{
    public int GetPendingBoxes(IPalletProperties unit, Context.ILoteParameters context) =>
        context.BoxesByPallet - GetProducedBoxes(unit, context);

    public int GetPendingBoxes(ILabel unit, Context.ILabelPack context) =>
        unit.Number - context.Minor;

    public int GetProducedBoxes(IPalletProperties unit, Context.ILoteParameters context) =>
        (unit.Levels * context.BoxesByLevel) + unit.Boxes;

    public int GetProducedBoxes(ILabel unit, Context.ILabelPack context) =>
        context.Length - GetPendingBoxes(unit, context);
}
