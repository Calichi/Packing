using Packing.Model;

namespace Packing.Core;

public static class ModelValidator
{
    public static bool IsValid(this IPallet pallet, IPalletParameters palletParams) =>
        pallet.Levels > -1 &&
        pallet.Boxes > -1 &&
        pallet.Levels <= palletParams.LevelsPerPallet &&
        pallet.Boxes <= palletParams.BoxesPerLevel &&
        pallet.GetPalletPendingBoxes(palletParams) > -1;

    public static bool IsValid(this ILabel label, ILabelParameters labelParams) =>
        labelParams.MinorNumber <= label.Number &&
        label.Number <= labelParams.MajorNumber; 
}
