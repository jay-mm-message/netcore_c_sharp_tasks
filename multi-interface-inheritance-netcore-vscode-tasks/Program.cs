using System;

namespace multi_interface_inheritance_netcore_vscode_tasks
{
    class SubClass : ISchool, IGrade {
        private int _status;
        public int Status {
            get {
                return this._status;
            }
            set {
                this._status = value;
            }
        }
        private int _subject;
        public int Subject {
            get {
                return this._subject;
            }
            set {
                this._subject = value;
            }
        }

        public void ShowMessage() {
            Console.WriteLine($"subject {this._subject}, status {this._status}");
        }
    }
    interface IGrade {
        int Status {get; set;}
    }
    interface ISchool {
        // define attribute
        int Subject {get; set;}
        void ShowMessage();
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            SubClass sb = new SubClass();
            sb.Status = 200;
            sb.Subject = 50000;
            sb.ShowMessage();
        }
    }
}
