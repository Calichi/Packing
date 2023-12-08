using Packing.Model;

namespace Packing.Core;

public class Packer(IConverterParameters parameters)
{
    public IConverterParameters Parameters { get; } = parameters;

    public int GetPalletPendingBoxes(ILabel label) =>
        label.GetPalletPendingBoxes(Parameters.Label);

    public int GetPalletProducedBoxes(ILabel label) =>
        label.GetPalletProducedBoxes(Parameters.Label);

    public int GetPalletPendingBoxes(IPallet pallet) =>
        pallet.GetPalletPendingBoxes(Parameters.Pallet);

    public int GetPalletProducedBoxes(IPallet pallet) =>
        pallet.GetPalletProducedBoxes(Parameters.Pallet);

    public ILabel ToLabel(IPallet pallet) =>
        pallet.ToLabel(Parameters);

    public IPallet ToPallet(ILabel label) =>
        label.ToPallet(Parameters);

    public IPallet ToPallet(ILabelParameters pack) =>
        ToPallet(pack.GetMajorLabel());

    public ILabelParameters ToLabelPack(IPallet pallet) =>
        ToLabelPack(ToLabel(pallet));

    public ILabelParameters ToLabelPack(ILabel majorLabel) =>
        majorLabel.ToLabelPack(Parameters.Label);

    public bool IsValid(ILabel label) =>
        label.IsValid(Parameters.Label);

    public bool IsValid(IPallet pallet) =>
        pallet.IsValid(Parameters.Pallet);
}