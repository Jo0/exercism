using System.Collections.Generic;

public class SumOfMultiples
{
    public static int To(int[] of, int to)
    {
        List<int> multiples = new List<int>();

        for (int i = 0; i < of.Length; i++)
        {            
            for (int j = 3; j < to; j++)
            {
                if (j % of[i] == 0 && !multiples.Contains(j))
                {
                    multiples.Add(j);
                }
            }
        }

        int sum = 0;
        foreach (var i in multiples)
        {
            sum += i;
        }

        return sum;


    }
}