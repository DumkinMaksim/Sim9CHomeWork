//Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.

//N = 4532 -> 4
int QuantityNums(int nums,int digital)
{
	if (nums==0)
		return digital;
	return QuantityNums(nums/10,++digital);

}

Console.WriteLine("Input N");
int n=Convert.ToInt32(Console.ReadLine());
int k=0;
Console.WriteLine(QuantityNums(n,k));
