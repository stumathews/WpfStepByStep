using System;
using System.Windows;

namespace Wpf3
{
    internal partial class MyApp : Application // Note we're deriving from Application
    {

        [STAThread]
        private static void Main(string[] args)
        {
            // We're creating an Application
            var app = new MyApp();

            // When it starts, we'll show a Window
            app.Startup += App_Startup;

            // Start the event handling system
            app.Run();
        }

        private static void App_Startup(object sender, StartupEventArgs e)
        {
            // This is a MyWindow window now!
            Window window = new MyWindow();

            // Show it
            window.Show();
        }
    }
}
