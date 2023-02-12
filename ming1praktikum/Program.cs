/*
1. Buatlah sebuah program seperti di bawah ini, setelah itu tambahkan sintak
dalam program di bawah ini sehingga nilai age_ptr berganti menjadi 35. 
namespace PointerPRak1
{
    class Program
    {
    static void Main(string[] args)
        {
        unsafe
            {
                int age = 32;
                int* age_ptr;
                age_ptr = &age;
                int hasil = *age_ptr + 3;
                Console.WriteLine("age = {0}", age);
                Console.WriteLine("age_ptr = {0}", hasil);
                Console.ReadLine();
            }
        }
    }
}

jawab
namespace program
{
    class Program
    {
    static void Main(string[] args)
        {
        unsafe
            {
                int age = 32;
                int* age_ptr;
                age_ptr = &age;
                int hasil = *age_ptr +3;
                age_ptr = &hasil;

                Console.WriteLine("age = {0}", age);
                Console.WriteLine("age_ptr = {0}", *age_ptr);
                Console.ReadLine();
            }
        }
    }
}

*/
// =====================================================
/*
2. Buatlah Program seperti contoh di bawah ini, kemudian dalam program
tersebut lakukan modifikasi sehingga user dapat memasukan jumlah stack dan
nilai dari masing – masing stack

using System;
using System.Collections;
public class SamplesStack
{
    public static void Main()
    {
        // Creates and initializes a new Stack.
        Stack myStack = new Stack();
        myStack.Push("Hello");
        myStack.Push("World");
        myStack.Push("!");
        
        // Displays the properties and values of the Stack.
        Console.WriteLine("myStack");
        Console.WriteLine("\tCount: {0}", myStack.Count);
        Console.Write("\tValues:");
        PrintValues(myStack);
    }
    public static void PrintValues(IEnumerable myCollection)
        { 
            foreach (Object obj in myCollection)
            Console.Write(" {0}", obj);
            Console.WriteLine(); Console.ReadLine();
        }
}

jawab 
using System;
using System.Collections;
public class SamplesStack
{
    public static void Main()
    {
        // Creates and initializes a new Stack.
        Stack myStack = new Stack();
        Console.Write("\ninput banyak isi stack : ");
        int input = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < input; i++){ 
            Console.Write("data ke - {0} : ", i+1, "\n");
            myStack.Push(Console.ReadLine());
        }

        // Displays the properties and values of the Stack.
        Console.WriteLine("myStack");
        Console.WriteLine("\tjumlah : {0}", myStack.Count);
        Console.Write("\tnilai :");
        PrintValues(myStack);
    }
    public static void PrintValues(IEnumerable myCollection)
        { 
            foreach (Object obj in myCollection)
            Console.Write(" {0}", obj);
            Console.WriteLine(); 
            Console.ReadLine();
        }
}
*/
using System;
using System.Collections;
public class SamplesStack
{
    public static void Main()
    {
        // Creates and initializes a new Stack.
        Stack myStack = new Stack();
        Console.Write("\ninput banyak isi stack : ");
        int input = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < input; i++){ 
            Console.Write("data ke - {0} : ", i+1, "\n");
            myStack.Push(Console.ReadLine());
        }

        // Displays the properties and values of the Stack.
        Console.WriteLine("myStack");
        Console.WriteLine("\tjumlah : {0}", myStack.Count);
        Console.Write("\tnilai :");
        PrintValues(myStack);
    }
    public static void PrintValues(IEnumerable myCollection)
        { 
            foreach (Object obj in myCollection)
            Console.Write(" {0}", obj);
            Console.WriteLine(); 
            Console.ReadLine();
        }
}