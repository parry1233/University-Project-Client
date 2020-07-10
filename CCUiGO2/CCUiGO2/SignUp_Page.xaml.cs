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
using System.Net;//
using System.Net.Sockets;//

namespace CCUiGO2
{
    /// <summary>
    /// SignUp_Page.xaml 的互動邏輯
    /// </summary>
    public partial class SignUp_Page : Page
    {
        private string id, pw;
        public SignUp_Page()
        {
            InitializeComponent();
            conditionIcon.Visibility = Visibility.Hidden;
            Sign_in_line.Visibility = Visibility.Hidden;
        }
        public SignUp_Page(string id)
        {
            InitializeComponent();
            conditionIcon.Visibility = Visibility.Hidden;
            Sign_in_line.Visibility = Visibility.Hidden;
            id_register.Text = id;
        }

        private void pw_register_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!pw_recheck.Password.Equals(pw_register.Password))
            {
                conditionIcon.Visibility = Visibility.Visible;
                conditionIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Close;
            }
            else if (pw_recheck.Password.Equals(pw_register.Password))
            {
                conditionIcon.Visibility = Visibility.Visible;
                conditionIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.CheckBold;
            }
        }

        private void Pw_recheck_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pw_recheck.Password.Length == 0)
            {
                conditionIcon.Visibility = Visibility.Hidden;
            }
            if (!pw_recheck.Password.Equals(pw_register.Password))
            {
                conditionIcon.Visibility = Visibility.Visible;
                conditionIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Close;
            }
            else if (pw_recheck.Password.Equals(pw_register.Password))
            {
                conditionIcon.Visibility = Visibility.Visible;
                conditionIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.CheckBold;
            }
        }
    }
}
