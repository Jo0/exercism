using System.Text;

public class Raindrops
{
    public static string Convert(int number)
    {
        StringBuilder sound = new StringBuilder();

        if (number % 3 == 0)
            sound.Append("Pling");

        if (number % 5 == 0)
            sound.Append("Plang");

        if (number % 7 == 0)
            sound.Append("Plong");

        if (sound.Length == 0)
            sound.Append(number);

        return sound.ToString();
    }
}