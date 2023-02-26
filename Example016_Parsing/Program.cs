﻿// парсинг (обработка) входной строки
// даны пары координат, нужно увеличить каждую в два раза и выдать пользователю, если координата Х четная.


using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "")
                .Replace(")", "");


System.Console.WriteLine(text);

var data = text.Split(" ")  //входные данные разбить после каждого указанного в кавычках знака (пробел)
                .Select(item => item.Split(','))    // в получившейся выборке еще раз разбить данные относительно указанного знака
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))  // в выборке объявляем координату Х первому значению, У - второму и сразу переводим их тип в число
                .Where(e => e.x %2 == 0)    // везде где Х четный делаем то что дальше указано
                .Select(point => (point.x*2, point.y*2))    // в выборке по вышеуказанным условиям умножаем обе координаты на 2
                .ToArray(); // полученные данные записать в массив 

for (int i = 0; i < data.Length; i++)
{
    System.Console.WriteLine(data[i]);
}





