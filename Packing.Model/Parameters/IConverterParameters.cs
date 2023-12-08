namespace Packing.Model;

public interface IConverterParameters
{
    IPalletParameters Pallet { get; }
    ILabelParameters Label { get; }
}
