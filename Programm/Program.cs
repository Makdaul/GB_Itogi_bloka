using System;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
        System.Console.WriteLine("Введите строки через пробел:");
        string input = Console.ReadLine();
        string[] FerstArray = input.Split(' ');
        string[] newArray = ArrayThreeChars(FerstArray);

        string[] ArrayThreeChars(string[] array) //Функция создания нового массива где элементы не длиннее 3 символов
        {
            string[] newArray = new string[FerstArray.Length];
            int newIndex = 0;

            foreach (string str in FerstArray)
            {
                if (str.Length <= 3)
                {
                    newArray[newIndex] = str;
                    newIndex++;
                }
            }
            return newArray;
        }

        void PrintArray(string[] array) //Функция печати массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write(array[i] + " ");
            }
            System.Console.WriteLine();
        }

        PrintArray(newArray);
    }
}