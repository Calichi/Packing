namespace Packing.Model.Service;

public interface IPalletOperation<U,C>
{
    int GetProducedBoxes(U unit, C context);
    int GetPendingBoxes(U unit, C context);
}

public interface IPalletOperation :
    IPalletOperation<Unit.ILabel, Context.ILabelPack>,
    IPalletOperation<Unit.IPalletProperties, Context.ILoteParameters>;