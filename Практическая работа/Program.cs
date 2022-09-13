// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите количество массивов");
int countmas = Convert.ToInt32(Console.ReadLine());

int nummas = 1; // счётчик массива, каждый раз в конце увеличивается на 1
while (nummas != countmas + 1)
{
    int n = new Random().Next(5, 7); //Размер массива

    string[] FillArray(int num) //заполнение массива различными символами
    {
        string[] arra = new string[num];
        for (int i = 0; i < num; i++)
        {
            Console.Write($"Введите {i + 1} символ {nummas} массива ");
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

        int n = 0;
        newarray[n] = array[new Random().Next(0, array.Length - 1)];
        for (int i = 1; i < newarray.Length; i++)
        {
            if (newarray[n] == newarray[i])
            {
                newarray[i] = array[new Random().Next(0, array.Length - 1)];
                n = i;
            }
        }
        return newarray;
    }

    string[] newarr = FillNewArray(arrays, 3, 3);
    PrintArr(newarr);
    nummas++;
    Console.WriteLine();
}