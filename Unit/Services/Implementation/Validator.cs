namespace Packing.Unit.Service;

class Validator(IPalletOperation palletOperation) : IValidator
{
    public IPalletOperation PalletOperation { get; } = palletOperation;

    public bool IsValid(ILabel unit, Context.ILabelPack context) =>
        IsInside(unit.Number, new Validation.LabelRange(context));

    public bool IsValid(IPalletProperties unit, Context.ILoteParameters context) =>
        IsInside(PalletOperation.GetProducedBoxes(unit, context), new Validation.BoxesByPalletRange(context));
    
    bool IsInside(int value, Validation.IRange range) =>
        range.Min <= value && value <= range.Max;
}
