using System.Windows;

namespace RDA.Task._2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new Windows().Show();
        }
    }
}
