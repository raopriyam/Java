using System;
using System.Collections;


namespace first{
    class program1{
        static void Main5(String[] args){
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);

            Console.WriteLine("elemnt is Queue: ");
            foreach(object ob in q){
                Console.WriteLine(ob);
            }
            object topele = q.Dequeue();
            foreach(object ob in q){
                Console.WriteLine(ob);
            }
            object topele2 = q.Dequeue();
            foreach(object ob in q){
                Console.WriteLine(ob);
            }


        }
    }
}