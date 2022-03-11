using System;
using System.Collections.Generic;   // to use the Stack<T> class of .NET instead of the SimpleStack<T> class.

namespace WiredBrainCoffee.StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDoubles();
            StackStrings();

            Console.ReadLine();
        }

        private static void StackDoubles()
        {
            var stack = new Stack<double>();  // SimpleStack class
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            double sum = 0.0;

            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }

            Console.WriteLine($"Sum: {sum}");
        }

        private static void StackStrings()
        {
            var stack = new Stack<string>(); // SimpleStack class
            stack.Push("Wired Brain Coffee");
            stack.Push("Pluralsight");

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

    }

}


/* 

Code from a Pluralsight course on C# Generics:
(https://app.pluralsight.com/library/courses/c-sharp-generics/table-of-contents)

*** Part 1. Course overview ***

    - The need for generics
    - Implementing generic classes
    - Create generic interfaces
    - Writing generic methods
    - Using generic delegates

What you will learn: 
How to use C# generics in your .NET applications to write type-safe, reusable, and performant code.

*** Part 2. Understanding the need for Generics ***

    - Implement a SimpleStack class that works as a storage for any type
        * Use the object type
        * Copy and paste for every type
        * Create a generic SimpleStack<T> class (SimpleStack of T class)
        
    - Advantages of generics
        * Code reuse
        * Type-safety
        * Performance

    - Use the Stack<T> class of .NET

 */