using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> common_elements = new List<int>();

        foreach (int i in list1)
        {
            foreach (int j in list2)
            {
                if (i == j)
                {
                    common_elements.Add(i);
                }
            }
        }
        common_elements.Sort();
        return (common_elements);
    }
}
