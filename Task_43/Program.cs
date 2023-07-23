// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string FindCross(float b1, float k1, float b2, float k2)
{
    float y1 = k1 * (b2 - b1) / (k1 - k2) + b1;
    float y2 = k2 * (b2 - b1) / (k1 - k2) + b2;
    string cross = $"({y1}; {y2})";
    return cross;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int b1 = GetInput("Введите значение b1: ");
int k1 = GetInput("Введите значение k1: ");
int b2 = GetInput("Введите значение b2: ");
int k2 = GetInput("Введите значение k2: ");

string  cross = FindCross(b1, k1, b2, k2);
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> {cross} ");


