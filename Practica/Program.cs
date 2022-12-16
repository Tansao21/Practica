// Известно число жителей, проживаюших в каждом доме улицы. Нумерация домов проведена подряд. Дома с не четными номерами расположены на одной стороне улицы, с четными - на другой. на какой стороне улицы проживает больше жителей?


/*int[] hous = new int[] {1,2,3,4,5,6,7,8,9,10};

int sumResidentR = 0;
int sumResidentL = 0;

for (int i = 0; i < hous.Length; i++)
{
	if (hous[i] % 2 == 0)
	{
		sumResidentR += hous[i];
	}

	if (hous[i] % 2 != 0)
	{
		sumResidentL += hous[i];
	}
}

	if (sumResidentR > sumResidentL)
	{
		Console.WriteLine($"С права живет {sumResidentR} !");
	}
	else
	{
		Console.WriteLine($"С лева живет {sumResidentL} !");
	}

// тут мы прировняли количество жителей к номерам домов(1 дом-1 житель, 2 дом-2жителя) верно ли будет такое решение этой задачи? */



// Дан массив.Определить количество неотрицательных элементов.

/*int[] hous = new int[] { 1, -2, 3, 4, -5, 6, -7, 8, 9, 10 };
int count = 0;

for (int i = 0;i < hous.Length; i++)
{
	if (hous[i] > 0)
	{
		count++;
	}
}
Console.WriteLine($"Количество неотрицательных элементов равна {count}");*/




// Дан массив.Определить:

/*Random rnd = new Random();

int[] mas = new int[25];
int max = 0;
int min = 0;
int ind = -1;

for (int i = 0; i < mas.Length; i++)
{
	mas[i] = rnd.Next(0, 100);
}

for (int i = 0; i < mas.Length; i++)
{
	Console.WriteLine(mas[i]);
}

Console.WriteLine();

max = mas[0];
min = mas[0];

// а) макс., элемент
for (int i = 0; i < mas.Length; i++)
{
	if (mas[i] > max)
	{
		max = mas[i];
		ind = i;
	}
}
Console.WriteLine($"Индекс максимального числа {ind}"); // г) индекс макс., элемента

Console.WriteLine();

Console.WriteLine($"Максимальное число из массива =  {max}");

Console.WriteLine();

// б) мин., элемент
for (int i = 0; i < mas.Length; i++)
{
	if (mas[i] < min)
	{
		min = mas[i];
		ind = i;
	}
}
Console.WriteLine($"Индекс минимального числа {ind}");// д) индекс мин., элемента

Console.WriteLine();

Console.WriteLine($"Минимальное число из массива =  {min}");

Console.WriteLine();

// в) на сколько максимальный элемент больше минимального 

int subtraction = max - min;
Console.WriteLine($"Максимальное число больше на  {subtraction} едениц");*/



// В массиве храниться информация о максимальной скорости каждой из 40 марок легковых автомобилей. определить порядковый номер самого быстрого автомобиля. Если таких автомабилей несколько, то должен быть найдет номер:

//Random rnd = new Random();

/*int[] masAvto =  new int [10];
int maxSpeed = 0;
int indAvto = 0;
int indAvtoLast = 0;

for (int i = 0;i < masAvto.Length;i++)
{
	//masAvto[i] = rnd.Next(5, 50);
	Console.Write("В ведите скорость машин: ");
	masAvto[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < masAvto.Length; i++)
{
	Console.WriteLine(masAvto[i]);
}

Console.WriteLine();

// а) первого из них.

maxSpeed = masAvto[0];	
for (int i = 0; i < masAvto.Length;i++)
{
	if (masAvto[i] > maxSpeed)
	{
		maxSpeed = masAvto[i];
		indAvto= i;
	}
}

Console.WriteLine();
Console.WriteLine($"Индекс первой машины {indAvto}");

// б) последнего из них.

for (int i = 0; i < masAvto.Length; i++)
{
	if (masAvto[i] >= maxSpeed)
	{
		indAvtoLast = i;
	}
}
Console.WriteLine();
Console.WriteLine($"Индекс последней машины {indAvtoLast}");*/