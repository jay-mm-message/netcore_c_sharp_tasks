using System;

namespace abstract_inheritance_netcore_vscode_tasks
{
    abstract class Base {
        public Base () {
            Data = "Base information";
        }
        public string Data { get; set;}
        public abstract void show();
    }

    class SubClass : Base {
        public override void show() {
            Console.WriteLine($"inplement show of SubClass and then get Data of Base by used show(): {Data}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            SubClass sb = new SubClass();
            sb.show();
        }
    }
}
