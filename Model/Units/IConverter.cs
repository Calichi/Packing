namespace Packing.Model.Unit;

public interface IConverter
{
    ILabel ToLabel(IPalletProperties source);
    IPalletProperties ToPalletProperties(ILabel source);
}
