namespace Packing.Model.Services;

public interface IConverter
{
    ILabel ToLabel(IPalletProperties palletProperties);
    IPalletProperties ToPalletProperties(ILabel label);

    public interface IDependencies
    {
        ILabelContext LabelContext { get; }
        ILoteContext LoteContext { get; }
        IFactory Factory { get; }
        IPalletBoxes PalletBoxes { get; }
    }
}
