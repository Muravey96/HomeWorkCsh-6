/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();

Console.WriteLine("Формула:y = k1 * x + b1 ; y = k2 * x + b2; ");
double k1= GetNumberFromUser("Введите число k1: ","Ошибка ввода!");
double b1= GetNumberFromUser("Введите число b1: ","Ошибка ввода!");
double k2= GetNumberFromUser("Введите число k2: ","Ошибка ввода!");
double b2= GetNumberFromUser("Введите число b2: ","Ошибка ввода!");

Console.WriteLine($"y={k1}*x+{b1} ; y={k2}*x+{b2}");

double pointX= FindPointX(k1, b1, k2, b2);
double pointY= k1*pointX + b1;
Console.Write("Точка пересечения координат: ");
Console.WriteLine($"k1={k1}, b1={b1}, k2={k2}, b2={b2} -> ({pointX};{pointY})");

//////////////////////

double GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
        if(isCorrect) 
           return userNumber;
        Console.WriteLine(errorMessage);   
    }
}

/////////////////////

double FindPointX(double k1, double b1, double k2, double b2)
{
    double result= (b2-b1)/(k1-k2);
    return result;
}


