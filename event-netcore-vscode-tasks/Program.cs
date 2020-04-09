using System;

namespace event_netcore_vscode_tasks
{
    /* 
        class BallEventArgs : EventArgs {
            public int Trajectory {get; set;}
            public int Distance {get; set;}
            public BallEventArgs(int trajectory, int distance) {
                this.Trajectory = trajectory;
                this.Distance = distance;
            }
        }
        class Ball {
            private EventHandler _ballInPlay;
            // Ball class
            public event EventHandler BallInPlay {
                add {
                    _ballInPlay += value;
                }
                remove {
                    _ballInPlay -= value;
                }
            }
            public void OnBallInPlay(BallEventArgs e) {
                _ballInPlay?.Invoke(this, e);// 觸發 BallInPlay 事件 
            }
        }
        class Pitcher {   // Pitcher class
            public Pitcher(Ball ball) {
                ball.BallInPlay += new EventHandler(ball_BallInPlay);   // 訂閱 BallInPlay 事件
            }
            void ball_BallInPlay(object sender, EventArgs e) {   // BallInPlay 事件處理方法
                if (e is BallEventArgs) {        // 判斷物件是否為 BallEventArgs 實體
                    BallEventArgs ballEventArgs = e as BallEventArgs;  // 將物件由 EventArgs 轉型 BallEventArgs
                    if ((ballEventArgs.Distance < 95) && (ballEventArgs.Trajectory < 60))
                        Console.WriteLine("  CatchBall(); !!!!");
                    else
                        Console.WriteLine("  CoverFirstBase(); !!!!");
                }
            }
        } */  

    class Ball {
        public event EventHandler BallInPlay;
        public void OnBallInPlay(BallEventArgs e) {
            EventHandler ballInPlay = BallInPlay;
            if (ballInPlay != null) {
                ballInPlay(this, e);
            }
        }
    }
    class BallEventArgs : EventArgs {
        public int Trajectory { get; private set;}
        public int Distance { get; private set;}
        public BallEventArgs(int trajectory, int distance) {
            this.Trajectory = trajectory;
            this.Distance = distance;
        }
    }
    class Pitcher {
        public Pitcher(Ball ball) {
            // subscribe BallInPlay eventHandler
            ball.BallInPlay += new EventHandler(ball_BallInPlay);
        }
        // subscribe method of event handler for BallInPlay
        void ball_BallInPlay(object sender, EventArgs e) {
            // Check state event for BallEvent
            if ( e is BallEventArgs ) {
                    
                BallEventArgs ballEventArgs = e as BallEventArgs;

                if ((ballEventArgs.Trajectory < 95)
                    && (ballEventArgs.Distance < 60)) {
                        Console.WriteLine("Trajectory < 90 and Distance < 60");
                } else {
                        Console.WriteLine("not Trajectory < 90 and Distance < 60");
                }
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

            // trigger event handler for BallInPlay
            ball.OnBallInPlay(new BallEventArgs(80, 50));
            ball.OnBallInPlay(new BallEventArgs(100, 50));
/*          
            {
                var ball = new Ball();
                var patcher = new Pitcher(ball);

                ball.OnBallInPlay(new BallEventArgs(100, 200));
                
                Console.ReadLine();                
            }
*/
        }
    }
}
