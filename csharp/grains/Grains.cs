using System;

public class Grains
{
    public static ulong Square(int square)
    {
        return (ulong)Math.Pow(2, square-1);
    }

    public static ulong Total()
    {
        ulong sum = 0;
        for(int i = 0; i <= 64; i++)
        {
            sum += (ulong)Math.Pow(2, i);
        }

        return sum;
    }
}