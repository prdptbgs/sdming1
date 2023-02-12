/*
1. Buatlah sebuah program untuk menunjukan lokasi pointer dari sebuah inputan

jawab 
using System;
namespace program
{
    unsafe
    class csharp
    {
        static void Main(string[] args)
        {
            Console.Write("input nilai : ");
            int input = Convert.ToInt32(Console.ReadLine());
            int *get_ptr = &input;
            Console.WriteLine("nilai input : {0} ",input);
            Console.WriteLine("nilai pointer : {0} ",*get_ptr);
        }
    }
}
*/
//============================================
/*
2. Buat sebuah Program stack dengan POP Operation dengan inputan berasal dari user.

jawab 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StackPOP
{
    class Program
    {
        static Stack<int> GetStack()
        {
            Stack<int> stak = new Stack<int>();
            Console.Write("masukkan banyak input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < input; i++){
                Console.Write("nilai ke - {0} :", i+1);
                stak.Push(Convert.ToInt32(Console.ReadLine()));
            }
            return stak;
        } 
        static void Main()
        {
            Stack<int> stak = GetStack();
            int pop = stak.Pop();
            Console.Write("variable yang di pop : ");
            Console.WriteLine(pop);

            int peek = stak.Peek();
            Console.Write("input teratas di stack : ");
            Console.WriteLine(peek);
        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StackPOP
{
    class Program
    {
        static Stack<int> GetStack()
        {
            Stack<int> stak = new Stack<int>();
            Console.Write("masukkan banyak input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < input; i++){
                Console.Write("nilai ke - {0} :", i+1);
                stak.Push(Convert.ToInt32(Console.ReadLine()));
            }
            return stak;
        } 
        static void Main()
        {
            Stack<int> stak = GetStack();
            int pop = stak.Pop();
            Console.Write("variable yang di pop : ");
            Console.WriteLine(pop);

            int peek = stak.Peek();
            Console.Write("input teratas di stack : ");
            Console.WriteLine(peek);
        }
    }
}

