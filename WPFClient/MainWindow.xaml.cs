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

namespace WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Generate(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int number = rand.Next();
            if(number>999999999)
            {
                number = number / 10;
                Input.Text = number.ToString();
            }
            else
            {
                Input.Text = number.ToString();
            }
        }

        private void Button_Click_Convert(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32(Input.Text);

            if(number<1 || number>999999999)
            {
                MessageBox.Show("Input Not in range.");
            }
            else
            {
                MessageBox.Show("Result:");
            }
        }
    }
}
