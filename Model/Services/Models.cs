namespace Packing.Model.Services;

record Context(ILabelPack LabelPack,
               ILoteParameters LoteParameters) : IContext;
record CalculatorTools(IFactory Factory,
                       IPalletOperations PalletOperation,
                       IValidators Validator) : ICalculatorTools;