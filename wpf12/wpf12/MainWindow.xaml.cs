﻿using System;
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

namespace wpf12
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
            nickNames = new NickNames();

            // Make data available for Data binding - note the data needs to support INotifyPropertyChanged
            theGrid.DataContext = nickNames;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            nickNames.Add(new Nickname(nameBox.Text, nickNameBox.Text));
        }

    }
}
