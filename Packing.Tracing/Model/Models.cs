namespace Packing.Tracing.Model;

// Mapeamiento del modelo Packing.Model

public interface ILabelPack :
    Packing.Model.ILabel,
    Packing.Model.ILabelParameters;

public interface IPallet :
    Packing.Model.ILabel,
    Packing.Model.IPallet;

public interface ILotParameters :
    Packing.Model.IConverterParameters;

// Implementación interna del modelo mapeado

readonly record struct
    Label(int Number) : Packing.Model.ILabel;

readonly record struct
    LabelPack(int Number,
              int MinorNumber,
              int MajorNumber) : ILabelPack;