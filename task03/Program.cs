//Напишите программу, которая будет создавать копию 
//заданного массива с помощью поэлементного копирования.

// Метод, который создает произвольный массив
int[] Array()
{
int num = 20;
Random rmd = new Random();
int[] arrs = new int[num];
for (int i = 0; i < num; i++)
{
    arrs[i] = rmd.Next(0, 55);
}
return arrs;
}

// Метод, который копирует массив по элементно
int[] YoungArray(int[] oldarray)
{
    int[] youngarrs = new int[oldarray.Length];
    for (int i = 0; i < oldarray.Length; i++)
    {
        youngarrs[i] = oldarray[i];
    }
    return youngarrs;
}


Console.Clear();
int[] oldarray = Array();
Console.WriteLine(String.Join(" ", oldarray));
int[] youngarray = YoungArray(oldarray);
Console.WriteLine(String.Join(" ", youngarray));
