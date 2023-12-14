namespace Packing.Tracing.Model;

public interface IReport
{
    int LotBoxesProduced { get; }
    IPalletReport Pallet { get; }
}
