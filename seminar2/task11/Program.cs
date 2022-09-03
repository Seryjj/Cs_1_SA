// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98




Random rand = new Random(); 
int number=rand.Next(100,1000);
Console.WriteLine($"Сгенерировалось случайное число {number}"); 

Console.WriteLine(number);
int digit3=number%10;
int digit1=number/100;
//Console.WriteLine(digit1); 
//Console.WriteLine(digit3);
int res=digit1*10+digit3;

Console.WriteLine(res);

