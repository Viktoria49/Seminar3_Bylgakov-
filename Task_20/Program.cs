// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.Write("Введите координаты x для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты x для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double cord = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));

Console.WriteLine(Math.Round (cord, 2, MidpointRounding.ToZero));

// string Cordinat(int number)
// {
//     if (num == 1) return "Диапазон возможных координат x > 0 и y > 0";
//     if (num == 2) return "Диапазон возможных координат x < 0 и y > 0";
//     if (num == 3) return "Диапазон возможных координат x < 0 и y < 0";
//     if (num == 4) return "Диапазон возможных координат x > 0 и y < 0";
//     return("Введен некорректный номер четверти");
// }

// string result = Cordinat(num);
// Console.WriteLine(result);
