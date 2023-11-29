namespace Packing.Model.Service;

public class PalletOperation : IPalletOperation
{
    public int GetPendingBoxes(Unit.IPalletProperties unit, Context.ILoteParameters context) =>
        context.BoxesByPallet - GetProducedBoxes(unit, context);

    public int GetPendingBoxes(Unit.ILabel unit, Context.ILabelPack context) =>
        unit.Number - context.Minor;

    public int GetProducedBoxes(Unit.IPalletProperties unit, Context.ILoteParameters context) =>
        (unit.Levels * context.BoxesByLevel) + unit.Boxes;

    public int GetProducedBoxes(Unit.ILabel unit, Context.ILabelPack context) =>
        context.Length - GetPendingBoxes(unit, context);
}
