namespace Packing.Model.Units;

public interface IOperationService<T,C>
{
    int GetProducedPalletBoxes(T unit, C context);
    int GetPendingPalletBoxes(T unit, C context);
}
