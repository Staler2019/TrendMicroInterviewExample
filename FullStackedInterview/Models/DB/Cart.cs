namespace FullStackedInterview.Models.DB;

public class Cart
{
    public int Id { get; set; }
    public int ItemId { get; set; }
    public int Count { get; set; }
    public int UserId { get; set; }
}
