/*
    III. prapraktikum
    01.apa yang dimaksud dgn pointer ?
    suatu variabel yang berisi alamat memori dari suatu
    variabel lain. Lokasi memori tersebut mungkin diwakili oleh sebuah 
    variabel atau mungkin juga lokasi bebas dalam memori.

    02.Apa yang dimaksud dengan Stack ? Sebutkan Contohnya !
    tumpukan dari sebuah daftar item yang hanya dapat diakses dari akhir
    daftar. Ada juga yang menyebutkan bahwa Stack adalah sebuah kumpulan data 
    yang mana datanya bersifat LIFO (Last In First Out).

    03.Salin program pada contoh yang sudah ada di atas di Visual Studio C#!
    - pointer 

    int[] a = new int[5] { 10, 20, 30, 40, 50 };
unsafe
{
    fixed (int* p = &a[0])
    {
        int* p2 = p;
        Console.WriteLine(*p2);
        p2 += 1;
        Console.WriteLine(*p2);
        p2 += 1;
        Console.WriteLine(*p2);
        Console.WriteLine("--------");
        Console.WriteLine(*p);
        *p += 1;
        Console.WriteLine(*p);
        *p += 1;
        Console.WriteLine(*p);
    }
Console.ReadLine();
}
===================================================
        - stack 

        -push operation 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPush
{
    class program
    {
        static Stack<int> GetStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(1000);
            stack.Push(10000);
            return stack;
        }
        static void Main()
        {
            var stack = GetStack();
            Console.WriteLine("--- Stack contents ---");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
} 
===================================================
        -pop operation 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacPOP
{
    class program
    {
        static Stack<int> GetStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(1000);
            stack.Push(10000);
            return stack;
        }
        static void Main()
        {
            // get the stack [see above definition of this method]
            Stack<int> stack = GetStack();

             // pop the top element
            int pop = stack.Pop();

            // write to the console
            Console.WriteLine("-- Element popped from top of Stack ---");
            Console.WriteLine(pop);

            // now look at the top element 
            int peek = stack.Peek();
            Console.WriteLine("--- Element now at the top ---");
            Console.WriteLine(peek);
            Console.ReadLine();
        }
    }
}                   
*/