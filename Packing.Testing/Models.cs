namespace Packing.Testing;

public readonly record struct Label(int Number) : Labels.ILabel;
public readonly record struct Pallet(int Levels, int Boxes) : Pallets.IPallet;
public readonly record struct Pack(int MinorNumber, int MajorNumber) : Labels.IPack;
public readonly record struct PalletParameters(int LevelsPerPallet, int BoxesPerLevel) : Pallets.IParameters;
public readonly record struct Parameters(Pallets.IParameters Pallet, Labels.IPack Label) : Convertion.IParameters;
