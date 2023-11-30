namespace Packing.Unit.Service;

public interface IUnitFactory
{
    ILabel NewLabel(int number);
    IPalletProperties NewPalletProperties(int levels, int boxes);
}
