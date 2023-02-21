// task1 Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
// Написать программу масштабирования фигуры

/*
double InputInteger(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Даны уравнения: y = k1 * x + b1, y = k2 * x + b2");

double k1 = InputInteger("Введите коэффициент к1:");
double b1 = InputInteger("Введите значение b1:");
double k2 = InputInteger("Введите коэффициент к2:");
double b2 = InputInteger("Введите значение b2:");

double x = Math.Round((b2 - b1) / (k1 - k2), 2);
double y = Math.Round(k1 * x + b1, 2);

Console.WriteLine($"Координаты точки пересения прямых: {x}; {y}"); 
 
*/

/* task2 Написать программу масштабирования фигуры. Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
*/

/*
int[] inputData()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        if ((i%2==0) && (i==0 || i==1)) Console.WriteLine("Точка А");
        else if ((i%2==0) && (i==2 || i==3)) Console.WriteLine("Точка B");
        else if ((i%2==0) && (i==4 || i==5)) Console.WriteLine("Точка C");
        else if ((i%2==0) && (i==6 || i==7)) Console.WriteLine("Точка D");

        Console.WriteLine(i%2==0 ? "Введите координату x:" : "Введите координату y:");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int[] array = inputData();
Console.WriteLine($"Координаты: ({array[0]},{array[1]}) ({array[2]},{array[3]}) ({array[4]},{array[5]}) ({array[6]},{array[7]})");
Console.WriteLine("Введите коэффициент масштабирования:");
int k = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Новые координаты: ({array[0]*k},{array[1]*k}) ({array[2]*k},{array[3]*k}) ({array[4]*k},{array[5]*k}) ({array[6]*k},{array[7]*k})");


*/
 
 //task3 Написать программу копирования массива
 /*
 static void Copy()
 {
        int[] array = {1, 3, 9, 23, 11};

        Console.Write("Original array: ");
        Console.WriteLine(String.Join(", ", array));
        
        int[] copy = new int[array.Length];
        array.CopyTo(copy, 0);

        Console.Write("Copy of array:  ");
        Console.WriteLine(String.Join(", ", copy));
 }

 Copy();

*/