// Task 2 Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

double Length3D(double x1, double y1,double z1,double x2,double y2,double z2)
{
    double length = Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)),2);
    return length;
}
Console.WriteLine("Input coordinate X of the first point");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate Y of the first point");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate Z of the first point");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate X of the second point");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate Y of the second point");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate Z of the second point");
double z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Length between two drops is {Length3D(x1,y1,z1,x2,y2,z2)}");