Console.Clear();

Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 0;
void PrintArrayGroup(int[,] arr)
{
    for (int i = 0; i < Convert.ToInt32(arr.GetLength(0)); i++)
    {
        Console.Write($"Группа {i + 1}: ");
        for (int j = 0; j < Convert.ToInt32(arr.GetLength(1)); j++)
        {
            if (arr[i, j] > 0) Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int countGroup(int x)
{
    if (x == 0) return m;
    m++;
    return countGroup(x / 2);
}
m = countGroup(n);
Console.WriteLine($"Для числа {n} групп {m}");
int[,] numberGroup = new int[m, n];
for (int i = 1; i <= n; i++)
{
    bool exit = false;
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < i; k++)
        {
            if (numberGroup[j, k] > 0 && i % numberGroup[j, k] == 0)
            {
                break;
            }
            if (numberGroup[j, k] == 0)
            {
                numberGroup[j, k] = i;
                exit = true;
                break;
            }
        }
        if (exit == true) break;
    }
}
PrintArrayGroup(numberGroup);