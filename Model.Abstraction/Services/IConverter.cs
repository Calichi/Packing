namespace Packing.Model.Abstraction.Services;

public interface IConverter
{
    ILabel ToLabel(IPalletProperties palletProperties);
    IPalletProperties ToPalletProperties(ILabel label);
}
