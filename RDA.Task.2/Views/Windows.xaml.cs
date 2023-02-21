using RDA.Task._2.AppStyles;
using RDA.Task._2.Core;
using System.Linq.Expressions;
using System.Windows;
using System.Windows.Input;
using WindowStyle = RDA.Task._2.AppStyles.WindowStyle;

namespace RDA.Task._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Windows : Window
    {
        public Windows()
        {
            InitializeComponent();
            CoreNavigate.MyConnection = MainFrame;
            MainFrame.Navigate(new WindowStyle());
            CoreNavigate.MyConnection = Main2Frame;
            Main2Frame.Navigate(new TextBlockStyle());
            CoreNavigate.MyConnection = Main3Frame;
            Main3Frame.Navigate(new ButtonStyler());

        }
        private void Move_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
