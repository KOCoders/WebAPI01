namespace WebAPI_01.Data
{
    public enum StatusOder
    {
        New =0,
        Payment = 1,
        Complete = 2,
        Cancel =-1
    }
    public class Order
    {
        public Guid ID { get; set; }
        public string Code { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public StatusOder Status { get; set; }
        public string Reciver { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }

    }
}
