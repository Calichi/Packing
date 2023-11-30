namespace Packing.Unit.Service;

public class ServiceFactory
{
    public IPalletOperation NewPalletOperation() =>
        new PalletOperation();

    public IValidator NewValidator(IPalletOperation palletOperation) =>
        new Validator(palletOperation);

    public IUnitFactory NewUnitFactory(Context.IBundle context, IValidator validator) =>
        new UnitFactory(context, validator);

    public IConverter NewConverter(Context.IBundle context,
                                   IPalletOperation palletOperation,
                                   IUnitFactory unitFactory) =>
        new Converter(context, palletOperation, unitFactory);
}
