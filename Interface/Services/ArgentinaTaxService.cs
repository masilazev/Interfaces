namespace Interface.Services
{
    internal class ArgentinaTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.4;
            }
            else
            {
                return amount * 0.3;
            }
        }
    }
}
