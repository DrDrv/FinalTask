using System;

namespace Massive
{
    class Program
    {
        static void Main()
        {
            // Входные данные
            var choice = "";
            string[] ArrayInput = new string[] {"qwerty", "12", "-4", "qaz", "qasde", "", "A"};
            int flag = 0;                           //переменная флаг для ветвления
            int lenghtnewarray = 0;                 //длина нового массива
            int lengtharrayinput = ArrayInput.Length;

            // Ввод массива руками
            Console.Write("Входной массив будем вводить руками? \t ");
            while (choice != "y" && choice != "n")
            {
              Console.Write("(y / n): ");
              choice = Console.ReadLine(); 
            } 
            if (choice == "y") 
            {
                Console.WriteLine("Введите 7 строк для массива:");
                for (int i = 0; i < 7; i++)
                {
                    Console.Write($"Элемент {i+1}:\t");
                    choice = Console.ReadLine();
                    if (choice == null) choice = "";
                    ArrayInput[i] = Convert.ToString(choice);

                }
            }
            // Вывод входного массива - метод
            PrintArr(ArrayInput, "исходного");

            void PrintArr(string[] array, string msg)
            {
                int rows = array.Length;
                Console.WriteLine($"+= Вывод в консоль {msg} массива =+");
                for (int i=0; i < rows; i++)
                {
                    Console.WriteLine(array[i]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}