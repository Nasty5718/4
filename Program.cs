using System.Collections.Generic;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<IShape> shapes = new List<IShape>();

        // Создание экземпляров треугольников и прямоугольников
        Triangle triangle1 = new Triangle(3, 4, 5);
        Triangle triangle2 = new Triangle(4, 5, 6);
        Triangle triangle3 = new Triangle(6, 7, 8);
        Rectangle rectangle2 = new Rectangle(4, 5);
        Rectangle rectangle3 = new Rectangle(6, 7);

        // Добавление фигур в коллекцию
        shapes.Add(triangle1);
        shapes.Add(triangle2);
        shapes.Add(triangle3);
        shapes.Add(rectangle2);
        shapes.Add(rectangle3);

        // Рассчет суммарной площади треугольников и прямоугольников
        double totalArea = shapes.Sum(s => s.CalculateArea());

        // Вывод результата в консоль
        Console.WriteLine("Суммарная площадь всех фигур РАВНА: " + totalArea);
    }
}

// Интерфейс для фигур
interface IShape
{
    double CalculateArea();
}

// Класс "Треугольник"
class Triangle : IShape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double a, double b, double c)
    {
        SideA = a;
        SideB = b;
        SideC = c;
    }

    public double CalculateArea()
    {
        // Формула Герона для расчета площади треугольника
        double p = (SideA + SideB + SideC) / 2; // полупериметр
        double area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        return area;
    }
}

// Класс "Прямоугольник"
class Rectangle : IShape
{
    public double SideA { get; set; }
    public double SideB { get; set; }

    public Rectangle(double a, double b)
    {
        SideA = a;
        SideB = b;
    }

    public double CalculateArea()
    {
        double area = SideA * SideB;
        return area;
    }
}