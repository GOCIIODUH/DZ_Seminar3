// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите координаты точки А");
System.Console.Write("х = ");
int xA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("y = ");
int yA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("z = ");
int zA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B");
System.Console.Write("х = ");
int xB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("y = ");
int yB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("z = ");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = Math.Round(Math.Sqrt((xB-xA)*(xB-xA)+(yB-yA)*(yB-yA)+(zB-zA)*(zB-zA)), 2);

System.Console.WriteLine($"Расстояние между точками A и B составляет {dist}");
