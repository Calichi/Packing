namespace Packing.Convertion;

public interface IParameters
{
    Pallets.IParameters Pallet { get; }
    Labels.IPack Label { get; }
}
