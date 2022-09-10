// See https://aka.ms/new-console-template for more information

Console.WriteLine();
Console.WriteLine("Pyramid App");

if (args.Length == 0)
{
    Console.WriteLine("Please enter pyramid level");
    return;
}

var inputLevel = args[0];

var isValidLevel = int.TryParse(inputLevel, out int level);

if (!isValidLevel)
{
    Console.WriteLine($"Level '{inputLevel}' is invalid");
    return;
}

var totalXs = 2 * level - 1;
var spacesToPrint = totalXs / 2;

Console.WriteLine($"Level: {level}");
Console.WriteLine();

for (int line = 1; line <= level; line++)
{
    Console.Write($"{line.ToString().PadLeft(level.ToString().Length)} ");
    Console.Write(new string(' ', spacesToPrint));

    var numberXsToPrint = 2 * line - 1;
    Console.Write(new string('X', numberXsToPrint));

    Console.WriteLine();
    spacesToPrint--;
}

Console.WriteLine();