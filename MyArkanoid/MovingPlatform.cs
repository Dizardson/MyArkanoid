using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace MyArkanoid
{
    class MovingPlatform
    {
        private static Rectangle platform = (Rectangle)Platform.platform;
        private static Rectangle ball = (Rectangle)Ball.ball;

        public static void MoveRight()
        {
            int platformColumn = Grid.GetColumn(platform);
            if (platformColumn < 93)
            {
                Grid.SetColumn(platform, platformColumn + 1);
                if (!Game.isGameStarted)
                {
                    int ballColumn = Grid.GetColumn(ball);
                    Grid.SetColumn(ball, ballColumn + 1);
                }
            }
        }
        public static void MoveLeft()
        {
            int platformColumn = Grid.GetColumn(platform);
            if (platformColumn > 0)
            {
                Grid.SetColumn(platform, platformColumn - 1);
                if (!Game.isGameStarted)
                {
                    int ballColumn = Grid.GetColumn(ball);
                    Grid.SetColumn(ball, ballColumn - 1);
                }
            }
        }
    }
}
