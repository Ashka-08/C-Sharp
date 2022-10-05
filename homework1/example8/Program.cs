/* Программа, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N */

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int counter = 2;

while(n > counter)
{
    Console.Write($"{counter} ");
    counter += 2; // counter = counter + 2
}


/* int count = 1;
while(count <= n)
{
   if((count % 2) == 0)
        {
            Console.Write(count+$" ");
            count++;
        }
   else
        {
            count++;
        }
} */