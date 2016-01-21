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
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
            Server.Text = Properties.Settings.Default.DBServer;
            DB.Text = Properties.Settings.Default.DBName;
            UN.Text = Properties.Settings.Default.DBUserName;
            PW.Text = Properties.Settings.Default.DBPassword;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DBServer = Server.Text;
            Properties.Settings.Default.DBName = DB.Text;
            Properties.Settings.Default.DBUserName = UN.Text;
            Properties.Settings.Default.DBPassword = PW.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("اتظبطت يا معلم :)");
            this.Hide();
        }

        string Constr()
        {
            string Value, server, dbname, user, password;
            server = Server.Text;
            dbname = DB.Text;
            user = UN.Text;
            password = PW.Text;

            Value = @"Data Source = " + server + "; Initial Catalog = " + dbname + "; Persist Security Info = True; User ID = " + user + "; Password = " + password;
            return Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = Constr();
            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    try
                    {
                        connection.Open();
                        if (connection.State == ConnectionState.Open) // if connection.Open was successful
                        {
                            MessageBox.Show("كلو تمام الداتا بيز شغالة زي الفول");
                        }
                        else
                        {
                            MessageBox.Show("Connection failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("غلط يا باشا زبط صح وبص ده سبب الغلط لو فهمت حاجة أبقا قابلني: \n" + ex);
                    }
                }
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Chyba v přihlášení: " + ex);
            //}
            finally
            {

            }
        }
    }
}
