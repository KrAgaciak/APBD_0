// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

static double GetAvarage(int[] numbers)
{
<<<<<<< HEAD
    double evenNewerSum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        evenNewerSum += numbers[i];
    }

    return evenNewerSum / numbers.Length;
=======
    double newSum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        newSum += numbers[i];
    }

    return newSum / numbers.Length;
>>>>>>> feature-new
}

static double getMax(int[] arr)
{
    double max = arr[0];
    foreach (double i in arr)
    {
        if (i > max)
        {
            max = i;
        }
    }

    return max;
}

int[] arr = {1,2,3,4};
double avv = GetAvarage(arr);
Console.WriteLine(avv);

