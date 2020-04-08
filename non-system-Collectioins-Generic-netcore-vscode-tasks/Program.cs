using System;
using System.Collections.Generic;
using System.Collections;

namespace non_system_Collectioins_Generic_netcore_vscode_tasks
{
    // not generic type of ArrayList : IList

    class Program
    {
        class Student<T> {
            public Student() {
                index = 0;
            }
            private int index;
            private T[] multi_group = new T[5];
            public bool StoreArray(T arrData) {
                if (index >= multi_group.Length) {
                    return false;
                }
                if (index < multi_group.Length){
                    multi_group[index] = arrData;
                }
                index++;
                return true;
            }
            public void ShowMessage() {
                Console.WriteLine();
                foreach(var n in multi_group) {
                    Console.Write($"{n}, ");
                }
                Console.WriteLine();
            }
        }
        // constraint of generic
        public static T checkData<T>(T one, T two, T three) where T : IComparable {
            Console.WriteLine();

            T max = one;
            if ( two.CompareTo(max) > 0 ) {
                max = two;
            }
            if ( three.CompareTo(max) > 0 ) {
                max = three;
            }

            return max;
        }
        public static void ShowMessage<T>(T [] arrDate) {
            Console.WriteLine();
            foreach(var item in arrDate) {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ushort[] one = {11, 12, 13, 14, 15};
            string[] two = { "Eric", "Andy", "Johon" };

            ShowMessage<ushort>(one);
            ShowMessage<string>(two);

            int a = 100;
            int b = 20;
            int c = 60;

            int max = checkData<int>(a, b, c);
            Console.Write($"a: {a}, b: {b}, c: {c}, max: {max}");

            Student<int> s1 = new Student<int>();
            for(int i = 0 ; i < 1000 ; ++i) {
                if (false == s1.StoreArray(i)) {
                    break;
                }
            }
            s1.ShowMessage();

            Student<string> s2 = new Student<string>();
            for(int i = 0 ; i < 1000; ++i) {
                if (false == s2.StoreArray("welcome generic world.")) {
                    break;
                }
            }
            s2.ShowMessage();

            // Using non generic of ArrayList
            Console.WriteLine();
                // write
                ArrayList a1 = new ArrayList();
                a1.Add(1);
                a1.Add(2);
                a1.Add(3);
                // ready
                foreach(var n in a1) {
                    Console.Write($"{n}, ");
                }
                Console.WriteLine();

            // Using non generic of ArrayList
            Console.WriteLine();
                // write
                ArrayList a2 = new ArrayList();
                a2.Add("hi");
                a2.Add("Jay");
                a2.Add("Welcome");
                // ready
                foreach(var n in a2) {
                    Console.Write($"{n}, ");
                }
                Console.WriteLine();

        }
    }
}
