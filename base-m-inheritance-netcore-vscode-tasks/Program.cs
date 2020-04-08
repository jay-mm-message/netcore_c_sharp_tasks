using System;

namespace base_m_inheritance_netcore_vscode_tasks
{
    class Person {
        public Person () {
            Name = "Jason";
            BaseMoney = 32000;
        }
        protected string Name {get;set;}
        private int baseSalary;
        public int BaseMoney { 
            get { return baseSalary;}
            set {
                if (value >= 22800 && value <= 36300) {
                    if (value < 22800)
                        baseSalary = value - 456;
                    else if (value < 30000)
                        baseSalary = value - 504;
                    else if (value < 36000)
                        baseSalary = value - 552;
                }
                else
                    Console.WriteLine("Can't be calcuration");
            }
        }
        public void Show() {
            Console.WriteLine($"Employee: {Name:7}, Pay: {BaseMoney:C0}");
        }
    }

    class Employee : Person {
        public Employee() {
            Name = "Jay";
            BaseMoney = 30000;
        }
        public void Display() {
            base.Show();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Person person = new Person();
            person.Show();

            Employee employee = new Employee();
            employee.Display();
        }
    }
}
