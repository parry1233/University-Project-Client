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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CCUiGO2
{
    /// <summary>
    /// Chatroom_Preview.xaml 的互動邏輯
    /// </summary>
    public partial class Chatroom_Preview : Page
    {
		private Client clientConnect; 
		private List<string> roomName = new List<string>();
		private List<string> roomNumberCount = new List<string>();
		private string user_name = "";
		private int start_index = 0;
		private int page_count = 1;

        public Chatroom_Preview(List<string> name,List<string> member,int dataStart,int pageCount,Socket sIn,string userName)
        {
            InitializeComponent();
			this.roomName = name;
			this.roomNumberCount = member;
			this.start_index = dataStart;
			this.page_count = pageCount;
			this.clientConnect = new Client(sIn);
			this.user_name = userName;
			AddTopicGrid.Visibility = Visibility.Collapsed;

			int TotalPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(this.roomName.Count) / 6));
			if(TotalPage==0)
			{
				TotalPage = 1;
			}
			PageNUM.Content = this.page_count+"/"+TotalPage;

			if (pageCount <= 1)
			{
				BackBTN.IsEnabled = false;
			}
			if (pageCount >= TotalPage)
			{
				NextBTN.IsEnabled = false;
			}

			try
			{
				Chatroom_Name1.Text = this.roomName[this.start_index];
				Chatroom_Number1.Text = this.roomNumberCount[this.start_index];
			}
			catch (System.ArgumentOutOfRangeException)
			{
				ChatroomBTN1.Visibility = Visibility.Collapsed;
			}

			try
			{
				Chatroom_Name2.Text = this.roomName[this.start_index+1];
				Chatroom_Number2.Text = this.roomNumberCount[this.start_index+1];
			}
			catch (System.ArgumentOutOfRangeException)
			{
				ChatroomBTN2.Visibility = Visibility.Collapsed;
			}

			try
			{
				Chatroom_Name3.Text = this.roomName[this.start_index+2];
				Chatroom_Number3.Text = this.roomNumberCount[this.start_index+2];
			}
			catch (System.ArgumentOutOfRangeException)
			{
				ChatroomBTN3.Visibility = Visibility.Collapsed;
			}

			try
			{
				Chatroom_Name4.Text = this.roomName[this.start_index+3];
				Chatroom_Number4.Text = this.roomNumberCount[this.start_index+3];
			}
			catch (System.ArgumentOutOfRangeException)
			{
				ChatroomBTN4.Visibility = Visibility.Collapsed;
			}

			try
			{
				Chatroom_Name5.Text = this.roomName[this.start_index+4];
				Chatroom_Number5.Text = this.roomNumberCount[this.start_index+4];
			}
			catch (System.ArgumentOutOfRangeException)
			{
				ChatroomBTN5.Visibility = Visibility.Collapsed;
			}

			try
			{
				Chatroom_Name6.Text = this.roomName[this.start_index+5];
				Chatroom_Number6.Text = this.roomNumberCount[this.start_index+5];
			}
			catch (System.ArgumentOutOfRangeException)
			{
				ChatroomBTN6.Visibility = Visibility.Collapsed;
			}
		}

		private void AddTopic(object sender, RoutedEventArgs e)
		{
			AddTopicGrid.Visibility = Visibility.Visible;
			topicGrid.IsEnabled = false;
			//this.clientConnect.AsyncSend("ADD_CHATROOM");
		}

		private void AddTopicComplete(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				if (AddTopicTextbox.Text.Length != 0)
				{
					this.clientConnect.AsyncSend("ADD_CHATROOM:" + user_name + "/" + AddTopicTextbox.Text);
					AddTopicGrid.Visibility = Visibility.Collapsed;
					topicGrid.IsEnabled = true;
				}
			}
		}

		private void ChatroomBTN1_Click(object sender, RoutedEventArgs e)
		{		
			this.clientConnect.AsyncSend("JOIN_CHATROOM:" + Chatroom_Name1.Text+"/"+this.user_name);
		}

		private void ChatroomBTN2_Click(object sender, RoutedEventArgs e)
		{
			this.clientConnect.AsyncSend("JOIN_CHATROOM:" + Chatroom_Name2.Text + "/" + this.user_name);
		}

		private void ChatroomBTN3_Click(object sender, RoutedEventArgs e)
		{
			this.clientConnect.AsyncSend("JOIN_CHATROOM:" + Chatroom_Name3.Text + "/" + this.user_name);
		}

		private void ChatroomBTN4_Click(object sender, RoutedEventArgs e)
		{
			this.clientConnect.AsyncSend("JOIN_CHATROOM:" + Chatroom_Name4.Text + "/" + this.user_name);
		}

		private void ChatroomBTN5_Click(object sender, RoutedEventArgs e)
		{
			this.clientConnect.AsyncSend("JOIN_CHATROOM:" + Chatroom_Name5.Text + "/" + this.user_name);
		}

		private void ChatroomBTN6_Click(object sender, RoutedEventArgs e)
		{
			this.clientConnect.AsyncSend("JOIN_CHATROOM:" + Chatroom_Name6.Text + "/" + this.user_name);
		}

		private void NextBTN_Click(object sender, RoutedEventArgs e)
		{
			Chatroom_Preview chatroom_Preview = new Chatroom_Preview(this.roomName, this.roomNumberCount, this.start_index+6, this.page_count+1, this.clientConnect.getSocket(), this.user_name);
			this.NavigationService.Navigate(chatroom_Preview);
		}

		private void BackBTN_Click(object sender, RoutedEventArgs e)
		{
			Chatroom_Preview chatroom_Preview = new Chatroom_Preview(this.roomName, this.roomNumberCount, this.start_index-6, this.page_count-1, this.clientConnect.getSocket(), this.user_name);
			this.NavigationService.Navigate(chatroom_Preview);
		}

		private void Add_Chatroom_GotFocus_1(object sender, RoutedEventArgs e)
		{
			if (AddTopicTextbox.Text.Equals(" 話題名稱"))
			{
				AddTopicTextbox.Text = "";
				AddTopicTextbox.SetCurrentValue(ForegroundProperty, Brushes.Black);
			}
		}

		private void Add_Chatroom_LostFocus_1(object sender, RoutedEventArgs e)
		{
			if (AddTopicTextbox.Text.Length == 0)
			{
				AddTopicTextbox.Text = " 話題名稱";
				AddTopicTextbox.SetCurrentValue(ForegroundProperty, Brushes.Gray);
			}
		}
	}
}
