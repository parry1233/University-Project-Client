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

namespace CCUiGO2
{
    /// <summary>
    /// Shop_Page.xaml 的互動邏輯
    /// </summary>
    public partial class Shop_Page : Page
    {
		private int points;
        public Shop_Page(string points)
        {
            InitializeComponent();

			this.points = Convert.ToInt32(points);
        }
    }
}