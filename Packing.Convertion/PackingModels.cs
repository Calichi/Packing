namespace Packing.Convertion;

readonly record struct Label(int Number) : Labels.ILabel;
readonly record struct Pallet(int Levels, int Boxes) : Pallets.IPallet;
readonly record struct Pack(int MinorNumber, int MajorNumber) : Labels.IPack;
