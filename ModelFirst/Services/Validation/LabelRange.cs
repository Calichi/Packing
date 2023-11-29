namespace Packing.Model.Services;

internal class LabelRange(ILabelPack labelPack) : IRange
{
    public int Min { get; } = labelPack.Minor;

    public int Max { get; } = labelPack.Major;
}
