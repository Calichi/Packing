add-type -path "Unit\*.cs",
               "Unit\Contexts\*.cs",
               "Unit\Services\Implementation\Validation\*.cs",
               "Unit\Services\*.cs",
               "Unit\Services\Implementation\*.cs"

$contextFactory = [Packing.Unit.Context.Factory]::new();
$lpack = $contextFactory.NewLabelPack(2,61);
$lparams = $contextFactory.NewLoteParameters(15, 10, 6);
$context = $contextFactory.NewBundle($lpack, $lparams);

$serviceFactory = [Packing.Unit.Service.ServiceFactory]::new();
$palletOperation = $serviceFactory.NewPalletOperation();
$unitValidator = $serviceFactory.NewValidator($palletOperation);
$unitFactory = $serviceFactory.NewUnitFactory($context, $unitValidator);
$converter = $serviceFactory.NewConverter($context, $palletOperation, $unitFactory);

new-variable -name context -value $context -scope global;
new-variable -name palletOperation -value $palletOperation -scope global;
new-variable -name unitFactory -value $unitFactory -scope global;
new-variable -name converter -value $converter -scope global;

new-variable -name lb02 -value $unitFactory.NewLabel(2) -scope global;
new-variable -name lb61 -value $unitFactory.NewLabel(61) -scope global;