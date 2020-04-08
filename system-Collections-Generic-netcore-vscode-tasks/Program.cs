using System;
using System.Collections.Generic;

namespace system_Collections_Generic_netcore_vscode_tasks
{
    class Student {
        public string Name {get;set;}
        public double Score {get;set;}
        public void ShowMessage() {
            Console.WriteLine($"Name: {this.Name}, Score: {this.Score}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<Student> students = new List<Student> {
                new Student { Name = "Mary", Score = 78.25 },
                new Student { Name = "Emily", Score = 85.47 },
                new Student { Name = "Steven", Score = 93.8 }};

            foreach(var s in students) {
                s.ShowMessage();
            }
            Console.WriteLine();

            Dictionary<string, int> student = 
                new Dictionary<string, int>() {
                    ["Peter"] = 78,
                    ["Leonardo"] = 65,
                    ["Michelle"] = 47,
                    ["Noami"] = 92,
                    ["Richard"] = 87
                };

            foreach(var dict in student) {
                Console.WriteLine($"{dict.Key, -10}, {dict.Value, 3}");
            }
            Console.WriteLine();

            Int32 one, index = 6;
            Queue<string> fruit = new Queue<string>();
            string[] name = {"Strawberry", "Watermelon", "Apple", "Orange", "Banana", "Mango"};

            // write queue
            foreach(var item in name){
                fruit.Enqueue(item);
            }

            // read queue
            int nIdx = 0;
            foreach(var item in fruit) {
                Console.WriteLine($"[{nIdx}] - {item, -10}");
                nIdx++;
            }
        }
    }
}
