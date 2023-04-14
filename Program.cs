Console.WriteLine("Задание 1: \n");

bool numberChech = true;

Random rnd = new Random();

while (numberChech)
{
    try
    {
        Console.WriteLine("Введите количество строк в матрице");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов в матрице");
        int b = Convert.ToInt32(Console.ReadLine());

        numberChech = false;

        int c = 0;

        int[,] mas = new int[b, a];

        Console.WriteLine("\nПервая случайная матрица: \n");

        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                mas[i, j] = rnd.Next(100, 200);
                Console.Write($"{mas[i, j]} ");
            }
            Console.WriteLine();
        }

        foreach (int i in mas)
        {
            c += i;
        }

        Console.WriteLine($"\nСумма всех элементов матрицы: {c}\n");
        Console.ReadKey();

        Console.WriteLine("Задание 2: \n");

        Console.WriteLine("Вторая случайная матрица: \n");

        int[,] mas1 = new int[b, a];

        for (int i = 0; i < mas1.GetLength(0); i++)
        {
            for (int j = 0; j < mas1.GetLength(1); j++)
            {
                mas1[i, j] = rnd.Next(100, 200);
                Console.Write($"{mas1[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nСумма двух матриц: \n");

        int[,] sumMas = new int[b, a];

        for (int i = 0; i < sumMas.GetLength(0); i++)
        {
            for (int j = 0; j < sumMas.GetLength(1); j++)
            {
                sumMas[i, j] = mas[i, j] + mas1[i, j];
                Console.Write($"{sumMas[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
    catch
    {
        Console.WriteLine("Это не число");
    }
}

Console.WriteLine("\nЗадание 3: \n");

int[,] petry = new int[11, 11];
int[,] petry1 = new int[11, 11];

for (int i = 0; i < petry.GetLength(0); i++)
{
    for (int j = 0; j < petry.GetLength(1); j++)
    {
        if(i == 0 || j == 0 || i == petry.GetLength(0) - 1 || j == petry.GetLength(1) - 1)
        {
            continue;
        }
        petry[i, j] = rnd.Next(0, 2);
        Console.Write($"{petry[i, j]} ");
    }
    Console.WriteLine();
}

bool live = true;
int age = 1;

while (live)
{
    Console.WriteLine($"Поколение номер {age}");

    for (int i = 0; i < petry.GetLength(0); i++)
    {
        for (int j = 0; j < petry.GetLength(1); j++)
        {
            if (i == 0 || j == 0 || i == petry.GetLength(0) - 1 || j == petry.GetLength(1) - 1)
            {
                continue;
            }

            if (i - 1 >= 0 && i + 1 < petry.GetLength(0) && j - 1 >= 0 && j + 1 < petry.GetLength(1))
            {

                if (petry[i, j + 1] + petry[i, j - 1] + petry[i + 1, j] + petry[i - 1, j] + petry[i + 1, j + 1] + petry[i - 1, j + 1] + petry[i - 1, j - 1] + petry[i + 1, j - 1] > 3)
                {
                    petry1[i, j] = 0;
                }
                else if (petry[i, j + 1] + petry[i, j - 1] + petry[i + 1, j] + petry[i - 1, j] + petry[i + 1, j + 1] + petry[i - 1, j + 1] + petry[i - 1, j - 1] + petry[i + 1, j - 1] < 3)
                {
                    petry1[i, j] = 0;
                }
                else
                {
                    petry1[i, j] = 1;
                }
            }
            Console.Write($"{petry1[i, j]} ");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < petry.GetLength(0); i++)
    {
        for (int j = 0; j < petry.GetLength(1); j++)
        {
            petry[i, j] = petry1[i, j];
        }
    }

    age += 1;

    string? a = Console.ReadLine();
    if (a == "exit")
        live = false;
}