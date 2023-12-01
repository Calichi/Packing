namespace Packing.Pallet.Parameters;

public interface ILabel
{
    int Minor { get; }
    int Major { get; }
    int Length => Major - Minor + 1;
}
