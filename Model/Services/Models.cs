namespace Packing.Model.Services;

record Context(ILabelPack LabelPack,
               ILoteParameters LoteParameters) : IContext;
record CalculatorTools(IModelFactory Factory,
                       IPalletOperations PalletOperation) : ICalculatorTools;