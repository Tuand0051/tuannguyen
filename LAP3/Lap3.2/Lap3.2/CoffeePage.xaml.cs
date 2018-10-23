using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Lap3._2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        
        string item = "Coffee: ";
        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            MenuFlyoutItem selectedItemFlyout = sender as MenuFlyoutItem;
            string txt = selectedItemFlyout.Text.ToString();
            if (txt != "None")
            {
                item += txt;
                txtCoffee.Text = item;
            }
            else
            {
                txtCoffee.Text = "Coffee: ";
            }
        }

        private void MenuFlyoutItem_Click_1(object sender, RoutedEventArgs e)
        {
            MenuFlyoutItem selectedItemFlyout = sender as MenuFlyoutItem;
            string txt = selectedItemFlyout.Text.ToString();
            if (txt != "None")
            {
                item += " + " + txt;
                txtCoffee.Text = item;
            }
            else
            {
                txtCoffee.Text = "Coffee: ";
            }
        }

        private void MenuFlyoutItem_Click_2(object sender, RoutedEventArgs e)
        {
            MenuFlyoutItem selectedItemFlyout = sender as MenuFlyoutItem;
            string txt = selectedItemFlyout.Text.ToString();
            if (txt != "None")
            {
                item += " + " + txt;
                txtCoffee.Text = item;
            }
            else
            {
                txtCoffee.Text = "Coffee: ";
            }
        }
    }
}
