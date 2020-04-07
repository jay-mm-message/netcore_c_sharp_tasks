using System;

namespace this_inheritance_netcore_vscode_tasks
{
    class Person {

        protected int Height {get; set;}
        protected string Hair {get; set;}
        protected string Surname {
            get { return "Cumberbatch"; } }
        public Person() {
            Height = 178;
            Hair = "Yellow";
        }
        public void showMessage()=>Console.WriteLine(
            $"Parent {this.Surname}, " +
            $"Hair {this.Hair}, " +
            $"Height {this.Height}");
    }
    class Human : Person {
        public string this[ string Surname ] {
            get { return Surname; }
        }

        public Human() {
            this.Height = 162;
            this.Hair = base.Hair;
        }

        public void show()=>Console.WriteLine(
            $"I'm inheritance, than me too that hair {this.Hair}, " +
            $"Height {this.Height}");
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Person person = new Person();
            person.showMessage();
            Human human = new Human();
            human.show();
        }
    }
}
