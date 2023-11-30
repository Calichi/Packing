namespace Packing.Service;

public interface IConverter
{
    Unit.ILabel ToLabel(Unit.IPalletProperties source);
    Unit.IPalletProperties ToPalletProperties(Unit.ILabel source);
}