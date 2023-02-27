/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

Примеры:

[*hello", "2", "world", ":-)"] > ["2", "5)"]
["1234", "1567", "-2", "computer science"] > ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

Console.WriteLine("Введите хоть что-нибудь, через запятую ");
CreateStroka();
void CreateStroka()
{
    string stroka = string.Empty;
    stroka = Console.ReadLine()!;
    string[] N;
    N = stroka.Split(',');
    var result = new string[N.Length];
    var realSize = 0;
    foreach (var value in N)
    {
        if (value.Length <= 3)
        {
            result[realSize] = value;
            realSize++;
        }
    }
    Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
    Console.ReadKey(true);
}

