namespace Packing.Model.Unit.Validation;

readonly struct LabelRange(Context.ILabelPack context) : IRange
{
    public int Min { get; } = context.Minor;

    public int Max { get; } = context.Major;
}
