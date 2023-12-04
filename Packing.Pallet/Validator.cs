namespace Packing.Pallet;

public static class Validator
{
    public static bool IsValid(this IProperties props, IParameters parameters) =>
        props.Levels > -1 &&
        props.Boxes > -1 &&
        props.Levels <= parameters.LevelsPerPallet &&
        props.Boxes <= parameters.BoxesPerLevel &&
        props.GetPendingBoxes(parameters) > -1;
}
