// See https://aka.ms/new-console-template for more information

using Packing.Labels;
using Packing.Testing;

int number = 61;
Pack pack = new(2, number);
Label label = new(number);

Console.WriteLine(pack);
Console.WriteLine(label);
Console.WriteLine($"Pending boxes: {label.GetPendingBoxes(pack)}");
Console.WriteLine($"Produced boxes: {label.GetProducedBoxes(pack)}");
Console.ReadLine();
