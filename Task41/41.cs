/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3  */

Console.Clear();

int amountOfNum = GetNumberFromUser("Введите количество чисел: ","Ошибка ввода!");
int positiveNum = CountPositiveNumbers(amountOfNum);
Console.WriteLine($"-> {positiveNum}");



/////// Ввод кол-ва чисел пользователем 
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumbers);
        if(isCorrect)
            return userNumbers;
        Console.WriteLine(errorMessage);
    } 
}

//////////// Ввод чисел и подсчет кол-ва положительных чисел

int CountPositiveNumbers(int number)
{
    int[] userNum = new int[number];
    int sum = 0;
    for (int i=0; i<number; i++)
    {
        userNum[i] = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
        if (userNum[i] > 0) sum += 1;
    }
    Console.Write(String.Join(",", userNum));
    return sum;
}