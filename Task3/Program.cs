using System;

namespace Task3
{
    internal class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.change = "не изменено";
            myStruct.change = "не изменено";
            ClassTaker(myClass); //передаём ссылку на класс
            StruktTaker(myStruct); //Передаём копию структуры
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
            Console.ReadKey();
        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
    class MyClass
    {
        public string change;
    }
    struct MyStruct
    {
        public string change;
    }

}
