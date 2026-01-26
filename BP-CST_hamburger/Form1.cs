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

        private void Form1_Load(object sender, EventArgs e)
        {
            Felhasznalok felhasznalok = new Felhasznalok();
            felhasznalok.felhasznalok.Add("Akciós Áron", new List<string> { "5555 5555 5555 4444", "1992.04.18", "482" });
            felhasznalok.felhasznalok.Add("Béres Bence", new List<string> { "4444 4444 4444 3333", "1988.11.30", "123" });
            felhasznalok.felhasznalok.Add("Cseresznye Csilla", new List<string> { "3333 3333 3333 2222", "1995.07.22", "987" });
        }
    }
}

class Felhasznalok
{

    public Dictionary<string, List<string>> felhasznalok = new Dictionary<string, List<string>>();

    public double kard_balance1 = new Random().Next(500, 142001); //500 és 142000 Ft között véletlenszerűen generált összeg
    public double kard_balance2 = new Random().Next(500, 142001);
    public double kard_balance3 = new Random().Next(500, 142001);
}