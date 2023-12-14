using namespace Packing.Models;

Import-Project Packing.Model,
               Packing.Core,
               Packing.Tracing,
               Packing.Models

$palletParams = [PalletParameters]::new(10, 6);
$labelParams = [LabelParameters]::new(2, 61);
$loteParams = [LotParameters]::new($palletParams, $labelParams);
$beginPallet = [Pallet]::new(1, 5, 0);
$endPallet = [Label]::new(8);
$lot = [Packing.Tracing.Lot]::new($loteParams, $beginPallet, $endPallet);
$lotPC = [Packing.Tracing.LotProductionCompiler]::new();
$packer = [Packing.Tracing.Packer]::new($lot, $lotPC);