using System;

namespace inheritance_netcore_vscode_tasks
{
    public class School
    {
        public string subject {get; set;}
        protected int room { get; set;}
        protected string teacher { get; set; }
        public School() {
            subject = "Computer";
            room = 1025;
            teacher = "Toms";
        }
        public void ShowMsg() {
            Console.WriteLine($"subject {this.subject}, class room {this.room}, teacher {this.teacher}");
        }
    }

    public class Education : School
    {
        private int student {get; set;}
        public Education() {
            subject = "English";
            room = 1028;
            teacher = "Ellen";
        }
        public void Display(int people) {
            student = people;
            if (student < 15) {
                Console.WriteLine($"Only {this.student}");
            }
            else{
                Console.WriteLine($"subjust {this.subject}" + 
                                $", class room {this.room}" +
                                $", teacher {this.teacher}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            School school = new School();
            school.ShowMsg();
            Education education = new Education();
            education.Display(20);
        }
    }
}
