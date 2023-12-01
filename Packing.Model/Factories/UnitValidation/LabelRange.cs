namespace Packing.Factory.UnitValidation;

readonly struct LabelRange(Context.IPack context) : IRange
{
    public int Min { get; } = context.Minor;

    public int Max { get; } = context.Major;
}
