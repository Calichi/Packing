add-type -path "Packing.Model\Contexts\*.cs",
               "Packing.Model\Units\*.cs",
               "Packing.Model\Factories\UnitValidation\*.cs",
               "Packing.Model\Factories\*.cs",
               "Packing.Model\Services\*.cs",
               "Packing.Model\*.cs"

$contextFactory = [Packing.Factory.Contexts]::new();
$lpack = $contextFactory.NewLabelPack(2,61);
$lparams = $contextFactory.NewLoteParameters(15, 10, 6);
$context = $contextFactory.NewBundle($lpack, $lparams);

$serviceFactory = [Packing.Factory.Services]::new();
$palletOperation = $serviceFactory.NewPalletOperation();
$unitValidator = $serviceFactory.NewUnitValidator($palletOperation);
$unitFactory = $serviceFactory.NewUnitFactory($context, $unitValidator);
$converter = $serviceFactory.NewUnitConverter($context, $palletOperation, $unitFactory);
$packing = [Packing.Calculator]::new(<#$context, $palletOperation, $unitFactory,#> $contextFactory, $converter);

new-variable -name context -value $context -scope global;
new-variable -name palletOperation -value $palletOperation -scope global;
new-variable -name unitFactory -value $unitFactory -scope global;
new-variable -name converter -value $converter -scope global;
new-variable -name packing -value $packing -scope global;
new-variable -name contextFactory -value $contextFactory -scope global;

new-variable -name lb02 -value $unitFactory.NewLabel(2) -scope global;
new-variable -name lb61 -value $unitFactory.NewLabel(61) -scope global;