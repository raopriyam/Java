using System;

namespace array1
{
    class array1{
        static void Main2(string[] args)
        {
            double[] arr1 = new double[10];
            arr1[0]= 100.20;
            int i;
            int [] marks = new int[5]  { 99,  98, 92, 97, 95};
            Console.WriteLine("arr1[0]="+arr1[0]);
            for(i=0;i<5;i++){
            Console.WriteLine("marks = "+marks[i]);
            }
        }
    }
}