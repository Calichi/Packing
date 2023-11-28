namespace Packing.Model.Abstraction.Services;

public interface IModelFactory
{
    ILabel NewLabel(int number);
    IPalletProperties NewPalletProperties(int levels, int boxes);
    //IPallet NewPallet(int number, int levels, int boxes);
}
