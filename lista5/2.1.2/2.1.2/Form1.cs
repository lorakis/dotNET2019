using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Firmy.Items.Add("Samsung");
            Firmy.Items.Add("Huawei");
            Firmy.Items.Add("Xiaomi");
            Firmy.Items.Add("Oneplus");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Firmy.SelectedItem.ToString() == "Samsung")
            {
                Modele.Visible = true;
                Modele.Items.Clear();
                Modele.Items.Add("S20");
                Modele.Items.Add("S20 Ultra");
                Modele.Items.Add("A70");
                Modele.Items.Add("S10e");
               
            }
            if (Firmy.SelectedItem.ToString() == "Huawei")
            {
                Modele.Visible = true;
                Modele.Items.Clear();
                Modele.Items.Add("P40 Pro");
                Modele.Items.Add("P40");
                Modele.Items.Add("Mate30 Pro");
                Modele.Items.Add("P30");
            }
            if (Firmy.SelectedItem.ToString() == "Xiaomi")
            {
                Modele.Visible = true;
                Modele.Items.Clear();
                Modele.Items.Add("Mi 9");
                Modele.Items.Add("Mi Note 10");
                Modele.Items.Add("Redmi Note 9");
                Modele.Items.Add("Mi 10");
            }
            if (Firmy.SelectedItem.ToString() == "Oneplus")
            {
                Modele.Visible = true;
                Modele.Items.Clear();
                Modele.Items.Add("8");
                Modele.Items.Add("8 Pro");
                Modele.Items.Add("7T");
                Modele.Items.Add("7T Pro");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                Thread.Sleep(100);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.progressBar1.Value = 0;
            this.timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
