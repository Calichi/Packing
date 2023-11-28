namespace Packing.Model.Services;

internal class PalletLevelsRange(ILoteParameters loteParameters) : IRange
{
    public int Min { get; } = 0;

    public int Max { get; } = loteParameters.LevelsByPallet;
}
