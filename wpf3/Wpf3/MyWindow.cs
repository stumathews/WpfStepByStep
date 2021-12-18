using System.Windows;
using System.Windows.Controls;

namespace Wpf3
{
    partial class MyApp
    {
        class MyWindow : Window
        {
            public MyWindow()
            {
                // Customize this window
                this.Title = "My Window!";

                // This is mixing how the window will look with
                // the code that initializes the Window - its not the WPF way...

                // Ideally the event handlers and such stuff should be handled by coders,
                // while the look and feel and placement should be handled by designers using XAML

                Button myButton = new Button();
                myButton.Content = "Click me baby, one more time!";
                myButton.Width = 200;
                myButton.Height = 25;
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
