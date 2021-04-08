using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miderm
{
    public partial class Form1 : Form
    {

        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Programs\Miderm\Miderm\ATMdatabase.mdf;Integrated Security=True;Connect Timeout=30";
        public static MoneyInterface MI = new MoneyInterface();
        public Form1()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (accountNumber.Text == "" || accountPin.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Select * from Users where Id=@number and PIN=@customerpin", connection);

                cmd.Parameters.AddWithValue("@number", accountNumber.Text);
                cmd.Parameters.AddWithValue("@customerpin", accountPin.Text);
                connection.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapt.Fill(dataSet);
                connection.Close();
                int count = dataSet.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    Program.currentUser = int.Parse(accountNumber.Text);
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    MI.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MI.Hide();
        }
    }
}
