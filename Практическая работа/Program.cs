// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


int n = new Random().Next(5, 7); //Размер массива

string[] FillArray(int num) //заполнение массива различными символами
{
    string[] arra = new string[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i + 1} символ  массива ");
        arra[i] = Console.ReadLine();
    }
    return arra;
}

void PrintArr(string[] array) //вывод массива на консоль
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}" + ", ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

string[] arrays = FillArray(n); // заполнение нашего массива

PrintArr(arrays);

Console.WriteLine();
Console.WriteLine("Отфильтрованный массив");

string[] FillNewArray(string[] array, int min, int max) // на вход принимаем наш массив
{
    int f = new Random().Next(min, max); //создаем размер нового массива (в нашем случае от 1 до 3)
    string[] newarray = new string[f];
    for (int i = 0; i < newarray.Length; i++)
    {
        newarray[i] = array[new Random().Next(0, array.Length - 1)]; //заполнение массива идет случайнымми элементами
    }
    return newarray;
}

string[] newarr = FillNewArray(arrays, 1, 3);
PrintArr(newarr);


