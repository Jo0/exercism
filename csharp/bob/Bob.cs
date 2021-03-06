﻿using System.Linq;

public class Bob
{
    /*
    Bob is a lackadaisical teenager.In conversation, his responses are very limited.
    Bob answers 'Sure.' if you ask him a question.
    He answers 'Whoa, chill out!' if you yell at him.
    He says 'Fine. Be that way!' if you address him without actually saying anything.
    He answers 'Whatever.' to anything else.
    */

    public static string Hey(string msg)
    {
        msg = msg.Trim();
        if (System.String.IsNullOrWhiteSpace(msg))
        {
            return "Fine. Be that way!";
        }
        else if (msg.LastIndexOf('!') == msg.Length - 1 || (msg.LastIndexOf('?') == msg.Length - 1 && msg.CompareTo(msg.ToUpper()) == 0 && char.IsLetter(msg[msg.Length-2])) || (msg.CompareTo(msg.ToUpper()) == 0 && char.IsLetter(msg[msg.Length - 1])))
        {
            return "Whoa, chill out!";
        }
        else if(msg.LastIndexOf('?') == msg.Length - 1)
        {
            return "Sure.";
        }       
        else
        {
            return "Whatever.";
        }


    }
}