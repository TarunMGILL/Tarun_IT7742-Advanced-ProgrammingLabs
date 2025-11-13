using System;
using System.Globalization;
using System.Windows.Forms;
using BankingAccountApp;

namespace BankingAppForm
{
    public partial class Form1 : Form
    {
        private Customer cust;
        private EverydayAccount everyday;
        private InvestmentAccount invest;
        private OmniAccount omni;

        public Form1()
        {
            InitializeComponent();
            cust = new Customer(501, "Arjun Patel", "arjun@example.com", true);
            everyday = new EverydayAccount(101, 800m);
            invest = new InvestmentAccount(102, 1500m, 5m, 20m);
            omni = new OmniAccount(103, 1200m, 3m, 100m, 10m);
            ddlAccount.SelectedIndex = 0;
        }

        private Account CurrentAccount()
        {
            if (ddlAccount.SelectedIndex == 0) return everyday;
            if (ddlAccount.SelectedIndex == 1) return invest;
            return omni;
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(amountBox.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out var amt))
            {
                CurrentAccount().Deposit(amt);
                logBox.Items.Add(CurrentAccount().Last());
            }
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(amountBox.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out var amt))
            {
                CurrentAccount().Withdraw(amt, cust.IsStaff());
                logBox.Items.Add(CurrentAccount().Last());
            }
        }

        private void interestBtn_Click(object sender, EventArgs e)
        {
            CurrentAccount().CalculateInterest();
            logBox.Items.Add(CurrentAccount().Last());
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            var a = CurrentAccount();
            logBox.Items.Add("Account " + a.GetAccountID() + " | Balance: " + a.GetBalance().ToString("0.00"));
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            logBox.Items.Clear();
        }
    }
}
