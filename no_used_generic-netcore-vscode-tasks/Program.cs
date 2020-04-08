using System;

namespace no_used_generic_netcore_vscode_tasks
{
    class Program
    {
        private static void ShowMessage(string [] args) {
            foreach (var s in args) {
                Console.WriteLine($"{s}");
            }
        }
        private static void ShowMessage(int [] args) {
            foreach(var n in args) {
                Console.WriteLine($"{n}");
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] one = {1, 2, 3, 4, 5, 6, 7};
            string[] two = { "hello", "abc", "new", "book", "hi" };

            ShowMessage(two);
            ShowMessage(one);
        }
    }
}
