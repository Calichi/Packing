﻿namespace Packing.Unit.Service;

public interface IFactory
{
    ILabel NewLabel(int number);
    IPalletProperties NewPalletProperties(int levels, int boxes);
}
