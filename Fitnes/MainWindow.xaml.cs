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

namespace Fitnes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void avtoriz_Click(object sender, RoutedEventArgs e)
        {
            if ((login.Text == "admin") && (parol.Text == "admin"))
            {
                Win win = new Win();
                win.Show();
            }
            else MessageBox.Show("Неверный пароль или логин");
        }
    }
}
