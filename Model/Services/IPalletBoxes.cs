namespace Packing.Model.Services;

public interface IPalletBoxes
{
    int GetProduced(IPalletProperties palletProperties);
    int GetPending(IPalletProperties palletPropoerties);
    int GetProduced(ILabel label);
    int GetPending(ILabel label);
}
