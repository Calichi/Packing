namespace Packing.Context;

public interface IPack
{
    int Minor { get; }
    int Major { get; }
    int Length => Major - Minor + 1;
}