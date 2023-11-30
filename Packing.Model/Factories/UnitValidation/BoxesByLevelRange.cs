namespace Packing.Factory.UnitValidation;

readonly struct BoxesByLevelRange(Context.ILoteParameters context) : IRange
{
    public int Min { get; } = 0;

    public int Max { get; } = context.BoxesByLevel;
}
