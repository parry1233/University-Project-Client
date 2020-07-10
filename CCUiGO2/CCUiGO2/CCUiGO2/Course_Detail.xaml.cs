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
    /// Course_Detail.xaml 的互動邏輯
    /// </summary>
    public partial class Course_Detail : Page
    {
        private Client clientConnect;
        private List<string> user_info = new List<string>();
		private List<string> rating_info = new List<string>();
		private List<string> comment_info = new List<string>();
        private List<string> like_info = new List<string>();
		private List<string> date_info = new List<string>();
		private List<string> tag_info = new List<string>();
		private int currentPage;
        private int tmp;
		private string saveCourseTime;
		private int saveCourseTable=0;

		public Course_Detail(string class_name, string class_id, string class_depart, string class_tea, string class_ratings, string class_time,
            List<string> user, List<string> rating, List<string> comment, List<string> like, List<string> date, List<string> tag, int i, int dataCount, Socket pre_socket)
        {
            InitializeComponent();
            this.clientConnect = new Client(pre_socket);
			Filter.Visibility = Visibility.Collapsed;
			ChooseTable.Visibility = Visibility.Collapsed;

			CourseDetail_Name.Text = class_name;
			CourseDetail_Name_ToolTip.Text = class_name;
            CourseDetail_Code.Text = class_id;
			CourseDetail_Depart.Text = class_depart;
			CourseDetail_Depart_ToolTip.Text = class_depart;
            CourseDetail_Tea.Text = class_tea;
			CourseDetail_Tea_ToolTip.Text = class_tea;
			CourseDetail_Time.Text = class_time;
			CourseDetail_Time_ToolTip.Text = class_time;
			CourseDetail_Rate.Text = class_ratings;

            user_info = user;
			rating_info = rating;
			comment_info = comment;
            like_info = like;
			date_info = date;
			tag_info = tag;

            this.currentPage = i;
            this.tmp = dataCount;

			try
			{
				User_Name1.Text = this.user_info[this.tmp];
				string comment_in = this.comment_info[this.tmp];
				comment_in = comment_in.Replace("*", ":");
				comment_in = comment_in.Replace("^", "/");
				User_Comment1.Text = comment_in;
				User_Comment_ToolTip1.Text = comment_in;

				User_Rate1.Text = this.rating_info[this.tmp];
				Comment_Time_ToolTip1.Text = this.date_info[this.tmp];

				string[] three_tags = new string[] { "","","" };
				string[] temp = this.tag_info[this.tmp].Split(' ');
				for (int z = 0; z < temp.Length; z++)
				{
					if (temp[z].Length > 0)
					{
						temp[z] = "#" + temp[z];
					}
				}
				for (int t=0;t < temp.Length;t++)
				{
					three_tags[t] = temp[t];
				}
				if(three_tags.Length>0)
				{
					User_Tag1_1.Text = three_tags[0];
					User_Tag1_2.Text = three_tags[1];
					User_Tag1_3.Text = three_tags[2];
				}
			}
			catch (System.ArgumentOutOfRangeException)
			{
				CommentBTN1.Visibility = Visibility.Collapsed;
			}

			try
			{
				User_Name2.Text = this.user_info[this.tmp + 1];
				string comment_in = this.comment_info[this.tmp+1];
				comment_in = comment_in.Replace("*", ":");
				comment_in = comment_in.Replace("^", "/");
				User_Comment2.Text = comment_in;
				User_Comment_ToolTip2.Text = comment_in;
				User_Rate2.Text = this.rating_info[this.tmp + 1];
				Comment_Time_ToolTip2.Text = this.date_info[this.tmp + 1];

				string[] three_tags = new string[] { "", "", "" };
				string[] temp = this.tag_info[this.tmp + 1].Split(' ');
				for (int z = 0; z < temp.Length; z++)
				{
					if (temp[z].Length > 0)
					{
						temp[z] = "#" + temp[z];
					}
				}
				for (int t = 0; t < temp.Length; t++)
				{
					three_tags[t] = temp[t];
				}
				if (three_tags.Length > 0)
				{
					User_Tag2_1.Text = three_tags[0];
					User_Tag2_2.Text = three_tags[1];
					User_Tag2_3.Text = three_tags[2];
				}
			}
			catch (System.ArgumentOutOfRangeException)
			{
				CommentBTN2.Visibility = Visibility.Collapsed;
			}

			try
			{
				User_Name3.Text = this.user_info[this.tmp + 2];
				string comment_in = this.comment_info[this.tmp+2];
				comment_in = comment_in.Replace("*", ":");
				comment_in = comment_in.Replace("^", "/");
				User_Comment3.Text = comment_in;
				User_Comment_ToolTip3.Text = comment_in;
				User_Rate3.Text = this.rating_info[this.tmp + 2];
				Comment_Time_ToolTip3.Text = this.date_info[this.tmp + 2];

				string[] three_tags = new string[] { "", "", "" };
				string[] temp = this.tag_info[this.tmp + 2].Split(' ');
				for(int z=0;z<temp.Length;z++)
				{
					if (temp[z].Length > 0)
					{
						temp[z] = "#" + temp[z];
					}
				}
				for (int t = 0; t < temp.Length; t++)
				{
					three_tags[t] = temp[t];
				}
				if (three_tags.Length > 0)
				{
					User_Tag3_1.Text = three_tags[0];
					User_Tag3_2.Text = three_tags[1];
					User_Tag3_3.Text = three_tags[2];
				}
			}
			catch (System.ArgumentOutOfRangeException)
			{
				CommentBTN3.Visibility = Visibility.Collapsed;
			}

			try
			{
				User_Name4.Text = this.user_info[this.tmp + 3];
				string comment_in = this.comment_info[this.tmp+3];
				comment_in = comment_in.Replace("*", ":");
				comment_in = comment_in.Replace("^", "/");
				User_Comment4.Text = comment_in;
				User_Comment_ToolTip4.Text = comment_in;

				User_Rate4.Text = this.rating_info[this.tmp + 3];
				Comment_Time_ToolTip4.Text = this.date_info[this.tmp + 3];

				string[] three_tags = new string[] { "", "", "" };
				string[] temp = this.tag_info[this.tmp + 3].Split(' ');
				for (int z = 0; z < temp.Length; z++)
				{
					if (temp[z].Length > 0)
					{
						temp[z] = "#" + temp[z];
					}
				}
				for (int t = 0; t < temp.Length; t++)
				{
					three_tags[t] = temp[t];
				}
				if (three_tags.Length > 0)
				{
					User_Tag4_1.Text = three_tags[0];
					User_Tag4_2.Text = three_tags[1];
					User_Tag4_3.Text = three_tags[2];
				}
			}
			catch (System.ArgumentOutOfRangeException)
			{
				CommentBTN4.Visibility = Visibility.Collapsed;
			}

			try
			{
				User_Name5.Text = this.user_info[this.tmp + 4];
				string comment_in = this.comment_info[this.tmp+4];
				comment_in = comment_in.Replace("*", ":");
				comment_in = comment_in.Replace("^", "/");
				User_Comment5.Text = comment_in;
				User_Comment_ToolTip5.Text = comment_in;

				User_Rate5.Text = this.rating_info[this.tmp + 4];
				Comment_Time_ToolTip5.Text = this.date_info[this.tmp + 4];

				string[] three_tags = new string[] { "", "", "" };
				string[] temp = this.tag_info[this.tmp + 4].Split(' ');
				for (int z = 0; z < temp.Length; z++)
				{
					if (temp[z].Length > 0)
					{
						temp[z] = "#" + temp[z];
					}
				}
				for (int t = 0; t < temp.Length; t++)
				{
					three_tags[t] = temp[t];
				}
				if (three_tags.Length > 0)
				{
					User_Tag5_1.Text = three_tags[0];
					User_Tag5_2.Text = three_tags[1];
					User_Tag5_3.Text = three_tags[2];
				}
			}
			catch (System.ArgumentOutOfRangeException)
			{
				CommentBTN5.Visibility = Visibility.Collapsed;
			}

			try
			{
				User_Name6.Text = this.user_info[this.tmp + 5];
				string comment_in = this.comment_info[this.tmp+5];
				comment_in = comment_in.Replace("*", ":");
				comment_in = comment_in.Replace("^", "/");
				User_Comment6.Text = comment_in;
				User_Comment_ToolTip6.Text = comment_in;

				User_Rate6.Text = this.rating_info[this.tmp + 5];
				Comment_Time_ToolTip6.Text = this.date_info[this.tmp + 5];

				string[] three_tags = new string[] { "", "", "" };
				string[] temp = this.tag_info[this.tmp + 5].Split(' ');
				for (int z = 0; z < temp.Length; z++)
				{
					if(temp[z].Length > 0)
					{
						temp[z] = "#" + temp[z];
					}
				}
				for (int t = 0; t < temp.Length; t++)
				{
					three_tags[t] = temp[t];
				}
				if (three_tags.Length > 0)
				{
					User_Tag6_1.Text = three_tags[0];
					User_Tag6_2.Text = three_tags[1];
					User_Tag6_3.Text = three_tags[2];
				}
			}
			catch (System.ArgumentOutOfRangeException)
			{
				CommentBTN6.Visibility = Visibility.Collapsed;
			}

			int TotalPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(this.comment_info.Count) / 6));
			PageNUM.Content = i + "/" + TotalPage;
			if (i <= 1)
			{
				BackBTN.IsEnabled = false;
			}
			if (i >= TotalPage)
			{
				NextBTN.IsEnabled = false;
			}
		}

		private void NextBTN_Click(object sender, RoutedEventArgs e)
		{
			Course_Detail otherPage = new Course_Detail(CourseDetail_Name.Text, CourseDetail_Code.Text, CourseDetail_Depart.Text, CourseDetail_Tea.Text, CourseDetail_Rate.Text, CourseDetail_Time.Text, 
				this.user_info, this.rating_info, this.comment_info, this.like_info, this.date_info, this.tag_info, this.currentPage + 1, this.tmp + 6, this.clientConnect.getSocket());
			otherPage.Add_Comment.Click += AddCommentBTN_Click;
			this.NavigationService.Navigate(otherPage);
		}

		private void BackBTN_Click(object sender, RoutedEventArgs e)
		{
			Course_Detail otherPage = new Course_Detail(CourseDetail_Name.Text, CourseDetail_Code.Text, CourseDetail_Depart.Text, CourseDetail_Tea.Text, CourseDetail_Rate.Text, CourseDetail_Time.Text,
				this.user_info, this.rating_info, this.comment_info, this.like_info, this.date_info,this.tag_info, this.currentPage - 1, this.tmp - 6, this.clientConnect.getSocket());
			otherPage.Add_Comment.Click += AddCommentBTN_Click;
			this.NavigationService.Navigate(otherPage);
		}

		private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.NavigationService.GoBack();
		}

		public string[] getClassInfo()
		{
			string[] output = new string[] { CourseDetail_Name.Text, CourseDetail_Code.Text, CourseDetail_Depart.Text, 
				CourseDetail_Tea.Text, CourseDetail_Rate.Text };
			return output;
		}

		private void AddCommentBTN_Click(object sender, RoutedEventArgs e)
		{
			foreach (Window win in App.Current.Windows)
			{
				if (win.GetType() == typeof(UserMainWindow))
				{
					Add_Comment_Page add_Comment_Page = new Add_Comment_Page((win as UserMainWindow).return_current_course_details(),
						(win as UserMainWindow).getID(), this.clientConnect.getSocket());
					(win as UserMainWindow).frame.NavigationService.Navigate(add_Comment_Page);
				}
			}
		}

		private void AddToScheduleBTN_MouseDown(object sender, MouseButtonEventArgs e)
		{
			selectTime.Items.Clear();
			saveCourseTable = 0;
			saveCourseTime = null;
			selectTime.Items.Clear();
			string timeText = CourseDetail_Time.Text.Replace("(", "");
			timeText.Substring(0, timeText.Length - 1);
			string[] time = timeText.Split(')');
			if(time.Length>1)
			{
				foreach(string t in time)
				{
					if(t.Length>=1)
					{
						selectTime.Items.Add(t);
					}
				}
			}
			Filter.Visibility = Visibility.Visible;
		}

		private void TimeSelectConfirm(object sender, RoutedEventArgs e)
		{
			if(selectTime.SelectedItem!=null)
			{
				saveCourseTime = selectTime.SelectedItem.ToString();
				//MessageBox.Show("Select Complete!\r\nSelected Interval:" + saveCourseTime);
				Filter.Visibility = Visibility.Collapsed;
				selectTable.Items.Clear();
				ScheduleSettings scheduleSettings = new ScheduleSettings();
				for (int i = 1; i <= scheduleSettings.TableCount(); i++)
				{
					selectTable.Items.Add("Table" + i);
				}
				ChooseTable.Visibility = Visibility.Visible;
			}
		}

		private void TimeSelectCancel(object sender, RoutedEventArgs e)
		{
			Filter.Visibility = Visibility.Collapsed;
		}

		private void TableSelectCancel(object sender, RoutedEventArgs e)
		{
			ChooseTable.Visibility = Visibility.Collapsed;
		}

		private void TableSelectConfirm(object sender, RoutedEventArgs e)
		{
			if (selectTable.SelectedItem != null)
			{
				saveCourseTable = selectTable.SelectedIndex;
				//MessageBox.Show("Select Complete!\r\nSelected Table:" + saveCourseTable);
				ChooseTable.Visibility = Visibility.Collapsed;

				ScheduleSettings scheduleSettings = new ScheduleSettings();
				string[] saveClass = new string[4];
				saveClass[0] = CourseDetail_Name.Text;
				saveClass[1] = CourseDetail_Depart.Text;
				saveClass[2] = CourseDetail_Tea.Text;
				saveClass[3] = saveCourseTime;
				scheduleSettings.Add(saveClass, saveCourseTable);
			}
		}
	}
}
