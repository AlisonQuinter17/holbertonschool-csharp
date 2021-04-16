using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> new_node = myLList.First;

        while (new_node != null || myLList.First.Value < new_node.Value)
        {
            if (new_node.Value < n)
            {
                new_node = new_node.Next;
            }
            else
            {
                myLList.AddBefore(new_node, n);
                return myLList.First;
            }
        }
        myLList.AddLast(n);
        return myLList.First;
    }
}
