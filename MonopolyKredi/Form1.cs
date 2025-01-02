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
        int[] balance = new int[6];
        string remitter,beneficiary;
        int rent;
        public main_page()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void main_page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < balance.Length; i++)
            {
                balance[i] = 15000000;
            }
            update_all_balance();
        }

        private void airplane_pay(object sender, EventArgs e)
        {
            give_salary(ref balance[0]);
            update_balance(balance[0], airplane_balance_text);
        }

        private void hamburger_pay(object sender, EventArgs e)
        {
            give_salary(ref balance[1]);
            update_balance(balance[1], hamburger_balance_text);
        }

        private void skateboard_pay(object sender, EventArgs e)
        {
            give_salary(ref balance[2]);
            update_balance(balance[2], skateboard_balance_text);
        }

        private void formula_pay(object sender, EventArgs e)
        {
            give_salary(ref balance[3]);
            update_balance(balance[3], formula_balance_text);
        }

        private void skate_pay(object sender, EventArgs e)
        {
            give_salary(ref balance[4]);
            update_balance(balance[4], skate_balance_text);
        }

        private void telephone_pay(object sender, EventArgs e)
        {
            give_salary(ref balance[5]);
            update_balance(balance[5], telephone_balance_text);
        }
        private void give_salary(ref int maas)
        {
            maas += 2000000;
        }
        private void update_balance(int bakiye, Label bakiye_text)
        {
            if (bakiye < 0) {
                bakiye_text.Text = "***İFLAS***";
            }
            else
            {
                bakiye_text.Text = bakiye.ToString("$###,###,###");
            }
        }
        private void update_all_balance()
        {
            if (balance[0] < 0) {
                airplane_balance_text.Text = "***İFLAS***";
            }
            else
            {
                airplane_balance_text.Text = balance[0].ToString("$###,###,###");
            }
            hamburger_balance_text.Text = balance[1].ToString("$###,###,###");
            skateboard_balance_text.Text = balance[2].ToString("$###,###,###");
            formula_balance_text.Text = balance[3].ToString("$###,###,###");
            skate_balance_text.Text = balance[4].ToString("$###,###,###");
            telephone_balance_text.Text = balance[5].ToString("$###,###,###");
        }
        private void reset_balance(object sender, EventArgs e)
        {
            for (int i = 0; i < balance.Length; i++)
            {
                balance[i] = 15000000;
            }
            update_all_balance();
        }
        private void reset_players(object sender, EventArgs e)
        {
            remitter_cb.Items.Clear();
            beneficiary_cb.Items.Clear();
        }

        private void gonderen_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.remitter = remitter_cb.Text;
        }

        private void alan_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            beneficiary = beneficiary_cb.Text;
        }

        private void rent_payment(object sender, EventArgs e)
        {
            try
            {
                rent = int.Parse(deduction.Text);
            }
            catch 
            {
                MessageBox.Show("Takas edilecek miktar gir");
            }
            rent_payment_control();
            update_all_balance();
        }

        private void Deduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void save_players(object sender, EventArgs e)
        {
            if (airplane_player.Text != "" && !remitter_cb.Items.Contains(airplane_player.Text) && !beneficiary_cb.Items.Contains(airplane_player.Text))
            {
                remitter_cb.Items.Add(airplane_player.Text);
                beneficiary_cb.Items.Add(airplane_player.Text);
            }
            if (hamburger_player.Text != "" && !remitter_cb.Items.Contains(hamburger_player.Text) && !beneficiary_cb.Items.Contains(hamburger_player.Text))
            {
                remitter_cb.Items.Add(hamburger_player.Text);
                beneficiary_cb.Items.Add(hamburger_player.Text);
            }
            if (skateboard_player.Text != "" && !remitter_cb.Items.Contains(skateboard_player.Text) && !beneficiary_cb.Items.Contains(skateboard_player.Text))
            {
                remitter_cb.Items.Add(skateboard_player.Text);
                beneficiary_cb.Items.Add(skateboard_player.Text);
            }
            if (formula_player.Text != "" && !remitter_cb.Items.Contains(formula_player.Text) && !beneficiary_cb.Items.Contains(formula_player.Text))
            {
                remitter_cb.Items.Add(formula_player.Text);
                beneficiary_cb.Items.Add(formula_player.Text);
            }
            if (skate_player.Text != "" && !remitter_cb.Items.Contains(skate_player.Text) && !beneficiary_cb.Items.Contains(skate_player.Text))
            {
                remitter_cb.Items.Add(skate_player.Text);
                beneficiary_cb.Items.Add(skate_player.Text);
            }
            if (telephone_player.Text != "" && !remitter_cb.Items.Contains(telephone_player.Text) && !beneficiary_cb.Items.Contains(telephone_player.Text))
            {
                remitter_cb.Items.Add(telephone_player.Text);
                beneficiary_cb.Items.Add(telephone_player.Text);
            }
        }

        private void rent_payment_control()
        {
            if (remitter == airplane_player.Text)
            {
                switch (beneficiary)
                {
                    case string beneficiaryName when beneficiaryName == hamburger_player.Text:
                        balance[0] -= rent;
                        balance[1] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == skateboard_player.Text:
                        balance[0] -= rent;
                        balance[2] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == formula_player.Text:
                        balance[0] -= rent;
                        balance[3] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == skate_player.Text:
                        balance[0] -= rent;
                        balance[4] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == telephone_player.Text:
                        balance[0] -= rent;
                        balance[5] += rent;
                        break;
                }
            }
            else if (remitter == hamburger_player.Text)
            {
                switch (beneficiary)
                {
                    case string beneficiaryName when beneficiaryName == airplane_player.Text:
                        balance[1] -= rent;
                        balance[0] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == skateboard_player.Text:
                        balance[1] -= rent;
                        balance[2] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == formula_player.Text:
                        balance[1] -= rent;
                        balance[3] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == skate_player.Text:
                        balance[1] -= rent;
                        balance[4] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == telephone_player.Text:
                        balance[1] -= rent;
                        balance[5] += rent;
                        break;
                }
            }
            else if (remitter == skateboard_player.Text)
            {
                switch (beneficiary)
                {
                    case string beneficiaryName when beneficiaryName == airplane_player.Text:
                        balance[2] -= rent;
                        balance[0] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == hamburger_player.Text:
                        balance[2] -= rent;
                        balance[1] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == formula_player.Text:
                        balance[2] -= rent;
                        balance[3] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == skate_player.Text:
                        balance[2] -= rent;
                        balance[4] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == telephone_player.Text:
                        balance[2] -= rent;
                        balance[5] += rent;
                        break;
                }
            }
            else if (remitter == formula_player.Text)
            {
                switch (beneficiary)
                {
                    case string beneficiaryName when beneficiaryName == airplane_player.Text:
                        balance[3] -= rent;
                        balance[0] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == hamburger_player.Text:
                        balance[3] -= rent;
                        balance[1] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == skateboard_player.Text:
                        balance[3] -= rent;
                        balance[2] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == skate_player.Text:
                        balance[3] -= rent;
                        balance[4] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == telephone_player.Text:
                        balance[3] -= rent;
                        balance[5] += rent;
                        break;
                }
            }
            else if (remitter == skate_player.Text)
            {
                switch (beneficiary)
                {
                    case string beneficiaryName when beneficiaryName == airplane_player.Text:
                        balance[4] -= rent;
                        balance[0] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == hamburger_player.Text:
                        balance[4] -= rent;
                        balance[1] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == skateboard_player.Text:
                        balance[4] -= rent;
                        balance[2] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == formula_player.Text:
                        balance[4] -= rent;
                        balance[3] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == telephone_player.Text:
                        balance[4] -= rent;
                        balance[5] += rent;
                        break;
                }
            }
            else if (remitter == telephone_player.Text)
            {
                switch (beneficiary)
                {
                    case string beneficiaryName when beneficiaryName == airplane_player.Text:
                        balance[5] -= rent;
                        balance[0] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == hamburger_player.Text:
                        balance[5] -= rent;
                        balance[1] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == skateboard_player.Text:
                        balance[5] -= rent;
                        balance[2] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == formula_player.Text:
                        balance[5] -= rent;
                        balance[3] += rent;
                        break;
                    case string beneficiaryName when beneficiaryName == skate_player.Text:
                        balance[5] -= rent;
                        balance[4] += rent;
                        break;
                }
            }
        }
    }
}
