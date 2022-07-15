Console.Clear();

string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();
    }
    return words;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

//Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

/*

int FirstVowelLetterWord(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i].ToLower()[0] == 'a' || 
           array[i].ToLower()[0] == 'e' || 
           array[i].ToLower()[0] == 'i' || 
           array[i].ToLower()[0] == 'u' || 
           array[i].ToLower()[0] == 'y' || 
           array[i].ToLower()[0] == 'o') count++;
    return count;        
}

Console.Write("Input number of words: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] TheWords = CreateStringArray(size);

Console.Write($"Number of words starting with a vowel letter -> {FirstVowelLetterWord(TheWords)}");

*/

//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

/*

string[] UnionArrayElemets(string[] array)
{
    string[] result = new string[array.Length];
    
    for(int i = 0, j = 1; i < array.Length; i+=2, j+=2)
        if(j>=array.Length) result[i] = array[i];
            else result[i] = array[i] + array[j];
    
    return result;
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] Elements = CreateStringArray(size);
ShowArray(UnionArrayElemets(Elements));

*/