**string** - (строка, текст любой), эту команду вводят, когда пользователь может ввести не только число, но и текст.

Пример: 

**Console.Write($"Введите первое число: ");**

**string userEnter = Console.ReadLine()!;**

---------------------------------

**ReadLine()** - Метод ReadLine() используется для ввода строки символов типа string.

-----

**TryParse** - Попытка перевода текста(string) в перемееную (допустим а) 

Пример:

Console.Write($"Введите первое число: ");

int.TryParse(Console.ReadLine()!, out a);

---
__if__ - если

__else__ - иначе

Пример:

if (a == c)

{

    Console.Write($"Да");
}
else
{

    Console.Write($"Нет");
}

