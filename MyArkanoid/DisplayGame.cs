using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace MyArkanoid
{
    class DisplayGame
    {
        private static List<Rectangle> rectangles = new List<Rectangle>();
        public static void StartDraw(Grid MyGrid)
        {
            DrawPlatform(MyGrid);
            DrawBall(MyGrid);
            DrawBlock(MyGrid);          
        }

        private static void DrawBall(Grid MyGrid)
        {
            Ball ball = new Ball(50, 74);
            ball.DrawBall(MyGrid);
        }

        private static void DrawPlatform(Grid MyGrid)
        {
            Platform platform = new Platform(47, 75);
            platform.DrawPlatform(MyGrid);
        }
    
        private static void DrawBlock(Grid MyGrid)
        {
            for (int i = 2; i < 100; i += 2)
            {
                for (int j = 3; j < 14; j += 2)
                {
                    Rectangle rectangle = new Rectangle();
                    rectangle.Fill = new SolidColorBrush(Colors.Green);
                    Grid.SetColumn(rectangle, i);
                    Grid.SetColumnSpan(rectangle, 1);
                    Grid.SetRow(rectangle, j);
                    Grid.SetRowSpan(rectangle, 1);
                    rectangle.Stroke = new SolidColorBrush(Colors.Red);
                    MyGrid.Children.Add(rectangle);
                    rectangles.Add(rectangle);
                }
            }
        }
       
    }
}
