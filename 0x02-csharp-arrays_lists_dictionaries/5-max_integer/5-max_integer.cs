using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int max = 0;

        myList.Sort();
        max = myList.Count - 1;
        return (myList[max]);
    }
}
