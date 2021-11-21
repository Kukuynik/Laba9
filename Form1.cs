using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Account3 account1 = new Account3(1200, TypeOfAccaunt.DEBIT);
        Account3 account2 = new Account3(4000, TypeOfAccaunt.DEPOSIT);
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Accaunt1 accaunt = new Accaunt1();
            accaunt.FillTypeAccaunt(TypeOfAccaunt.DEBIT);
            accaunt.FillNumber(random.Next(10000000, 99999999));
            accaunt.FillBalance(100000);
            accaunt.FillInfo();
            richTextBox1.Text = accaunt.FullInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accaunt2 accaunt1 = new Accaunt2();
            Accaunt2 accaunt2 = new Accaunt2();
            Accaunt2 accaunt3 = new Accaunt2();
            accaunt1.FillTypeAccaunt(TypeOfAccaunt.DEBIT);
            accaunt1.FillBalance(100000);
            accaunt2.FillTypeAccaunt(TypeOfAccaunt.CREDIT);
            accaunt2.FillBalance(5959);
            accaunt3.FillTypeAccaunt(TypeOfAccaunt.DEPOSIT);
            accaunt3.FillBalance(1856890);
            accaunt1.FillInfo();
            accaunt2.FillInfo();
            accaunt3.FillInfo();
            richTextBox2.Text = accaunt1.FullInfo() + accaunt2.FullInfo() + accaunt3.FullInfo();
        }


        // zadanie 3


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox2.Text = Convert.ToString(account1.TypeAccount);
                textBox3.Text = Convert.ToString(account1.Balance);

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox2.Text = Convert.ToString(account2.TypeAccount);
                textBox3.Text = Convert.ToString(account2.Balance);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        // zadanie 4 


    }
}
