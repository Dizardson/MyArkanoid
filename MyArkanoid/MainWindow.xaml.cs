using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace MyArkanoid
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            DisplayGame.StartDraw(MyGrid);
        }

        public void Clap(object sender, KeyEventArgs e)
        {
            User_KeyDown user_KeyDown = new User_KeyDown(e, MyGrid);
            user_KeyDown.ToDetermineThePressing();
        }
    }
}
