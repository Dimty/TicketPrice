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
    public partial class ListClients : Form
    {
        private int actionClient;
        List<Client> list = new List<Client>();
        GroupBox groupBox = new GroupBox();
        public ListClients(List<Client> list)
        {
            this.list = list;
            Fill(list);
            InitializeComponent();
            groupBox.Location = new Point(12, 12);
            groupBox.Size = new Size(284, 379);
            this.Controls.Add(groupBox);
        }
        private void Fill(List<Client> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Button button = new Button();
                button.Size = new Size(200,30);
                button.Location = new Point(10, 30 * i + 10);
                button.Text = list[i].firstName + " " + list[i].secondName + " " + list[i].GetPrice().ToString();
                button.Click += MClick;
                button.Show();
                groupBox.Controls.Add(button);
            }
        }

        private void MClick(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text.Substring(0, ((Button)sender).Text.IndexOf(' '));
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].firstName == text)
                {
                    actionClient = i;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" || textBox2.Text!="" || (checkBox1.Checked != false &&checkBox2.Checked!=false &&checkBox2.Checked!=false))
            {
                Client client;
                if (checkBox1.Checked == true)
                {
                    client = new Student(textBox1.Text, textBox2.Text);
                }
                else if(checkBox2.Checked==true)
                {
                    client = new OrdinaryClient(textBox1.Text, textBox2.Text);
                }
                else
                {
                    client = new Pensioners(textBox1.Text, textBox2.Text);
                }
                list[actionClient] = client;
                groupBox.Controls.Clear();
                Fill(list);
            }
        }
    }
}
