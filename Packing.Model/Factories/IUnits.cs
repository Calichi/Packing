namespace Packing.Factory;

public interface IUnits
{
    Unit.ILabel NewLabel(int number);
    Unit.IPalletProperties NewPalletProperties(int levels, int boxes);
}
