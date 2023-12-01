namespace Packing.Factory.UnitValidation;

class Validator(Service.IPalletOperation palletOperation) : IValidator
{
    public Service.IPalletOperation PalletOperation { get; } = palletOperation;

    public bool IsValid(Unit.ILabel unit, Context.IPack context) =>
        IsInside(unit.Number, new LabelRange(context));

    public bool IsValid(Unit.IPalletProperties unit, Context.ILoteParameters context) =>
        IsInside(PalletOperation.GetProducedBoxes(unit, context), new BoxesByPalletRange(context))
        &&IsInside(unit.Levels, new LevelsByPalletRange(context))
        &&IsInside(unit.Boxes, new BoxesByLevelRange(context));
    
    bool IsInside(int value, IRange range) =>
        range.Min <= value && value <= range.Max;
}
