using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> Primes = new List<int>() {2};
        Console.WriteLine("Enter a number, any number.");
        string stringNumber = Console.ReadLine();
        int number = int.Parse(stringNumber);

        for (int i = 3; i <= number; i++)
        {
            for (int j = i - 1; j >= 2; j--)
                {
                if (j == 2 && i % 2 != 0)
                {
                    Primes.Add(i);
                }
                else if (i % j == 0)
                {
                    j = 1;
                }
                else
                {
                    j = j;
                }
                }
           
    }

    foreach (int prime in Primes)
    {
        Console.WriteLine(prime);

    }
}
}