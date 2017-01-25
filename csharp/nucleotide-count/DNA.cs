using System;
using System.Collections.Generic;
using System.Linq;

internal class DNA
{
    private string v;
    public Dictionary<char, int> NucleotideCounts = new Dictionary<char, int> { { 'A', 0 }, { 'T', 0 }, { 'C', 0 }, { 'G', 0 } };
    public DNA(string v)
    {
        this.v = v;
        
        foreach (var key in NucleotideCounts.Keys.ToList())
        {
            NucleotideCounts[key] = Count(key);
        }
    }

    public int Count(char c)
    {
        if (!NucleotideCounts.ContainsKey(c))
            throw new InvalidNucleotideException();

        int count = 0;

        for(int i = 0; i < v.Length; i++)
        {
            if (v[i] == c)
                count++;
        }

        return count;
    }

    public class InvalidNucleotideException : Exception
    {
        public InvalidNucleotideException() { }
    }
}