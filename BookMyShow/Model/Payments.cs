using BookMyShow.Enum;

namespace BookMyShow.Model
{
    public class Payments : Auditable
    {
        public PaymentStatus Status { get; set; }
        public PaymentType Type { get; set; }
        public float Amount { get; set; }
        public PaymentProvide Provider { get; set; }
        public string ReferenceID { get; set; }
        public int TicketId { get; set; }
        public int PaymentStatusId { get; set; }
        public int PaymentTypeId { get; set; }
        public int PaymentProvideId { get; set; }
    }
}