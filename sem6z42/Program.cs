// Задача 42: Напишите программу, которая будет преобразовывать 
//десятичное число в двоичное.45 -> 1011013  -> 112  -> 10

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"В двоичной системе: {ConvertTo2(num)}");

string ConvertTo2(int num_local)
{
    string s = "";
    while (num_local > 0)
    {
        s = ((num_local % 2 == 0) ? "0" : "1") + s;
        num_local /= 2;
    }
    if (s == "") s = "0";
    return s;
}


//Задача 44: Не используя рекурсию, выведите 
//первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8



/*Console.WriteLine();
Console.Write("Введите число: ");
int num2 = int.Parse(Console.ReadLine());

int[] array = new int[num2];
array[0] = 0;
array[1] = 1;

for (int i = 2; i < num2; i++)
{
    array[i] = array[i-1] + array[i-2];
}

Console.WriteLine("Фибоначи: " + String.Join(", ", array));*/



