namespace Packing.Model.Abstraction.Services;

public interface ICalculator : IConverter
{
    IPalletProperties GetPalletProperties(ILabelPack labelPack);
}
