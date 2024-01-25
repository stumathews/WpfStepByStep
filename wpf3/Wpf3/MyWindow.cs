using System.Windows;
using System.Windows.Controls;

namespace Wpf3
{
    internal partial class MyApp
    {
        private class MyWindow : Window
        {
            public MyWindow()
            {
                // Customize this window
                this.Title = "My Window!";

                // This is mixing how the window will look with
                // the code that initializes the Window - its not the WPF way...

                // Ideally the event handlers and such stuff should be handled by coders,
                // while the look and feel and placement should be handled by designers using XAML

                var myButton = new Button
                {
                    Content = "Click me baby, one more time!",
                    Width = 200,
                    Height = 25
                };
                myButton.Click += MyButton_Click;

                // Set the windows main content to the button
                this.Content = myButton;
            }

            private void MyButton_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("You've clicked on me!");
            }
        }
    }
}
