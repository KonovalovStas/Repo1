string name;

Console.Write($"Hello, what's your name? : ");
name = Console.ReadLine()!;
string name2 = "Gulnaz";
string name3 = "Arishka";

PrintText(name);
PrintText(name2);
PrintText(name3);

void PrintText(string text)
{
    for (int i = 0; i < text.Length + 2; i++)
        Console.Write("-");
    Console.Write($"\n|{text}|\n");
    for (int i = 0; i < text.Length + 2; i++)
        Console.Write("-");
    Console.WriteLine();
}