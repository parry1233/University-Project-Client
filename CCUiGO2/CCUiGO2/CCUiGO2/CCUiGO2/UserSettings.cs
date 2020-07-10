using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace CCUiGO2
{
    class UserSettings
    {
        private Dictionary<string, string> MainSet;
        public UserSettings()
        {
            this.MainSet = new Dictionary<string, string>();
        }
        public Dictionary<string, string> MainWindow_LoadXML()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("Settings.xml");//load string initFile into xml document
                XmlNodeList NodeLists = xmlDoc.SelectNodes("Settings/MainWindow");
                foreach (XmlNode Node in NodeLists)
                {
                    try
                    {
                        if(this.MainSet.ContainsKey("remeberID")&&this.MainSet["remeberID"].Equals(Node["remeberID"].InnerText))
                        {
                            //do nothing
                        }
                        else
                        {
                            this.MainSet.Add("remeberID", Node["remeberID"].InnerText);
                        }
                    }
                    catch (System.NullReferenceException)
                    {
                        this.MainSet.Add("remeberID", "");
                    }
                }

            }
            catch (FileNotFoundException)
            {
                string initFile = "<Settings><MainWindow><remeberID></remeberID></MainWindow></Settings>";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(initFile);//load string initFile into xml document
                xmlDoc.Save("Settings.xml");//save xml document
                                            //Application.Restart();
                MainWindow_LoadXML();
            }
            return this.MainSet;
        }

        public void MainWindow_SaveXML(Dictionary<string, string> save)
        {
            try
            {
                string s = "<Settings><MainWindow>";
                foreach (KeyValuePair<string, string> save_value in save)
                {
                    if (save_value.Key.Equals("remeberID"))
                    {
                        s += "<remeberID>" + save_value.Value + "</remeberID>";
                    }
                }
                s += "</MainWindow></Settings>";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(s);//load string initFile into xml document
                xmlDoc.Save("Settings.xml");//save xml document
            }
            catch (Exception e)
            {
                MessageBox.Show("ERR: Settings.xml save error");
                Application.Current.Shutdown();
            }
        }
    }

}
