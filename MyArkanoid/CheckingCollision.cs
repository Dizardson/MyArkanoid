using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace MyArkanoid
{
    class CheckingCollision
    {
        private static Rectangle platform = (Rectangle)Platform.platform;
        private static Rectangle ball = (Rectangle)Ball.ball;

        public static void CheckCollision()
        {
            
            int platformColumn = Grid.GetColumn(platform);
            int ballColumn = Grid.GetColumn(ball);
            int ballRow = Grid.GetRow(ball);
            if (ballRow == 74 && MovingBall.dy > 0)
            {
                if (platformColumn >= (ballColumn - 7) && platformColumn <= ballColumn)
                {
                    MovingBall.dy = -(MovingBall.dy);
                }
                else if ((platformColumn == (ballColumn - 8) && MovingBall.dx < 0)||(platformColumn == (ballColumn + 1) && MovingBall.dx > 0))
                {
                    MovingBall.dy = -(MovingBall.dy);
                    MovingBall.dx = -(MovingBall.dx);
                }
                else
                {
                    Game.isGameStarted = false;
                    Game.Luse();
                }
            }
            if ((ballColumn == 0 && MovingBall.dx < 0) || (ballColumn == 100 && MovingBall.dx > 0))
            {
                MovingBall.dx = -(MovingBall.dx);
            }
            if (ballRow == 0 && MovingBall.dy < 0)
            {
                MovingBall.dy = -(MovingBall.dy);
            }
            UIElement upDownBlock = User_KeyDown.MyGrid.Children.Cast<Rectangle>().Where(i => (Grid.GetRow(i) == ballRow + MovingBall.dy) && (Grid.GetColumn(i) == ballColumn)).FirstOrDefault();
            if (upDownBlock != null)
            {
                MovingBall.dy = -(MovingBall.dy);
                User_KeyDown.MyGrid.Children.Remove(upDownBlock);
            }
            UIElement leftRightBlock = User_KeyDown.MyGrid.Children.Cast<Rectangle>().Where(i => (Grid.GetColumn(i) == ballColumn + MovingBall.dx) && (Grid.GetRow(i) == ballRow)).FirstOrDefault();
            if (leftRightBlock != null)
            {
                MovingBall.dx = -(MovingBall.dx);
                User_KeyDown.MyGrid.Children.Remove(leftRightBlock);
            }
            UIElement skos = User_KeyDown.MyGrid.Children.Cast<Rectangle>().Where(i => (Grid.GetColumn(i) == ballColumn + MovingBall.dx) && (Grid.GetRow(i) == ballRow + MovingBall.dy)).FirstOrDefault();
            if (skos != null)
            {
                MovingBall.dx = -(MovingBall.dx);
                MovingBall.dy = -(MovingBall.dy);
                User_KeyDown.MyGrid.Children.Remove(skos);
            }

        }
    }
}
