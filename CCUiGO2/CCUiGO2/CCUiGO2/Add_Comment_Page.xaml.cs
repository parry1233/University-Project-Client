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
    /// Add_Comment_Page.xaml 的互動邏輯
    /// </summary>
    public partial class Add_Comment_Page : Page
    {
        private Client clientConnect;
        private string[] class_info;
        private string user_info;
        private Dictionary<string, string> label_selectTag = new Dictionary<string, string>();
        private List<string> addTag_selectTag = new List<string>();
        public Add_Comment_Page(string[] classInfo,string userInfo,Socket preSocket)
        {
            InitializeComponent();
            this.class_info = classInfo;
            this.user_info = userInfo;
            this.clientConnect = new Client(preSocket);
            CourseDetail_Name.Text = this.class_info[0];
            CourseDetail_Name_ToolTip.Text = this.class_info[0];
            CourseDetail_Code.Text = this.class_info[1];
            CourseDetail_Depart.Text = this.class_info[2];
            CourseDetail_Depart_ToolTip.Text = this.class_info[2];
            CourseDetail_Tea.Text = this.class_info[3];
            CourseDetail_Tea_ToolTip.Text = this.class_info[3];
            CourseDetail_Rate.Text = this.class_info[4];

            teacher_choose.Items.Clear();
            char[] delimiterChars = { ' ' };
            string[] teacherAll = this.class_info[3].Split(delimiterChars);
            foreach(string s in teacherAll)
            {
                teacher_choose.Items.Add(s);
            }
        }

        private void add_tag_MouseDown(object sender, MouseButtonEventArgs e)
        {
           AddTagCreate();
        }

        private void addTagPressUp(object sender, KeyEventArgs e)
        {
            if ((sender as TextBox).Text.Length == 0)
            {
                secondPanel.Children.Remove(sender as UIElement);
            }
            RenewCurrentAddTag();
        }

        private void checkTag(object sender, RoutedEventArgs e)
        {
            if((sender as TextBox).Text.Length == 0)
            {
                secondPanel.Children.Remove(sender as UIElement);
            }
            else
            {
                bool check = false;
                if(!check)
                {
                    foreach (KeyValuePair<string, string> s in label_selectTag)
                    {
                        if (s.Value.Equals((sender as TextBox).Text))
                        {
                            secondPanel.Children.Remove(sender as UIElement);
                            check = true;
                            break;
                        }
                    }
                }
                if(!check)
                {
                    List<TextBox> textboxList = new List<TextBox>();
                    foreach (Object obj in secondPanel.Children)
                    {
                        if (obj.GetType() == typeof(TextBox))
                        {
                            textboxList.Add((obj as TextBox));
                        }
                    }
                    int count=0;
                    foreach(TextBox tBox in textboxList)
                    {
                        for(int i=count+1;i<textboxList.Count;i++)
                        {
                            if(count<textboxList.Count)
                            {
                                if (tBox.Text.Equals(textboxList[i].Text))
                                {
                                    secondPanel.Children.Remove((tBox as TextBox));
                                }
                            }
                        }
                        count++;
                    }
                }
            }
            RenewCurrentAddTag();
        }

        private void AddTagCreate()
        {
            RenewCurrentAddTag();
            if ((label_selectTag.Count+addTag_selectTag.Count)>=3)
            {
                MessageBox.Show("選擇的標籤已達上限，請先移除標籤再新增");
            }
            else
            {
                TextBox addTag = new TextBox();
                addTag.Text = "";
                addTag.Margin = new Thickness { Left = 10 };
                addTag.FontSize = 20;
                addTag.Height = 40;
                addTag.Background = new SolidColorBrush(Color.FromRgb(223, 64, 90));
                addTag.BorderThickness = new Thickness(10, 0, 10, 0);
                addTag.BorderBrush = new SolidColorBrush(Color.FromRgb(223, 64, 90));
                addTag.Foreground = Brushes.White;
                addTag.VerticalContentAlignment = VerticalAlignment.Center;
                addTag.HorizontalContentAlignment = HorizontalAlignment.Center;

                addTag.KeyUp += addTagPressUp;
                addTag.LostFocus += checkTag;
                secondPanel.Children.Add(addTag);

                addTag.Focus();
            }
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void Select_Tag(object sender, MouseButtonEventArgs e)
        {
            RenewCurrentAddTag();
            bool checkExist = false;
            foreach (KeyValuePair<string, string> s in label_selectTag)
            {
                if (s.Key.ToString().Equals((sender as Label).Name.ToString()))
                {
                    checkExist = true;
                    label_selectTag.Remove(s.Key);
                    (sender as Label).Background = new SolidColorBrush(Color.FromRgb(216, 230, 231));
                    (sender as Label).Foreground = Brushes.Black;
                    break;
                }
                else if (s.Value.ToString().Equals((sender as Label).Content.ToString()))
                {
                    checkExist = true;
                    break;
                }
                else
                {
                    checkExist = false;
                }
            }
            foreach(string s in addTag_selectTag)
            {
                if(s.Equals((sender as Label).Content.ToString()))
                {
                    checkExist = true;
                    break;
                }
            }
            if ((label_selectTag.Count+addTag_selectTag.Count) < 3 && !checkExist)
            {
                label_selectTag.Add((sender as Label).Name.ToString(), (sender as Label).Content.ToString());
                (sender as Label).Background = new SolidColorBrush(Color.FromRgb(223, 64, 90));
                (sender as Label).Foreground = Brushes.White;
            }
        }

        private void RenewCurrentAddTag()
        {
            int textboxCount = 0;
            this.addTag_selectTag.Clear();
            foreach (Object obj in secondPanel.Children)
            {
                if (obj.GetType() == typeof(TextBox))
                {
                    textboxCount++;
                    this.addTag_selectTag.Add((obj as TextBox).Text);
                }
            }
        }

        private void Add_Comment_Click(object sender, RoutedEventArgs e)
        {
            if(teacher_choose.SelectedIndex!=-1&&rate.SelectedIndex!=-1&&comment_content.Text.Length>0)
            {
                //處理textbox特殊字符
                string comment_text = comment_content.Text;
                comment_text = comment_text.Replace(":", "*");
                comment_text = comment_text.Replace("：", "*");
                comment_text = comment_text.Replace("/", "^");
                
                //處理標籤
                List<string> tag = new List<string>();
                string final = "";
                foreach (KeyValuePair<string, string> s in label_selectTag)
                {
                    tag.Add(s.Value);
                }
                foreach (string s in addTag_selectTag)
                {
                    tag.Add(s);
                }
                foreach (string s in tag)
                {
                    final += s+" ";
                }
                if(final.Length>0)
                {
                   final = final.Substring(0, final.Length - 1);
                }

                //取得本地時間
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                string time = DateTime.Now.ToShortTimeString();
                time = time.Replace(":", "時") + "分";
                string dateAndTime = date + " " + time;

                //回傳
                this.clientConnect.AsyncSend("COMMENT_REQUEST:" + user_info + "/" + class_info[1] + "/" + teacher_choose.SelectedItem.ToString() + "/" +
                    rate.Text + "/" + comment_text + "/" + 0 + "/" + dateAndTime + "/" + final);
            }
            else
            {
                MessageBox.Show("請填妥所有資訊!");
            }
        }
    }
}
