namespace Packing.Model.Context;

public interface ILabelPack
{
    int Minor { get; }
    int Major { get; }
    int Length => Major - Minor + 1;
}
