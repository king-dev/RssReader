﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Reader.ViewModels;

namespace Reader
{
    public partial class StartPage : PhoneApplicationPage
    {
        public StartPage()
        {
            InitializeComponent();
            this.DataContext = new StartPageViewModel();

        }

        private void update_Click(object sender, EventArgs e)
        {
            ((StartPageViewModel)DataContext).Update();
        }
    }
}