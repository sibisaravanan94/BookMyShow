namespace BookMyShow.Models
{
    public class Payments : Auditable
    {
        public PaymentStatus Status { get; set; }
        public PaymentType Type { get; set; }
        public float Amount { get; set; }
        public PaymentProvide Provider { get; set; }
        public string ReferenceID { get; set; }
    }
}