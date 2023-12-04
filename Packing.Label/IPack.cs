namespace Packing.Label;

public interface IPack
{
    int MinorNumber { get; }
    int MajorNumber { get; }
    int LabelsAmount => MajorNumber - MinorNumber + 1;
}
