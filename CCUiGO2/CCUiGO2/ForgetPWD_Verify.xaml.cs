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
using System.Windows.Threading;

namespace CCUiGO2
{
	/// <summary>
	/// ForgetPWD_Verify.xaml 的互動邏輯
	/// </summary>
	public partial class ForgetPWD_Verify : Window
	{
		private int time_count;
		private string id,email;
		private Client clientConnect;
		public ForgetPWD_Verify()
		{
			InitializeComponent();
		}

		public ForgetPWD_Verify(Socket pre_socket,string id_in,string email_in)
		{
			InitializeComponent();
			this.clientConnect = new Client(pre_socket);
			this.id = id_in;
			this.email = email_in;
			this.time_count = 0;
			TimerStart();
			ReVerifyCodeBTN.IsEnabled = false;
			ReVerifyCodeBTN.Visibility = Visibility.Hidden;
		}

		private void Back_Click(object sender, RoutedEventArgs e)
		{
			ForgetPWD_idpw forgetPWD_Idpw = new ForgetPWD_idpw(this.clientConnect.getSocket());
			forgetPWD_Idpw.Show();
			this.Close();
		}

		private void Next_Click(object sender, RoutedEventArgs e)
		{
			this.clientConnect.AsyncSend("FORGET_PW_VERIFY:"+verify_code_text.Text+"/"+this.id+"/"+this.email);
		}

		public void TimerStart()
		{
			DispatcherTimer dispatcherTimer = new DispatcherTimer();
			dispatcherTimer.Tick += dispatcherTimer_Tick;
			dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
			dispatcherTimer.Start();
		}

		private void dispatcherTimer_Tick(object sender, EventArgs e)
		{
			this.time_count++;
			if (this.time_count >= 6)
			{
				this.time_count = 0;
				ReVerifyCodeBTN.IsEnabled = true;
				ReVerifyCodeBTN.Visibility = Visibility.Visible;
			}
		}
		private void Verify_code_text_GotFocus(object sender, RoutedEventArgs e)
		{
			if (verify_code_text.Text.Equals("輸入驗證碼"))
			{
				verify_code_text.Text = "";
				verify_code_text.SetCurrentValue(ForegroundProperty, Brushes.Black);
			}
		}

		private void Verify_code_text_LostFocus(object sender, RoutedEventArgs e)
		{
			if (verify_code_text.Text.Length == 0)
			{
				verify_code_text.Text = "輸入驗證碼";
				verify_code_text.SetCurrentValue(ForegroundProperty, Brushes.Gray);
			}
		}

		private void Close_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void Minus_Click(object sender, RoutedEventArgs e)
		{
			this.WindowState = WindowState.Minimized;
		}

		private void ReVerifyCode_Click(object sender, RoutedEventArgs e)
		{
			this.clientConnect.AsyncSend("RESEND_VERIFYtoEMAIL:" + this.email);
			ReVerifyCodeBTN.Visibility = Visibility.Hidden;
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
