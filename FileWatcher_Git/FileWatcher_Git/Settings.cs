using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using FileWatcher_Git.Data_Structure;

namespace FileWatcher_Git
{
    public partial class Settings : Form
    {
        List<DDirectory> directorylist;
        List<string> filelist;
        
        public Settings()
        {
            InitializeComponent();
            InitializeForm();
        }

        public void InitializeForm()
        {
            directorylist = new List<DDirectory>();

            XElement xe = XElement.Load(@"..\..\Lookup.xml");
            if (xe != null)
            {
                IEnumerable<XElement> directories = xe.Descendants("directory");
                foreach (XElement d in directories)
                {
                    DDirectory newdir = new DDirectory(d.Attribute("name").Value);
                    DirectoryComboBox.Items.Add(newdir.dir);
                    filelist = new List<string>();

                    IEnumerable<XElement> files = d.Descendants("filename");
                    foreach(XElement f in files)
                        filelist.Add(f.Value);

                    newdir.file = filelist;
                    directorylist.Add(newdir);
                    
                }
            }

            Redraw();
                
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            foreach (DDirectory n in directorylist)
            {
                if (n.dir == DirectoryComboBox.Text)
                {
                    n.file.Add(FileNameTextBox.Text);
                }
                 
            }

            Redraw();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            using (XmlWriter wrt = XmlWriter.Create(@"..\..\Lookup.xml"))
            {
                wrt.WriteStartDocument();
                wrt.WriteStartElement("lookup");
                foreach (DDirectory dd in directorylist)
                {
                    wrt.WriteStartElement("directory");
                    wrt.WriteAttributeString("name", dd.dir);
                    foreach (string l in dd.file)
                    {
                        wrt.WriteElementString("filename", l);
                    }
                    wrt.WriteEndElement();
                }
                wrt.WriteEndElement();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (DDirectory n in directorylist)
            {
                if (n.dir != DirectoryTreeView.SelectedNode.Text)
                {
                    foreach (string ss in n.file)
                    {
                        if (ss == DirectoryTreeView.SelectedNode.Text)
                        {
                            n.file.Remove(ss);
                            break;
                        }
                    }
                }
                else if (n.dir == DirectoryTreeView.SelectedNode.Text)
                {
                    directorylist.Remove(n);
                    break;
                }

            }
            Redraw();
        }

        private void DirectoryAddButton_Click(object sender, EventArgs e)
        {
            DDirectory dnew = new DDirectory(DirectoryTextBox.Text);
            directorylist.Add(dnew);
            Redraw();
            DirectoryComboBox.Items.Add(DirectoryTextBox.Text);
        }


        private void Redraw()
        {
            DirectoryTreeView.Nodes.Clear();
            foreach (DDirectory dd in directorylist)
            {
                List<string> tempfiles = dd.file;

                TreeNode[] temp = new TreeNode[tempfiles.Count];
                int i = 0;

                foreach (string s in dd.file)
                {
                    temp[i] = new TreeNode(s);
                    i++;
                }

                TreeNode nn = new TreeNode(dd.dir, temp);
                DirectoryTreeView.Nodes.Add(nn);
            }
        }
    }
}
