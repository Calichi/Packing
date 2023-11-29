﻿namespace Packing.Model.Unit;

public interface IFactory
{
    ILabel NewLabel(int number);
    IPalletProperties NewPalletProperties(int levels, int boxes);
}
