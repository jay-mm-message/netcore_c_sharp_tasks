using System;

namespace abstract_inheritance_netcore_vscode_tasks
{
    abstract class Base {
        public abstract void show();
    }

    class SubClass : Base {
        public override void show() {
            Console.WriteLine("inplement show of SubClass");
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
