using System;

 public class Point
{
    public double r;
    public double fi;

    public void Init(double radius, double angle)
    {
        r = radius;
        fi = angle;
    }

    public void Read()
    {
        Console.Write("Введите радиус: ");
        r = Convert.ToDouble(Console.ReadLine());

        do
        {
            Console.Write($"Введите значение угла fi (в радианах от 0 до {2 * Math.PI:F4}): ");
            fi = Convert.ToDouble(Console.ReadLine());

            if (fi < 0 || fi >= 2 * Math.PI)
            {
                Console.WriteLine($"Ошибка: неверно введен угол fi. Пожалуйста, введите значение от 0 до {2 * Math.PI:F4}");
            }
        } while (fi < 0 || fi >= 2 * Math.PI);
    }

    public void Display()
    {
        Console.WriteLine($"Радиус: {r}");
        Console.WriteLine($"Угол: {fi} радиан");
    }

    public double DistanceToOX()
    {
        return r * Math.Abs(Math.Sin(fi));
    }

    public Point Add(Point p)
    {
        Point newPoint = new Point();
        newPoint.r = r + p.r;
        newPoint.fi = (fi + p.fi) % (2 * Math.PI);
        return newPoint;
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point();
        p1.Init(5.0, Math.PI / 4);
        p1.Read();
        p1.Display();
        double distance = p1.DistanceToOX();
        Console.WriteLine($"Расстояние от точки до OX: {distance:F4}");

        Point p2 = new Point();
        p2.Read();
        p2.Display();
        double distance2 = p2.DistanceToOX();
        Console.WriteLine($"Расстояние от точки до OX: {distance2:F4}");

        Point sum = p1.Add(p2);
        Console.WriteLine("Сумма точек:");
        sum.Display();

        Console.WriteLine("Вызов метода двумя способами:");
        Point pt = new Point();
        pt.Init(12, 5);
        pt.Display();
        ((Point)pt).Display();


        Console.ReadKey();
    }

}
