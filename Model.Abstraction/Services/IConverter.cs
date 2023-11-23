namespace Packing.Model.Abstraction.Services;

public interface IConverter
{
    ILabel ToLabel(IPalletProperties palletProperties);
    IPalletProperties ToPalletProperties(ILabel label);

    public interface IDependencies
    {
        ILabelPack LabelPack { get; }
        ILoteParameters LoteParameters { get; }
        IFactory Factory { get; }
        IPalletBoxes PalletBoxes { get; }
    }
}
