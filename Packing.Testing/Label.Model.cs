namespace Packing.Testing;

readonly record struct Pack(int MinorNumber, int MajorNumber) : Labels.IPack;
readonly record struct Label(int Number) : Labels.ILabel;
