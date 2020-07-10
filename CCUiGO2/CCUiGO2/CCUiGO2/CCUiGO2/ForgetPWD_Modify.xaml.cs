using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

namespace CCUiGO2
{
	/// <summary>
	/// ForgetPWD_Modify.xaml 的互動邏輯
	/// </summary>
	public partial class ForgetPWD_Modify : Window
	{
		private string id,email;
		private Client clientConnect;
		public ForgetPWD_Modify()
		{
			InitializeComponent();
		}

		public ForgetPWD_Modify(Socket pre_socket,string id_in,string email_in)
		{
			InitializeComponent();
			this.clientConnect = new Client(pre_socket);
			this.id = id_in;
			this.email = email_in;
		}

		private void Next_Click(object sender, RoutedEventArgs e)
		{
			if(pw_modify.Password.Equals(pw_modify_recheck.Password))
			{
				this.clientConnect.AsyncSend("FORGET_PW_CHANGEPW:" + pw_modify.Password+"/"+this.id);
				Loading loading = new Loading();
				loading.Show();
			}
			else
			{
				MessageBox.Show("密碼不一致，請重新輸入!");
			}
		}

		private void Back_Click(object sender, RoutedEventArgs e)
		{
			ForgetPWD_Verify forgetPWD_Verify = new ForgetPWD_Verify(this.clientConnect.getSocket(),this.id,this.email);
			forgetPWD_Verify.Show();
			this.Close();
		}

		private void Pw_modify_PasswordChanged(object sender, RoutedEventArgs e)
		{
			if (!pw_modify.Password.Equals(pw_modify_recheck.Password))
			{
				conditionIcon.Visibility = Visibility.Visible;
				conditionIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Close;
			}
			else if (pw_modify.Password.Equals(pw_modify_recheck.Password))
			{
				conditionIcon.Visibility = Visibility.Visible;
				conditionIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.CheckBold;
			}
		}

		private void Pw_modify_recheck_PasswordChanged(object sender, RoutedEventArgs e)
		{
			if (pw_modify.Password.Length == 0)
			{
				conditionIcon.Visibility = Visibility.Hidden;
			}
			if (!pw_modify_recheck.Password.Equals(pw_modify.Password))
			{
				conditionIcon.Visibility = Visibility.Visible;
				conditionIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Close;
			}
			else if (pw_modify_recheck.Password.Equals(pw_modify.Password))
			{
				conditionIcon.Visibility = Visibility.Visible;
				conditionIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.CheckBold;
			}
		}

		private void Minus_Click(object sender, RoutedEventArgs e)
		{
			this.WindowState = WindowState.Minimized;
		}

		private void Close_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

        private void WindowDrag(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void TitleClick(object sender, MouseButtonEventArgs e)
        {
            string item = ((ListViewItem)((ListView)sender).SelectedItem).Name;
            if (item != null)
            {
                if (item.Equals("ZoomIn"))
                {
                    this.WindowState = WindowState.Minimized;
                }
                else if (item.Equals("Close"))
                {
                    this.Close();
                }
            }
        }
    }
}
