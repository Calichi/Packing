using Packing.Pallets;
using Packing.Labels;
using Packing.Convertion;

namespace Packing;

public class Packer(Convertion.IParameters parameters)
{
    public Convertion.IParameters Parameters { get; } = parameters;

    public int GetPalletPendingBoxes(ILabel label) =>
        label.GetPendingBoxes(Parameters.Label);

    public int GetPalletProducedBoxes(ILabel label) =>
        label.GetProducedBoxes(Parameters.Label);

    public int GetPalletPendingBoxes(IPallet pallet) =>
        pallet.GetPendingBoxes(Parameters.Pallet);

    public int GetPalletProducedBoxes(IPallet pallet) =>
        pallet.GetProducedBoxes(Parameters.Pallet);

    public ILabel ToLabel(IPallet pallet) =>
        pallet.ToLabel(Parameters);

    public IPallet ToPallet(ILabel label) =>
        label.ToPallet(Parameters);

    public IPallet ToPallet(IPack pack) =>
        ToPallet(pack.GetMajorLabel());

    public IPack ToLabelPack(IPallet pallet) =>
        ToLabelPack(ToLabel(pallet));

    public IPack ToLabelPack(ILabel majorLabel) =>
        majorLabel.ToLabelPack(Parameters.Label);

    public bool IsValid(ILabel label) =>
        label.IsValid(Parameters.Label);

    public bool IsValid(IPallet pallet) =>
        pallet.IsValid(Parameters.Pallet);
}