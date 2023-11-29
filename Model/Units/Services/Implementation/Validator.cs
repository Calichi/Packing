namespace Packing.Unit.Validation;

public class Validator(IPalletOperation palletOperation) : IValidator
{
    public IPalletOperation PalletOperation { get; } = palletOperation;

    public bool IsValid(ILabel unit, Context.ILabelPack context) =>
        IsInside(unit.Number, new LabelRange(context));

    public bool IsValid(IPalletProperties unit, Context.ILoteParameters context) =>
        IsInside(PalletOperation.GetProducedBoxes(unit, context), new BoxesByPalletRange(context));
    
    bool IsInside(int value, IRange range) =>
        range.Min <= value && value <= range.Max;
}
