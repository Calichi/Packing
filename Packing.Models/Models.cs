namespace Packing.Models;

public readonly record struct
    Label(int Number) : Model.ILabel;


public readonly record struct
    Pallet(int Number,
           int Levels,
           int Boxes) : Tracing.Model.IPallet;


public readonly record struct
    LotParameters(Model.IPalletParameters Pallet,
                  Model.ILabelParameters Label) : Tracing.Model.ILotParameters;


public readonly record struct
    LabelParameters(int MinorNumber,
                    int MajorNumber) : Model.ILabelParameters;


public readonly record struct
    PalletParameters(int LevelsPerPallet,
                     int BoxesPerLevel) : Model.IPalletParameters;