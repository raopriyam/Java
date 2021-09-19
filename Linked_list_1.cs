
using System;
using System.Collections;
using System.Collections.Generic;

class GFG {
  
    // Driver code
    public static void Main()
    {
  
        // Creating a LinkedList of Strings
        LinkedList<String> myList = new LinkedList<String>();
  
        // Adding nodes in LinkedList
        myList.AddLast("Geeks");
        myList.AddLast("for");
        myList.AddLast("Data Structures");
        myList.AddLast("Noida");
        myList.AddLast("for students");
  
        // To check if LinkedList is empty or not
        if (myList.Count > 0){
            Console.WriteLine("LinkedList is not empty"+myList);
            foreach (String item in myList)
            {
                Console.WriteLine(item);
            }}
        else
            Console.WriteLine("LinkedList is empty");
    }
}