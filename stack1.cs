using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
 class Program
 {
  static void Main(string[] args)
  {
   Stack st = new Stack();
   st.Push(1);
   st.Push(2);
   st.Push(3);

   foreach (Object obj in st)
   {
    Console.WriteLine(obj);
   }
  }
 }
}