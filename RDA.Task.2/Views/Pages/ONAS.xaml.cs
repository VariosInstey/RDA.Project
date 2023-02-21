using RDA.Task._2.AppStyles;
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

namespace RDA.Task._2.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ONAS.xaml
    /// </summary>
    public partial class ONAS : Page
    {
        public ONAS()
        {
            InitializeComponent();
        }
        private void BtnWindows_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new System.Windows.WindowStyle());
            CoreNavigate.MyConnection?.Navigate(new ButtonStyler());
            CoreNavigate.MyConnection?.Navigate(new ButtonStyler());

        }
    }
}
