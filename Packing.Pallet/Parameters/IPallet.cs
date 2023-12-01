namespace Packing.Pallet.Parameters;

public interface IPallet
{
    int BoxesPerLevel { get; }
    int SizeInLevels { get; }
    int SizeInBoxes => SizeInLevels * BoxesPerLevel;
}
