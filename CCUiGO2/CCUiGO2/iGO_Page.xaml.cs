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
using System.Windows.Threading;

namespace CCUiGO2
{
    /// <summary>
    /// iGO_Page.xaml 的互動邏輯
    /// </summary>
    public partial class iGO_Page : Page
    {
        private IgoSettings igoSettings = new IgoSettings();
        private DispatcherTimer timer;
        public iGO_Page()
        {
            InitializeComponent();

            load();
        }

        public void load()
        {
            InitializeComponent();
            this.igoSettings.LoadTarget();

            List<ComboBox> comboboxList = new List<ComboBox>();
            comboboxList.Add(Tomorr_Target_1_Combobox);
            comboboxList.Add(Tomorr_Target_2_Combobox);
            comboboxList.Add(Tomorr_Target_3_Combobox);
            comboboxList.Add(Tomorr_Target_4_Combobox);
            comboboxList.Add(Tomorr_Target_5_Combobox);

            foreach (ComboBox cbox in comboboxList)
            {
                cbox.Text = "";
                cbox.Items.Clear();
                cbox.Items.Add("學習");
                cbox.Items.Add("作業");
                cbox.Items.Add("考試");
                cbox.Items.Add("思考");

            }

            List<string[]> todayList = this.igoSettings.getDateTarget(DateTime.Now.ToString("yyyy-MM-dd"));
            for (int count = 0;count<todayList.Count;count++)
            {
               string objectName = Today_Target.Name;
               foreach(object obj in Today_Target.Children)
               {
                    if(obj is StackPanel&& (obj as StackPanel).Name.Replace("Today_Target_","").Equals((count+1).ToString()))
                    {
                        foreach(object childrenInObj in (obj as StackPanel).Children)
                        {
                            if(childrenInObj is TextBox)
                            {
                                (childrenInObj as TextBox).Text = todayList[count][1];
                            }
                            else if(childrenInObj is Border)
                            {
                                if ((childrenInObj as Border).Child is TextBlock)
                                {
                                    ((childrenInObj as Border).Child as TextBlock).Text = todayList[count][2];
                                }
                            }
                            else if(childrenInObj is RadioButton)
                            {
                                (childrenInObj as RadioButton).IsEnabled = true;
                                if(todayList[count][3].Equals("undone"))
                                {
                                    (childrenInObj as RadioButton).IsChecked = false;
                                }
                                else if(todayList[count][3].Equals("done"))
                                {
                                    (childrenInObj as RadioButton).IsChecked = true;
                                }
                            }
                        }
                    }
               }
            }

            if (this.igoSettings.getLongTarget().Count > 1)
            {
                Tomorr_Target_1_Combobox.Items.Add("長期");
                Tomorr_Target_2_Combobox.Items.Add("長期");
                Tomorr_Target_3_Combobox.Items.Add("長期");
                Tomorr_Target_4_Combobox.Items.Add("長期");
                Tomorr_Target_5_Combobox.Items.Add("長期");
            }
            List<string[]> tomorrowList = this.igoSettings.getDateTarget(DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"));
            for (int count = 0; count < tomorrowList.Count; count++)
            {
                string objectName = Tomorr_Target.Name;
                foreach (object obj in Tomorr_Target.Children)
                {
                    if (obj is StackPanel && (obj as StackPanel).Name.Replace("Tomorr_Target_", "").Equals((count + 1).ToString()))
                    {
                        foreach (object childrenInObj in (obj as StackPanel).Children)
                        {
                            if (childrenInObj is TextBox)
                            {
                                (childrenInObj as TextBox).Text = tomorrowList[count][1];
                            }
                            else if (childrenInObj is ComboBox)
                            {
                                (childrenInObj as ComboBox).Text = tomorrowList[count][2];
                            }
                        }
                    }
                }
            }

            if(this.igoSettings.getLongTarget().Count>1)
            {
                AddTopicBTN.IsEnabled = false;
                AddTopicBTN.Visibility = Visibility.Collapsed;
                AddTargetTitle.Visibility = Visibility.Collapsed;

                int longTargetAllTime = Convert.ToInt32(this.igoSettings.getLongTarget()[1]);
                int longTargetCompleteTime = Convert.ToInt32(this.igoSettings.getLongTarget()[2]);
                Long_Target_Title.Text = this.igoSettings.getLongTarget()[0];
                Long_Target_Time.Text = "為期"+longTargetAllTime+"天";
                LongTargetPercentage.Text = (longTargetCompleteTime*100 / longTargetAllTime)+"%";
                percentageBorder.Height = (longTargetCompleteTime * 92 / longTargetAllTime);

                LongTargetPercentage.Visibility = Visibility.Visible;
                Complete_Percent.Visibility = Visibility.Visible;
                Long_Target_Title.Visibility = Visibility.Visible;
                Long_Target_Time.Visibility = Visibility.Visible;
            }
            else
            {
                AddTopicBTN.IsEnabled = true;
                AddTopicBTN.Visibility = Visibility.Visible;
                AddTargetTitle.Visibility = Visibility.Collapsed;
                Complete_Percent.Visibility = Visibility.Hidden;
                Long_Target_Title.Visibility = Visibility.Hidden;
                Long_Target_Time.Visibility = Visibility.Hidden;
                LongTargetPercentage.Visibility = Visibility.Hidden;
            }
        }

        private void AddTarget(object sender, RoutedEventArgs e)
        {
            AddTargetTitle.Visibility = Visibility.Visible;
            //topicGrid.IsEnabled = false;
        }

        private void EditTargetBox_Click(object sender, RoutedEventArgs e)
        {
            if(EditTargetBox.IsChecked.Value)
            {
                Tomorr_Target_1.IsEnabled = true;
                Tomorr_Target_2.IsEnabled = true;
                Tomorr_Target_3.IsEnabled = true;
                Tomorr_Target_4.IsEnabled = true;
                Tomorr_Target_5.IsEnabled = true;
            }
            else
            {
                Tomorr_Target_1.IsEnabled = false;
                Tomorr_Target_2.IsEnabled = false;
                Tomorr_Target_3.IsEnabled = false;
                Tomorr_Target_4.IsEnabled = false;
                Tomorr_Target_5.IsEnabled = false;

                List<string> names = new List<string>();
                List<string> tags = new List<string>();
                string tomorr_date = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");

                if (Tomorr_Target_1_Textbox.Text.Length > 0 && Tomorr_Target_1_Combobox.Text.Length > 0)
                {
                    names.Add(Tomorr_Target_1_Textbox.Text);
                    tags.Add(Tomorr_Target_1_Combobox.Text);
                }
                else if (Tomorr_Target_1_Textbox.Text.Length <= 0 || Tomorr_Target_1_Combobox.Text.Length <= 0)
                {
                    Tomorr_Target_1_Textbox.Text = "";
                    Tomorr_Target_1_Combobox.SelectedIndex = -1;
                }

                if (Tomorr_Target_2_Textbox.Text.Length > 0 && Tomorr_Target_2_Combobox.Text.Length > 0)
                {
                    names.Add(Tomorr_Target_2_Textbox.Text);
                    tags.Add(Tomorr_Target_2_Combobox.Text);
                }
                else if (Tomorr_Target_2_Textbox.Text.Length <= 0 || Tomorr_Target_2_Combobox.Text.Length <= 0)
                {
                    Tomorr_Target_2_Textbox.Text = "";
                    Tomorr_Target_2_Combobox.SelectedIndex = -1;
                }

                if (Tomorr_Target_3_Textbox.Text.Length > 0 && Tomorr_Target_3_Combobox.Text.Length > 0)
                {
                    names.Add(Tomorr_Target_3_Textbox.Text);
                    tags.Add(Tomorr_Target_3_Combobox.Text);
                }
                else if (Tomorr_Target_3_Textbox.Text.Length <= 0 || Tomorr_Target_3_Combobox.Text.Length <= 0)
                {
                    Tomorr_Target_3_Textbox.Text = "";
                    Tomorr_Target_3_Combobox.SelectedIndex = -1;
                }

                if (Tomorr_Target_4_Textbox.Text.Length > 0 && Tomorr_Target_4_Combobox.Text.Length > 0)
                {
                    names.Add(Tomorr_Target_4_Textbox.Text);
                    tags.Add(Tomorr_Target_4_Combobox.Text);
                }
                else if (Tomorr_Target_4_Textbox.Text.Length <= 0 || Tomorr_Target_4_Combobox.Text.Length <= 0)
                {
                    Tomorr_Target_4_Textbox.Text = "";
                    Tomorr_Target_4_Combobox.SelectedIndex = -1;
                }

                if (Tomorr_Target_5_Textbox.Text.Length > 0 && Tomorr_Target_5_Combobox.Text.Length > 0)
                {
                    names.Add(Tomorr_Target_5_Textbox.Text);
                    tags.Add(Tomorr_Target_5_Combobox.Text);
                }
                else if (Tomorr_Target_5_Textbox.Text.Length <= 0 || Tomorr_Target_5_Combobox.Text.Length <= 0)
                {
                    Tomorr_Target_5_Textbox.Text = "";
                    Tomorr_Target_5_Combobox.SelectedIndex = -1;
                }

                this.igoSettings.ShortTargetEdit(tomorr_date, names, tags);
                this.igoSettings.Save();

                load();
            }
        }

        private void Today_Target_radioBTN_Checked(object sender, RoutedEventArgs e)
        {
            bool wait = false;
            switch((sender as RadioButton).Name.ToString())
            {
                case "Today_Target_1_radioBTN":
                    this.igoSettings.setStatus(DateTime.Now.ToString("yyyy-MM-dd"), Today_Target_1_name.Text, Today_Target_1_tag.Text, "done");
                    if(Today_Target_1_tag.Text.Equals("長期"))
                    {
                        wait = true;
                    }
                    break;
                case "Today_Target_2_radioBTN":
                    this.igoSettings.setStatus(DateTime.Now.ToString("yyyy-MM-dd"), Today_Target_2_name.Text, Today_Target_2_tag.Text, "done");
                    if (Today_Target_2_tag.Text.Equals("長期"))
                    {
                        wait = true;
                    }
                    break;
                case "Today_Target_3_radioBTN":
                    this.igoSettings.setStatus(DateTime.Now.ToString("yyyy-MM-dd"), Today_Target_3_name.Text, Today_Target_3_tag.Text, "done");
                    if (Today_Target_3_tag.Text.Equals("長期"))
                    {
                        wait = true;
                    }
                    break;
                case "Today_Target_4_radioBTN":
                    this.igoSettings.setStatus(DateTime.Now.ToString("yyyy-MM-dd"), Today_Target_4_name.Text, Today_Target_4_tag.Text, "done");
                    if (Today_Target_4_tag.Text.Equals("長期"))
                    {
                        wait = true;
                    }
                    break;
                case "Today_Target_5_radioBTN":
                    this.igoSettings.setStatus(DateTime.Now.ToString("yyyy-MM-dd"), Today_Target_5_name.Text, Today_Target_5_tag.Text, "done");
                    if (Today_Target_5_tag.Text.Equals("長期"))
                    {
                        wait = true;
                    }
                    break;
            }

            if(!wait)
            {
                this.igoSettings.Save();
                load();
            }
            else
            {
                Timer();
            }
        }

        public void Timer()
        {
            todayStack.IsEnabled = false;
            this.timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(30);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            int longTargetAllTime = Convert.ToInt32(this.igoSettings.getLongTarget()[1]);
            int longTargetCompleteTime = Convert.ToInt32(this.igoSettings.getLongTarget()[2]);
            if(percentageBorder.Height >= ((longTargetCompleteTime+1) * 92 / longTargetAllTime))
            {
                this.timer.Stop();

                this.igoSettings.LongTargetAddDay();

                if (this.igoSettings.getLongTarget().Count > 0 && this.igoSettings.getLongTarget()[1].Equals(this.igoSettings.getLongTarget()[2]))
                {
                    this.igoSettings.ClearLongTarget();
                }
                this.igoSettings.Save();
                todayStack.IsEnabled = true;
                load();
            }
            else
            {
                percentageBorder.Height += 1;
            }
        }

        private void editLongTargetBTN_Click(object sender, RoutedEventArgs e)
        {
            if (AddTargetTitleBox.Text.Length != 0)
            {
                try
                {
                    if (Convert.ToInt32(AddTargetTimeBox.Text)>=2)
                    {
                        this.igoSettings.LongTargetAdd(AddTargetTitleBox.Text, AddTargetTimeBox.Text);
                        this.igoSettings.Save();
                        load();
                    }
                    else
                    {
                        MessageBox.Show("輸入資料不符合格式!計畫天數少於2天!");
                    }
                }
                catch(System.FormatException)
                {
                    MessageBox.Show("輸入資料不符合格式!計畫天數格式錯誤!");
                }
            }
            else
            {
                MessageBox.Show("輸入資料不符合格式!計畫名稱空白!");
            }
        }

        private void AddTargetTitleBox_GotFocus(object sender, RoutedEventArgs e)
        {
            AddTargetTitleBox.Text = "";
        }

        private void AddTargetTimeBox_GotFocus(object sender, RoutedEventArgs e)
        {
            AddTargetTimeBox.Text = "";
        }

        private void AddTargetTitleBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if(AddTargetTitleBox.Text.Length==0)
            {
                AddTargetTitleBox.Text = "輸入計畫名稱";
            }
        }

        private void AddTargetTimeBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if(AddTargetTitleBox.Text.Length==0)
            {
                AddTargetTimeBox.Text = "輸入計畫天數(2天以上)";
            }
        }
    }
}
