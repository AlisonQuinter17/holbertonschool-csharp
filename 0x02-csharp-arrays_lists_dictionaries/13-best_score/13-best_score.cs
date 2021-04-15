using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string key = "";
        int value = 0;

        if (myList.Count == 0)
        {
            return ("None");
        }
        foreach (KeyValuePair<string, int> i in myList)
        {
            if (i.Value >= value)
            {
                key = i.Key;
                value = i.Value;
            }
        }
        return (key);
    }
}
