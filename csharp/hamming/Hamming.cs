public class Hamming
{
    public static int Compute(string dna1, string dna2)
    {
        if((string.IsNullOrWhiteSpace(dna1)  || string.IsNullOrWhiteSpace(dna2)) || (dna1.Length != dna2.Length))
        {
            return 0;
        }

        int count = 0;

        for(int i = 0; i < dna1.Length; i++)
        {
            if(dna1[i] != dna2[i])
            {
                count++;
            }
        }

        return count;

    }
}