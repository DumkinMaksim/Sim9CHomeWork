//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int SumNaturalElements(int one,int two)
{
	if (one<two)
	{
		return one+SumNaturalElements(one+1,two);
	}
	else return 0;
}

Console.WriteLine("Input M");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Input N");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Sum of elements from "+m+ " to " +n+"-> ");
Console.WriteLine(SumNaturalElements(m,n));