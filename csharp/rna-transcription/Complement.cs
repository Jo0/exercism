using System.Text;

public class Complement
{
    public static string OfDna(string dna)
    {
        StringBuilder complement = new StringBuilder();
        for(int i = 0; i < dna.Length; i++)
        {
            switch(dna[i])
            {
                case 'G':
                    complement.Append('C');
                    break;
                case 'C':
                    complement.Append('G');
                    break;
                case 'T':
                    complement.Append('A');
                    break;
                case 'A':
                    complement.Append('U');
                    break;
                default:
                    break;
            }
        }

        return complement.ToString();
    }
}