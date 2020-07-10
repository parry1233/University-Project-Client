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
		public OtherPage(List<string> name, List<string> depart, List<string> teacher, List<string> rating, int i,int dataCount)
		{
			InitializeComponent();
			this.name_info = name;
			this.depart_info = depart;
			this.teacher_info = teacher;
			this.rating_info = rating;
			this.currentPage = i;
			//PresentationLabel.Content = this.info[i-1];
			this.tmp = dataCount;

			CourseName1.Text = this.name_info[this.tmp];
			CourseName2.Text = this.name_info[this.tmp + 1];
			CourseName3.Text = this.name_info[this.tmp + 2];
			CourseName4.Text = this.name_info[this.tmp + 3];
			CourseName5.Text = this.name_info[this.tmp + 4];
			CourseName6.Text = this.name_info[this.tmp + 5];

			CourseDepart1.Text = this.depart_info[this.tmp];
			CourseDepart2.Text = this.depart_info[this.tmp + 1];
			CourseDepart3.Text = this.depart_info[this.tmp + 2];
			CourseDepart4.Text = this.depart_info[this.tmp + 3];
			CourseDepart5.Text = this.depart_info[this.tmp + 4];
			CourseDepart6.Text = this.depart_info[this.tmp + 5];

			CourseTea1.Text = this.teacher_info[this.tmp];
			CourseTea2.Text = this.teacher_info[this.tmp + 1];
			CourseTea3.Text = this.teacher_info[this.tmp + 2];
			CourseTea4.Text = this.teacher_info[this.tmp + 3];
			CourseTea5.Text = this.teacher_info[this.tmp + 4];
			CourseTea6.Text = this.teacher_info[this.tmp + 5];

			CourseRate1.Text = this.rating_info[this.tmp];
			CourseRate2.Text = this.rating_info[this.tmp + 1];
			CourseRate3.Text = this.rating_info[this.tmp + 2];
			CourseRate4.Text = this.rating_info[this.tmp + 3];
			CourseRate5.Text = this.rating_info[this.tmp + 4];
			CourseRate6.Text = this.rating_info[this.tmp + 5];

			int TotalPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(this.name_info.Count)/ 6));
			PageNUM.Content = i+"/"+TotalPage;
			if (i==1)
			{
				BackBTN.IsEnabled = false;
			}
			else if(i==TotalPage)
			{
				NextBTN.IsEnabled = false;
			}
		}

		private void NextBTN_Click(object sender, RoutedEventArgs e)
		{
			OtherPage otherPage = new OtherPage(this.name_info,this.depart_info,this.teacher_info,this.rating_info,this.currentPage + 1,this.tmp+6);
			this.NavigationService.Navigate(otherPage);
		}

		private void BackBTN_Click(object sender, RoutedEventArgs e)
		{
			OtherPage otherPage = new OtherPage(this.name_info, this.depart_info, this.teacher_info, this.rating_info, this.currentPage - 1, this.tmp - 6);
			this.NavigationService.Navigate(otherPage);
		}
	}
}
