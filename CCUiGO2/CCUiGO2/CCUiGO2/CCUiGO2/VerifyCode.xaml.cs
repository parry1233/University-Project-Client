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
using System.Net;//
using System.Net.Sockets;//
using System.Windows.Threading;

namespace CCUiGO2
{
	/// <summary>
	/// VerifyCode.xaml 的互動邏輯
	/// </summary>
	public partial class VerifyCode : Window
	{
        private int time_count;
		private string[] info = new string[8];
		private Client clientConnect;
		public VerifyCode()
		{
			InitializeComponent();
			this.clientConnect = new Client();
            this.time_count = 0;
            TimerStart();
            ReVerifyCodeBTN.IsEnabled = false;
            ReVerifyCodeBTN.Visibility = Visibility.Hidden;
		}

		public VerifyCode(Socket pre_socket, string[] input)
		{
			InitializeComponent();
			this.clientConnect = new Client(pre_socket);
            this.time_count = 0;
            for (int a = 0; a <= 6; a++)
            {
                this.info[a] = input[a];
            }
            TimerStart();
            ReVerifyCodeBTN.IsEnabled = false;
            ReVerifyCodeBTN.Visibility = Visibility.Hidden;
        }

        private void ReVerifyCode_Click(object sender, RoutedEventArgs e)
        {
            this.clientConnect.AsyncSend("REGISTER_VERIFY_EMAIL:" + this.info[6]);
            ReVerifyCodeBTN.Visibility = Visibility.Hidden;
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

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            this.info[7] = verify_code_text.Text;
            this.clientConnect.AsyncSend("REGISTER_ACCOUNT:"
                    + this.info[0] + "/" + this.info[1] + "/" + this.info[2] + "/" + this.info[3] + "/" +
                    this.info[4] + "/" + this.info[5] + "/" + this.info[6] + "/" + this.info[7]);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            string[] output = new string[7];
            for (int i = 0; i < 7; i++)
            {
                output[i] = this.info[i];
            }
            sign_up_info sign_Up_Info = new sign_up_info(output[0], output[1], output[2], output[3], output[4], output[5], output[6], this.clientConnect.getSocket());
            sign_Up_Info.Show();
            this.Close();
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
