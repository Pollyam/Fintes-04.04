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
using System.Windows.Shapes;

namespace Fitnes
{
    /// <summary>
    /// Логика взаимодействия для Win.xaml
    /// </summary>
    public partial class Win : Window
    {
        public Win()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Win1 win1 = new Win1();
            win1.Show();
        }
    }
}
