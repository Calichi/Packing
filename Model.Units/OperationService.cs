namespace Packing.Model.Units;

public class OperationService :
    IOperationService<ILabel, Context.ILabelPack>,
    IOperationService<IPalletProperties, Context.ILoteParameters>
{
    public int GetPendingPalletBoxes(IPalletProperties unit, Context.ILoteParameters context) =>
        context.BoxesByPallet - GetProducedPalletBoxes(unit, context);

    public int GetPendingPalletBoxes(ILabel unit, Context.ILabelPack context) =>
        unit.Number - context.Minor;

    public int GetProducedPalletBoxes(IPalletProperties unit, Context.ILoteParameters context) =>
        (unit.Levels * context.BoxesByLevel) + unit.Boxes;

    public int GetProducedPalletBoxes(ILabel unit, Context.ILabelPack context) =>
        context.Length - GetPendingPalletBoxes(unit, context);
}
