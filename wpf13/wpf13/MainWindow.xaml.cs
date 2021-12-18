using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NickNames nickNames;
        public MainWindow()
        {
            InitializeComponent();
            
            // Instead of creating the collection, we can pull it directly from the resources
            // so it appears like the resources are a bag of already constructed objects... unless FindResource() does the instantiation of 'names' object
            nickNames = (NickNames) FindResource("names");
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            nickNames.Add(new Nickname(nameBox.Text, nickNameBox.Text));
        }
    }
}
