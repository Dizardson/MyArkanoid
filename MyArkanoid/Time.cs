using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace MyArkanoid
{
    class Time
    {
        private DispatcherTimer dispatcherTimer;
        public void Start()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 30);
            dispatcherTimer.Start();
        }
      
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (!Game.isGameStarted)
            {
                Stop();
            }
            else if(User_KeyDown.MyGrid.Children.Count == 2)
            {
                Stop();
                Game.Win();
            }
            CheckingCollision.CheckCollision();
            MovingBall.Move();
        }
        private void Stop()
        {
            dispatcherTimer.Stop();
            return;
        }
    }
}
