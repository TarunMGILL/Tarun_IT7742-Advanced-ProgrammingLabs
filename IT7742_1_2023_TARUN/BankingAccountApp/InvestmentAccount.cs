namespace BankingAccountApp
{
    public class InvestmentAccount : Account
    {
        public InvestmentAccount(int id, decimal opening, decimal rate, decimal fee)
            : base(id, opening, rate, 0m, fee) { }

        public override void CalculateInterest()
        {
            AddInterest(GetBalance() * (Rate() / 100m));
        }
    }
}
