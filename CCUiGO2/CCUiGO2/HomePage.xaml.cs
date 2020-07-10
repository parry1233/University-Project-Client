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
    /// HomePage.xaml 的互動邏輯
    /// </summary>
    public partial class HomePage : Page
	{
		private Client clientConnect;
		public HomePage(Socket preSocket)
		{
			InitializeComponent();
			clientConnect = new Client(preSocket);
        }
		private void HomePage_Schedule_Click(object sender, RoutedEventArgs e)
		{
			Schedule_Page schedule_Page = new Schedule_Page(this.clientConnect.getSocket());
			this.NavigationService.Navigate(schedule_Page);
		}

		private void HomePage_Comment_Click(object sender, RoutedEventArgs e)
		{
			clientConnect.AsyncSend("GET_COMMENT_DEFAULT");
		}

		private void Search_Enter_Press(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				if (SearchBox.Text.Length != 0)
				{
					clientConnect.AsyncSend("GET_COMMENT_KEYWORD:" + SearchBox.Text);
				}
				else
				{
					clientConnect.AsyncSend("GET_COMMENT_DEFAULT");
				}
			}
		}

		private void SearchBox_GotFocus(object sender, RoutedEventArgs e)
		{
			if (SearchBox.Text.Equals("輸入標籤、課程名稱、老師名稱等"))
			{
				SearchBox.Text = "";
				SearchBox.SetCurrentValue(ForegroundProperty, Brushes.GhostWhite);
			}
		}

		private void SearchBox_LostFocus(object sender, RoutedEventArgs e)
		{
			if (SearchBox.Text.Length == 0)
			{
				SearchBox.Text = "輸入標籤、課程名稱、老師名稱等";
				SearchBox.Foreground = new SolidColorBrush(Color.FromRgb(216, 230, 231));
				//SearchBox.SetCurrentValue(ForegroundProperty, Color.FromRgb(216, 230, 231));
			}
		}
	}
}
