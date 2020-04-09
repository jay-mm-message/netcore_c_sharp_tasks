using System;

namespace event2_netcore_vscode_tasks
{
    class BallEventArgs : EventArgs {
        public int Trajectory {get;set;}
        public int Distance {get;set;}
        public BallEventArgs(int trajectory, int distance) {
            this.Trajectory = trajectory;
            this.Distance = distance;
        }
    }
    class Ball {
        public event EventHandler BallInPlay;
        public void OnBallInPlay(BallEventArgs e) {
            EventHandler ballInPlay = BallInPlay;
            if (ballInPlay != null) {
                ballInPlay(this, e);
            }
        }
    }

    class Pitcher{

        public Pitcher(Ball ball) {
            // subscribes
            ball.BallInPlay += new EventHandler(ball_BallInPlay);
        }
        void ball_BallInPlay(object sender, EventArgs e) {
            if (e is BallEventArgs) {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if (ballEventArgs.Trajectory < 70
                    && ballEventArgs.Distance < 80) {

                        Console.WriteLine("<Pitcher> Say, I gets it!!! (￣▽￣)~*");
                }
                //Console.WriteLine($"<Pitcher> {ballEventArgs.Trajectory}, {ballEventArgs.Distance}");
            }
        }
    }

    class Umpire{
        public Umpire(Ball ball) {
            // subscribes
            ball.BallInPlay += new EventHandler(ball_BallInPlay);
        }
        void ball_BallInPlay(object sender, EventArgs e) {
            if (e is BallEventArgs) {
                BallEventArgs ballEventArgs = e as BallEventArgs;

                if (ballEventArgs.Trajectory < 70
                    && ballEventArgs.Distance < 80) {

                        Console.WriteLine("<Umpire> Say, Out !!! ");
                }

                //Console.WriteLine($"<Umpire> {ballEventArgs.Trajectory}, {ballEventArgs.Distance}");
            }
        }
    }

    class Fan {
        public Fan(Ball ball) {
            // subscribes
            ball.BallInPlay += new EventHandler(ball_BallInPlay);
        }
        void ball_BallInPlay(object sender, EventArgs e) {
            if (e is BallEventArgs) {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if (ballEventArgs.Trajectory < 70
                    && ballEventArgs.Distance < 80) {

                        Console.WriteLine("<Fan> Ｏ(≧▽≦)Ｏ, σ(≧ε≦ｏ), ₍₍ ◝(●˙꒳˙●)◜ ₎₎,（〜^∇^)〜  ");
                }

                //Console.WriteLine($"<Fan> {ballEventArgs.Trajectory}, {ballEventArgs.Distance}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Ball ball = new Ball();
            Pitcher pitcher = new Pitcher(ball);
            Umpire umpire = new Umpire(ball);
            Fan fan = new Fan(ball);

            ball.OnBallInPlay(new BallEventArgs(69, 79));
        }
    }
}
