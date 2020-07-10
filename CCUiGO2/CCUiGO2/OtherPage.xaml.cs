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
	/// OtherPage.xaml 的互動邏輯
	/// </summary>
	public partial class OtherPage : Page
	{
		private List<string> name_info = new List<string>();
		private List<string> depart_info = new List<string>();
		private List<string> teacher_info = new List<string>();
		private List<string> rating_info = new List<string>();
		private int currentPage;
		private int tmp;

		private Client clientConnect;
		public OtherPage(List<string> name, List<string> depart, List<string> teacher, List<string> rating, int i,int dataCount,Socket pre_socket,string nowsearch)
		{
			InitializeComponent();
			Filter.Visibility = Visibility.Hidden;
			this.clientConnect = new Client(pre_socket);
			this.SearchBox.Text = nowsearch;
			this.name_info = name;
			this.depart_info = depart;
			this.teacher_info = teacher;
			this.rating_info = rating;
			this.currentPage = i;
			//PresentationLabel.Content = this.info[i-1];
			this.tmp = dataCount;

			try
			{
				CourseName1.Text = this.name_info[this.tmp];
				CourseNameToolTip1.Text = this.name_info[this.tmp];
				CourseDepart1.Text = this.depart_info[this.tmp];
				CourseTea1.Text = this.teacher_info[this.tmp];
				CourseRate1.Text = this.rating_info[this.tmp];
			}
			catch(System.ArgumentOutOfRangeException)
			{
				CourseBTN1.Visibility = Visibility.Collapsed;
			}

			try
			{
				CourseName2.Text = this.name_info[this.tmp + 1];
				CourseNameToolTip2.Text = this.name_info[this.tmp + 1];
				CourseDepart2.Text = this.depart_info[this.tmp + 1];
				CourseTea2.Text = this.teacher_info[this.tmp + 1];
				CourseRate2.Text = this.rating_info[this.tmp + 1];
			}
			catch (System.ArgumentOutOfRangeException)
			{
				CourseBTN2.Visibility = Visibility.Collapsed;
			}

			try
			{
				CourseName3.Text = this.name_info[this.tmp + 2];
				CourseNameToolTip3.Text = this.name_info[this.tmp + 2];
				CourseDepart3.Text = this.depart_info[this.tmp + 2];
				CourseTea3.Text = this.teacher_info[this.tmp + 2];
				CourseRate3.Text = this.rating_info[this.tmp + 2];
			}
			catch (System.ArgumentOutOfRangeException)
			{
				CourseBTN3.Visibility = Visibility.Collapsed;
			}

			try
			{
				CourseName4.Text = this.name_info[this.tmp + 3];
				CourseNameToolTip4.Text = this.name_info[this.tmp + 3];
				CourseDepart4.Text = this.depart_info[this.tmp + 3];
				CourseTea4.Text = this.teacher_info[this.tmp + 3];
				CourseRate4.Text = this.rating_info[this.tmp + 3];
			}
			catch (System.ArgumentOutOfRangeException)
			{
				CourseBTN4.Visibility = Visibility.Collapsed;
			}

			try
			{
				CourseName5.Text = this.name_info[this.tmp + 4];
				CourseNameToolTip5.Text = this.name_info[this.tmp + 4];
				CourseDepart5.Text = this.depart_info[this.tmp + 4];
				CourseTea5.Text = this.teacher_info[this.tmp + 4];
				CourseRate5.Text = this.rating_info[this.tmp + 4];
			}
			catch (System.ArgumentOutOfRangeException)
			{
				CourseBTN5.Visibility = Visibility.Collapsed;
			}

			try
			{
				CourseName6.Text = this.name_info[this.tmp + 5];
				CourseNameToolTip6.Text = this.name_info[this.tmp + 5];
				CourseDepart6.Text = this.depart_info[this.tmp + 5];
				CourseTea6.Text = this.teacher_info[this.tmp + 5];
				CourseRate6.Text = this.rating_info[this.tmp + 5];
			}
			catch (System.ArgumentOutOfRangeException)
			{
				CourseBTN6.Visibility = Visibility.Collapsed;
			}

			int TotalPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(this.name_info.Count)/ 6));
			PageNUM.Content = i+"/"+TotalPage;
			if (i<=1)
			{
				BackBTN.IsEnabled = false;
			}
			if(i>=TotalPage)
			{
				NextBTN.IsEnabled = false;
			}
		}

		private void NextBTN_Click(object sender, RoutedEventArgs e)
		{
			OtherPage otherPage = new OtherPage(this.name_info,this.depart_info,this.teacher_info,this.rating_info,this.currentPage + 1,this.tmp+6, this.clientConnect.getSocket(), SearchBox.Text);
			this.NavigationService.Navigate(otherPage);
		}

		private void BackBTN_Click(object sender, RoutedEventArgs e)
		{
			OtherPage otherPage = new OtherPage(this.name_info, this.depart_info, this.teacher_info, this.rating_info, this.currentPage - 1, this.tmp - 6, this.clientConnect.getSocket(), SearchBox.Text);
			this.NavigationService.Navigate(otherPage);
		}

		private void Search_Enter_Press(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				string time_interval_string = "";
				foreach (object checkbox1 in MonTime1.Children)
				{
					if ((checkbox1 as CheckBox).IsChecked.Value)
					{
						time_interval_string += "一" + (checkbox1 as CheckBox).Content + " ";
					}
				}
				foreach (object checkbox1 in MonTime2.Children)
				{
					if ((checkbox1 as CheckBox).IsChecked.Value)
					{
						time_interval_string += "一" + (checkbox1 as CheckBox).Content + " ";
					}
				}
				foreach (object checkbox1 in TueTime1.Children)
				{
					if ((checkbox1 as CheckBox).IsChecked.Value)
					{
						time_interval_string += "二" + (checkbox1 as CheckBox).Content + " ";
					}
				}
				foreach (object checkbox1 in TueTime2.Children)
				{
					if ((checkbox1 as CheckBox).IsChecked.Value)
					{
						time_interval_string += "二" + (checkbox1 as CheckBox).Content + " ";
					}
				}
				foreach (object checkbox1 in WedTime1.Children)
				{
					if ((checkbox1 as CheckBox).IsChecked.Value)
					{
						time_interval_string += "三" + (checkbox1 as CheckBox).Content + " ";
					}
				}
				foreach (object checkbox1 in WedTime2.Children)
				{
					if ((checkbox1 as CheckBox).IsChecked.Value)
					{
						time_interval_string += "三" + (checkbox1 as CheckBox).Content + " ";
					}
				}
				foreach (object checkbox1 in ThuTime1.Children)
				{
					if ((checkbox1 as CheckBox).IsChecked.Value)
					{
						time_interval_string += "四" + (checkbox1 as CheckBox).Content + " ";
					}
				}
				foreach (object checkbox1 in ThuTime2.Children)
				{
					if ((checkbox1 as CheckBox).IsChecked.Value)
					{
						time_interval_string += "四" + (checkbox1 as CheckBox).Content + " ";
					}
				}
				foreach (object checkbox1 in FriTime1.Children)
				{
					if ((checkbox1 as CheckBox).IsChecked.Value)
					{
						time_interval_string += "五" + (checkbox1 as CheckBox).Content + " ";
					}
				}
				foreach (object checkbox1 in FriTime2.Children)
				{
					if ((checkbox1 as CheckBox).IsChecked.Value)
					{
						time_interval_string += "五" + (checkbox1 as CheckBox).Content + " ";
					}
				}
				if (time_interval_string.Length >= 1)
				{
					time_interval_string = time_interval_string.Substring(0, time_interval_string.Length - 1);
				}

				string rate_interval = "";
				int max = 0;
				bool check = false;

				if (MaxFive.IsChecked.Value)
				{
					check = true;
					if(max<5)
					{
						max = 5;
					}
					rate_interval = max.ToString();
				}
				if (MaxFour.IsChecked.Value)
				{
					check = true;
					if (max < 4)
					{
						max = 4;
					}
					rate_interval = max.ToString();
				}
				if (MaxThree.IsChecked.Value)
				{
					check = true;
					if (max < 3)
					{
						max = 3;
					}
					rate_interval = max.ToString();
				}
				if (MaxTwo.IsChecked.Value)
				{
					check = true;
					if (max < 2)
					{
						max = 2;
					}
					rate_interval = max.ToString();
				}
				if (MaxOne.IsChecked.Value)
				{
					check = true;
					if (max < 1)
					{
						max = 1;
					}
					rate_interval = max.ToString();
				}


				if (SearchBox.Text.Length!=0)
				{
					if (time_interval_string.Length >= 1)
					{
						if (check)
						{
							clientConnect.AsyncSend("GET_COMMENT_KEYWORD_FILTER_ALL:" + SearchBox.Text + "/" + time_interval_string + "/" + rate_interval);
						}
						else
						{
							clientConnect.AsyncSend("GET_COMMENT_KEYWORD_FILTER_TIME:" + SearchBox.Text + "/" + time_interval_string);
						}
					}
					else if (check)
					{
						clientConnect.AsyncSend("GET_COMMENT_KEYWORD_FILTER_RATE:" + SearchBox.Text + "/" + rate_interval);
					}
					else
					{
						clientConnect.AsyncSend("GET_COMMENT_KEYWORD:" + SearchBox.Text);
					}
				}
				else
				{
					if (time_interval_string.Length >= 1)
					{
						if (check)
						{
							clientConnect.AsyncSend("GET_COMMENT_DEFAULT_FILTER_ALL:" + time_interval_string + "/" + rate_interval);
						}
						else
						{
							clientConnect.AsyncSend("GET_COMMENT_DEFAULT_FILTER_TIME:"+ time_interval_string);
						}
					}
					else if (check)
					{
						clientConnect.AsyncSend("GET_COMMENT_DEFAULT_FILTER_RATE:"+ rate_interval);
					}
					else
					{
						clientConnect.AsyncSend("GET_COMMENT_DEFAULT");
					}
				}
			}
		}

		private void CourseBTN_Click(object sender, RoutedEventArgs e)
		{
			if((sender as Button).Name.Equals("CourseBTN1"))
			{
				clientConnect.AsyncSend("GET_COMMENT:"+ CourseName1.Text + "/" + CourseDepart1.Text + "/" + CourseTea1.Text);
			}
			else if((sender as Button).Name.Equals("CourseBTN2"))
			{
				clientConnect.AsyncSend("GET_COMMENT:" + CourseName2.Text + "/" + CourseDepart2.Text + "/" + CourseTea2.Text);
			}
			else if((sender as Button).Name.Equals("CourseBTN3"))
			{
				clientConnect.AsyncSend("GET_COMMENT:" + CourseName3.Text + "/" + CourseDepart3.Text + "/" + CourseTea3.Text);
			}
			else if((sender as Button).Name.Equals("CourseBTN4"))
			{
				clientConnect.AsyncSend("GET_COMMENT:" + CourseName4.Text + "/" + CourseDepart4.Text + "/" + CourseTea4.Text);
			}
			else if((sender as Button).Name.Equals("CourseBTN5"))
			{
				clientConnect.AsyncSend("GET_COMMENT:" + CourseName5.Text + "/" + CourseDepart5.Text + "/" + CourseTea5.Text);
			}
			else if((sender as Button).Name.Equals("CourseBTN6"))
			{
				clientConnect.AsyncSend("GET_COMMENT:" + CourseName6.Text + "/" + CourseDepart6.Text + "/" + CourseTea6.Text);
			}
			else
			{
				// do nothing
			}
		}

		private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			bool flag = (sender as ToggleButton).Toggled1 == true ? true : false;
			
			//Transfer name
			string day = (sender as ToggleButton).Name.ToString().Split('_')[0];
			day = day + "Time";
			//MessageBox.Show(day);

			object wantedNode = Time_Interval_All.FindName(day);

			foreach (object item in (wantedNode as WrapPanel).Children)
			{
				//var item = MonTime.Children[i];
				if (item is StackPanel)
				{
					//CheckBox checkBoxItem = (CheckBox)item;
					//checkBoxItem.IsChecked = flag;
					foreach(object stackPanel_inStackPanel in (item as StackPanel).Children)
					{
						foreach(object checkbox in (stackPanel_inStackPanel as StackPanel).Children)
						{
							(checkbox as CheckBox).IsChecked = flag;
						}
					}
				}
			}
		}

		private void FilterShowOrNot(object sender,RoutedEventArgs e)
		{
			bool show = Filter.IsVisible == true ? false : true;

			if(show)
			{
				Filter.Visibility = Visibility.Visible;
			}
			else
			{
				Filter.Visibility = Visibility.Hidden;
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
				SearchBox.Foreground = new SolidColorBrush(Color.FromRgb(216, 230, 231)); ;
			}
		}

		private void FilterComfirm_Click(object sender, RoutedEventArgs e)
		{
			Filter.Visibility = Visibility.Hidden;
		}
	}
}
