namespace API.Entities
{
    public class Billing
    {
        public int Id { get; set; }
        public string ChargeDescription { get; set; }
        public decimal ChargeAmount { get; set; }
        public string PaymentDescription { get; set; }
        public decimal PaymentAmount { get; set; }
        public AppUser AppUser { get; set; }        
    }
}