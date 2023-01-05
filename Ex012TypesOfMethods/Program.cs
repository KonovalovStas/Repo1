// Вид 1 которые не чего не принимают и не чего не возвращают
void Method1()
{
    Console.WriteLine("Автор итд ...");
}
Method1();


// Вид 2 Не чего не возвращают, но могут принимать какие ни будь аргументы

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст", 4);
Method21(count: 4, msg: "новый текст");

// Вид 3 Что то возвращают, но не чего не принимают.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4 Что то принимают и что то возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf\n");
Console.WriteLine(res);