namespace Packing.Model.Units.Validation;

public class Validator() :
    IValidator<ILabel, Context.ILabelPack>,
    IValidator<IPalletProperties, Context.ILoteParameters>
{
    public bool IsValid(IPalletProperties value, Context.ILoteParameters context) =>
        IsInside(value.Levels, new LevelsByPalletRange(context)) &&
        IsInside(value.Boxes, new BoxesByLevelRange(context));

    public bool IsValid(ILabel value, Context.ILabelPack context) =>
        IsInside(value.Number, new LabelRange(context));

    bool IsInside(int value, IRange range) =>
        range.Min <= value && value <= range.Max;
}
