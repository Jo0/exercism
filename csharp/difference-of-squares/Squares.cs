using System;

public class Squares
{
    private int n;
    private int squaresum = 0;
    private int sumsquare = 0;

    public Squares(int n)
    {
        if (n >= 0)
        {
            this.n = n;
        }
        else
        {
            throw new System.ArgumentOutOfRangeException("cant be negative");
        }
    }

    public int SquareOfSums()
    {
   
        for(int i = 1; i <= n; i++)
        {
            squaresum += i;
        }
        squaresum = (int)Math.Pow(squaresum, 2);

        return squaresum;
    }

    public int SumOfSquares()
    {
        
        for (int i = 1; i <= n; i++)
        {
            sumsquare += (int)Math.Pow(i,2);
        }

        return sumsquare;
    }

    public int DifferenceOfSquares()
    {
        return SquareOfSums() - SumOfSquares();
    }
}