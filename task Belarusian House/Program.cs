Console.WriteLine("Belarusian House");

string entrance = Console.ReadLine();
for (int i = 0; i < 10; i++)
{

    ConsoleColor[] cl = new ConsoleColor[] { ConsoleColor.White, ConsoleColor.Red, ConsoleColor.White };
    for (int k = 0; k < 3; k++)
    {
        Console.BackgroundColor = cl[k];
        Console.Write(entrance);
    }
    Console.WriteLine();
}
Console.BackgroundColor = ConsoleColor.Black;