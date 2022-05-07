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

            // Начало работы программы
            lenghtnewarray = Convert.ToInt32(CompareArray()[0]);
            string[] ArrayOut = new string[lenghtnewarray];  // Инициализация нового выходного массива с требуемой длиной
            flag = 1;
            ArrayOut = CompareArray();
            PrintArr(ArrayOut, "нового"); 

            string[] CompareArray()
            {
                int indexnewarray = 0;
                int peremennaya = 0;
                if (flag == 0) peremennaya = 1;
                else peremennaya = lenghtnewarray;
                string[] NGArr = new string[peremennaya];
                
                for (int index = 0; index < lengtharrayinput; index++)
                {
                    if (ArrayInput[index].Length <= 3)
                    {
                        if (flag == 0)
                        {
                            lenghtnewarray++;
                            NGArr[0] = Convert.ToString(lenghtnewarray);
                        }
                        else 
                        { 
                            NGArr[indexnewarray] = ArrayInput[index];
                            indexnewarray++;
                        }
                    }
                }
                return NGArr;
            }
            
            // Метод вывода массива в консоль
            void PrintArr(string[] array, string msg)
            {
                int rows = array.Length;
                Console.WriteLine($"+= Вывод в консоль {msg} массива =+");
                for (int i=0; i < rows; i++)
                {
                    Console.WriteLine($"Элемент {i}: \t{array[i]}");
                }
            }
        }
    }
}