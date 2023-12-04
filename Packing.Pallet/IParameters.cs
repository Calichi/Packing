namespace Packing.Pallet;

public interface IParameters
{
    int LevelsPerPallet { get; }
    int BoxesPerLevel { get; }
    int BoxesPerPallet => LevelsPerPallet * BoxesPerLevel;
}
