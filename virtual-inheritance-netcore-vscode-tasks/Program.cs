using System;

namespace virtual_inheritance_netcore_vscode_tasks
{
    class Base {
        public virtual void show() {
            Console.WriteLine("Base");
        }
    }
    class SubClass : Base {
        public override void show(){
            Console.WriteLine("SubClass");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Base b1 = new Base();
            b1.show();
            SubClass sc = new SubClass();
            sc.show();
        }
    }
}
