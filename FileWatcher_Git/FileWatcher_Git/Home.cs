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
        DataTable st;
        public Home()
        {
            InitializeComponent();

           
            
        }


        private void SettingsButton_Click(object sender, EventArgs e)
        {
            (new Settings()).Show();

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            GenerateStatus gs = new GenerateStatus();
            st = gs.status(dateTimePicker1.Value);
            FileTable.AutoGenerateColumns = true;
            FileTable.DataSource = st;
            FileTable.AutoResizeColumns();
            FileTable.Refresh();
        }
    }
}
