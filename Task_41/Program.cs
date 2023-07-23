// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountMoreZiro(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += 1;
        }
    }
    return sum;
}

int[] GenerateUserArray(int size)
{
    int[] array = new int[size];
    int num = 1;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {num}-е число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        num++;
    }
    return array;
}

int GetInput (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInput("Сколько чисел Вы хотите ввести? : ");
int[] array = GenerateUserArray(size);
int sum = CountMoreZiro(array);
Console.Write($"{String.Join(", ", array)} -> {sum}");

