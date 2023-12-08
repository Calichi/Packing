namespace Packing.Model;

public interface ILabelParameters
{
    int MinorNumber { get; }
    int MajorNumber { get; }
    int LabelsAmount => MajorNumber - MinorNumber + 1;
}
