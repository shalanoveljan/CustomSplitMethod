using CustomSplitMethod;

string text = "Elcan Bakidan Gelir";

char letter = 'n';

foreach (var item in text.CustomSplit(letter))
{
    Console.WriteLine(item);
}

Console.WriteLine("------------------");

foreach (var item in text.CustomSplit())
{
    Console.WriteLine(item);
}
