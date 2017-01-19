using System;

public  class Gigasecond
{
    public static DateTime Date(DateTime dob)
    {
        return dob.AddSeconds(1000000000);
    }
}