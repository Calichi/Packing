add-type -path "ug.cs",
               "Model.Abstraction\*.cs",
               "Model.Abstraction\Services\*.cs",
               "Model\*.cs",
               "Model\Services\*.cs"

$service = [Packing.Model.Services.ServiceDataFactory]::new();
$lpack = $service.NewLabelPack(2, 61);
$lparams = $service.NewLoteParameters(15, 10, 6);
$ctxt = $service.NewContext($lpack, $lparams);
$v = [Packing.Model.Services.RangeValidator]::new();

$model = [Packing.Model.Services.ModelFactory]::new($ctxt, $v);
$pop = [Packing.Model.Services.PalletOperations]::new();
$tools = $service.NewCalculatorTools($model, $pop);

$c = [Packing.Model.Services.Calculator]::new($ctxt, $tools);
new-variable -name s -value $service -scope global;
new-variable -name calc -value $c -scope global;
new-variable -name l61 -value $c.Tool.Factory.NewLabel(61) -scope global;
new-variable -name p01 -value $c.ToPalletProperties($l61) -scope global;
new-variable -name l02 -value $c.Tool.Factory.NewLabel(2) -scope global;
new-variable -name p10 -value $c.ToPalletProperties($l02) -scope global;
new-variable -name lp -value $service.NewLabelPack(2,32) -scope global;
new-variable -name p -value $c.GetPalletProperties($lp) -scope global;