using NLog;
using System.Windows;
using System.Windows.Threading;

namespace ModToolbox
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static Logger log = LogManager.GetCurrentClassLogger();

        private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            log.Fatal(e.Exception);
        }
    }
}
