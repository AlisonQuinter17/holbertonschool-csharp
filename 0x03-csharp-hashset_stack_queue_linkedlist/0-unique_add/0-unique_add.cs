using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> collection =  new HashSet<int>();
        int total = 0;

        for (int i = 0; i < myList.Count; i++)
        {
            collection.Add(myList[i]);
        }
        foreach (int j in collection)
        {
            total += j;
        }
        return (total);
    }
}
