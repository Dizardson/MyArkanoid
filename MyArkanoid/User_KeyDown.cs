using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

namespace MyArkanoid
{
    class User_KeyDown
    {
        private static Grid _MyGrid;
        private KeyEventArgs _e;
        public static Grid MyGrid
        {
            get { return _MyGrid; }
            set { _MyGrid = value; }
        }
        public KeyEventArgs E
        {
            get { return _e; }
            set { _e = value; }
        }
        public User_KeyDown(KeyEventArgs e, Grid myGrid)
        {
            MyGrid = myGrid;
            E = e;
        }
        private static Rectangle platform = (Rectangle)Platform.platform;
        private static Rectangle ball = (Rectangle)Ball.ball;
        public void ToDetermineThePressing()
        {
            if (E.Key == Key.Right || E.Key == Key.D)
            {
                MovingPlatform.MoveRight();
            }
            else if (E.Key == Key.Left || E.Key == Key.A)
            {
                MovingPlatform.MoveLeft();
            }else if (E.Key == Key.Enter)
            {
                KeyEnter();
            }
        }
        
        
        private void KeyEnter()
        {
            if (!Game.isGameStarted)
            {
                Game.StartGame();
            }
           
        }
    }
}
