using System;
using System.Windows;

namespace Wpf
{
    class Program
    {
        // This signals to .NET to make sure that when COM is initialized on the
        // application's main thread, its initialized in such a way that its 
        // compatible with single-threaded UI work, as thts required by WPF apps
        [STAThread]
        static void Main(string[] args)
        {
            MessageBox.Show("Hello, world!");
        }
    }
}
