using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_CST_hamburger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Felhasznalok felhasznalok = new Felhasznalok();
            felhasznalok.felhasznalok.Add("Akciós Áron", new List<string> { "5555 5555 5555 4444", "1992.04.18", "482" });
            felhasznalok.felhasznalok.Add("Béres Bence", new List<string> { "4444 4444 4444 3333", "1988.11.30", "123" });
            felhasznalok.felhasznalok.Add("Cseresznye Csilla", new List<string> { "3333 3333 3333 2222", "1995.07.22", "987" });
        }

        class Felhasznalok
        {

            public Dictionary<string, List<string>> felhasznalok = new Dictionary<string, List<string>>();

            public double kard_balance1 = new Random().Next(500, 142001); //500 és 142000 Ft között véletlenszerűen generált összeg
            public double kard_balance2 = new Random().Next(500, 142001);
            public double kard_balance3 = new Random().Next(500, 142001);
        }

        private void mustarBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chedarBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mozzarellaBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }
    }
}
