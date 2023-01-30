int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int [] array = {11,211,31,41,15,16,17,18,19};

array[0] = 12;  // заменить значение с индексом 0 на 12.

int result = Max(  
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8])
);

System.Console.WriteLine(result);