﻿using System;
using System.Collections;
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

namespace Trials_Eldor
{
    /// <summary>
    /// Interaction logic for dialogbox.xaml
    /// </summary>
    public partial class dialogbox : Window
    {
        public dialogbox(IEnumerable List)
        {
            InitializeComponent();
            Box.ItemsSource = List;
        }
    }
}
