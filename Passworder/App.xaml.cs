using Passworder.Core;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Windows;

namespace Passworder
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            try
            {
                Initialization.InitPathDirectory();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot initialize application: {ex.Message}",
                          "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Shutdown();
            }
        }
    }
}
