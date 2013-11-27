using System;
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

namespace ERP_System
{
    /// <summary>
    /// ChoseFuncWindow.xaml 的互動邏輯
    /// </summary>
    public partial class ChoseFuncWindow : Window
    {
        public ChoseFuncWindow()
        {
            InitializeComponent();
        }

        private void SDButton_Click(object sender, RoutedEventArgs e)
        {
            SDModule.SDWindow sdWindow = new SDModule.SDWindow();
            sdWindow.Show();

        }

        private void MMButton_Click(object sender, RoutedEventArgs e)
        {
            MMModule.MMWindow mmWindow = new MMModule.MMWindow();
            mmWindow.Show();
        }

        private void InformationButton_Click(object sender, RoutedEventArgs e)
        {
            InfoModule.ModifyInfoWindow modifyInfoWindow = new InfoModule.ModifyInfoWindow();
            modifyInfoWindow.Show();
        }

        private void ManageButton_Click(object sender, RoutedEventArgs e)
        {
            InfoModule.ManageUserWindow manageUserWindow = new InfoModule.ManageUserWindow();
            manageUserWindow.Show();
        }


    }
}