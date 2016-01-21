using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectTool
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        void Detail()
        {
            string str = "";
            if (Download.Checked) str = str + " AND EventMessage NOT LIKE '%Download%'";
            if (Receive.Checked) str = str + " AND EventMessage NOT LIKE 'Upload%'";
            if (Update.Checked) str = str + " AND EventMessage NOT LIKE 'Receive%'";
            if (Created.Checked) str = str + " AND EventMessage NOT LIKE 'Created%'";
            if (Update.Checked) str = str + " AND EventMessage NOT LIKE 'Update%'";
            if (Delete.Checked) str = str + " AND EventMessage NOT LIKE 'Deleted%'";
            if (Synchronize.Checked) str = str + " AND EventMessage NOT LIKE 'Synchronized%'";
            if (Time.Checked) str = str + " AND EventMessage NOT LIKE 'Store-HQ Time%'";
            if (LocalAndHQ.Checked) str = str + " AND EventMessage NOT LIKE 'Local and HQ%' ";
            if (OpeningOf.Checked) str = str + " AND EventMessage NOT LIKE 'Opening of local %'";
            if (Closed.Checked) str = str + " AND EventMessage NOT LIKE 'Closed local %'";
            if (CONNECTIONENDED.Checked) str = str + " AND EventMessage != '======= CONNECTION ENDED ======='";

            Properties.Settings.Default.Details= str;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Detail();
            // this.Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
