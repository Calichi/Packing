add-type -path "ug.cs",
               "Model.Abstraction\*.cs",
               "Model.Abstraction\Services\*.cs",
               "Model\*.cs",
               "Model\Services\*.cs"

$factory = [Packing.Model.Services.Factory]::new();
$lpack = $factory.NewLabelPack(2, 61);
$lparams = $factory.NewLoteParameters(15, 10, 6);
$ctxt = $factory.NewContext($lpack, $lparams);
$pop = [Packing.Model.Services.PalletOperations]::new();
$v = [Packing.Model.Services.RangeValidator]::new();
$tools = $factory.NewCalculatorTools($factory, $pop, $v);
$c = [Packing.Model.Services.Calculator]::new($ctxt, $tools);
new-variable -name calc -value $c -scope global;