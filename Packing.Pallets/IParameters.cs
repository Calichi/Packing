namespace Packing.Pallets;

public interface IParameters
{
    int LevelsPerPallet { get; }
    int BoxesPerLevel { get; }
    int BoxesPerPallet => LevelsPerPallet * BoxesPerLevel;
}
