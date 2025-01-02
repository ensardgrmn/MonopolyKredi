using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonopolyKredi
{
    public partial class main_page : Form
    {
        int[] bakiye = new int[6];
        string gonderen,alan;
        int kira;
        public main_page()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < bakiye.Length; i++)
            {
                bakiye[i] = 15000000;
            }
            tum_bakiye_guncelle();
        }

        private void maas_button1_Click(object sender, EventArgs e)
        {
            maas_ver(ref bakiye[0]);
            bakiye_guncelle(bakiye[0], ucak_bakiye_text);
        }

        private void maas_button2_Click(object sender, EventArgs e)
        {
            maas_ver(ref bakiye[1]);
            bakiye_guncelle(bakiye[1], hamburger_bakiye_text);
        }

        private void maas_button3_Click(object sender, EventArgs e)
        {
            maas_ver(ref bakiye[2]);
            bakiye_guncelle(bakiye[2], kaykay_bakiye_text);
        }

        private void maas_button4_Click(object sender, EventArgs e)
        {
            maas_ver(ref bakiye[3]);
            bakiye_guncelle(bakiye[3], formula_bakiye_text);
        }

        private void maas_button5_Click(object sender, EventArgs e)
        {
            maas_ver(ref bakiye[4]);
            bakiye_guncelle(bakiye[4], paten_bakiye_text);
        }

        private void maas_button6_Click(object sender, EventArgs e)
        {
            maas_ver(ref bakiye[5]);
            bakiye_guncelle(bakiye[5], telefon_bakiye_text);
        }
        private void maas_ver(ref int maas)
        {
            maas += 2000000;
        }
        private void bakiye_guncelle(int bakiye, Label bakiye_text)
        {
            if (bakiye < 0) {
                bakiye_text.Text = "***İFLAS***";
            }
            else
            {
                bakiye_text.Text = bakiye.ToString("$###,###,###");
            }
        }
        private void tum_bakiye_guncelle()
        {
            if (bakiye[0] < 0) {
                ucak_bakiye_text.Text = "***İFLAS***";
            }
            else
            {
                ucak_bakiye_text.Text = bakiye[0].ToString("$###,###,###");
            }
            hamburger_bakiye_text.Text = bakiye[1].ToString("$###,###,###");
            kaykay_bakiye_text.Text = bakiye[2].ToString("$###,###,###");
            formula_bakiye_text.Text = bakiye[3].ToString("$###,###,###");
            paten_bakiye_text.Text = bakiye[4].ToString("$###,###,###");
            telefon_bakiye_text.Text = bakiye[5].ToString("$###,###,###");
        }
        private void bakiye_sifirla(object sender, EventArgs e)
        {
            for (int i = 0; i < bakiye.Length; i++)
            {
                bakiye[i] = 15000000;
            }
            tum_bakiye_guncelle();
        }
        private void oyuncu_sifirla(object sender, EventArgs e)
        {
            gonderen_cb.Items.Clear();
            alan_cb.Items.Clear();
        }

        private void gonderen_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            gonderen = gonderen_cb.Text;
        }

        private void alan_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            alan = alan_cb.Text;
        }

        private void kira_ver(object sender, EventArgs e)
        {
            try
            {
                kira = int.Parse(dusulecek_miktar.Text);
            }
            catch 
            {
                MessageBox.Show("Takas edilecek miktar gir");
            }
            kira_gonderim_kontrol();
            tum_bakiye_guncelle();
        }

        private void dusulecek_miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void oyuncu_kaydet_Click(object sender, EventArgs e)
        {
            if (ucak_oyuncusu.Text != "" && !gonderen_cb.Items.Contains(ucak_oyuncusu.Text) && !alan_cb.Items.Contains(ucak_oyuncusu.Text))
            {
                gonderen_cb.Items.Add(ucak_oyuncusu.Text);
                alan_cb.Items.Add(ucak_oyuncusu.Text);
            }
            if (hamburger_oyuncusu.Text != "" && !gonderen_cb.Items.Contains(hamburger_oyuncusu.Text) && !alan_cb.Items.Contains(hamburger_oyuncusu.Text))
            {
                gonderen_cb.Items.Add(hamburger_oyuncusu.Text);
                alan_cb.Items.Add(hamburger_oyuncusu.Text);
            }
            if (kaykay_oyuncusu.Text != "" && !gonderen_cb.Items.Contains(kaykay_oyuncusu.Text) && !alan_cb.Items.Contains(kaykay_oyuncusu.Text))
            {
                gonderen_cb.Items.Add(kaykay_oyuncusu.Text);
                alan_cb.Items.Add(kaykay_oyuncusu.Text);
            }
            if (formula_oyuncusu.Text != "" && !gonderen_cb.Items.Contains(formula_oyuncusu.Text) && !alan_cb.Items.Contains(formula_oyuncusu.Text))
            {
                gonderen_cb.Items.Add(formula_oyuncusu.Text);
                alan_cb.Items.Add(formula_oyuncusu.Text);
            }
            if (paten_oyuncusu.Text != "" && !gonderen_cb.Items.Contains(paten_oyuncusu.Text) && !alan_cb.Items.Contains(paten_oyuncusu.Text))
            {
                gonderen_cb.Items.Add(paten_oyuncusu.Text);
                alan_cb.Items.Add(paten_oyuncusu.Text);
            }
            if (telefon_oyuncusu.Text != "" && !gonderen_cb.Items.Contains(telefon_oyuncusu.Text) && !alan_cb.Items.Contains(telefon_oyuncusu.Text))
            {
                gonderen_cb.Items.Add(telefon_oyuncusu.Text);
                alan_cb.Items.Add(telefon_oyuncusu.Text);
            }
        }

        private void kira_gonderim_kontrol()
        {
            if (gonderen == ucak_oyuncusu.Text)
            {
                switch (alan)
                {
                    case string alanadi when alanadi == hamburger_oyuncusu.Text:
                        bakiye[0] -= kira;
                        bakiye[1] += kira;
                        break;
                    case string alanadi when alanadi == kaykay_oyuncusu.Text:
                        bakiye[0] -= kira;
                        bakiye[2] += kira;
                        break;
                    case string alanadi when alanadi == formula_oyuncusu.Text:
                        bakiye[0] -= kira;
                        bakiye[3] += kira;
                        break;
                    case string alanadi when alanadi == paten_oyuncusu.Text:
                        bakiye[0] -= kira;
                        bakiye[4] += kira;
                        break;
                    case string alanadi when alanadi == telefon_oyuncusu.Text:
                        bakiye[0] -= kira;
                        bakiye[5] += kira;
                        break;
                }
            }
            else if (gonderen == hamburger_oyuncusu.Text)
            {
                switch (alan)
                {
                    case string alanadi when alanadi == ucak_oyuncusu.Text:
                        bakiye[1] -= kira;
                        bakiye[0] += kira;
                        break;
                    case string alanadi when alanadi == kaykay_oyuncusu.Text:
                        bakiye[1] -= kira;
                        bakiye[2] += kira;
                        break;
                    case string alanadi when alanadi == formula_oyuncusu.Text:
                        bakiye[1] -= kira;
                        bakiye[3] += kira;
                        break;
                    case string alanadi when alanadi == paten_oyuncusu.Text:
                        bakiye[1] -= kira;
                        bakiye[4] += kira;
                        break;
                    case string alanadi when alanadi == telefon_oyuncusu.Text:
                        bakiye[1] -= kira;
                        bakiye[5] += kira;
                        break;
                }
            }
            else if (gonderen == kaykay_oyuncusu.Text)
            {
                switch (alan)
                {
                    case string alanadi when alanadi == ucak_oyuncusu.Text:
                        bakiye[2] -= kira;
                        bakiye[0] += kira;
                        break;
                    case string alanadi when alanadi == hamburger_oyuncusu.Text:
                        bakiye[2] -= kira;
                        bakiye[1] += kira;
                        break;
                    case string alanadi when alanadi == formula_oyuncusu.Text:
                        bakiye[2] -= kira;
                        bakiye[3] += kira;
                        break;
                    case string alanadi when alanadi == paten_oyuncusu.Text:
                        bakiye[2] -= kira;
                        bakiye[4] += kira;
                        break;
                    case string alanadi when alanadi == telefon_oyuncusu.Text:
                        bakiye[2] -= kira;
                        bakiye[5] += kira;
                        break;
                }
            }
            else if (gonderen == formula_oyuncusu.Text)
            {
                switch (alan)
                {
                    case string alanadi when alanadi == ucak_oyuncusu.Text:
                        bakiye[3] -= kira;
                        bakiye[0] += kira;
                        break;
                    case string alanadi when alanadi == hamburger_oyuncusu.Text:
                        bakiye[3] -= kira;
                        bakiye[1] += kira;
                        break;
                    case string alanadi when alanadi == kaykay_oyuncusu.Text:
                        bakiye[3] -= kira;
                        bakiye[2] += kira;
                        break;
                    case string alanadi when alanadi == paten_oyuncusu.Text:
                        bakiye[3] -= kira;
                        bakiye[4] += kira;
                        break;
                    case string alanadi when alanadi == telefon_oyuncusu.Text:
                        bakiye[3] -= kira;
                        bakiye[5] += kira;
                        break;
                }
            }
            else if (gonderen == paten_oyuncusu.Text)
            {
                switch (alan)
                {
                    case string alanadi when alanadi == ucak_oyuncusu.Text:
                        bakiye[4] -= kira;
                        bakiye[0] += kira;
                        break;
                    case string alanadi when alanadi == hamburger_oyuncusu.Text:
                        bakiye[4] -= kira;
                        bakiye[1] += kira;
                        break;
                    case string alanadi when alanadi == kaykay_oyuncusu.Text:
                        bakiye[4] -= kira;
                        bakiye[2] += kira;
                        break;
                    case string alanadi when alanadi == formula_oyuncusu.Text:
                        bakiye[4] -= kira;
                        bakiye[3] += kira;
                        break;
                    case string alanadi when alanadi == telefon_oyuncusu.Text:
                        bakiye[4] -= kira;
                        bakiye[5] += kira;
                        break;
                }
            }
            else if (gonderen == telefon_oyuncusu.Text)
            {
                switch (alan)
                {
                    case string alanadi when alanadi == ucak_oyuncusu.Text:
                        bakiye[5] -= kira;
                        bakiye[0] += kira;
                        break;
                    case string alanadi when alanadi == hamburger_oyuncusu.Text:
                        bakiye[5] -= kira;
                        bakiye[1] += kira;
                        break;
                    case string alanadi when alanadi == kaykay_oyuncusu.Text:
                        bakiye[5] -= kira;
                        bakiye[2] += kira;
                        break;
                    case string alanadi when alanadi == formula_oyuncusu.Text:
                        bakiye[5] -= kira;
                        bakiye[3] += kira;
                        break;
                    case string alanadi when alanadi == paten_oyuncusu.Text:
                        bakiye[5] -= kira;
                        bakiye[4] += kira;
                        break;
                }
            }
        }
    }
}
