using System;

namespace Polymorphism_interface_netcore_vscode_tasks
{
    interface IShape {
        double Area { get; }
    }
    class Circle {
        private double _radius;
        public double Radius {
            get { return _radius; }
            set { this._radius = value; }
        }
        public double Area {
            
            get {
                return Math.PI * this.Radius * 2;
            }  
       }
    }
    class Trapezoidal {
        private double _height;
        public double Height {
            get {
                return this._height;
            }
            set {
                this._height = value;
            }
        }
        private double _width;
        public double Width {
            get {
                return this._width;
            }
            set {
                this._width = value;
            }
        }
        public double Area {
            
            get {
                return this.Width * this.Height * 0.5;
            }
        }
    }

    class Rectangle {
        private double _height;
        public double Height {
            get {
                return this._height;
            }
            set {
                this._height = value;
            }
        }
        private double _width;
        public double Width {
            get {
                return this._width;
            }
            set {
                this._width = value;
            }
        }
        public double Area {
            get {
                return this.Width * this.Height;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Circle circle = new Circle();
            circle.Radius = 5;
            Console.WriteLine($"circle area {circle.Area}");

            Rectangle rectangle = new Rectangle();
            rectangle.Height = 50;
            rectangle.Width = 100;
            Console.WriteLine($"Rectangle {rectangle.Area}");

            Trapezoidal trapezoidal = new Trapezoidal();
            trapezoidal.Height = 10;
            trapezoidal.Width = 20;
            Console.WriteLine($"Trapezoidal {trapezoidal.Area}");
        }
    }
}
