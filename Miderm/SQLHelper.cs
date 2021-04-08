using Miderm;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderm
{
    public static class SQLHelper
    {
        ///<summary>Populates a list with checking account objects.</summary>
        ///<returns>Returns a list of all checking accounts, indexed by ID number.</returns>
        public static List<Checking> GetChecking()
        {
            List<Checking> accountList = new List<Checking>();
            SqlConnection cnn;
            SqlDataReader reader;
            string connectionString;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Programs\Miderm\Miderm\ATMdatabase.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = String.Empty;
            sql = "Select Id from Users";
            command = new SqlCommand(sql, cnn);

            reader = command.ExecuteReader();


            int tempForFilling;
            while (reader.Read())
            {
                tempForFilling = (int)reader.GetValue(0);
                accountList.Add(new Checking(tempForFilling));

            }
            return accountList;
        }

        ///<summary>Populates a list with savings account objects.</summary>
        ///<returns>Returns a list of all savings accounts, indexed by ID number.</returns>
        public static List<Savings> GetSavings()
        {
            List<Savings> accountList = new List<Savings>();
            SqlConnection cnn;
            SqlDataReader reader;
            string connectionString;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Programs\Miderm\Miderm\ATMdatabase.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = String.Empty;
            sql = "Select Id from Users";
            command = new SqlCommand(sql, cnn);

            reader = command.ExecuteReader();


            int tempForFilling;
            while (reader.Read())
            {
                tempForFilling = (int)reader.GetValue(0);
                accountList.Add(new Savings(tempForFilling));
                    
            }
            return accountList;
        }
    }
}
