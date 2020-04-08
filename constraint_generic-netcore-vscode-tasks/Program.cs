using System;

namespace constraint_generic_netcore_vscode_tasks
{
    class Program
    {
        private static T checkData<T>(T one, T two, T three) where T : IComparable {
            T max =  one;
            if (two.CompareTo(max) > 0) {
                max = two;
            }
            if (three.CompareTo(max) > 0) {
                max = three;
            }

            return max;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int a = 5;
            int b = 6;
            int c = 1;

            int max = checkData(a, b, c);
            Console.WriteLine($"a {a}, b {b}, c {c}, max is {max}");
        }
    }
}
