add-type -path "Model\*.cs",
               "Model\Contexts\*.cs",
               "Model\Units\Validation\*.cs",
               "Model\Units\*.cs",
               "Model\Services\*.cs"

$contextFactory = [Packing.Model.Context.Factory]::new();
$lpack = $contextFactory.NewLabelPack(2,61);
$lparams = $contextFactory.NewLoteParameters(15, 10, 6);
$context = $contextFactory.NewBundle($lpack, $lparams);
$palletOperation = [Packing.Model.Service.PalletOperation]::new();
$unitValidator = [Packing.Model.Unit.Validation.Validator]::new($palletOperation);
$unitFactory = [Packing.Model.Unit.Factory]::new($context, $unitValidator);

new-variable -name unitFactory -value $unitFactory -scope global;