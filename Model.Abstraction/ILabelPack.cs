namespace Packing.Model.Abstraction;

public interface ILabelPack
{
    int Minor { get; }
    int Major { get; }
    int Length => Major - Minor + 1;
}
