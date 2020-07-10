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
	/// ForgetPWD_idpw.xaml 的互動邏輯
	/// </summary>
	public partial class ForgetPWD_idpw : Window
	{
		private Client clientConnect;
		public ForgetPWD_idpw()
		{
			InitializeComponent();
		}
		public ForgetPWD_idpw(Socket pre_socket)
		{
			InitializeComponent();
			this.clientConnect = new Client(pre_socket);
		}

		private void Back_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow(this.clientConnect.getSocket());
			mainWindow.Show();
			this.Close();
		}

		private void Next_Click(object sender, RoutedEventArgs e)
		{
			Loading loading = new Loading();
			loading.Show();
			this.clientConnect.AsyncSend("FOERGET_PW_CHECKIDEMAIL:" + id_textbox.Text + "/" + email_textbox.Text);
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
