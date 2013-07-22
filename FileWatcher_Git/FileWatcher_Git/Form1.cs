using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FileWatcher_Git
{
    public partial class Form1 : Form
    {
        List<string> directorylist;
        List<string> writedirectorylist;
        List<string> filelist;
        List<string> writefilelist;


        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        public void InitializeForm()
        {
            filelist = new List<string>();
            XmlTextReader liststream = new XmlTextReader("Lookup.xml");
            string sName;
            while (liststream.Read())
            {

                if ((liststream.NodeType == XmlNodeType.Element) && (liststream.Name == "lookup"))
                {

                    while (liststream.NodeType != XmlNodeType.EndElement)
                    {
                        liststream.Read();
                        if ((liststream.NodeType == XmlNodeType.Element) && (liststream.Name == "directory"))
                        {
                            directorylist.Add(liststream.GetAttribute(0));
                            liststream.Read();
                            while (liststream.NodeType != XmlNodeType.EndElement)
                            {
                                if (liststream.Name == "filename")
                                    filelist.Add(liststream.Value);
                                liststream.Read();
                                if (liststream.NodeType == XmlNodeType.EndElement)
                                    break;
                            }
                        }

                    }
                }

            }

            liststream.Close();

            foreach (string s in filelist)
            {
                FileNameList.Items.Add(s);
            }

            writefilelist = new List<string>();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            filelist.Add(FileNameTextBox.Text);
            FileNameList.Items.Add(FileNameTextBox.Text);

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            StreamWriter writestream = new StreamWriter("Settings.txt");

            foreach (string s in filelist)
            {
                writestream.WriteLine(s);
            }
            writestream.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection temp = FileNameList.SelectedItems;
            string[] t = new string[100];
            temp.CopyTo(t, 0);
            foreach (string s in t)
            {
                ListViewItem item = new ListViewItem(s);
                FileNameList.Items.Remove(item);
            }
            FileNameList.Refresh();
        }

    }
}
