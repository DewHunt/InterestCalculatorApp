using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculatorApp
{
    public partial class interestCalculaorUI : Form
    {
        public interestCalculaorUI()
        {
            InitializeComponent();
        }

        private void calculateInterestButton_Click(object sender, EventArgs e)
        {
            double interest;


            string bankName = bankNameComboBox.Text;

            //MessageBox.Show(bankName);
            if (timeTextBox.Text == "" || balanceTextBox.Text == "")
            {
                MessageBox.Show("Enter Time and Balance");
                //timeTextBox.Text = "Enter Time";
                //balanceTextBox.Text = "Enter Balance";
            }
            else
            {
                double time = Convert.ToDouble(timeTextBox.Text);
                double principle = Convert.ToDouble(balanceTextBox.Text);
                if (bankName == "BRAC")
                {
                    interest = (principle * time * 6) / 100;
                }
                else
                {
                    if (bankName == "DBBL")
                    {
                        interest = (principle * time * 7) / 100;
                    }
                    else
                    {
                        interest = (principle * time * 8) / 100;
                    }
                }

                interestTextBox.Text = interest.ToString();
            }
            
        }

        private void interestCalculaorUI_Load(object sender, EventArgs e)
        {

            bankNameComboBox.Items.Add("BRAC");
            bankNameComboBox.Items.Add("DBBL");
            bankNameComboBox.Items.Add("HSBC");
            bankNameComboBox.SelectedItem = "BRAC";
            //bankNameComboBox.SelectedIndex = bankNameComboBox.FindStringExact("BRAC");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            bankNameComboBox.SelectedItem = "BRAC";
            timeTextBox.Clear();
            interestTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
