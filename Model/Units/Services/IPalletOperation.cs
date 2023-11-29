namespace Packing.Unit;

public interface IPalletOperation<U,C>
{
    int GetProducedBoxes(U unit, C context);
    int GetPendingBoxes(U unit, C context);
}

public interface IPalletOperation :
    IPalletOperation<ILabel, Context.ILabelPack>,
    IPalletOperation<IPalletProperties, Context.ILoteParameters>;