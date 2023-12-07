using namespace Packing.Testing;

Import-Project Packing.Pallets, Packing.Labels, Packing.Convertion, Packing, Packing.Testing;

$palletParams = [PalletParameters]::new(10, 6);
$labelPack = [Pack]::new(2, 61);
$convertionParams = [Parameters]::new($palletParams, $labelPack);
$packer = [Packing.Packer]::new($convertionParams);
$l32 = [Label]::new(32);