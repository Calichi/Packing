namespace Packing.Model;

public interface IPalletParameters
{
    int LevelsPerPallet { get; }
    int BoxesPerLevel { get; }
    int BoxesPerPallet => BoxesPerLevel * LevelsPerPallet;
}
