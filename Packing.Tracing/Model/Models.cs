using Packing.Core;

namespace Packing.Tracing;

// Mapeamiento del modelo Packing.Model

public interface ILabel : Model.ILabel;
public interface ILabelPack : Model.ILabel, Model.ILabelParameters;
public interface IPallet : Model.ILabel, Model.IPallet;
public interface ILoteParameters : Model.IConverterParameters;

// Implementación interna del modelo mapeado

readonly record struct Label(int Number) : ILabel;
readonly record struct LabelPack(int Number, int MinorNumber, int MajorNumber) : ILabelPack;