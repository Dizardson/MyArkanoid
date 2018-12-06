using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace MyArkanoid
{
    class Ball
    {
        public static Rectangle ball = new Rectangle();
        private int _row;
        private int _column;
        public int Row
        {
            get { return _row; }
            set { _row = value; }
        }
        public int Column
        {
            get { return _column; }
            set { _column = value; }
        }
        public Ball(int column, int row)
        {
            Column = column;
            Row = row;
        }
        public void DrawBall(Grid MyGrid)
        {
            ball.Name = "MyBall";
            ball.Fill = new SolidColorBrush(Colors.Green);
            ball.Stroke = new SolidColorBrush(Colors.Black);
            Grid.SetColumn(ball, 50);
            Grid.SetColumnSpan(ball, 1);
            Grid.SetRow(ball, 74);
            Grid.SetRowSpan(ball, 1);
            ball.RadiusX = 100;
            ball.RadiusY = 100;
            MyGrid.Children.Add(ball);
        }
    }
}
