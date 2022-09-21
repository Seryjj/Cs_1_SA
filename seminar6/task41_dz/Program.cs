// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

            int M = ReadNumber("Введите M");
            int count=0;
            for(int i = 0; i < M; i++)
            {
            Console.WriteLine($"Введите {i}-е число или stop:");
            string a= Console.ReadLine();
            try{
            int b = Convert.ToInt32(a);
            if (b>0) count++;
            }
            catch
            {
            if (a=="stop") 
            {
            Console.WriteLine($"Число элементов больше 0 равно {count}");
            return;
            }
            }
            }
Console.WriteLine($"Число элементов больше 0 равно {count}");

