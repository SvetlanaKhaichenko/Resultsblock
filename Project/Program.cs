string[] FindArray(string[] givenmas)
{
    int count = 0;
    for (int i = 0; i < givenmas.Length; i++)
    {
        if (givenmas[i].Length <= 3) count++;
    }
    string[] result = new string[givenmas.Length];
    if (count == 0) System.Console.WriteLine("Массив не содержит строк <= 3");
    else
    {
        for (int i = 0; i < givenmas.Length; i++)
        {
            if (givenmas[i].Length <= 3) result[i] = givenmas[i];
        }
    }
    return result;
}

void PrintMas(string[] mas)
{
    for (int i = 0; i < 1; i++)
    {
        if (mas[i].Length <= 3) System.Console.Write($"[{mas[i]}, ");
        else System.Console.WriteLine("[");
    }
    for (int j = 1; j < mas.Length - 1; j++)
    {
        if (mas[j] != null) Console.Write($"{mas[j]}, ");
    }
    for (int k = mas.Length - 1; k < mas.Length; k++)
    {
        if (mas[k].Length <= 3) System.Console.WriteLine($"{mas[k]}]");
        else System.Console.WriteLine("]");
    }
    //if (mas[i] != null ) System.Console.Write($"{mas[i]} ");
}


Console.WriteLine("Введите массив из строк через запятую");
string read = Console.ReadLine().Replace(" ", "");
string[] userarray = read.Split(",");

PrintMas (FindArray(userarray));