namespace Packing.Unit;

public interface IConverter
{
    ILabel ToLabel(IPalletProperties source);
    IPalletProperties ToPalletProperties(ILabel source);
}
