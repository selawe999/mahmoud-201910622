public class OrderItem
{
    public int OrderItemID { get; set; }
    public int OrderID { get; set; }
    public int ItemID { get; set; }
    public int Quantity { get; set; }
    public Order Order { get; set; }
    public MenuItem MenuItem { get; set; }
}