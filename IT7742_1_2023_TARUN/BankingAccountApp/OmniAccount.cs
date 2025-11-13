namespace BankingAccountApp
{
    public class OmniAccount : Account
    {
        public OmniAccount(int id, decimal opening, decimal rate, decimal od, decimal fee)
            : base(id, opening, rate, od, fee) { }

        public override void CalculateInterest()
        {
            decimal eligible = GetBalance() > 1000 ? GetBalance() - 1000 : 0;
            AddInterest(eligible * (Rate() / 100m));
        }
    }
}
