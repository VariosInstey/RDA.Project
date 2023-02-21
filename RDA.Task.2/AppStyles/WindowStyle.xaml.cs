using RDA.Task._2.Core;
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

namespace RDA.Task._2.AppStyles
{
    /// <summary>
    /// Логика взаимодействия для WindowStyle.xaml
    /// </summary>
    public partial class WindowStyle : Page
    {
        public WindowStyle()
        {
            InitializeComponent();
            CoreNavigate.MyConnection = MainFrame4;
            MainFrame4.Navigate(new ButtonStyler());
        }
        
    }
}
