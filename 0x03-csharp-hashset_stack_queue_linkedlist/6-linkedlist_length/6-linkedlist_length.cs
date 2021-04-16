using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        var total = 0;

        foreach (int i in myLList)
        {
            total += 1;
        }
        return (total);
    }
}
