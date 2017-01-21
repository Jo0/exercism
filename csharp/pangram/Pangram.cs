using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Pangram
{
    public static bool IsPangram(string str)
    {      
        str.ToLower();


        if (string.IsNullOrWhiteSpace(str) || str.Length < 26)
        {
            return false;
        }

        bool[] Letters = new bool[26];

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 97 && str[i] <= 122)
            {
                Letters[str[i] - 97] = true;
            }
        }

        if (Array.TrueForAll(Letters, redundant))
        {
            return true;
        }
        else
            return false;
    }

    private static bool redundant(bool b)
    {
        return b;
    }


}