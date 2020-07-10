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
using System.Net.Sockets;//

namespace CCUiGO2
{
	/// <summary>
	/// UserMainWindow.xaml 的互動邏輯
	/// </summary>
	public partial class UserMainWindow : Window
	{
		public string[] user_info;
		private Client clientConnect;
		public UserMainWindow()
		{
			InitializeComponent();
			this.clientConnect = new Client();
			HomePage mainPage = new HomePage();
			//List<string> list = new List<string>();
			//OtherPage otherPage = new OtherPage(list,1);
			//Course_Detail course_Detail = new Course_Detail();
			Add_Comment_Page comment_Page = new Add_Comment_Page();
			frame.NavigationService.Navigate(comment_Page);
			user_info = new string[7];
		}

		public UserMainWindow(Socket pre_socket,string[] input)
		{
			InitializeComponent();
			this.clientConnect = new Client(pre_socket);
			HomePage mainPage = new HomePage();
			frame.NavigationService.Navigate(mainPage);
			user_info = new string[7];
			user_info = input;

			if(Convert.ToInt32(this.user_info[5])==0)
			{
				user_logo.Source = new BitmapImage(new Uri(@"Icon/user_female.png", UriKind.Relative));
			}
			else if(Convert.ToInt32(this.user_info[5]) == 1)
			{
				user_logo.Source = new BitmapImage(new Uri(@"Icon/user_male.png", UriKind.Relative));
			}
			else if (Convert.ToInt32(this.user_info[5]) == 2)
			{
				user_logo.Source = new BitmapImage(new Uri(@"Icon/admin.png", UriKind.Relative));
			}
			else
			{
				user_logo.Source = new BitmapImage(new Uri(@"Icon/info.png", UriKind.Relative));
			}

		}

		private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
		{
			ButtonCloseMenu.Visibility = Visibility.Visible;
			ButtonOpenMenu.Visibility = Visibility.Collapsed;
		}

		private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
		{
			ButtonCloseMenu.Visibility = Visibility.Collapsed;
			ButtonOpenMenu.Visibility = Visibility.Visible;
		}

		private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			//UserControl usc = null;
            //GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
					HomePage homePage = new HomePage();
					frame.NavigationService.Navigate(homePage);
                    break;
                case "ItemCreate":
                    //usc = new UserControlCreate();
                    //GridMain.Children.Add(usc);
                    break;
				case "ItemComment":
					clientConnect.AsyncSend("GET_COMMENT_DEFAULT");
					break;
				case "ItemLogout":
					MainWindow mainWindowback = new MainWindow(this.clientConnect.getSocket());
					mainWindowback.Show();
					this.Close();
					break;
				default:
                    break;
            }
		}

		private void WindowDrag(object sender, MouseButtonEventArgs e)
		{
			if(e.ChangedButton == MouseButton.Left)
			{
				this.DragMove();
			}
		}


		private void ListViewTitle_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			/*switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
			{
				case "ZoomIn":
					this.WindowState = WindowState.Minimized;
					break;
				case "Close":
					this.Close();
					break;
				default:
					break;
			}*/
		}

		private void TitleClick(object sender , RoutedEventArgs e)
		{
			string item = ((ListViewItem)((ListView)sender).SelectedItem).Name;
			if (item != null)
			{
				if(item.Equals("ZoomIn"))
				{
					this.WindowState = WindowState.Minimized;
				}
				else if(item.Equals("Close"))
				{
					this.Close();
				}
			}
		}
	}
}
