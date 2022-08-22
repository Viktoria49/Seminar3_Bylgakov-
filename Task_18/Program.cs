// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

string Cordinat(int number)
{
    if (num == 1) return "Диапазон возможных координат x > 0 и y > 0";
    if (num == 2) return "Диапазон возможных координат x < 0 и y > 0";
    if (num == 3) return "Диапазон возможных координат x < 0 и y < 0";
    if (num == 4) return "Диапазон возможных координат x > 0 и y < 0";
    return("Введен некорректный номер четверти");
}

string result = Cordinat(num);
Console.WriteLine(result);
