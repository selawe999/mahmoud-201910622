public class Discount
{
    public int DiscountID { get; set; }
    public string Description { get; set; }
    public decimal DiscountPercentage { get; set; }
    public DateTime ValidFrom { get; set; }
    public DateTime ValidTo { get; set; }
}