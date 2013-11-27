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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ERP_System
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        private ERP_DBEntities db; //db related var.

        public MainWindow()
        {
            InitializeComponent();
            this.ResizeMode = System.Windows.ResizeMode.NoResize;
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Check_Passowrd();
        }

        private void Password_Box_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Check_Passowrd();
        }

        private void Check_Passowrd()
        {
            String UsernameStr = UsernameTextBox.Text.ToString();
            String PasswordStr = Password_Box.Password.ToString();

            db = new ERP_DBEntities();
            var LoginQuery = from d in db.user where d.Username == UsernameStr select d.Password;
            //Find password in db
            Boolean IsLoginSuccess = false;
            foreach (String StrInQuery in LoginQuery.ToList())
            {
                if (StrInQuery == PasswordStr)
                {
                    IsLoginSuccess = true;
                    break;
                }
            }
            if (IsLoginSuccess)
            {
                ChoseFuncWindow choseFuncWindow = new ChoseFuncWindow();
                choseFuncWindow.Show();
            }
            else
            {
                MessageBox.Show("用户名和密码错误，请检查。", "登录失败！");
            }
        }
    }
}
