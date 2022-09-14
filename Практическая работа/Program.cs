// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите количество массивов");
int countmas = Convert.ToInt32(Console.ReadLine());

if (countmas < 1)
{
    Console.WriteLine("Введите положительное целое число");
    return;
}

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
        if (array.Length > 0)
        {

            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1) Console.Write($"{array[i]}" + ", ");
            }
            Console.Write($"{array[array.Length - 1]}]");
        }
        else Console.WriteLine("[]");
    }


    string[] FillNewArray(string[] array, int min, int max) // на вход принимаем наш массив
    {
        int arraylength = new Random().Next(min, max); //создаем размер нового массива (в нашем случае от 1 до 3)

        string[] newarray = new string[arraylength];

        if (arraylength == 0) return newarray; //если в отфильтрованном массиве 0 элементов, то мы его не заполняем

        for (int i = 0; i < newarray.Length; i++)
        {
            newarray[i] = array[new Random().Next(0, array.Length - 1)]; //заполнение массива идет случайнымми элементами
            string checker = newarray[i];
            if (i >= 1)
            {
                for (int j = 0; j < i; j++) //проверка на повторяемость элементов в массиве
                {
                    while (newarray[i] == newarray[j])
                    {
                        newarray[i] = array[new Random().Next(0, array.Length - 1)];
                        j = 0;
                        checker = newarray[i];
                    }
                    checker = newarray[i];
                }
            }
        }
        return newarray;
    }

    string[] arrays = FillArray(n); // заполнение нашего массива
    PrintArr(arrays);

    Console.WriteLine();
    Console.WriteLine("Отфильтрованный массив");

    string[] newarr = FillNewArray(arrays, 0, 3);

    PrintArr(newarr);
    nummas++;
}