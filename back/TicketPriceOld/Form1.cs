using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketPrice
{
    public partial class Form1 : Form
    {
        List<Client> list = new List<Client>();
        List<string> dis = new List<string>();
        public Form1()
        {
            dis.Add("ASHFDWRPB");
            dis.Add("QPCKNCHFN");
            dis.Add("BMNRJWKVP");
            dis.Add("HXXMBHRND");
            InitializeComponent();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="" || textBox2.Text == ""|| (checkBox1.Checked==false &&checkBox2.Checked==false&&checkBox3.Checked==false))
            {
                ExceptionLabel.Text = "Проверте корректность введенных данных.";
            }
            else
            {
                Client client;
                if(checkBox1.Checked==true)
                {
                    if (dis.Contains(textBox4.Text))
                    {
                         client = new Student(textBox1.Text, textBox2.Text,true);
                    }
                    else client = new Student(textBox1.Text,textBox2.Text);
                }
                else if(checkBox2.Checked ==true)
                {
                    if (dis.Contains(textBox4.Text))
                    {
                        client = new OrdinaryClient(textBox1.Text, textBox2.Text, true);
                    }
                    else client = new OrdinaryClient(textBox1.Text, textBox2.Text);
                }
                else
                {
                    if (dis.Contains(textBox4.Text))
                    {
                        client = new Pensioners(textBox1.Text, textBox2.Text, true);
                    }
                    else client = new Pensioners(textBox1.Text, textBox2.Text);
                }
                list.Add(client);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ListClients listClients = new ListClients(list);
            listClients.Show();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
