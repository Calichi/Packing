namespace Packing.Unit.Service.Validation;

readonly struct LevelsByPalletRange(Context.ILoteParameters context) : IRange
{
    public int Min { get; } = 0;

    public int Max { get; } = context.LevelsByPallet;
}
