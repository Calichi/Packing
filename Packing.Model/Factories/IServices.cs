namespace Packing.Factory;

public interface IServices
{
    Service.IPalletOperation NewPalletOperation();
    UnitValidation.IValidator NewUnitValidator(Service.IPalletOperation palletOperation);
    IUnits NewUnitFactory(Context.IBundle context, UnitValidation.IValidator validator);
    Service.IConverter NewUnitConverter(Context.IBundle context,
                                        Service.IPalletOperation palletOperation,
                                        IUnits factory);
}
