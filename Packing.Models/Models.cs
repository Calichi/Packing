namespace Packing.Models;

public readonly record struct
    Label(int Number) : Tracing.ILabel;


public readonly record struct
    Pallet(int Number,
           int Levels,
           int Boxes) : Tracing.IPallet;


public readonly record struct
    LoteParameters(Model.IPalletParameters Pallet,
                   Model.ILabelParameters Label) : Tracing.ILoteParameters;


public readonly record struct
    LabelParameters(int MinorNumber,
                    int MajorNumber) : Model.ILabelParameters;


public readonly record struct
    PalletParameters(int LevelsPerPallet,
                     int BoxesPerLevel) : Model.IPalletParameters;