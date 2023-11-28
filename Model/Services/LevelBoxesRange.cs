namespace Packing.Model;

public class LevelBoxesRange(ILoteParameters loteParameters) : IRange
{
    public int Min { get; } = 0;

    public int Max { get; } = loteParameters.BoxesByLevel;
}
