﻿using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        var total_nodes = 0;

        foreach (int node in myLList)
        {
            total_nodes += node;
        }
        return (total_nodes);
    }
}
