// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите положительные и отрицатеьные числа через пробел: \n");
int[] numM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
for (int i = 0; i < numM.Length; i++)
{
    if (numM[i] >= 1)
    {
        count++;
    }
}
System.Console.WriteLine("\nВ введенных вами числах " + count + " чис(ла)ел больше 0");



