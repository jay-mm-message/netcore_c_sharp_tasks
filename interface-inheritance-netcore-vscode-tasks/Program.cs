using System;

namespace interface_inheritance_netcore_vscode_tasks
{
    class SubClass : ISchool {
        private int subject;
        // implement ISchool
        public int Subject { 
            get {
                return subject;
            }
            set {
                this.subject = value;
            } 
        }
        public void ShowMessage() {
            Console.WriteLine($"subject {this.Subject}");
        }

    }
    // define interface
    interface ISchool {
        // define attribute
        int Subject { get; set; }
        void ShowMessage();
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            SubClass subject = new SubClass();
            subject.Subject = 200;
            subject.ShowMessage();
        }
    }
}
