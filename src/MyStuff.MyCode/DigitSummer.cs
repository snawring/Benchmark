namespace MyStuff.MyClasses;

// No benchmarking code here. 
public static class DigitSummer
{
    public static long SumUsingDivision(long number)
    {
        long sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    public static long SumUsingLinq(long number)
    {
        return number.ToString()
                     .Select(c => c - '0').Sum();
    }
}
