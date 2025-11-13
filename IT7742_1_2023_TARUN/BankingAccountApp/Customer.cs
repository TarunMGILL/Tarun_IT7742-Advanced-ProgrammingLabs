namespace BankingAccountApp
{
    public class Customer
    {
        private int customerNumber;
        private string name;
        private string contact;
        private bool isStaff;

        public Customer(int num, string name, string contact, bool staff)
        {
            customerNumber = num;
            this.name = name;
            this.contact = contact;
            isStaff = staff;
        }

        public int GetCustomerNumber() => customerNumber;
        public string GetName() => name;
        public string GetContact() => contact;
        public void SetContact(string v) => contact = v;
        public bool IsStaff() => isStaff;
    }
}
