using System;

namespace hide_inheritance_netcore_vscode_tasks
{
    class Base {
        protected string Information {
            get {
                return "Base.";
            }
        }
        public void show() {
            Console.WriteLine($"Base information is {this.Information}");
        }
    }
    class SubClass : Base {
        new public void show() {
            Console.WriteLine($"Subclass information is none");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Base b1 = new Base();
            b1.show();
            SubClass sc1 = new SubClass();
            sc1.show();
        }
    }
}
