using FileWatcher_Git.Data_Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FileWatcher_Git
{
    public partial class Home : Form
    {
        List<string> directorylist;
        DataTable memtable;

        public Home()
        {
            InitializeComponent();
            InitializeForm();
        }

        public void InitializeForm()
        {
            directorylist = new List<string>();

            XElement xe = XElement.Load(@"..\..\Lookup.xml");
            if (xe != null)
            {
                IEnumerable<XElement> directories = xe.Descendants("directory");
                foreach (XElement d in directories)
                {
                    IEnumerable<XElement> files = d.Descendants("filename");
                    foreach (XElement f in files)
                        directorylist.Add(f.Value);
                 }
            }

            memtable = new DataTable();
            memtable.Columns.Add("Files", Type.GetType("System.String"));
            memtable.Columns.Add("Status", Type.GetType("System.String"));

            int i = 0;
            while (i<directorylist.Count)
            {
                memtable.Rows.Add();
                memtable.Rows[memtable.Rows.Count - 1]["Files"] = directorylist[i];
                //memtable.Rows[memtable.Rows.Count - 1]["Status"] = ;
                i++;
            }

            Redraw();

        }

        public void Redraw()
        {
            foreach(DataRow dr in memtable.Rows)
                Console.WriteLine(dr["Files"]);

            FileTable.AutoGenerateColumns = true;
            FileTable.DataSource = memtable;
            FileTable.Refresh();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            (new Settings()).Show();

        }
    }
}
