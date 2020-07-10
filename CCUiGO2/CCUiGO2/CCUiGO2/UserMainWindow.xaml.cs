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
		//public string[] user_info;
		private Client clientConnect;
		private string[] current_course_details;
		private bool checkInChatroom = false;

		private string ID;
		private string PW;
		private string User_Name;
		private string Depart;
		private string Grade;
		private string Gender;
		private string Email;
		private string Level;
		private string Points;
		private string Detail;
		private string Friend;
		private string Achievement;
		private string LastLogin;
		private string TodayTarget;
		private string TomorrowTarget;

		private HomePage mainPage;
		private Chatroom_Preview chatroom_Preview;
		private Chatroom_Page chatroom_Page;
		private Schedule_Page schedule_Page;
		private iGO_Page igo_Page;

		public UserMainWindow()
		{
			InitializeComponent();
			this.clientConnect = new Client();
			//List<string> list = new List<string>();
			//OtherPage otherPage = new OtherPage(list,1);
			//Course_Detail course_Detail = new Course_Detail();
			//frame.NavigationService.Navigate(comment_Page);
			//user_info = new string[7];
		}

		public UserMainWindow(Socket pre_socket,string[] input)
		{
			InitializeComponent();
			this.clientConnect = new Client(pre_socket);
			this.mainPage = new HomePage(clientConnect.getSocket());
			this.mainPage.Course_Chatroom.Click += mainPage_Course_Chatroom_Click;
			frame.NavigationService.Navigate(this.mainPage);

			this.ID = input[0];
			this.PW = input[1];
			this.User_Name = input[2];
			this.Depart = input[3];
			this.Grade = input[4];
			this.Gender = input[5];
			this.Email = input[6];
			this.Level = input[7];
			this.Points = input[8];
			this.Detail = input[9];
			this.Friend = input[10];
			this.Achievement = input[11];
			this.LastLogin = input[12];
			this.TodayTarget = input[13];
			this.TomorrowTarget = input[14];


			//user_info = new string[15];
			//user_info = input;

			User_Name_TextBlock.Text = this.User_Name;
			User_Level_TextBlock.Text = this.Level;
			User_Points_TextBlock.Text = this.Points;

			char[] delimiterChars = { ',' };
			string detail_temp = this.Detail;
			string[] split = detail_temp.Split(delimiterChars);
			int counter = 0;

			foreach(string s in split)
			{
				counter++;
				if(counter==1)
				{
					if(s.Equals("vip"))
					{
						user_logo.Source = new BitmapImage(new Uri(@"Icon/vip.png", UriKind.Relative));
					}
					else
					{
						if (Convert.ToInt32(this.Gender) == 0)
						{
							user_logo.Source = new BitmapImage(new Uri(@"Icon/user_female.png", UriKind.Relative));
						}
						else if (Convert.ToInt32(this.Gender) == 1)
						{
							user_logo.Source = new BitmapImage(new Uri(@"Icon/user_male.png", UriKind.Relative));
						}
						else if (Convert.ToInt32(this.Gender) == 2)
						{
							user_logo.Source = new BitmapImage(new Uri(@"Icon/admin.png", UriKind.Relative));
						}
						else
						{
							user_logo.Source = new BitmapImage(new Uri(@"Icon/info.png", UriKind.Relative));
						}
					}
				}
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

            /*switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
					frame.NavigationService.Navigate(this.mainPage);
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
            }*/
		}

		private void Home(object sender, MouseButtonEventArgs e)
		{
			frame.NavigationService.Navigate(this.mainPage);
		}

		private void Comment(object sender, MouseButtonEventArgs e)
		{
			clientConnect.AsyncSend("GET_COMMENT_DEFAULT");
		}

		private void Schedule(object sender, MouseButtonEventArgs e)
		{
			this.schedule_Page = new Schedule_Page(this.clientConnect.getSocket()) ;
			frame.NavigationService.Navigate(this.schedule_Page);
		}

		private void iGO(object sender, MouseButtonEventArgs e)
		{
			this.igo_Page = new iGO_Page();
			frame.NavigationService.Navigate(this.igo_Page);
		}

		private void Chatroom(object sender, MouseButtonEventArgs e)
		{
			ChatOrChatPreview();
		}

		private void mainPage_Course_Chatroom_Click(object sender, RoutedEventArgs e)
		{
			ChatOrChatPreview();
		}

		private void ChatOrChatPreview()
		{
			if (!checkInChatroom)
			{
				clientConnect.AsyncSend("PREVIEW_CHATROOM");
			}
			else
			{
				this.frame.NavigationService.Navigate(this.chatroom_Page);
			}
		}

		private void Settings_Click(object sender, MouseButtonEventArgs e)
		{
			//
		}

		private void Logout(object sender, MouseButtonEventArgs e)
		{
			MainWindow mainWindowback = new MainWindow(this.clientConnect.getSocket());
			mainWindowback.Show();
			this.Close();
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
		private void BottomClick(object sender, RoutedEventArgs e)
		{
			
		}

		/*public string[] get_user_info()
		{
			return this.user_info;
		}*/

		public void set_current_course_details(string[] input)
		{
			this.current_course_details = input;
		}
		public string[] return_current_course_details()
		{
			return this.current_course_details;
		}

		public void ChatPreview(List<string> name, List<string> member)
		{
			this.checkInChatroom = false;
			this.chatroom_Preview = new Chatroom_Preview(name,member,0,1,this.clientConnect.getSocket(),this.User_Name);
			this.frame.NavigationService.Navigate(this.chatroom_Preview);
		}

		public void JoinChatroom(string room)
		{
			this.checkInChatroom = true;
			this.chatroom_Page = new Chatroom_Page(room,this.clientConnect.getSocket());
			this.chatroom_Page.exitIcon.MouseDown += ExitChat;
			this.frame.NavigationService.Navigate(this.chatroom_Page);
		}

		public void AddChatToOwn(string s)
		{
			this.chatroom_Page.AddTextOwn(s);
		}

		public void AddChat(string name,string s)
		{
			this.chatroom_Page.AddText(name,s);
		}

		public void MemberJoin(string name)
		{
			this.chatroom_Page.JoinMessage(name);
		}

		public void MemberLeave(string name)
		{
			this.chatroom_Page.LeaveMessage(name);
		}

		public void Broadcast(string user_name,string chatroom)
		{
			Scrolling_Text.Text = user_name + " 新增話題「" + chatroom + "」，歡迎參與!";
			run_word.Begin();
		}

		private void run_word_Completed(object sender, EventArgs e)
		{
			Scrolling_Text.Text = "";
		}

		private void ExitChat(object sender, RoutedEventArgs e)
		{
			clientConnect.AsyncSend("EXIT_CHATROOM");
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (checkInChatroom)
			{
				clientConnect.AsyncSend("EXIT_CHATROOM");
			}
		}

		public string getID()
		{
			return this.ID;
		}

		private void DownTitleClick(object sender, RoutedEventArgs e)
		{
			string item = ((ListViewItem)((ListView)sender).SelectedItem).Name;
			if (item != null)
			{
				if (item.Equals("Achievement_Icon"))
				{
					Achievement_Page achievement_Page = new Achievement_Page();
					achievement_Page.NavigationService.Navigate(achievement_Page);
				}
				else if (item.Equals("Shop_Icon"))
				{
					
				}
				else if (item.Equals("Settings_Icon"))
				{

				}
			}
		}
	}
}
