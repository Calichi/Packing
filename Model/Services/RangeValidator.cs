namespace Packing.Model.Services;

public class RangeValidator : IRangeValidator<ILabel, ILabelPack>,
                              IRangeValidator<IPalletProperties, ILoteParameters>
{
    public bool IsValid(ILabel value, ILabelPack context) =>
        IsInside(value.Number, new LabelRange(context));

    public bool IsValid(IPalletProperties value, ILoteParameters context) =>
        IsInside(value.Levels, new PalletLevelsRange(context)) &&
        IsInside(value.Boxes, new LevelBoxesRange(context));

    bool IsInside(int value, IRange range) =>
        range.Min <= value && value <= range.Max;
}