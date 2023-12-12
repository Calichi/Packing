using namespace Packing.Models;

Import-Project Packing.Model,
               Packing.Core,
               Packing.Tracing,
               Packing.Models

$palletParams = [PalletParameters]::new(10, 6);
$labelParams = [LabelParameters]::new(2, 61);
$loteParams = [LoteParameters]::new($palletParams, $labelParams);
$beginPallet = [Pallet]::new(1, 5, 0);
$endPallet = [Label]::new(1);
$packer = [Packing.Tracing.Packer]::new($loteParams, $beginPallet, $endPallet);