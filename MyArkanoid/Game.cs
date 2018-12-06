using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MyArkanoid
{
    class Game
    {   
        private static bool _isGameStarted = false;
        public static bool isGameStarted
        {
            get { return _isGameStarted; }
            set { _isGameStarted = value; }
        }
        public static void StartGame()
        {

            isGameStarted = true;
            Time time = new Time();
            time.Start();
            
        }
        public static void Win()
        {
            MessageBox.Show("Красава!");
            _isGameStarted = false;
        }
        public static void Luse()
        {
            MessageBox.Show("У , не красава!");
            _isGameStarted = false;
        }
    }
}
