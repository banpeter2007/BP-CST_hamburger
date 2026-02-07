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
            mustarBox_CheckedChanged(sender, e); // <<< EZ HIÁNYZOTT
        }

        Felhasznalok felhasznalok = new Felhasznalok(); // <<< EZ HIÁNYZOTT

        Hamburgerek hamburgerek = new Hamburgerek(); // <<< EZ HIÁNYZOTT

        class Felhasznalok
        {
            public Dictionary<string, List<string>> felhasznalok = new Dictionary<string, List<string>>();

            private Dictionary<string, double> balances = new Dictionary<string, double>();

            public Felhasznalok()
            {
                // Felhasználók adatainak feltöltése
                felhasznalok.Add("Akciós Áron", new List<string> { "5555 5555 5555 4444", "2032.04.18", "482" });
                felhasznalok.Add("Béres Bence", new List<string> { "4444 4444 4444 3333", "2028.11.30", "123" });
                felhasznalok.Add("Cseresznye Csilla", new List<string> { "3333 3333 3333 2222", "2030.07.22", "987" });

                // Egyenlegek generálása
                Random rnd = new Random();
                balances["Akciós Áron"] = rnd.Next(500, 142001);
                balances["Béres Bence"] = rnd.Next(500, 142001);
                balances["Cseresznye Csilla"] = rnd.Next(500, 142001);
            }

            public double GetBalance(string name)
            {
                return balances[name];
            }
        }

        class Hamburgerek
        {
            public Dictionary<string, double> hamburgerek = new Dictionary<string, double>();
            public Hamburgerek()
            {
                hamburgerek.Add("Marhás Hamburger", 1490);
                hamburgerek.Add("Western Whopper", 1990);
                hamburgerek.Add("Smoky Grilled", 2490);
                hamburgerek.Add("Chicken Bacon", 1740);
                hamburgerek.Add("Chili Cheese Crispy Chicken", 1740);
                hamburgerek.Add("Deluxe Csirkemell szendvics", 2240);
            }
        }

        private void mustarBox_CheckedChanged(object sender, EventArgs e)
        {
            // Feltöltjük a listBox-ot a felhasználók neveivel
            foreach (var nev in felhasznalok.felhasznalok.Keys) { listBox1.Items.Add(nev); }
            // Automatikusan kijelöljük az első elemet
            listBox1.SelectedIndex = 0;
            //ListBox2 feltöltése a hamburgerek neveivel
            foreach (var hamburger in new Hamburgerek().hamburgerek.Keys) { listBox2.Items.Add(hamburger); }
            listBox2.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUser = listBox1.SelectedItem as string;

            if (selectedUser != null && felhasznalok.felhasznalok.ContainsKey(selectedUser))
            {
                List<string> userData = felhasznalok.felhasznalok[selectedUser];
                szam.Text = userData[0]; // Kártyaszám
                ido.Text = userData[1]; // Születési dátum
                kod.Text = userData[2]; // CVV
                double balance = felhasznalok.GetBalance(selectedUser);
                //egyenleg.Text = balance.ToString("N0") + " Ft";
            }
        }

        public string selectedHamburger { get; set; }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedHamburger = listBox2.SelectedItem as string;
            if (selectedHamburger != null && hamburgerek.hamburgerek.ContainsKey(selectedHamburger))
            {
                double price = hamburgerek.hamburgerek[selectedHamburger];
                if (selectedHamburger == "Marhás Hamburger")
                {
                    marhaBox.Checked = false;
                    csirkeBox.Checked = false;
                    paraBox.Checked = false;
                    salátaBox.Checked = false;
                    majonezBo.Checked = false;
                    hagymaBox.Checked = false;
                    bbqBox.Checked = false;
                    baconBox.Checked = false;
                    ketchupBox.Checked = false;
                    mustarBox.Checked = false;
                    uborkaBox.Checked = false;
                    jalapenoBox.Checked = false;
                    cheddarBox.Checked = false;
                    mozzarellaBox.Checked = false;

                    marhaBox.Checked = true;
                    ketchupBox.Checked = true;
                    mustarBox.Checked = true;
                    uborkaBox.Checked = true;

                    hamburger_ara.Text = price.ToString("N0") + " Ft";
                    burgerkepek.Image = Properties.Resources.marhas_hamburger;
                }
                else if (selectedHamburger == "Western Whopper")
                {
                    marhaBox.Checked = false;
                    csirkeBox.Checked = false;
                    paraBox.Checked = false;
                    salátaBox.Checked = false;
                    majonezBo.Checked = false;
                    hagymaBox.Checked = false;
                    bbqBox.Checked = false;
                    baconBox.Checked = false;
                    ketchupBox.Checked = false;
                    mustarBox.Checked = false;
                    uborkaBox.Checked = false;
                    jalapenoBox.Checked = false;
                    cheddarBox.Checked = false;
                    mozzarellaBox.Checked = false;

                    marhaBox.Checked = true;
                    paraBox.Checked = true;
                    salátaBox.Checked = true;
                    majonezBo.Checked = true;
                    hagymaBox.Checked = true;
                    bbqBox.Checked = true;
                    baconBox.Checked = true;
                    uborkaBox.Checked = true;

                    hamburger_ara.Text = price.ToString("N0") + " Ft";
                    burgerkepek.Image = Properties.Resources.western_whopper;
                }
                else if (selectedHamburger == "Smoky Grilled")
                {
                    marhaBox.Checked = false;
                    csirkeBox.Checked = false;
                    paraBox.Checked = false;
                    salátaBox.Checked = false;
                    majonezBo.Checked = false;
                    hagymaBox.Checked = false;
                    bbqBox.Checked = false;
                    baconBox.Checked = false;
                    ketchupBox.Checked = false;
                    mustarBox.Checked = false;
                    uborkaBox.Checked = false;
                    jalapenoBox.Checked = false;
                    cheddarBox.Checked = false;
                    mozzarellaBox.Checked = false;

                    mustarBox.Checked = true;
                    hagymaBox.Checked = true;
                    salátaBox.Checked = true;
                    paraBox.Checked = true;
                    marhaBox.Checked = true;
                    bbqBox.Checked = true;
                    baconBox.Checked = true;
                    cheddarBox.Checked = true;

                    hamburger_ara.Text = price.ToString("N0") + " Ft";
                    burgerkepek.Image = Properties.Resources.smoky_grilled;
                }
                else if (selectedHamburger == "Chicken Bacon")
                {
                    marhaBox.Checked = false;
                    csirkeBox.Checked = false;
                    paraBox.Checked = false;
                    salátaBox.Checked = false;
                    majonezBo.Checked = false;
                    hagymaBox.Checked = false;
                    bbqBox.Checked = false;
                    baconBox.Checked = false;
                    ketchupBox.Checked = false;
                    mustarBox.Checked = false;
                    uborkaBox.Checked = false;
                    jalapenoBox.Checked = false;
                    cheddarBox.Checked = false;
                    mozzarellaBox.Checked = false;

                    csirkeBox.Checked = true;
                    baconBox.Checked = true;
                    ketchupBox.Checked = true;
                    mozzarellaBox.Checked = true;
                    majonezBo.Checked = true;

                    hamburger_ara.Text = price.ToString("N0") + " Ft";
                    burgerkepek.Image = Properties.Resources.chicken_bacon_king;
                }
                else if (selectedHamburger == "Chili Cheese Crispy Chicken")
                {
                    marhaBox.Checked = false;
                    csirkeBox.Checked = false;
                    paraBox.Checked = false;
                    salátaBox.Checked = false;
                    majonezBo.Checked = false;
                    hagymaBox.Checked = false;
                    bbqBox.Checked = false;
                    baconBox.Checked = false;
                    ketchupBox.Checked = false;
                    mustarBox.Checked = false;
                    uborkaBox.Checked = false;
                    jalapenoBox.Checked = false;
                    cheddarBox.Checked = false;
                    mozzarellaBox.Checked = false;

                    csirkeBox.Checked = true;
                    jalapenoBox.Checked = true;
                    cheddarBox.Checked = true;

                    hamburger_ara.Text = price.ToString("N0") + " Ft";
                    burgerkepek.Image = Properties.Resources.chili_cheese_crispy_chicken;
                }
                else if (selectedHamburger == "Deluxe Csirkemell szendvics")
                {
                    marhaBox.Checked = false;
                    csirkeBox.Checked = false;
                    paraBox.Checked = false;
                    salátaBox.Checked = false;
                    majonezBo.Checked = false;
                    hagymaBox.Checked = false;
                    bbqBox.Checked = false;
                    baconBox.Checked = false;
                    ketchupBox.Checked = false;
                    mustarBox.Checked = false;
                    uborkaBox.Checked = false;
                    jalapenoBox.Checked = false;
                    cheddarBox.Checked = false;
                    mozzarellaBox.Checked = false;

                    csirkeBox.Checked = true;
                    paraBox.Checked = true;
                    majonezBo.Checked = true;
                    salátaBox.Checked = true;

                    hamburger_ara.Text = price.ToString("N0") + " Ft";
                    burgerkepek.Image = Properties.Resources.deluxe_csirkemell_szendvics;
                }
            }
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
        private void hozaad_Click(object sender, EventArgs e)
        {
            double vegosszeg = 0; // Ha már volt korábbi összeg, akkor azt beolvassuk
            double.TryParse(osszeg.Text.Replace(" Ft", ""), out vegosszeg);

            //Írjuk ki mit adott hozzá a rendeléshez
            string selectedHamburger = listBox2.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedHamburger))
            {
                MessageBox.Show($"Hozzáadva a rendeléshez: {hamburger_ara.Text}");
                // Csak egyszer adjuk hozzá az árat
                vegosszeg += Convert.ToDouble(hamburger_ara.Text.Replace(" Ft", ""));
                osszeg.Text = vegosszeg.ToString("N0") + " Ft";
            }
        }

        private void megrendelesBtn_Click(object sender, EventArgs e)
        {
            //Ellenőrizzük, hogy van-e elég egyenleg a rendeléshez a kiválasztott felhasználónál és vonjuk le az összeget
            string selectedUser = listBox1.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedUser)) {
                double balance = felhasznalok.GetBalance(selectedUser);
                double orderAmount = 0;
                double.TryParse(osszeg.Text.Replace(" Ft", ""), out orderAmount);
                if (balance >= orderAmount)
                {
                    if (orderAmount <= 0)
                    {
                        MessageBox.Show("Nincs semmi a rendelésben! Kérem adjon hozzá legalább egy hamburgert a rendeléshez!");
                    }
                    else
                    {
                        // Levonjuk az összeget a felhasználó egyenlegéből
                        double newBalance = balance - orderAmount;
                        MessageBox.Show($"Rendelés sikeres!");          //Maradék egyenleg: {newBalance.ToString("N0")} Ft
                        this.Close(); // Bezárjuk a formot a rendelés után
                    }
                }
                else
                {
                    MessageBox.Show("Nincs elég egyenleg a rendeléshez! Rendelését töröltük! Térjen vissza hozzánk és rendeljen kevesebb összegért!");
                    //Bezárjuk a formot, hogy újra kelljen indítani a rendelést
                    this.Close();
                }
            }
        }
    }
}
