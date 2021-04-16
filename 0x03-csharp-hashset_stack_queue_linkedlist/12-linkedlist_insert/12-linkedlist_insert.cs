﻿using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> new_node = myLList.First;

        while (myLList != null)
        {
            if (new_node.Value < n)
            {
                new_node = new_node.Next;
            }
            else
            {
                myLList.AddBefore(new_node, n);
                return (new_node);
            }
        }
        myLList.AddLast(n);
        return (new_node);
    }
}
