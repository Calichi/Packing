using Packing.Tracing;

namespace Packing.Models;

public readonly record struct
    Label(int Number) : Tracing.ILabel;


public readonly record struct
    Pallet(int Number,
           int Levels,
           int Boxes) : Tracing.IPallet;


public readonly record struct
    LabelParameters(int MinorNumber,
                    int MajorNumber) : Model.ILabelParameters;


public readonly record struct
    PalletParameters(int LevelsPerPallet,
                     int BoxesPerLevel,
                     int BoxesPerPallet) : Model.IPalletParameters;


public readonly record struct
    LoteParameters(Model.ILabelParameters Label,
                   Model.IPalletParameters Pallet) : ILoteParameters;