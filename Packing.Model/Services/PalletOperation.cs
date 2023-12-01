﻿namespace Packing.Service;

class PalletOperation : IPalletOperation
{
    public int GetPendingBoxes(Unit.IPalletProperties unit, Context.ILoteParameters context) =>
        context.BoxesByPallet - GetProducedBoxes(unit, context);

    public int GetPendingBoxes(Unit.ILabel unit, Context.IPack context) =>
        unit.Number - context.Minor;

    public int GetProducedBoxes(Unit.IPalletProperties unit, Context.ILoteParameters context) =>
        (unit.Levels * context.BoxesByLevel) + unit.Boxes;

    public int GetProducedBoxes(Unit.ILabel unit, Context.IPack context) =>
        context.Length - GetPendingBoxes(unit, context);
}