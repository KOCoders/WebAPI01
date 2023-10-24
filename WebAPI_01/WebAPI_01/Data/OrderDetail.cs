namespace WebAPI_01.Data
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Guid ProductID { get; set; }
        public Guid OrderID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public byte Discount { get; set; }


        //relationship
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
