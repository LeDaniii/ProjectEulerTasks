// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
// Find the sum of all the multiples of 3 or 5 below 1000.

int count = 0;

for (int i = 0; i < 1000; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        count += i;
        Console.WriteLine(i);
    }
    else
    {
        if (i % 3 == 0)
        {
            count += i;
            Console.WriteLine("vom dreier {0}", i);
        }
        if (i % 5 == 0)
        {
            count += i;
            Console.WriteLine("vom fünfer {0}", i);
        }
    }
}

Console.WriteLine("The sum of all the multiples of 3 and 5 is {0}", count);