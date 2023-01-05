string Method4(int count, string text)
{

    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "asdf\n");
Console.WriteLine(res);