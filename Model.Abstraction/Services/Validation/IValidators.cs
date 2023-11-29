namespace Packing.Model.Abstraction.Services;

public interface IValidators : 
    IRangeValidator<ILabel, ILabelPack>,
    IRangeValidator<IPalletProperties, ILoteParameters>;
