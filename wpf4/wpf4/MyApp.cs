using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace wpf4
{
    class MyApp : Application
    {
        [STAThread]
        private static void Main(string[] args)
        {
            var app = new MyApp();
            app.Startup += App_Startup;
            app.Run();
        }

        private static void App_Startup(object sender, StartupEventArgs e)
        {
            // Our MyWindow1 class is defined in two places using partial classes to refer to the same class:
            // 1) Xaml defines the MyWindow1 class and its members etc
            // 2) the code behind for the MyWindow will call InitalizeComponent() to actually
            // run C# to hook up the and setup the definition of the MyWindow1 class as defined in the Xaml 
            
            // We can just 'use' it as MyWindow1 (its comprised of Xaml and code behind)
            var myWindow1 = new MyWindow.MyWindow1();
            myWindow1.Show();
        }
    }
}
