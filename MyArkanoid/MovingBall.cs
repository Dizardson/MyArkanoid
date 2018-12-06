using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace MyArkanoid
{
    class MovingBall
    {
        private static Rectangle ball = (Rectangle)Ball.ball;
        private static  int _dx = -1;
        private static int _dy = -1;
        public static  int dx
        {
            get { return _dx; }
            set { _dx = value; }
        }
        public static int dy
        {
            get { return _dy; }
            set { _dy = value; }
        } 
        public static void Move()
        {
            int ballCollum = Grid.GetColumn(ball);
            int ballRow = Grid.GetRow(ball);
            Grid.SetColumn(ball, ballCollum + dx);
            Grid.SetRow(ball, ballRow + dy);
        }
    }
}
