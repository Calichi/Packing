namespace Packing.Model;

readonly record struct Label(int Number) : Abstraction.ILabel;
readonly record struct PalletProperties(int Levels, int Boxes) : Abstraction.IPalletProperties;
readonly record struct LabelPack(int Minor, int Major) : Abstraction.ILabelPack;
readonly record struct Pallet(int Number, int Levels, int Boxes) : Abstraction.IPallet;
readonly record struct LoteParameters(int PalletsByLote, int LevelsByPallet, int BoxesByLevel) : Abstraction.ILoteParameters;
