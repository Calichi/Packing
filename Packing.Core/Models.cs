using Packing.Model;

namespace Packing.Core;

readonly record struct Label(int Number) : ILabel;
readonly record struct Pallet(int Levels, int Boxes) : IPallet;
readonly record struct LabelParameters(int MinorNumber, int MajorNumber) : ILabelParameters;
readonly record struct ProductionReport(int ProducedBoxes, int PendingBoxes) : IProductionReport;
