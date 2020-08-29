using System;

namespace Generics
{
    //Generic is a concept that allows us to define classes and methods with placeholder. C# compiler replaces these placeholders with specified type at compile time. The concept of generics is used to create general purpose classes and methods.

    //To define generic class, we must use angle<> brackets.The angle brackets are used to declare a class or method as generic type.In the following example, we are creating generic class that can be used to deal with any type of data.

    class GenericClass<T>
    {
        public GenericClass(T msg)
        {
            Console.WriteLine(msg);
        }
    }

    class ClassWithGenericMethod
    {
        //C# allows us to create generic methods also. In the following example, we are creating generic method that can be called by passing any type of argument.
        public void Show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> gen = new GenericClass<string>("This is generic class.");
            GenericClass<int> genI = new GenericClass<int>(456);
            GenericClass<char> genCh = new GenericClass<char>('C');

            ClassWithGenericMethod genC = new ClassWithGenericMethod();

            genC.Show("This is generic method.");
            genC.Show(654);
            genC.Show('C');

        }
    }
}
