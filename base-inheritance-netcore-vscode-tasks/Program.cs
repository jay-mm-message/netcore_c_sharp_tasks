using System;

namespace base_inheritance_netcore_vscode_tasks
{
    class Person{
        protected int baseSalary { get; set; }
        protected string Name {get; set;}
        public Person(string title, int wage) {
            this.baseSalary = wage;
            this.Name = title;
            Console.WriteLine( $"Name: {this.Name}, " + $"BaseSalary: {this.baseSalary}");
        }/* 
        public void showTime() {
            DateTime hireDate = new DateTime(2009, 3, 21);
            DateTime justNow = DateTime.Today;
            TimeSpan jobDays = justNow - hireDate;

            double work = (double)(jobDays.Days) / 365;
            Console.WriteLine(  $"hirDate {0, 10}, " +
                                $"work {1:F2} year");

        } */
    }

    class Employee : Person {
        public Employee(string Name, int pay) : base(Name, pay) {}
/*         public void hireTime(){
            DateTime startDate = DateTime.Today;
            Console.WriteLine($"hireDate {startDate.ToShortDateString()}");
        } */
    }
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           Person person = new Person("Ellen_", 5550);
           Employee employee = new Employee("Toms_", 35500);
        }
    }
}
