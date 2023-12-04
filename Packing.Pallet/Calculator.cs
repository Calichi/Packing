namespace Packing.Pallet;

//Pallet establece directivas generales

public static class Calculator
{
    public static int GetProducedBoxes(this IParameters parameters, IProperties palletProps) =>
        (palletProps.Levels * parameters.BoxesPerLevel) + palletProps.Boxes;

    public static int GetPendingBoxes(this IParameters parameters, IProperties palletProps) =>
        parameters.BoxesPerPallet - GetProducedBoxes(parameters, palletProps);
}
