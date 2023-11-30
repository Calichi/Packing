namespace Packing.Factory;

public class Services : IServices
{
    public Service.IPalletOperation NewPalletOperation() =>
        new Service.PalletOperation();

    public UnitValidation.IValidator NewUnitValidator(Service.IPalletOperation palletOperation) =>
        new UnitValidation.Validator(palletOperation);

    public IUnits NewUnitFactory(Context.IBundle context, UnitValidation.IValidator validator) =>
        new Units(context, validator);

    public Service.IConverter NewUnitConverter(Context.IBundle context,
                                           Service.IPalletOperation palletOperation,
                                           IUnits unitFactory) =>
        new Service.Converter(context, palletOperation, unitFactory);
}
