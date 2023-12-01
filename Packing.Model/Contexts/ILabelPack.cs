namespace Packing.Context;

public interface ILabelPack : Unit.ILabel
{
    int Minor { get; }
    int Major { get; }
    int Length => Major - Minor + 1;
}