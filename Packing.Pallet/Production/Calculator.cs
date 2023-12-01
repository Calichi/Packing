namespace Packing.Pallet.Production;

//Pallet establece directivas generales
//LabelPack establece directivas especificas

public static class Calculator
{
    public static int GetProducedBoxes(this Parameters.IPallet palletParams, IProperties palletProps) =>
        (palletProps.Levels * palletParams.SizeInBoxes) + palletProps.Boxes;

    public static int GetPendingBoxes(this Parameters.IPallet palletParams, IProperties palletProps) =>
        palletParams.SizeInBoxes - GetProducedBoxes(palletParams, palletProps);
    
    public static int GetPendingBoxes(this Parameters.ILabel labelParams, ILabel label) =>
        label.Number - labelParams.Minor;

    public static int GetProducedBoxes(this Parameters.ILabel labelParams, ILabel label) =>
        labelParams.Length - GetPendingBoxes(labelParams, label);
}
