// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
{
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt16(Console.ReadLine());
int A = num % 100;
int B = A / 10; 
if ((num > 99 && num <= 999))
    
    Console.WriteLine(B);
     
    

else
{
    Console.WriteLine("Вы ввели не трехначное число");
}    
}
 



 


    

