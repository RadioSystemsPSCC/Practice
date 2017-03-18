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
using System.Windows.Media.Animation;

namespace InvisibleFenceContract
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Source = new Uri("Views/Contact1.xaml", UriKind.RelativeOrAbsolute);
        }

        //private void btnLeftMenuHide_Click(object sender, RoutedEventArgs e)
        //{
        //    ShowHideMenu("sbHideLeftMenu", btnLeftMenuHide, btnLeftMenuShow, pnlLeftMenu);
        //}

        //private void btnLeftMenuShow_Click(object sender, RoutedEventArgs e)
        //{
        //    ShowHideMenu("sbShowLeftMenu", btnLeftMenuHide, btnLeftMenuShow, pnlLeftMenu);
        //}

        private void ShowHideMenu(string Storyboard, Button btnHide, Button btnShow, StackPanel pnl)
        {
            Storyboard sb = Resources[Storyboard] as Storyboard;
            sb.Begin(pnl);

            if (Storyboard.Contains("Show"))
            {
                btnHide.Visibility = System.Windows.Visibility.Visible;
                btnShow.Visibility = System.Windows.Visibility.Hidden;

            }
            else if (Storyboard.Contains("Hide"))
            {
                btnHide.Visibility = System.Windows.Visibility.Hidden;
                btnShow.Visibility = System.Windows.Visibility.Visible;

            }
        }

        private void btnContact1_Click(object sender, RoutedEventArgs e)
        {
            Main.Source = new Uri("Views/Contact1.xaml", UriKind.RelativeOrAbsolute);
        }

        private void btnSafety2_Click(object sender, RoutedEventArgs e)
        {
            Main.Source = new Uri("Views/Safety2.xaml", UriKind.RelativeOrAbsolute);
        }

        private void btnProtection3_Click(object sender, RoutedEventArgs e)
        {
            Main.Source = new Uri("Views/Protection3.xaml", UriKind.RelativeOrAbsolute);
        }

        private void btnFreedom4_Click(object sender, RoutedEventArgs e)
        {
            Main.Source = new Uri("Views/Freedom4.xaml", UriKind.RelativeOrAbsolute);
        }

        private void btnSolutions5_Click(object sender, RoutedEventArgs e)
        {
            Main.Source = new Uri("Views/Solutions5.xaml", UriKind.RelativeOrAbsolute);
        }

        private void btnInstallation6_Click(object sender, RoutedEventArgs e)
        {
            Main.Source = new Uri("Views/Installation6.xaml", UriKind.RelativeOrAbsolute);
        }

        private void btnSignature7_Click(object sender, RoutedEventArgs e)
        {
            Main.Source = new Uri("Views/Signature7.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
