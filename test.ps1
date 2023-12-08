using namespace Packing.Models;

Import-Project Packing.Model, Packing.Core, Packing.Models

$palletParams = [PalletParameters]::new(10, 6);
$labelParams = [LabelParameters]::new(2, 61);
$converterParams = [ConverterParameters]::new($palletParams, $labelParams);
$packer = [Packing.Core.Packer]::new($converterParams);
$l32 = [Label]::new(32);