using System.Windows;

namespace wpf4.MyWindow
{
    partial class MyWindow1 : Window
    {
        public MyWindow1()
        {
            // This will effectively create and initialize the objects that are
            // defined in the Xaml.
            // It will initialize the myButton class and set its members and 
            // set the Click event to the Button_Click method defined in this file (we are the code behind)
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(myButton.Content as string);
        }
    }
}
