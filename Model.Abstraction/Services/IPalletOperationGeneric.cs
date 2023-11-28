namespace Packing.Model.Abstraction.Services;

public interface IPalletOperation<T, C>
{
    int GetBoxesPending(T unit, C context);
    int GetBoxesProduced(T unit, C context);
}
