using Packing.Model;

namespace Packing.Models;

public readonly record struct Label(int Number) : ILabel;
public readonly record struct Pallet(int Levels, int Boxes) : IPallet;
public readonly record struct LabelParameters(int MinorNumber, int MajorNumber) : ILabelParameters;
public readonly record struct PalletParameters(int LevelsPerPallet, int BoxesPerLevel) : IPalletParameters;
public readonly record struct ConverterParameters(IPalletParameters Pallet, ILabelParameters Label) : IConverterParameters;
