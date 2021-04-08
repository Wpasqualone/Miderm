using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miderm
{


    public partial class MoneyInterface : Form
    {

        public List<Savings> savingList;
        public List<Checking> checkingList;

        ///<summary>Takes all checking and savings accounts and puts them into a list, as well as displaying current balance</summary>
        public void Update()
        {
            savingList = SQLHelper.GetSavings();
            checkingList = SQLHelper.GetChecking();

            checkinglabel.Text = "Checking Account Balance: " + checkingList[Program.currentUser - 1].Balance();
            savingslabel.Text = "Savings Account Balance: " + savingList[Program.currentUser-1].Balance();


        }
        public MoneyInterface()
        {
            InitializeComponent();
        }

        private void MoneyInterface_Load(object sender, EventArgs e)
        {
            Update();
        }

        public double moneyAmount;
        public double bal;
        private void wsave_Click(object sender, EventArgs e)
        {
            if (double.Parse(wsavebox.Text) > 0)
            {
                Update();
                moneyAmount = double.Parse(wsavebox.Text);
                bal = savingList[Program.currentUser - 1].Balance();
                if (moneyAmount > bal)
                {
                    bal = checkingList[Program.currentUser - 1].Balance();
                    if (moneyAmount > bal)
                    {
                        MessageBox.Show("Insufficient Fundsx    .");

                    }
                    else
                    {
                        MessageBox.Show("The funds in your savings account were insufficient. Money has been withdrawn from your checking account.");
                        checkingList[Program.currentUser - 1].Deposit(-moneyAmount);
                        Update();
                    }
                }
                else
                {
                    savingList[Program.currentUser - 1].Deposit(-moneyAmount);
                    Update();
                }
            }
            else {
                MessageBox.Show("Invalid Input.");
            }
        }

        private void dsave_Click(object sender, EventArgs e)
        {
            if (double.Parse(dsavebox.Text) > 0)
            {
                Update();
                moneyAmount = double.Parse(dsavebox.Text);  
                savingList[Program.currentUser - 1].Deposit(moneyAmount);
                Update();
            }
            else
            {
                MessageBox.Show("Invalid Input.");
            }
        }

        private void wcheck_Click(object sender, EventArgs e)
        {
            if (double.Parse(wcheckbox.Text) > 0)
            {
                Update();
                moneyAmount = double.Parse(wcheckbox.Text);
                bal = checkingList[Program.currentUser - 1].Balance();
                if (moneyAmount > bal)
                {
                    bal = savingList[Program.currentUser - 1].Balance();
                    if (moneyAmount > bal)
                    {
                        MessageBox.Show("Insufficient Funds.");

                    }
                    else
                    {
                        MessageBox.Show("The funds in your checking account were insufficient. Money has been withdrawn from your savings account.");
                        savingList[Program.currentUser - 1].Deposit(-moneyAmount);
                        Update();
                    }
                }
                else
                {
                    checkingList[Program.currentUser - 1].Deposit(-moneyAmount);
                    Update();
                }
            }
            else
            {
                MessageBox.Show("Invalid Input.");
            }
        }

        private void dcheck_Click(object sender, EventArgs e)
        {
            if (double.Parse(dcheckbox.Text) > 0)
            {
                Update();
                moneyAmount = double.Parse(dcheckbox.Text);
                checkingList[Program.currentUser - 1].Deposit(moneyAmount);
                Update();
            }
            else
            {
                MessageBox.Show("Invalid Input.");
            }
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            if (double.Parse(sendbox2.Text) > 0)
            {
                Update();
                moneyAmount = double.Parse(sendbox2.Text);
                bal = checkingList[Program.currentUser - 1].Balance();
                if (moneyAmount > bal)
                {
                    bal = savingList[Program.currentUser - 1].Balance();
                    if (moneyAmount > bal)
                    {
                        MessageBox.Show("Insufficient Funds.");

                    }
                    else
                    {
                        if (int.Parse(sendbox1.Text) <= checkingList.Count)
                        {
                            MessageBox.Show("The funds in your checking account were insufficient. Money has been sent from your savings account.");
                            savingList[Program.currentUser - 1].Deposit(-moneyAmount);
                            checkingList[int.Parse(sendbox1.Text) - 1].Deposit(moneyAmount);
                            Update();
                        }
                        else {
                            MessageBox.Show("Error: User not found.");
                        }
                    }
                }
                else
                {

                    if (int.Parse(sendbox1.Text) <= checkingList.Count)
                    {
                        MessageBox.Show("Funds successfully transferred.");
                        checkingList[Program.currentUser - 1].Deposit(-moneyAmount);
                        checkingList[int.Parse(sendbox1.Text) - 1].Deposit(moneyAmount);
                        Update();
                    }
                    else
                    {
                        MessageBox.Show("Error: User not found.");
                    }
               
                }
            }
            else
            {
                MessageBox.Show("Invalid Input.");
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log out successful.");
            this.Hide();
        }
    }
}
