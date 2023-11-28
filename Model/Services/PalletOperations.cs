namespace Packing.Model.Services;

public class PalletOperations : IPalletOperations
{
    public int GetBoxesPending(ILabel unit, ILabelPack context) =>
        unit.Number - context.Minor;

    public int GetBoxesPending(IPalletProperties unit, ILoteParameters context) =>
        context.BoxesByPallet - GetBoxesProduced(unit, context);

    public int GetBoxesProduced(ILabel unit, ILabelPack context) =>
        context.Length - GetBoxesPending(unit, context);

    public int GetBoxesProduced(IPalletProperties unit, ILoteParameters context) =>
        (unit.Levels * context.BoxesByLevel) + unit.Boxes;
}