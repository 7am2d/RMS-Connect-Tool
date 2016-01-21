using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConnectTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string Constr()
        {
            string Value, server, dbname, user, password;
            server = Properties.Settings.Default.DBServer;
            dbname = Properties.Settings.Default.DBName;
            user = Properties.Settings.Default.DBUserName;
            password = Properties.Settings.Default.DBPassword;

            Value = @"Data Source = "+server+"; Initial Catalog = "+ dbname + "; Persist Security Info = True; User ID = "+user+"; Password = "+ password;
            return Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getStores();
            //MessageBox.Show("منور يا كبير  :P");
            datePicker.CustomFormat = "dd-MM-yyyy";
            datePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "mm:HH";
            TimePicker.Format = DateTimePickerFormat.Custom;
        }

        string getDateTime()
        {
            string value = "";
            if (radioDCostom.Checked)   value = datePicker.Value.ToString("yyyy-MM-dd");
            if (radioDLN.Checked) value = datePicker.Value.AddDays(-1).ToString("yyyy-MM-dd");
            if (radio12pm.Checked)      value = value + " 12:00";
            if (radio5pm.Checked)       value = value + " 17:00";
            if (radio8am.Checked)       value = value + " 08:00";
            if (radio9pm.Checked)       value = value + " 21:00";
            if (radioCustom.Checked)    value = value + TimePicker.Value.ToString(" HH:mm");
            return value;
        }

        private void getStores()
        {
            string str = Constr();
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter sda = new SqlDataAdapter
            ("SELECT ID, Name FROM Store ORDER BY Name ", con);
            sda.Fill(this.clueTestDataSet.Store);
        }

        private void سلامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("سلام يا برنس");
            Application.Exit();
        }

        private void softwareInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ss = new Form3();
            ss.Show();
        }

        private void detailsOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Details ss = new Details();
            ss.Show();
        }

        private void CheckConnect(string SID)
        {
            textBox1.Text = SID;
            string date = getDateTime();
            string str = Constr();
            string Details = Properties.Settings.Default.Details;
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter sda = new SqlDataAdapter
            ("SELECT StoreID, EventTime, EventMessage FROM HQEventLog WHERE  StoreID = " + SID
            + " AND EventTime > '" + date + "'" + Details + "ORDER BY EventTime DESC", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                this.clueTestDataSet.HQEventLog.Clear();
                textBox2.Text= "Connect ERORR";
                textBox2.BackColor = Color.Red;
            }
            else
            {
                this.clueTestDataSet.HQEventLog.Clear();
                sda.Fill(this.clueTestDataSet.HQEventLog);
                textBox2.Text = "Connected";
                textBox2.BackColor = Color.Green;
            }
            if (checkBoxPhone.Checked)
            {
                this.clueTestDataSet1.SalesRep.Clear();
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT ID, Name, Telephone FROM SalesRep where StoreID = " + SID + " ORDER BY ID ASC", con);
                sda1.Fill(this.clueTestDataSet1.SalesRep);
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string SID = listBox1.SelectedValue.ToString();
            CheckConnect(SID);
        }

        private void buttonAotu_Click(object sender, EventArgs e)
        {
            string str = Constr();
            string DT = getDateTime();
            DataTable Not = new DataTable();
            DataTable dt1 = new DataTable();
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter sda = new SqlDataAdapter ("SELECT ID, Name FROM Store ORDER BY Name ", con);
            DataTable dtSID = new DataTable();
            sda.Fill(dtSID);
            foreach (DataRow item in dtSID.Rows)
            {
                string sid =item[0].ToString();
                SqlDataAdapter sda1 = new SqlDataAdapter ("SELECT StoreID FROM HQEventLog WHERE  StoreID = "+sid+" AND EventTime > '"+DT+"'", con);
                dt1.Clear();
                sda1.Fill(dt1);
                if (dt1.Rows.Count == 0)
                {
                    SqlDataAdapter sda36 = new SqlDataAdapter("SELECT ID, Name FROM Store WHERE ID = "+sid, con);
                    sda36.Fill(Not);
                }
            }
            dataGridView1.DataSource = Not;
        }

        private void dataBaseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connection ff = new Connection();
            ff.Show();
        }

       
        
    }
}
