int[] array = { 1, 2, 3, 4, 65, 4, 3, 66, 78 };

int n = array.Length;

int find = 4;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index +1;
    index++;
}


