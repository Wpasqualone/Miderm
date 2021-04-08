using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miderm
{
    public abstract class Account
    {
        protected int id;
        public Account(int ID)
        {
            this.id = ID;
        }

        public Account() {
            this.id = -1;
        }

        public int ID {
            get {       
                return id;
            }

            set {
                if (value > 0) {
                    id = value;
                }
            
            }
        
        }

    }

    public class Checking : Account {
        private double temp;
        

        public Checking(int ID) {
            this.id = ID;
        
        }
        ///<summary>Takes an amount and deposits it into your checking account.</summary>
        ///<param name="Amount">The amount to be deposited</param>
        ///<returns>Returns the current balance of the account</returns>
        public double Deposit(double Amount) {
            SqlConnection connection;
            SqlDataReader reader;
            string connectionString;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Programs\Miderm\Miderm\ATMdatabase.mdf;Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = String.Empty;
            sql = "Select Id, CheckingBalance from Users";
            command = new SqlCommand(sql, connection);

            reader = command.ExecuteReader();


            while (reader.Read())
            {
                if ((int)reader.GetValue(0) == id) {
                    temp = (double)reader.GetValue(1);
                
                }
            }

            temp = temp + Amount;

            adapter.Dispose();
            reader.Close();

            sql = String.Empty;
            sql = "Update Users Set CheckingBalance ='" +  temp + "' where (Id = '" + id+ "')";
            command = new SqlCommand(sql, connection);

            adapter.InsertCommand = new SqlCommand(sql, connection);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            connection.Close();

            return temp;
        }

        ///<summary>Gets the current balance of the checking account.</summary>
        ///<returns>Returns the current balance of the account.</returns>
        public double Balance() {
            return Deposit(0);
        }
    
    }



    public class Savings : Account
    {
        private double temp;
        public Savings(int ID)
        {
            this.id = ID;

        }

        ///<summary>Takes an amount and deposits it into your savings account.</summary>
        ///<param name="Amount">The amount to be deposited</param>
        ///<returns>Returns the current balance of the account</returns>
        public double Deposit(double Amount)
        {
            SqlConnection connection2;
            SqlDataReader reader2;
            string connectionString;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Programs\Miderm\Miderm\ATMdatabase.mdf;Integrated Security=True;Connect Timeout=30";
            connection2 = new SqlConnection(connectionString);
            connection2.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = String.Empty;
            sql = "Select Id, SavingBalance from Users";
            command = new SqlCommand(sql, connection2);

            reader2 = command.ExecuteReader();


            while (reader2.Read())
            {
                if ((int)reader2.GetValue(0) == id)
                {
                    temp = Convert.ToDouble(reader2.GetValue(1));

                }
            }

            temp = temp + Amount;
            adapter.Dispose();
            reader2.Close();

            sql = String.Empty;
            sql = "Update Users Set SavingBalance ='" + temp + "' where (Id = '" + id + "')";
            command = new SqlCommand(sql, connection2);

            adapter.InsertCommand = new SqlCommand(sql, connection2);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            connection2.Close();

            return temp;
        }

        ///<summary>Gets the current balance of the checking account.</summary>
        ///<returns>Returns the current balance of the account.</returns>
        public double Balance()
        {
            return Deposit(0);
        }

    }


}
