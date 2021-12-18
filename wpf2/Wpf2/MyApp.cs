using System;
using System.Windows;

namespace Wpf2
{
    class MyApp : Application // Note we're deriving from Application
    {
        [STAThread]
        static void Main(string[] args)
        {
            // We're creating an Application
            MyApp app = new MyApp();

            // When it starts, we'll show a Window
            app.Startup += App_Startup;

            // Start the event handling system
            app.Run();
        }

        private static void App_Startup(object sender, StartupEventArgs e)
        {
            // Arbitary window
            Window window = new Window();
            window.Title = "Hello World!";

            // Show it
            window.Show();
        }
    }
}
