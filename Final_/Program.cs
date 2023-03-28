string paragraph = "This book is largely concerned with Hobbits, and from its pages a reader may discover much of their character and a little of their history. Further information will also be found in the selection from the Red Book of Westmarch that has already been published, under the title of The Hobbit. That story was derived from the earlier chapters of the Red Book, composed by Bilbo himself, the first Hobbit to become famous in the world at large, and called by him There and Back Again, since they told of his journey into the East and his return: an adventure which later involved all the Hobbits in the great events of that Age that are here related. Many, however, may wish to know more about this remarkable people from the  outset, while some may not possess the earlier book. For such readers a few notes on the more important points are here collected from Hobbit-lore, and the first adventure is briefly recalled.";


/// Преобразование текста в массив слов

string[] GetPrgAsArrWord(string str)
{
    // удаляем точки, запятые и скобки из текста
    string[] replaceChar = { ".", ",", "(", ")" }; //добавить по необходимости
    for (int i = 0; i < replaceChar.Length; i++)
    {
        str = str.Replace(replaceChar[i], string.Empty);
    }
    return str.Split(' '); // возвращаем массив слов
}

/// Поиск слов по их длинне

string[] FindWordsByLength(string[] str, int wordLength)
{
    string newString = string.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= wordLength)
        {
            newString = newString + str[i] + " ";
        }
    }
    newString = newString.Trim();
    return newString.Split(" ");
}

// ПРОВЕРКИ
int wordLength = 3; // максимальная длинна искомого слова
Console.WriteLine("Исходный параграф:");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(paragraph);
Console.ResetColor();
Console.WriteLine();
Console.WriteLine("Найденые слова:");
string[] arrayString = FindWordsByLength(GetPrgAsArrWord(paragraph), wordLength);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write($"{string.Join(' ', arrayString)}");
Console.ResetColor();
Console.WriteLine();
