namespace Packing.Tracing.Model;

public interface IPalletReport
{
    IPallet View { get; }
    Packing.Model.IBoxes Balance { get; }
}
