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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lap3._2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(DonutPage));
        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Tag)
            {
                case "donut":
                    MainFrame.Navigate(typeof(DonutPage));
                    break;
                case "coffee":
                    MainFrame.Navigate(typeof(CoffeePage));
                    break;
                case "schedule":
                    MainFrame.Navigate(typeof(SchedulePage));
                    break;
                case "complete":
                    MainFrame.Navigate(typeof(CompletePage));
                    break;
            }
        }
    }
}
