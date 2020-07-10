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

namespace CCUiGO2
{
    /// <summary>
    /// sign_up_info.xaml 的互動邏輯
    /// </summary>
    public partial class sign_up_info : Window
    {
		private string[] info = new string[7];
		private Client clientConnect;
		public sign_up_info()
        {
            InitializeComponent();
			this.clientConnect = new Client();
			info = new string[7];
		}
		public sign_up_info(string[] idpw,Socket pre_socket)
		{
			InitializeComponent();
			this.info[0] = idpw[0];
			this.info[1] = idpw[1];
			this.clientConnect = new Client(pre_socket);
		}

		//for back page
		public sign_up_info(string id,string pw,string name,string depart,string grade_in,string gender, string email_in, Socket pre_socket)
		{
			InitializeComponent();
			this.info[0] = id;
			this.info[1] = pw;
			this.info[2] = name;
			this.info[3] = depart;
			this.info[4] = grade_in;
			this.info[5] = gender;
			this.info[6] = email_in;
			this.clientConnect = new Client(pre_socket);

			nickname.Text = this.info[2];
			nickname.SetCurrentValue(ForegroundProperty, Brushes.Black);
			department.Text = this.info[3];
			grade.Text = this.info[4];
			if (Convert.ToInt32(this.info[5]) == 1)
			{
				male.IsChecked = true;
			}
			else if (Convert.ToInt32(this.info[5]) == 0)
			{
				female.IsChecked = true;
			}
			email.Text = this.info[6];
			email.SetCurrentValue(ForegroundProperty, Brushes.Black);
		}

		private void nickname_GotFocus_1(object sender, RoutedEventArgs e)
		{
			if (nickname.Text.Equals("暱稱"))
			{
				nickname.Text = "";
				nickname.SetCurrentValue(ForegroundProperty, Brushes.Black);
			}
		}

		private void nickname_LostFocus_1(object sender, RoutedEventArgs e)
		{
			if (nickname.Text.Length == 0)
			{
				nickname.Text = "暱稱";
				nickname.SetCurrentValue(ForegroundProperty, Brushes.Gray);
			}
		}

		private void email_GotFocus_1(object sender, RoutedEventArgs e)
		{
			if (email.Text.Equals("Email"))
			{
				email.Text = "";
				email.SetCurrentValue(ForegroundProperty, Brushes.Black);
			}
		}

		private void email_LostFocus_1(object sender, RoutedEventArgs e)
		{
			if (email.Text.Length == 0)
			{
				email.Text = "Email";
				email.SetCurrentValue(ForegroundProperty, Brushes.Gray);
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
            this.info[2] = nickname.Text;
            //this.info[3] = department.Text;
            this.info[3] = department.Text;
            //this.info[4] = grade.Text;
            this.info[4] = grade.Text;
            int maleORfemale;
            if (male.IsChecked.Value)
            {
                maleORfemale = 1;
                this.info[5] = maleORfemale.ToString();
            }
            else if (female.IsChecked.Value)
            {
                maleORfemale = 0;
                this.info[5] = maleORfemale.ToString();
            }
            else
            {
                maleORfemale = 2;
                this.info[5] = maleORfemale.ToString();
            }
            this.info[6] = email.Text;
            this.clientConnect.setALLinfo(this.info);
            this.clientConnect.AsyncSend("REGISTER_VERIFY_EMAIL:" + email.Text);
            VerifyCode verify_Code = new VerifyCode(this.clientConnect.getSocket(), this.info);
            verify_Code.Show();
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(this.clientConnect.getSocket(),this.info[0]);
            mainWindow.Show();
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
