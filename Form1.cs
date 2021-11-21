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
            comboBox2.Items.Add(building1.GetNumber());
            comboBox2.Items.Add(building2.GetNumber());
            
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                account1.PutMoney(Convert.ToInt32(textBox4.Text));
                textBox3.Text = Convert.ToString(account1.InfoBalance());
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                account2.PutMoney(Convert.ToInt32(textBox4.Text));
                textBox3.Text = Convert.ToString(account2.InfoBalance());
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 127)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 127)
            {
                e.Handled = true;
            }
        }

        // zadanie 4 
        Building building1 = new Building();
        Building building2 = new Building(36,12,96,2);
        

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == building1.GetNumber()-1)
            {
                building1.setHeight(Convert.ToDouble(textBox5.Text));
                building1.setLevelsCount(Convert.ToInt32(textBox6.Text));
                building1.setEntryCount(Convert.ToInt32(textBox8.Text));
                building1.setApartmentsCount(Convert.ToInt32(textBox7.Text));
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == building1.GetNumber()-1)
            {
                textBox5.Text = Convert.ToString(building1.GetHeight());
                textBox6.Text = Convert.ToString(building1.GetLevelsCount());
                textBox7.Text = Convert.ToString(building1.GetApartmentsCount());
                textBox8.Text = Convert.ToString(building1.GetEntryCount());
            }
            else if(comboBox2.SelectedIndex == building2.GetNumber()-1)
            {
                textBox5.Text = Convert.ToString(building2.GetHeight());
                textBox6.Text = Convert.ToString(building2.GetLevelsCount());
                textBox7.Text = Convert.ToString(building2.GetApartmentsCount());
                textBox8.Text = Convert.ToString(building2.GetEntryCount());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == building1.GetNumber()-1) 
            {
                building1.setHeight(Convert.ToDouble(textBox5.Text));
                building1.setLevelsCount(Convert.ToInt32(textBox6.Text));
                building1.setEntryCount(Convert.ToInt32(textBox8.Text));
                building1.setApartmentsCount(Convert.ToInt32(textBox7.Text));
                textBox9.Text = Convert.ToString(building1.LevelsHeight());
                textBox10.Text = Convert.ToString(building1.ApartmentsInLevel());
                textBox11.Text = Convert.ToString(building1.ApartmensInEntry());
            }
            else if (comboBox2.SelectedIndex == building2.GetNumber()-1)
            {
                textBox9.Text = Convert.ToString(building2.LevelsHeight());
                textBox10.Text = Convert.ToString(building2.ApartmentsInLevel());
                textBox11.Text = Convert.ToString(building2.ApartmensInEntry());
            }
        }
    }
}
