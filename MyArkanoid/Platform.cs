using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace MyArkanoid
{
    class Platform 
    {
        public static Rectangle platform = new Rectangle();
        private int _row;
        private int _column;
        public  int Row
        {
            get { return _row; }
            set { _row = value; }
        }
        public  int Column
        {
            get { return _column; }
            set { _column = value; }
        }
        public Platform(int column, int row)
        {
            Row = row;
            Column = column;
            
        }
        public void DrawPlatform(Grid MyGrid)
        {
            platform.Name = "MyPlatform";     
            platform.Fill = new SolidColorBrush(Colors.Blue);
            platform.Stroke = new SolidColorBrush(Colors.Black);
            Grid.SetColumn(platform, Column);
            Grid.SetColumnSpan(platform, 7);
            Grid.SetRow(platform, Row);
            Grid.SetRowSpan(platform, 1);
            platform.RadiusX = 10;
            platform.RadiusY = 10;
            MyGrid.Children.Add(platform);
        }
    }
}
