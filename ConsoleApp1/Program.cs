using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("#1");
        Console.WriteLine("координаты первого прямоугольника (x1 y1 x2 y2):");
        string[] input1 = Console.ReadLine().Split(" ");
        int x1_1 = int.Parse(input1[0]);
        int y1_1 = int.Parse(input1[1]);
        int x2_1 = int.Parse(input1[2]);
        int y2_1 = int.Parse(input1[3]);

        Console.WriteLine("координаты второго прямоугольника (x1 y1 x2 y2):");
        string[] input2 = Console.ReadLine().Split(" ");
        int x1_2 = int.Parse(input2[0]);
        int y1_2 = int.Parse(input2[1]);
        int x2_2 = int.Parse(input2[2]);
        int y2_2 = int.Parse(input2[3]);

        int minX = Math.Min(x1_1, x1_2);
        int minY = Math.Min(y1_1, y1_2);
        int maxX = Math.Max(x2_1, x2_2);
        int maxY = Math.Max(y2_1, y2_2);

        Console.WriteLine($"координаты минимального прямоугольника:");
        Console.WriteLine($"левый нижний угол: ({minX}, {minY})");
        Console.WriteLine($"правый верхний угол: ({maxX}, {maxY})");

        Console.WriteLine("#2");
        Console.WriteLine("площадь круга:");
        double circleArea = double.Parse(Console.ReadLine());

        Console.WriteLine("площадь квадрата:");
        double squareArea = double.Parse(Console.ReadLine());

        double circleRadius = Math.Sqrt(circleArea / Math.PI);

        double squareSide = Math.Sqrt(squareArea);

        bool circleFitsInSquare = circleRadius * 2 <= squareSide;

        bool squareFitsInCircle = squareSide <= circleRadius * Math.Sqrt(2);

        Console.WriteLine($"круг уместится в квадрате: {circleFitsInSquare}");
        Console.WriteLine($"квадрат уместится в круге: {squareFitsInCircle}");

        Console.WriteLine("#3");
        Console.WriteLine("число:");
        int number = int.Parse(Console.ReadLine());

        bool answer = number >= -5 && number <= 3;

        Console.WriteLine($"число находится в диаразоне от -5 до 3: {answer}");

        Console.WriteLine("#4");
        Console.WriteLine("введи трёхзначное число:");
        string[] input3 = Console.ReadLine().Split("");
        int n100 = int.Parse(input3[0]);
        int n10 = int.Parse(input3[1]);
        int n1 = int.Parse(input3[2]);

        if (n100 > n1) {Console.WriteLine("первое больше последнего");}
        else {Console.WriteLine("последнеe больше певрого");}

        if (n100 > n10) {Console.WriteLine("первое больше второго")}
        else {Console.WriteLine("второе больше первого")}

        if(n10 > n1) {Console.WriteLine("второе больше последнего")}
        else {Console.WriteLine("последнее больше второго")}

        Console.WriteLine("#5")
        Console.WriteLine("размеры кирпича (a, b, c):");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("размеры отверстия (x, y):");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());

        if (CanBrickFit(a, b, x, y) || CanBrickFit(a, c, x, y) || CanBrickFit(b, c, x, y)) {Console.WriteLine("кирпич может пройти через отверстие.");}
        else {Console.WriteLine("кирпич не может пройти через отверстие.");}
    }

    static bool CanBrickFit(double width, double height, double holeWidth, double holeHeight)
    {
        return (width <= holeWidth && height <= holeHeight) || (width <= holeHeight && height <= holeWidth);
    }
}