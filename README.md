# Итоговая проверочная работа.

&#10004; 1. Создать репозиторий на GitHub

[Тут](https://github.com/PetrashTank/FinalWork) ссылка на мою итоговую работу.

&#10004; 2. Нарисовать блок-схему алгоритма

![logo](/%D0%91%D0%BB%D0%BE%D0%BA%20%D1%81%D1%85%D0%B5%D0%BC%D0%B0.png)
&#10004; 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)

&#10004; 4. Написать программу, решающую поставленную задачу

Console.WriteLine("Введите хоть что-нибудь, через запятую ");

CreateStroka();

void CreateStroka()

{

    string stroka = Console.ReadLine()!;
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

&#10004; 5. Использовать контроль версий в работе над этим небольшим проектом
