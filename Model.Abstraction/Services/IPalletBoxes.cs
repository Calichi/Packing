namespace Packing.Model.Abstraction.Services;

public interface IPalletBoxes
{
    int GetPending(ILabel label);
    int GetProduced(ILabel label);
    int GetPending(IPalletProperties palletProperties);
    int GetProduced(IPalletProperties palletProperties);
}