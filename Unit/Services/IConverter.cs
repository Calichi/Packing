namespace Packing.Unit.Service;

public interface IConverter
{
    ILabel ToLabel(IPalletProperties source);
    IPalletProperties ToPalletProperties(ILabel source);
}