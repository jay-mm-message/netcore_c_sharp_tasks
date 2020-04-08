using System;

namespace template_class_netcore_vscode_tasks
{
    class Spaceship <T> {
        public T [] store_db = new T[100];
        public int index = 0;
        public bool StoreResourceArray(T resData) {
            if (index == store_db.Length) {
                Console.WriteLine("store_db is full.");
                return false;
            }

            store_db[index] = resData;
            ++index;

            return true;
        }

        public void Display() {
            foreach(var res in store_db) {
                Console.Write($"{res:D9}, ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Spaceship<int> s1 = new Spaceship<int>();
            for(int i = 0 ; i < 10000 ; ++i) {
                if ( false == s1.StoreResourceArray(100) )
                    break;
            }
            s1.Display();

            Spaceship<string> s2 = new Spaceship<string>();
            for(int i = 0 ; i < 10000; ++i) {
                if ( false == s2.StoreResourceArray("hello"))
                    break;
            }
            s2.Display();
        }
    }
}
