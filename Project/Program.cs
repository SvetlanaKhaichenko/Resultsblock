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



Console.WriteLine("Введите массив из строк через запятую");
string read = Console.ReadLine().Replace(" ", "");
string[] userarray = read.Split(",");