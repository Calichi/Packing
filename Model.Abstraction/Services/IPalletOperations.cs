namespace Packing.Model.Abstraction.Services;

public interface IPalletOperations : IPalletOperation<ILabel, ILabelPack>,
                                     IPalletOperation<IPalletProperties, ILoteParameters>
{
}