namespace Packing.Pallets;

public static class Validation
{
    public static bool IsValid(this IPallet props, IParameters parameters) =>
        props.Levels > -1 &&
        props.Boxes > -1 &&
        props.Levels <= parameters.LevelsPerPallet &&
        props.Boxes <= parameters.BoxesPerLevel &&
        props.GetPendingBoxes(parameters) > -1;
}
