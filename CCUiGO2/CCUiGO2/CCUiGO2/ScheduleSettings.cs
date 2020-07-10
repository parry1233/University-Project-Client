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
	class ScheduleSettings
	{
        private List<Dictionary<string, List<string[]>>> AllSets = new List<Dictionary<string, List<string[]>>>();
        private Dictionary<string, string> CounterDic = new Dictionary<string, string>();

        public ScheduleSettings()
        {
            this.AllSets = Schedule_LoadXML();
        }

        public List<Dictionary<string, List<string[]>>> Schedule_LoadXML()
        {
            this.AllSets.Clear();
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("Schedule.xml");//load string initFile into xml document
                XmlNodeList Tables = xmlDoc.SelectNodes("Schedule");

                foreach(XmlNode table in Tables)
                {
                    XmlNodeList EachTableNodeLists = xmlDoc.SelectNodes("Schedule/Table");
                    foreach (XmlNode Node in EachTableNodeLists)
                    {
                        try
                        {
                            Dictionary<string, List<string[]>> Set = new Dictionary<string, List<string[]>>();
                            foreach (XmlNode days_node in Node.ChildNodes)
                            {
                                foreach(XmlNode day_node in days_node.ChildNodes)
                                {
                                    string[] nodeNames = new string[5];
                                    nodeNames[0] = days_node.Name + "123AB";
                                    nodeNames[1] = days_node.Name + "456CD";
                                    nodeNames[2] = days_node.Name + "789EF";
                                    nodeNames[3] = days_node.Name + "012GH";
                                    nodeNames[4] = days_node.Name + "345IJ";
                                    if (day_node.Name.Equals(nodeNames[0]))
                                    {
                                        List<string[]> single_class_section = new List<string[]>();
                                        foreach (XmlNode class_node in day_node.ChildNodes)
                                        {
                                            string[] detail = new string[4];
                                            detail[0] = class_node.ChildNodes.Item(0).InnerText;
                                            detail[1] = class_node.ChildNodes.Item(1).InnerText;
                                            detail[2] = class_node.ChildNodes.Item(2).InnerText;
                                            detail[3] = class_node.ChildNodes.Item(3).InnerText;
                                            single_class_section.Add(detail);
                                        }
                                        Set.Add(nodeNames[0], single_class_section);
                                    }
                                    else if (day_node.Name.Equals(nodeNames[1]))
                                    {
                                        List<string[]> single_class_section = new List<string[]>();
                                        foreach (XmlNode class_node in day_node.ChildNodes)
                                        {
                                            string[] detail = new string[4];
                                            detail[0] = class_node.ChildNodes.Item(0).InnerText;
                                            detail[1] = class_node.ChildNodes.Item(1).InnerText;
                                            detail[2] = class_node.ChildNodes.Item(2).InnerText;
                                            detail[3] = class_node.ChildNodes.Item(3).InnerText;
                                            single_class_section.Add(detail);
                                        }
                                        Set.Add(nodeNames[1], single_class_section);
                                    }
                                    else if (day_node.Name.Equals(nodeNames[2]))
                                    {
                                        List<string[]> single_class_section = new List<string[]>();
                                        foreach (XmlNode class_node in day_node.ChildNodes)
                                        {
                                            string[] detail = new string[4];
                                            detail[0] = class_node.ChildNodes.Item(0).InnerText;
                                            detail[1] = class_node.ChildNodes.Item(1).InnerText;
                                            detail[2] = class_node.ChildNodes.Item(2).InnerText;
                                            detail[3] = class_node.ChildNodes.Item(3).InnerText;
                                            single_class_section.Add(detail);
                                        }
                                        Set.Add(nodeNames[2], single_class_section);
                                    }
                                    else if (day_node.Name.Equals(nodeNames[3]))
                                    {
                                        List<string[]> single_class_section = new List<string[]>();
                                        foreach (XmlNode class_node in day_node.ChildNodes)
                                        {
                                            string[] detail = new string[4];
                                            detail[0] = class_node.ChildNodes.Item(0).InnerText;
                                            detail[1] = class_node.ChildNodes.Item(1).InnerText;
                                            detail[2] = class_node.ChildNodes.Item(2).InnerText;
                                            detail[3] = class_node.ChildNodes.Item(3).InnerText;
                                            single_class_section.Add(detail);
                                        }
                                        Set.Add(nodeNames[3], single_class_section);
                                    }
                                    else if (day_node.Name.Equals(nodeNames[4]))
                                    {
                                        List<string[]> single_class_section = new List<string[]>();
                                        foreach (XmlNode class_node in day_node.ChildNodes)
                                        {
                                            string[] detail = new string[4];
                                            detail[0] = class_node.ChildNodes.Item(0).InnerText;
                                            detail[1] = class_node.ChildNodes.Item(1).InnerText;
                                            detail[2] = class_node.ChildNodes.Item(2).InnerText;
                                            detail[3] = class_node.ChildNodes.Item(3).InnerText;
                                            single_class_section.Add(detail);
                                        }
                                        Set.Add(nodeNames[4], single_class_section);
                                    }
                                }
                            }
                            this.AllSets.Add(Set);
                        }
                        catch (System.Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }

            }
            catch (FileNotFoundException)
            {
                string initFile = "<Schedule>" +
                    "<Table>" +
                    "<Mon><Mon123AB></Mon123AB><Mon456CD></Mon456CD><Mon789EF></Mon789EF><Mon012GH></Mon012GH><Mon345IJ></Mon345IJ></Mon>" +
                    "<Tue><Tue123AB></Tue123AB><Tue456CD></Tue456CD><Tue789EF></Tue789EF><Tue012GH></Tue012GH><Tue345IJ></Tue345IJ></Tue>" +
                    "<Wed><Wed123AB></Wed123AB><Wed456CD></Wed456CD><Wed789EF></Wed789EF><Wed012GH></Wed012GH><Wed345IJ></Wed345IJ></Wed>" +
                    "<Thu><Thu123AB></Thu123AB><Thu456CD></Thu456CD><Thu789EF></Thu789EF><Thu012GH></Thu012GH><Thu345IJ></Thu345IJ></Thu>" +
                    "<Fri><Fri123AB></Fri123AB><Fri456CD></Fri456CD><Fri789EF></Fri789EF><Fri012GH></Fri012GH><Fri345IJ></Fri345IJ></Fri>" +
                    "</Table>" +
                    "</Schedule>";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(initFile);//load string initFile into xml document
                xmlDoc.Save("Schedule.xml");//save xml document
                Schedule_LoadXML();
            }
            return this.AllSets;
        }

        public void Save()
        {
            try
            {
                string xmlString = "<Schedule>";
                foreach (Dictionary<string, List<string[]>> save_value in this.AllSets)
                {
                    xmlString += "<Table>";
                    foreach (KeyValuePair<string,List<string[]>> keyValuePair in save_value)
                    {
                        if(keyValuePair.Key.Equals("Mon123AB")|| keyValuePair.Key.Equals("Mon456CD") || keyValuePair.Key.Equals("Mon789EF")
                            || keyValuePair.Key.Equals("Mon012GH") || keyValuePair.Key.Equals("Mon345IJ"))
                        {
                            xmlString += "<Mon>";


                            if(keyValuePair.Key.Equals("Mon123AB"))
                            {
                                xmlString += "<Mon123AB>";
                                foreach(string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Mon123AB>";
                            }
                            else if(keyValuePair.Key.Equals("Mon456CD"))
                            {
                                xmlString += "<Mon456CD>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Mon456CD>";
                            }
                            else if (keyValuePair.Key.Equals("Mon789EF"))
                            {
                                xmlString += "<Mon789EF>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Mon789EF>";
                            }
                            else if (keyValuePair.Key.Equals("Mon012GH"))
                            {
                                xmlString += "<Mon012GH>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Mon012GH>";
                            }
                            else if (keyValuePair.Key.Equals("Mon345IJ"))
                            {
                                xmlString += "<Mon345IJ>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Mon345IJ>";
                            }


                            xmlString += "</Mon>";
                        }
                        else if (keyValuePair.Key.Equals("Tue123AB") || keyValuePair.Key.Equals("Tue456CD") || keyValuePair.Key.Equals("Tue789EF")
                            || keyValuePair.Key.Equals("Tue012GH") || keyValuePair.Key.Equals("Tue345IJ"))
                        {
                            xmlString += "<Tue>";


                            if (keyValuePair.Key.Equals("Tue123AB"))
                            {
                                xmlString += "<Tue123AB>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Tue123AB>";
                            }
                            else if (keyValuePair.Key.Equals("Tue456CD"))
                            {
                                xmlString += "<Tue456CD>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Tue456CD>";
                            }
                            else if (keyValuePair.Key.Equals("Tue789EF"))
                            {
                                xmlString += "<Tue789EF>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Tue789EF>";
                            }
                            else if (keyValuePair.Key.Equals("Tue012GH"))
                            {
                                xmlString += "<Tue012GH>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Tue012GH>";
                            }
                            else if (keyValuePair.Key.Equals("Tue345IJ"))
                            {
                                xmlString += "<Tue345IJ>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Tue345IJ>";
                            }


                            xmlString += "</Tue>";
                        }
                        else if (keyValuePair.Key.Equals("Wed123AB") || keyValuePair.Key.Equals("Wed456CD") || keyValuePair.Key.Equals("Wed789EF")
                            || keyValuePair.Key.Equals("Wed012GH") || keyValuePair.Key.Equals("Wed345IJ"))
                        {
                            xmlString += "<Wed>";


                            if (keyValuePair.Key.Equals("Wed123AB"))
                            {
                                xmlString += "<Wed123AB>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Wed123AB>";
                            }
                            else if (keyValuePair.Key.Equals("Wed456CD"))
                            {
                                xmlString += "<Wed456CD>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Wed456CD>";
                            }
                            else if (keyValuePair.Key.Equals("Wed789EF"))
                            {
                                xmlString += "<Wed789EF>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Wed789EF>";
                            }
                            else if (keyValuePair.Key.Equals("Wed012GH"))
                            {
                                xmlString += "<Wed012GH>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Wed012GH>";
                            }
                            else if (keyValuePair.Key.Equals("Wed345IJ"))
                            {
                                xmlString += "<Wed345IJ>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Wed345IJ>";
                            }


                            xmlString += "</Wed>";
                        }
                        else if (keyValuePair.Key.Equals("Thu123AB") || keyValuePair.Key.Equals("Thu456CD") || keyValuePair.Key.Equals("Thu789EF")
                            || keyValuePair.Key.Equals("Thu012GH") || keyValuePair.Key.Equals("Thu345IJ"))
                        {
                            xmlString += "<Thu>";


                            if (keyValuePair.Key.Equals("Thu123AB"))
                            {
                                xmlString += "<Thu123AB>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Thu123AB>";
                            }
                            else if (keyValuePair.Key.Equals("Thu456CD"))
                            {
                                xmlString += "<Thu456CD>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Thu456CD>";
                            }
                            else if (keyValuePair.Key.Equals("Thu789EF"))
                            {
                                xmlString += "<Thu789EF>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Thu789EF>";
                            }
                            else if (keyValuePair.Key.Equals("Thu012GH"))
                            {
                                xmlString += "<Thu012GH>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Thu012GH>";
                            }
                            else if (keyValuePair.Key.Equals("Thu345IJ"))
                            {
                                xmlString += "<Thu345IJ>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Thu345IJ>";
                            }


                            xmlString += "</Thu>";
                        }
                        else if (keyValuePair.Key.Equals("Fri123AB") || keyValuePair.Key.Equals("Fri456CD") || keyValuePair.Key.Equals("Fri789EF")
                            || keyValuePair.Key.Equals("Fri012GH") || keyValuePair.Key.Equals("Fri345IJ"))
                        {
                            xmlString += "<Fri>";


                            if (keyValuePair.Key.Equals("Fri123AB"))
                            {
                                xmlString += "<Fri123AB>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Fri123AB>";
                            }
                            else if (keyValuePair.Key.Equals("Fri456CD"))
                            {
                                xmlString += "<Fri456CD>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Fri456CD>";
                            }
                            else if (keyValuePair.Key.Equals("Fri789EF"))
                            {
                                xmlString += "<Fri789EF>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Fri789EF>";
                            }
                            else if (keyValuePair.Key.Equals("Fri012GH"))
                            {
                                xmlString += "<Fri012GH>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Fri012GH>";
                            }
                            else if (keyValuePair.Key.Equals("Fri345IJ"))
                            {
                                xmlString += "<Fri345IJ>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Fri345IJ>";
                            }


                            xmlString += "</Fri>";
                        }
                    }
                    xmlString += "</Table>";
                }
                xmlString += "</Schedule>";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xmlString);//load string initFile into xml document
                xmlDoc.Save("Schedule.xml");//save xml document
            }
            catch (Exception e)
            {
                MessageBox.Show("[ERR] Schedule.xml save error:\r\n" + e.Message);
                Application.Current.Shutdown();
            }
        }

        public void SaveAdd()
        {
            try
            {
                string xmlString = "<Schedule>";
                foreach (Dictionary<string, List<string[]>> save_value in this.AllSets)
                {
                    xmlString += "<Table>";
                    foreach (KeyValuePair<string, List<string[]>> keyValuePair in save_value)
                    {
                        if (keyValuePair.Key.Equals("Mon123AB") || keyValuePair.Key.Equals("Mon456CD") || keyValuePair.Key.Equals("Mon789EF")
                            || keyValuePair.Key.Equals("Mon012GH") || keyValuePair.Key.Equals("Mon345IJ"))
                        {
                            xmlString += "<Mon>";


                            if (keyValuePair.Key.Equals("Mon123AB"))
                            {
                                xmlString += "<Mon123AB>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Mon123AB>";
                            }
                            else if (keyValuePair.Key.Equals("Mon456CD"))
                            {
                                xmlString += "<Mon456CD>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Mon456CD>";
                            }
                            else if (keyValuePair.Key.Equals("Mon789EF"))
                            {
                                xmlString += "<Mon789EF>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Mon789EF>";
                            }
                            else if (keyValuePair.Key.Equals("Mon012GH"))
                            {
                                xmlString += "<Mon012GH>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Mon012GH>";
                            }
                            else if (keyValuePair.Key.Equals("Mon345IJ"))
                            {
                                xmlString += "<Mon345IJ>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Mon345IJ>";
                            }


                            xmlString += "</Mon>";
                        }
                        else if (keyValuePair.Key.Equals("Tue123AB") || keyValuePair.Key.Equals("Tue456CD") || keyValuePair.Key.Equals("Tue789EF")
                            || keyValuePair.Key.Equals("Tue012GH") || keyValuePair.Key.Equals("Tue345IJ"))
                        {
                            xmlString += "<Tue>";


                            if (keyValuePair.Key.Equals("Tue123AB"))
                            {
                                xmlString += "<Tue123AB>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Tue123AB>";
                            }
                            else if (keyValuePair.Key.Equals("Tue456CD"))
                            {
                                xmlString += "<Tue456CD>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Tue456CD>";
                            }
                            else if (keyValuePair.Key.Equals("Tue789EF"))
                            {
                                xmlString += "<Tue789EF>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Tue789EF>";
                            }
                            else if (keyValuePair.Key.Equals("Tue012GH"))
                            {
                                xmlString += "<Tue012GH>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Tue012GH>";
                            }
                            else if (keyValuePair.Key.Equals("Tue345IJ"))
                            {
                                xmlString += "<Tue345IJ>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Tue345IJ>";
                            }


                            xmlString += "</Tue>";
                        }
                        else if (keyValuePair.Key.Equals("Wed123AB") || keyValuePair.Key.Equals("Wed456CD") || keyValuePair.Key.Equals("Wed789EF")
                            || keyValuePair.Key.Equals("Wed012GH") || keyValuePair.Key.Equals("Wed345IJ"))
                        {
                            xmlString += "<Wed>";


                            if (keyValuePair.Key.Equals("Wed123AB"))
                            {
                                xmlString += "<Wed123AB>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Wed123AB>";
                            }
                            else if (keyValuePair.Key.Equals("Wed456CD"))
                            {
                                xmlString += "<Wed456CD>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Wed456CD>";
                            }
                            else if (keyValuePair.Key.Equals("Wed789EF"))
                            {
                                xmlString += "<Wed789EF>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Wed789EF>";
                            }
                            else if (keyValuePair.Key.Equals("Wed012GH"))
                            {
                                xmlString += "<Wed012GH>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Wed012GH>";
                            }
                            else if (keyValuePair.Key.Equals("Wed345IJ"))
                            {
                                xmlString += "<Wed345IJ>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Wed345IJ>";
                            }


                            xmlString += "</Wed>";
                        }
                        else if (keyValuePair.Key.Equals("Thu123AB") || keyValuePair.Key.Equals("Thu456CD") || keyValuePair.Key.Equals("Thu789EF")
                            || keyValuePair.Key.Equals("Thu012GH") || keyValuePair.Key.Equals("Thu345IJ"))
                        {
                            xmlString += "<Thu>";


                            if (keyValuePair.Key.Equals("Thu123AB"))
                            {
                                xmlString += "<Thu123AB>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Thu123AB>";
                            }
                            else if (keyValuePair.Key.Equals("Thu456CD"))
                            {
                                xmlString += "<Thu456CD>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Thu456CD>";
                            }
                            else if (keyValuePair.Key.Equals("Thu789EF"))
                            {
                                xmlString += "<Thu789EF>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Thu789EF>";
                            }
                            else if (keyValuePair.Key.Equals("Thu012GH"))
                            {
                                xmlString += "<Thu012GH>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Thu012GH>";
                            }
                            else if (keyValuePair.Key.Equals("Thu345IJ"))
                            {
                                xmlString += "<Thu345IJ>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Thu345IJ>";
                            }


                            xmlString += "</Thu>";
                        }
                        else if (keyValuePair.Key.Equals("Fri123AB") || keyValuePair.Key.Equals("Fri456CD") || keyValuePair.Key.Equals("Fri789EF")
                            || keyValuePair.Key.Equals("Fri012GH") || keyValuePair.Key.Equals("Fri345IJ"))
                        {
                            xmlString += "<Fri>";


                            if (keyValuePair.Key.Equals("Fri123AB"))
                            {
                                xmlString += "<Fri123AB>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Fri123AB>";
                            }
                            else if (keyValuePair.Key.Equals("Fri456CD"))
                            {
                                xmlString += "<Fri456CD>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Fri456CD>";
                            }
                            else if (keyValuePair.Key.Equals("Fri789EF"))
                            {
                                xmlString += "<Fri789EF>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Fri789EF>";
                            }
                            else if (keyValuePair.Key.Equals("Fri012GH"))
                            {
                                xmlString += "<Fri012GH>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Fri012GH>";
                            }
                            else if (keyValuePair.Key.Equals("Fri345IJ"))
                            {
                                xmlString += "<Fri345IJ>";
                                foreach (string[] eachClass in keyValuePair.Value)
                                {
                                    xmlString += "<Class>";
                                    xmlString += "<Name>" + eachClass[0] + "</Name>";
                                    xmlString += "<Department>" + eachClass[1] + "</Department>";
                                    xmlString += "<Teacher>" + eachClass[2] + "</Teacher>";
                                    xmlString += "<Time>" + eachClass[3] + "</Time>";
                                    xmlString += "</Class>";
                                }
                                xmlString += "</Fri345IJ>";
                            }


                            xmlString += "</Fri>";
                        }
                    }
                    xmlString += "</Table>";
                }
                xmlString += 
                    "<Table>" +
                    "<Mon><Mon123AB></Mon123AB><Mon456CD></Mon456CD><Mon789EF></Mon789EF><Mon012GH></Mon012GH><Mon345IJ></Mon345IJ></Mon>" +
                    "<Tue><Tue123AB></Tue123AB><Tue456CD></Tue456CD><Tue789EF></Tue789EF><Tue012GH></Tue012GH><Tue345IJ></Tue345IJ></Tue>" +
                    "<Wed><Wed123AB></Wed123AB><Wed456CD></Wed456CD><Wed789EF></Wed789EF><Wed012GH></Wed012GH><Wed345IJ></Wed345IJ></Wed>" +
                    "<Thu><Thu123AB></Thu123AB><Thu456CD></Thu456CD><Thu789EF></Thu789EF><Thu012GH></Thu012GH><Thu345IJ></Thu345IJ></Thu>" +
                    "<Fri><Fri123AB></Fri123AB><Fri456CD></Fri456CD><Fri789EF></Fri789EF><Fri012GH></Fri012GH><Fri345IJ></Fri345IJ></Fri>" +
                    "</Table>" + 
                    "</Schedule>";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xmlString);//load string initFile into xml document
                xmlDoc.Save("Schedule.xml");//save xml document
            }
            catch (Exception e)
            {
                MessageBox.Show("[ERR] Schedule.xml save error:\r\n" + e.Message);
                Application.Current.Shutdown();
            }
        }

        public void Delete(string[] s,int i)
        {
            Dictionary<string, List<string[]>> editDic = new Dictionary<string, List<string[]>> (AllSets[i]);
            foreach(KeyValuePair<string,List<string[]>> keyValuePair in AllSets[i])
            {
                List<string[]> overWriteList = new List<string[]> (keyValuePair.Value);
                foreach(string[] eachClass in keyValuePair.Value)
                {
                    if(eachClass[0].Equals(s[0])&& eachClass[1].Equals(s[1]) && eachClass[2].Equals(s[2]))
                    {
                        overWriteList.Remove(eachClass);
                    }
                }
                editDic[keyValuePair.Key] = overWriteList;
            }

            this.AllSets[i] = editDic;
            Save();
        }

        public void Add(string[] s,int i)//[name],[teacher].[depart],[time]
        {
            if(Check(s[3],i))
            {
                List<string> time_List = new List<string>();
                List<string> day_List = new List<string>();

                string[] allTime = s[3].Split(' ');
                foreach(string time in allTime)
                {
                    day_List.Add(time.Substring(0, 1));
                    string[] time_section = time.Substring(1).Split(',');

                    foreach(string split in time_section)
                    {
                        time_List.Add(time.Substring(0, 1) + split);
                    }
                }

                foreach(string timeSplit in time_List)
                {
                    if(timeSplit.Substring(0,1).Equals("一"))
                    {
                        if(timeSplit.Substring(1).Equals("1")|| timeSplit.Substring(1).Equals("2")|| timeSplit.Substring(1).Equals("3")
                            || timeSplit.Substring(1).Equals("A") || timeSplit.Substring(1).Equals("B"))
                        {
                            this.AllSets[i]["Mon123AB"].Add(s); 
                        }
                        else if(timeSplit.Substring(1).Equals("4") || timeSplit.Substring(1).Equals("5") || timeSplit.Substring(1).Equals("6")
                            || timeSplit.Substring(1).Equals("C") || timeSplit.Substring(1).Equals("D"))
                        {
                            this.AllSets[i]["Mon456CD"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("7") || timeSplit.Substring(1).Equals("8") || timeSplit.Substring(1).Equals("9")
                            || timeSplit.Substring(1).Equals("E") || timeSplit.Substring(1).Equals("F"))
                        {
                            this.AllSets[i]["Mon789EF"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("10") || timeSplit.Substring(1).Equals("11") || timeSplit.Substring(1).Equals("12")
                            || timeSplit.Substring(1).Equals("G") || timeSplit.Substring(1).Equals("H"))
                        {
                            this.AllSets[i]["Mon012GH"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("13") || timeSplit.Substring(1).Equals("14") || timeSplit.Substring(1).Equals("15")
                            || timeSplit.Substring(1).Equals("I") || timeSplit.Substring(1).Equals("J"))
                        {
                            this.AllSets[i]["Mon345IJ"].Add(s);
                        }
                    }
                    else if(timeSplit.Substring(0, 1).Equals("二"))
                    {
                        if (timeSplit.Substring(1).Equals("1") || timeSplit.Substring(1).Equals("2") || timeSplit.Substring(1).Equals("3")
                            || timeSplit.Substring(1).Equals("A") || timeSplit.Substring(1).Equals("B"))
                        {
                            this.AllSets[i]["Tue123AB"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("4") || timeSplit.Substring(1).Equals("5") || timeSplit.Substring(1).Equals("6")
                            || timeSplit.Substring(1).Equals("C") || timeSplit.Substring(1).Equals("D"))
                        {
                            this.AllSets[i]["Tue456CD"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("7") || timeSplit.Substring(1).Equals("8") || timeSplit.Substring(1).Equals("9")
                            || timeSplit.Substring(1).Equals("E") || timeSplit.Substring(1).Equals("F"))
                        {
                            this.AllSets[i]["Tue789EF"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("10") || timeSplit.Substring(1).Equals("11") || timeSplit.Substring(1).Equals("12")
                            || timeSplit.Substring(1).Equals("G") || timeSplit.Substring(1).Equals("H"))
                        {
                            this.AllSets[i]["Tue012GH"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("13") || timeSplit.Substring(1).Equals("14") || timeSplit.Substring(1).Equals("15")
                            || timeSplit.Substring(1).Equals("I") || timeSplit.Substring(1).Equals("J"))
                        {
                            this.AllSets[i]["Tue345IJ"].Add(s);
                        }
                    }
                    else if (timeSplit.Substring(0, 1).Equals("三"))
                    {
                        if (timeSplit.Substring(1).Equals("1") || timeSplit.Substring(1).Equals("2") || timeSplit.Substring(1).Equals("3")
                            || timeSplit.Substring(1).Equals("A") || timeSplit.Substring(1).Equals("B"))
                        {
                            this.AllSets[i]["Wed123AB"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("4") || timeSplit.Substring(1).Equals("5") || timeSplit.Substring(1).Equals("6")
                            || timeSplit.Substring(1).Equals("C") || timeSplit.Substring(1).Equals("D"))
                        {
                            this.AllSets[i]["Wed456CD"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("7") || timeSplit.Substring(1).Equals("8") || timeSplit.Substring(1).Equals("9")
                            || timeSplit.Substring(1).Equals("E") || timeSplit.Substring(1).Equals("F"))
                        {
                            this.AllSets[i]["Wed789EF"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("10") || timeSplit.Substring(1).Equals("11") || timeSplit.Substring(1).Equals("12")
                            || timeSplit.Substring(1).Equals("G") || timeSplit.Substring(1).Equals("H"))
                        {
                            this.AllSets[i]["Wed012GH"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("13") || timeSplit.Substring(1).Equals("14") || timeSplit.Substring(1).Equals("15")
                            || timeSplit.Substring(1).Equals("I") || timeSplit.Substring(1).Equals("J"))
                        {
                            this.AllSets[i]["Wed345IJ"].Add(s);
                        }
                    }
                    else if (timeSplit.Substring(0, 1).Equals("四"))
                    {
                        if (timeSplit.Substring(1).Equals("1") || timeSplit.Substring(1).Equals("2") || timeSplit.Substring(1).Equals("3")
                            || timeSplit.Substring(1).Equals("A") || timeSplit.Substring(1).Equals("B"))
                        {
                            this.AllSets[i]["Thu123AB"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("4") || timeSplit.Substring(1).Equals("5") || timeSplit.Substring(1).Equals("6")
                            || timeSplit.Substring(1).Equals("C") || timeSplit.Substring(1).Equals("D"))
                        {
                            this.AllSets[i]["Thu456CD"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("7") || timeSplit.Substring(1).Equals("8") || timeSplit.Substring(1).Equals("9")
                            || timeSplit.Substring(1).Equals("E") || timeSplit.Substring(1).Equals("F"))
                        {
                            this.AllSets[i]["Thu789EF"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("10") || timeSplit.Substring(1).Equals("11") || timeSplit.Substring(1).Equals("12")
                            || timeSplit.Substring(1).Equals("G") || timeSplit.Substring(1).Equals("H"))
                        {
                            this.AllSets[i]["Thu012GH"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("13") || timeSplit.Substring(1).Equals("14") || timeSplit.Substring(1).Equals("15")
                            || timeSplit.Substring(1).Equals("I") || timeSplit.Substring(1).Equals("J"))
                        {
                            this.AllSets[i]["Thu345IJ"].Add(s);
                        }
                    }
                    else if (timeSplit.Substring(0, 1).Equals("五"))
                    {
                        if (timeSplit.Substring(1).Equals("1") || timeSplit.Substring(1).Equals("2") || timeSplit.Substring(1).Equals("3")
                            || timeSplit.Substring(1).Equals("A") || timeSplit.Substring(1).Equals("B"))
                        {
                            this.AllSets[i]["Fri123AB"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("4") || timeSplit.Substring(1).Equals("5") || timeSplit.Substring(1).Equals("6")
                            || timeSplit.Substring(1).Equals("C") || timeSplit.Substring(1).Equals("D"))
                        {
                            this.AllSets[i]["Fri456CD"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("7") || timeSplit.Substring(1).Equals("8") || timeSplit.Substring(1).Equals("9")
                            || timeSplit.Substring(1).Equals("E") || timeSplit.Substring(1).Equals("F"))
                        {
                            this.AllSets[i]["Fri789EF"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("10") || timeSplit.Substring(1).Equals("11") || timeSplit.Substring(1).Equals("12")
                            || timeSplit.Substring(1).Equals("G") || timeSplit.Substring(1).Equals("H"))
                        {
                            this.AllSets[i]["Fri012GH"].Add(s);
                        }
                        else if (timeSplit.Substring(1).Equals("13") || timeSplit.Substring(1).Equals("14") || timeSplit.Substring(1).Equals("15")
                            || timeSplit.Substring(1).Equals("I") || timeSplit.Substring(1).Equals("J"))
                        {
                            this.AllSets[i]["Fri345IJ"].Add(s);
                        }
                    }
                }

                Save();
            }
            else
            {
                MessageBox.Show("無法添加，此時段已有選課!");
            }
        }

        public void AddTable()
        {
            SaveAdd();
        }

        public void ClearTable(int i)
        {
            AllSets.Remove(AllSets[i]);
            Save();
        }

        public bool Check(string s,int table_index)
        {
            string[] interval = s.Split(' ');
            bool check = true;
            foreach (string s_split in interval)
            {
                string day = s_split.Substring(0, 1);
                string[] time = s_split.Substring(1).Split(',');

                if (day.Equals("一"))
                {
                    //Pick the specific table out and store to a temp dictionary
                    Dictionary<string, List<string[]>> tmp_dic = new Dictionary<string, List<string[]>>();
                    tmp_dic = AllSets[table_index];
                    
                    //five temp storage for classes in different time interval
                    List<string[]> tmp_Classes_Mon123AB = tmp_dic["Mon123AB"];
                    List<string[]> tmp_Classes_Mon456CD = tmp_dic["Mon456CD"];
                    List<string[]> tmp_Classes_Mon789EF = tmp_dic["Mon789EF"];
                    List<string[]> tmp_Classes_Mon012GH = tmp_dic["Mon012GH"];
                    List<string[]> tmp_Classes_Mon345IJ = tmp_dic["Mon345IJ"];

                    //set a list for storing time
                    List<string> tmp_TimeList = new List<string>();
                    foreach(string[] sArray in tmp_Classes_Mon123AB)
                    {
                        if(sArray.Length==4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach(string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach(string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday+sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Mon456CD)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Mon789EF)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Mon012GH)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Mon345IJ)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }

                    //check if there exists any counter time
                    foreach(string time_check in time)
                    {
                        if(time_check.Equals("1") && !tmp_TimeList.Contains("一1") && !tmp_TimeList.Contains("一A"))
                        {/*do nothing*/}
                        else if(time_check.Equals("2") && !tmp_TimeList.Contains("一2") && !tmp_TimeList.Contains("一A") &&!tmp_TimeList.Contains("一B"))
                        {/*do nothing*/}
                        else if (time_check.Equals("3") && !tmp_TimeList.Contains("一3") && !tmp_TimeList.Contains("一B"))
                        {/*do nothing*/}
                        else if (time_check.Equals("4") && !tmp_TimeList.Contains("一4") && !tmp_TimeList.Contains("一C"))
                        {/*do nothing*/}
                        else if (time_check.Equals("5") && !tmp_TimeList.Contains("一5") && !tmp_TimeList.Contains("一C") && !tmp_TimeList.Contains("一D"))
                        {/*do nothing*/}
                        else if (time_check.Equals("6") && !tmp_TimeList.Contains("一6") && !tmp_TimeList.Contains("一D"))
                        {/*do nothing*/}
                        else if (time_check.Equals("7") && !tmp_TimeList.Contains("一7") && !tmp_TimeList.Contains("一E"))
                        {/*do nothing*/}
                        else if (time_check.Equals("8") && !tmp_TimeList.Contains("一8") && !tmp_TimeList.Contains("一E") && !tmp_TimeList.Contains("一F"))
                        {/*do nothing*/}
                        else if (time_check.Equals("9") && !tmp_TimeList.Contains("一9") && !tmp_TimeList.Contains("一F"))
                        {/*do nothing*/}
                        else if (time_check.Equals("10") && !tmp_TimeList.Contains("一10") && !tmp_TimeList.Contains("一G"))
                        {/*do nothing*/}
                        else if (time_check.Equals("11") && !tmp_TimeList.Contains("一11") && !tmp_TimeList.Contains("一G") && !tmp_TimeList.Contains("一H"))
                        {/*do nothing*/}
                        else if (time_check.Equals("12") && !tmp_TimeList.Contains("一12") && !tmp_TimeList.Contains("一H"))
                        {/*do nothing*/}
                        else if (time_check.Equals("13") && !tmp_TimeList.Contains("一13") && !tmp_TimeList.Contains("一I"))
                        {/*do nothing*/}
                        else if (time_check.Equals("14") && !tmp_TimeList.Contains("一14") && !tmp_TimeList.Contains("一I") && !tmp_TimeList.Contains("一J"))
                        {/*do nothing*/}
                        else if (time_check.Equals("15") && !tmp_TimeList.Contains("一15") && !tmp_TimeList.Contains("一J"))
                        {/*do nothing*/}
                        else if (time_check.Equals("A") && !tmp_TimeList.Contains("一A") && !tmp_TimeList.Contains("一1") && !tmp_TimeList.Contains("一2"))
                        {/*do nothing*/}
                        else if (time_check.Equals("B") && !tmp_TimeList.Contains("一B") && !tmp_TimeList.Contains("一2") && !tmp_TimeList.Contains("一3"))
                        {/*do nothing*/}
                        else if (time_check.Equals("C") && !tmp_TimeList.Contains("一C") && !tmp_TimeList.Contains("一4") && !tmp_TimeList.Contains("一5"))
                        {/*do nothing*/}
                        else if (time_check.Equals("D") && !tmp_TimeList.Contains("一D") && !tmp_TimeList.Contains("一5") && !tmp_TimeList.Contains("一6"))
                        {/*do nothing*/}
                        else if (time_check.Equals("E") && !tmp_TimeList.Contains("一E") && !tmp_TimeList.Contains("一7") && !tmp_TimeList.Contains("一8"))
                        {/*do nothing*/}
                        else if (time_check.Equals("F") && !tmp_TimeList.Contains("一F") && !tmp_TimeList.Contains("一8") && !tmp_TimeList.Contains("一9"))
                        {/*do nothing*/}
                        else if (time_check.Equals("G") && !tmp_TimeList.Contains("一G") && !tmp_TimeList.Contains("一10") && !tmp_TimeList.Contains("一11"))
                        {/*do nothing*/}
                        else if (time_check.Equals("H") && !tmp_TimeList.Contains("一H") && !tmp_TimeList.Contains("一11") && !tmp_TimeList.Contains("一12"))
                        {/*do nothing*/}
                        else if (time_check.Equals("I") && !tmp_TimeList.Contains("一I") && !tmp_TimeList.Contains("一13") && !tmp_TimeList.Contains("一14"))
                        {/*do nothing*/}
                        else if (time_check.Equals("J") && !tmp_TimeList.Contains("一J") && !tmp_TimeList.Contains("一14") && !tmp_TimeList.Contains("一15"))
                        {/*do nothing*/}
                        else
                        {
                            check = false;
                            break;
                        }
                    }

                    return check;
                }
                else if(day.Equals("二"))
                {
                    //Pick the specific table out and store to a temp dictionary
                    Dictionary<string, List<string[]>> tmp_dic = new Dictionary<string, List<string[]>>();
                    tmp_dic = AllSets[table_index];

                    //five temp storage for classes in different time interval
                    List<string[]> tmp_Classes_Tue123AB = tmp_dic["Tue123AB"];
                    List<string[]> tmp_Classes_Tue456CD = tmp_dic["Tue456CD"];
                    List<string[]> tmp_Classes_Tue789EF = tmp_dic["Tue789EF"];
                    List<string[]> tmp_Classes_Tue012GH = tmp_dic["Tue012GH"];
                    List<string[]> tmp_Classes_Tue345IJ = tmp_dic["Tue345IJ"];

                    //set a list for storing time
                    List<string> tmp_TimeList = new List<string>();
                    foreach (string[] sArray in tmp_Classes_Tue123AB)
                    {
                        string[] Splitbyday = sArray[3].Split(' ');
                        foreach (string split in Splitbyday)
                        {
                            string byday = split.Substring(0, 1);
                            string[] bytime = split.Substring(1).Split(',');
                            foreach (string sIn in bytime)
                            {
                                tmp_TimeList.Add(byday + sIn);
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Tue456CD)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Tue789EF)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Tue012GH)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Tue345IJ)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }

                    //check if there exists any counter time
                    foreach (string time_check in time)
                    {
                        if (time_check.Equals("1") && !tmp_TimeList.Contains("二1") && !tmp_TimeList.Contains("二A"))
                        {/*do nothing*/}
                        else if (time_check.Equals("2") && !tmp_TimeList.Contains("二2") && !tmp_TimeList.Contains("二A") && !tmp_TimeList.Contains("二B"))
                        {/*do nothing*/}
                        else if (time_check.Equals("3") && !tmp_TimeList.Contains("二3") && !tmp_TimeList.Contains("二B"))
                        {/*do nothing*/}
                        else if (time_check.Equals("4") && !tmp_TimeList.Contains("二4") && !tmp_TimeList.Contains("二C"))
                        {/*do nothing*/}
                        else if (time_check.Equals("5") && !tmp_TimeList.Contains("二5") && !tmp_TimeList.Contains("二C") && !tmp_TimeList.Contains("二D"))
                        {/*do nothing*/}
                        else if (time_check.Equals("6") && !tmp_TimeList.Contains("二6") && !tmp_TimeList.Contains("二D"))
                        {/*do nothing*/}
                        else if (time_check.Equals("7") && !tmp_TimeList.Contains("二7") && !tmp_TimeList.Contains("二E"))
                        {/*do nothing*/}
                        else if (time_check.Equals("8") && !tmp_TimeList.Contains("二8") && !tmp_TimeList.Contains("二E") && !tmp_TimeList.Contains("二F"))
                        {/*do nothing*/}
                        else if (time_check.Equals("9") && !tmp_TimeList.Contains("二9") && !tmp_TimeList.Contains("二F"))
                        {/*do nothing*/}
                        else if (time_check.Equals("10") && !tmp_TimeList.Contains("二10") && !tmp_TimeList.Contains("二G"))
                        {/*do nothing*/}
                        else if (time_check.Equals("11") && !tmp_TimeList.Contains("二11") && !tmp_TimeList.Contains("二G") && !tmp_TimeList.Contains("二H"))
                        {/*do nothing*/}
                        else if (time_check.Equals("12") && !tmp_TimeList.Contains("二12") && !tmp_TimeList.Contains("二H"))
                        {/*do nothing*/}
                        else if (time_check.Equals("13") && !tmp_TimeList.Contains("二13") && !tmp_TimeList.Contains("二I"))
                        {/*do nothing*/}
                        else if (time_check.Equals("14") && !tmp_TimeList.Contains("二14") && !tmp_TimeList.Contains("二I") && !tmp_TimeList.Contains("二J"))
                        {/*do nothing*/}
                        else if (time_check.Equals("15") && !tmp_TimeList.Contains("二15") && !tmp_TimeList.Contains("二J"))
                        {/*do nothing*/}
                        else if (time_check.Equals("A") && !tmp_TimeList.Contains("二A") && !tmp_TimeList.Contains("二1") && !tmp_TimeList.Contains("二2"))
                        {/*do nothing*/}
                        else if (time_check.Equals("B") && !tmp_TimeList.Contains("二B") && !tmp_TimeList.Contains("二2") && !tmp_TimeList.Contains("二3"))
                        {/*do nothing*/}
                        else if (time_check.Equals("C") && !tmp_TimeList.Contains("二C") && !tmp_TimeList.Contains("二4") && !tmp_TimeList.Contains("二5"))
                        {/*do nothing*/}
                        else if (time_check.Equals("D") && !tmp_TimeList.Contains("二D") && !tmp_TimeList.Contains("二5") && !tmp_TimeList.Contains("二6"))
                        {/*do nothing*/}
                        else if (time_check.Equals("E") && !tmp_TimeList.Contains("二E") && !tmp_TimeList.Contains("二7") && !tmp_TimeList.Contains("二8"))
                        {/*do nothing*/}
                        else if (time_check.Equals("F") && !tmp_TimeList.Contains("二F") && !tmp_TimeList.Contains("二8") && !tmp_TimeList.Contains("二9"))
                        {/*do nothing*/}
                        else if (time_check.Equals("G") && !tmp_TimeList.Contains("二G") && !tmp_TimeList.Contains("二10") && !tmp_TimeList.Contains("二11"))
                        {/*do nothing*/}
                        else if (time_check.Equals("H") && !tmp_TimeList.Contains("二H") && !tmp_TimeList.Contains("二11") && !tmp_TimeList.Contains("二12"))
                        {/*do nothing*/}
                        else if (time_check.Equals("I") && !tmp_TimeList.Contains("二I") && !tmp_TimeList.Contains("二13") && !tmp_TimeList.Contains("二14"))
                        {/*do nothing*/}
                        else if (time_check.Equals("J") && !tmp_TimeList.Contains("二J") && !tmp_TimeList.Contains("二14") && !tmp_TimeList.Contains("二15"))
                        {/*do nothing*/}
                        else
                        {
                            check = false;
                            break;
                        }
                    }

                    return check;
                }
                else if (day.Equals("三"))
                {
                    //Pick the specific table out and store to a temp dictionary
                    Dictionary<string, List<string[]>> tmp_dic = new Dictionary<string, List<string[]>>();
                    tmp_dic = AllSets[table_index];

                    //five temp storage for classes in different time interval
                    List<string[]> tmp_Classes_Wed123AB = tmp_dic["Wed123AB"];
                    List<string[]> tmp_Classes_Wed456CD = tmp_dic["Wed456CD"];
                    List<string[]> tmp_Classes_Wed789EF = tmp_dic["Wed789EF"];
                    List<string[]> tmp_Classes_Wed012GH = tmp_dic["Wed012GH"];
                    List<string[]> tmp_Classes_Wed345IJ = tmp_dic["Wed345IJ"];

                    //set a list for storing time
                    List<string> tmp_TimeList = new List<string>();
                    foreach (string[] sArray in tmp_Classes_Wed123AB)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Wed456CD)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Wed789EF)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Wed012GH)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Wed345IJ)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }

                    //check if there exists any counter time
                    foreach (string time_check in time)
                    {
                        if (time_check.Equals("1") && !tmp_TimeList.Contains("三1") && !tmp_TimeList.Contains("三A"))
                        {/*do nothing*/}
                        else if (time_check.Equals("2") && !tmp_TimeList.Contains("三2") && !tmp_TimeList.Contains("三A") && !tmp_TimeList.Contains("三B"))
                        {/*do nothing*/}
                        else if (time_check.Equals("3") && !tmp_TimeList.Contains("三3") && !tmp_TimeList.Contains("三B"))
                        {/*do nothing*/}
                        else if (time_check.Equals("4") && !tmp_TimeList.Contains("三4") && !tmp_TimeList.Contains("三C"))
                        {/*do nothing*/}
                        else if (time_check.Equals("5") && !tmp_TimeList.Contains("三5") && !tmp_TimeList.Contains("三C") && !tmp_TimeList.Contains("三D"))
                        {/*do nothing*/}
                        else if (time_check.Equals("6") && !tmp_TimeList.Contains("三6") && !tmp_TimeList.Contains("三D"))
                        {/*do nothing*/}
                        else if (time_check.Equals("7") && !tmp_TimeList.Contains("三7") && !tmp_TimeList.Contains("三E"))
                        {/*do nothing*/}
                        else if (time_check.Equals("8") && !tmp_TimeList.Contains("三8") && !tmp_TimeList.Contains("三E") && !tmp_TimeList.Contains("三F"))
                        {/*do nothing*/}
                        else if (time_check.Equals("9") && !tmp_TimeList.Contains("三9") && !tmp_TimeList.Contains("三F"))
                        {/*do nothing*/}
                        else if (time_check.Equals("10") && !tmp_TimeList.Contains("三10") && !tmp_TimeList.Contains("三G"))
                        {/*do nothing*/}
                        else if (time_check.Equals("11") && !tmp_TimeList.Contains("三11") && !tmp_TimeList.Contains("三G") && !tmp_TimeList.Contains("三H"))
                        {/*do nothing*/}
                        else if (time_check.Equals("12") && !tmp_TimeList.Contains("三12") && !tmp_TimeList.Contains("三H"))
                        {/*do nothing*/}
                        else if (time_check.Equals("13") && !tmp_TimeList.Contains("三13") && !tmp_TimeList.Contains("三I"))
                        {/*do nothing*/}
                        else if (time_check.Equals("14") && !tmp_TimeList.Contains("三14") && !tmp_TimeList.Contains("三I") && !tmp_TimeList.Contains("三J"))
                        {/*do nothing*/}
                        else if (time_check.Equals("15") && !tmp_TimeList.Contains("三15") && !tmp_TimeList.Contains("三J"))
                        {/*do nothing*/}
                        else if (time_check.Equals("A") && !tmp_TimeList.Contains("三A") && !tmp_TimeList.Contains("三1") && !tmp_TimeList.Contains("三2"))
                        {/*do nothing*/}
                        else if (time_check.Equals("B") && !tmp_TimeList.Contains("三A") && !tmp_TimeList.Contains("三2") && !tmp_TimeList.Contains("三3"))
                        {/*do nothing*/}
                        else if (time_check.Equals("C") && !tmp_TimeList.Contains("三C") && !tmp_TimeList.Contains("三4") && !tmp_TimeList.Contains("三5"))
                        {/*do nothing*/}
                        else if (time_check.Equals("D") && !tmp_TimeList.Contains("三D") && !tmp_TimeList.Contains("三5") && !tmp_TimeList.Contains("三6"))
                        {/*do nothing*/}
                        else if (time_check.Equals("E") && !tmp_TimeList.Contains("三E") && !tmp_TimeList.Contains("三7") && !tmp_TimeList.Contains("三8"))
                        {/*do nothing*/}
                        else if (time_check.Equals("F") && !tmp_TimeList.Contains("三F") && !tmp_TimeList.Contains("三8") && !tmp_TimeList.Contains("三9"))
                        {/*do nothing*/}
                        else if (time_check.Equals("G") && !tmp_TimeList.Contains("三G") && !tmp_TimeList.Contains("三10") && !tmp_TimeList.Contains("三11"))
                        {/*do nothing*/}
                        else if (time_check.Equals("H") && !tmp_TimeList.Contains("三H") && !tmp_TimeList.Contains("三11") && !tmp_TimeList.Contains("三12"))
                        {/*do nothing*/}
                        else if (time_check.Equals("I") && !tmp_TimeList.Contains("三I") && !tmp_TimeList.Contains("三13") && !tmp_TimeList.Contains("三14"))
                        {/*do nothing*/}
                        else if (time_check.Equals("J") && !tmp_TimeList.Contains("三J") && !tmp_TimeList.Contains("三14") && !tmp_TimeList.Contains("三15"))
                        {/*do nothing*/}
                        else
                        {
                            check = false;
                            break;
                        }
                    }

                    return check;
                }
                else if (day.Equals("四"))
                {
                    //Pick the specific table out and store to a temp dictionary
                    Dictionary<string, List<string[]>> tmp_dic = new Dictionary<string, List<string[]>>();
                    tmp_dic = AllSets[table_index];

                    //five temp storage for classes in different time interval
                    List<string[]> tmp_Classes_Thu123AB = tmp_dic["Thu123AB"];
                    List<string[]> tmp_Classes_Thu456CD = tmp_dic["Thu456CD"];
                    List<string[]> tmp_Classes_Thu789EF = tmp_dic["Thu789EF"];
                    List<string[]> tmp_Classes_Thu012GH = tmp_dic["Thu012GH"];
                    List<string[]> tmp_Classes_Thu345IJ = tmp_dic["Thu345IJ"];

                    //set a list for storing time
                    List<string> tmp_TimeList = new List<string>();
                    foreach (string[] sArray in tmp_Classes_Thu123AB)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Thu456CD)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Thu789EF)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Thu012GH)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Thu345IJ)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }

                    //check if there exists any counter time
                    foreach (string time_check in time)
                    {
                        if (time_check.Equals("1") && !tmp_TimeList.Contains("四1") && !tmp_TimeList.Contains("四A"))
                        {/*do nothing*/}
                        else if (time_check.Equals("2") && !tmp_TimeList.Contains("四2") && !tmp_TimeList.Contains("四A") && !tmp_TimeList.Contains("四B"))
                        {/*do nothing*/}
                        else if (time_check.Equals("3") && !tmp_TimeList.Contains("四3") && !tmp_TimeList.Contains("四B"))
                        {/*do nothing*/}
                        else if (time_check.Equals("4") && !tmp_TimeList.Contains("四4") && !tmp_TimeList.Contains("四C"))
                        {/*do nothing*/}
                        else if (time_check.Equals("5") && !tmp_TimeList.Contains("四5") && !tmp_TimeList.Contains("四C") && !tmp_TimeList.Contains("四D"))
                        {/*do nothing*/}
                        else if (time_check.Equals("6") && !tmp_TimeList.Contains("四6") && !tmp_TimeList.Contains("四D"))
                        {/*do nothing*/}
                        else if (time_check.Equals("7") && !tmp_TimeList.Contains("四7") && !tmp_TimeList.Contains("四E"))
                        {/*do nothing*/}
                        else if (time_check.Equals("8") && !tmp_TimeList.Contains("四8") && !tmp_TimeList.Contains("四E") && !tmp_TimeList.Contains("四F"))
                        {/*do nothing*/}
                        else if (time_check.Equals("9") && !tmp_TimeList.Contains("四9") && !tmp_TimeList.Contains("四F"))
                        {/*do nothing*/}
                        else if (time_check.Equals("10") && !tmp_TimeList.Contains("四10") && !tmp_TimeList.Contains("四G"))
                        {/*do nothing*/}
                        else if (time_check.Equals("11") && !tmp_TimeList.Contains("四11") && !tmp_TimeList.Contains("四G") && !tmp_TimeList.Contains("四H"))
                        {/*do nothing*/}
                        else if (time_check.Equals("12") && !tmp_TimeList.Contains("四12") && !tmp_TimeList.Contains("四H"))
                        {/*do nothing*/}
                        else if (time_check.Equals("13") && !tmp_TimeList.Contains("四13") && !tmp_TimeList.Contains("四I"))
                        {/*do nothing*/}
                        else if (time_check.Equals("14") && !tmp_TimeList.Contains("四14") && !tmp_TimeList.Contains("四I") && !tmp_TimeList.Contains("四J"))
                        {/*do nothing*/}
                        else if (time_check.Equals("15") && !tmp_TimeList.Contains("四15") && !tmp_TimeList.Contains("四J"))
                        {/*do nothing*/}
                        else if (time_check.Equals("A") && !tmp_TimeList.Contains("四A") && !tmp_TimeList.Contains("四1") && !tmp_TimeList.Contains("四2"))
                        {/*do nothing*/}
                        else if (time_check.Equals("B") && !tmp_TimeList.Contains("四B") && !tmp_TimeList.Contains("四2") && !tmp_TimeList.Contains("四3"))
                        {/*do nothing*/}
                        else if (time_check.Equals("C") && !tmp_TimeList.Contains("四C") && !tmp_TimeList.Contains("四4") && !tmp_TimeList.Contains("四5"))
                        {/*do nothing*/}
                        else if (time_check.Equals("D") && !tmp_TimeList.Contains("四D") && !tmp_TimeList.Contains("四5") && !tmp_TimeList.Contains("四6"))
                        {/*do nothing*/}
                        else if (time_check.Equals("E") && !tmp_TimeList.Contains("四E") && !tmp_TimeList.Contains("四7") && !tmp_TimeList.Contains("四8"))
                        {/*do nothing*/}
                        else if (time_check.Equals("F") && !tmp_TimeList.Contains("四F") && !tmp_TimeList.Contains("四8") && !tmp_TimeList.Contains("四9"))
                        {/*do nothing*/}
                        else if (time_check.Equals("G") && !tmp_TimeList.Contains("四G") && !tmp_TimeList.Contains("四10") && !tmp_TimeList.Contains("四11"))
                        {/*do nothing*/}
                        else if (time_check.Equals("H") && !tmp_TimeList.Contains("四H") && !tmp_TimeList.Contains("四11") && !tmp_TimeList.Contains("四12"))
                        {/*do nothing*/}
                        else if (time_check.Equals("I") && !tmp_TimeList.Contains("四I") && !tmp_TimeList.Contains("四13") && !tmp_TimeList.Contains("四14"))
                        {/*do nothing*/}
                        else if (time_check.Equals("J") && !tmp_TimeList.Contains("四J") && !tmp_TimeList.Contains("四14") && !tmp_TimeList.Contains("四15"))
                        {/*do nothing*/}
                        else
                        {
                            check = false;
                            break;
                        }
                    }

                    return check;
                }
                else if (day.Equals("五"))
                {
                    //Pick the specific table out and store to a temp dictionary
                    Dictionary<string, List<string[]>> tmp_dic = new Dictionary<string, List<string[]>>();
                    tmp_dic = AllSets[table_index];

                    //five temp storage for classes in different time interval
                    List<string[]> tmp_Classes_Fri123AB = tmp_dic["Fri123AB"];
                    List<string[]> tmp_Classes_Fri456CD = tmp_dic["Fri456CD"];
                    List<string[]> tmp_Classes_Fri789EF = tmp_dic["Fri789EF"];
                    List<string[]> tmp_Classes_Fri012GH = tmp_dic["Fri012GH"];
                    List<string[]> tmp_Classes_Fri345IJ = tmp_dic["Fri345IJ"];

                    //set a list for storing time
                    List<string> tmp_TimeList = new List<string>();
                    foreach (string[] sArray in tmp_Classes_Fri123AB)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Fri456CD)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Fri789EF)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Fri012GH)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }
                    foreach (string[] sArray in tmp_Classes_Fri345IJ)
                    {
                        if (sArray.Length == 4)
                        {
                            string[] Splitbyday = sArray[3].Split(' ');
                            foreach (string split in Splitbyday)
                            {
                                string byday = split.Substring(0, 1);
                                string[] bytime = split.Substring(1).Split(',');
                                foreach (string sIn in bytime)
                                {
                                    tmp_TimeList.Add(byday + sIn);
                                }
                            }
                        }
                    }

                    //check if there exists any counter time
                    foreach (string time_check in time)
                    {
                        if (time_check.Equals("1") && !tmp_TimeList.Contains("五1") && !tmp_TimeList.Contains("五A"))
                        {/*do nothing*/}
                        else if (time_check.Equals("2") && !tmp_TimeList.Contains("五2") && !tmp_TimeList.Contains("五A") && !tmp_TimeList.Contains("五B"))
                        {/*do nothing*/}
                        else if (time_check.Equals("3") && !tmp_TimeList.Contains("五3") && !tmp_TimeList.Contains("五B"))
                        {/*do nothing*/}
                        else if (time_check.Equals("4") && !tmp_TimeList.Contains("五4") && !tmp_TimeList.Contains("五C"))
                        {/*do nothing*/}
                        else if (time_check.Equals("5") && !tmp_TimeList.Contains("五5") && !tmp_TimeList.Contains("五C") && !tmp_TimeList.Contains("五D"))
                        {/*do nothing*/}
                        else if (time_check.Equals("6") && !tmp_TimeList.Contains("五6") && !tmp_TimeList.Contains("五D"))
                        {/*do nothing*/}
                        else if (time_check.Equals("7") && !tmp_TimeList.Contains("五7") && !tmp_TimeList.Contains("五E"))
                        {/*do nothing*/}
                        else if (time_check.Equals("8") && !tmp_TimeList.Contains("五8") && !tmp_TimeList.Contains("五E") && !tmp_TimeList.Contains("五F"))
                        {/*do nothing*/}
                        else if (time_check.Equals("9") && !tmp_TimeList.Contains("五9") && !tmp_TimeList.Contains("五F"))
                        {/*do nothing*/}
                        else if (time_check.Equals("10") && !tmp_TimeList.Contains("五10") && !tmp_TimeList.Contains("五G"))
                        {/*do nothing*/}
                        else if (time_check.Equals("11") && !tmp_TimeList.Contains("五11") && !tmp_TimeList.Contains("五G") && !tmp_TimeList.Contains("五H"))
                        {/*do nothing*/}
                        else if (time_check.Equals("12") && !tmp_TimeList.Contains("五12") && !tmp_TimeList.Contains("五H"))
                        {/*do nothing*/}
                        else if (time_check.Equals("13") && !tmp_TimeList.Contains("五13") && !tmp_TimeList.Contains("五I"))
                        {/*do nothing*/}
                        else if (time_check.Equals("14") && !tmp_TimeList.Contains("五14") && !tmp_TimeList.Contains("五I") && !tmp_TimeList.Contains("五J"))
                        {/*do nothing*/}
                        else if (time_check.Equals("15") && !tmp_TimeList.Contains("五15") && !tmp_TimeList.Contains("五J"))
                        {/*do nothing*/}
                        else if (time_check.Equals("A") && !tmp_TimeList.Contains("五A") && !tmp_TimeList.Contains("五1") && !tmp_TimeList.Contains("五2"))
                        {/*do nothing*/}
                        else if (time_check.Equals("B") && !tmp_TimeList.Contains("五B") && !tmp_TimeList.Contains("五2") && !tmp_TimeList.Contains("五3"))
                        {/*do nothing*/}
                        else if (time_check.Equals("C") && !tmp_TimeList.Contains("五C") && !tmp_TimeList.Contains("五4") && !tmp_TimeList.Contains("五5"))
                        {/*do nothing*/}
                        else if (time_check.Equals("D") && !tmp_TimeList.Contains("五D") && !tmp_TimeList.Contains("五5") && !tmp_TimeList.Contains("五6"))
                        {/*do nothing*/}
                        else if (time_check.Equals("E") && !tmp_TimeList.Contains("五E") && !tmp_TimeList.Contains("五7") && !tmp_TimeList.Contains("五8"))
                        {/*do nothing*/}
                        else if (time_check.Equals("F") && !tmp_TimeList.Contains("五F") && !tmp_TimeList.Contains("五8") && !tmp_TimeList.Contains("五9"))
                        {/*do nothing*/}
                        else if (time_check.Equals("G") && !tmp_TimeList.Contains("五G") && !tmp_TimeList.Contains("五10") && !tmp_TimeList.Contains("五11"))
                        {/*do nothing*/}
                        else if (time_check.Equals("H") && !tmp_TimeList.Contains("五H") && !tmp_TimeList.Contains("五11") && !tmp_TimeList.Contains("五12"))
                        {/*do nothing*/}
                        else if (time_check.Equals("I") && !tmp_TimeList.Contains("五I") && !tmp_TimeList.Contains("五13") && !tmp_TimeList.Contains("五14"))
                        {/*do nothing*/}
                        else if (time_check.Equals("J") && !tmp_TimeList.Contains("五J") && !tmp_TimeList.Contains("五14") && !tmp_TimeList.Contains("五15"))
                        {/*do nothing*/}
                        else
                        {
                            check = false;
                            break;
                        }
                    }
                }
            }

            return check;
        }

        public int TableCount()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Schedule.xml");
            XmlNodeList Tables = xmlDoc.SelectNodes("Schedule/Table");
            int counter = 0;
            foreach(XmlNode table in Tables)
            {
                counter++;
            }

            return counter;
        }
    }
}
