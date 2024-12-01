using FullStackedInterview.Models.DB;

namespace FullStackedInterview.Services;

public class MyDbContextAlt
{
    public MyDbContextAlt()
    {

    }

    public IEnumerable<Item> Items = new List<Item>
    {
        new Item { Id = 1, Name = "Pen", Price    = 10 },
        new Item { Id = 2, Name = "Pencil", Price = 5 },
        new Item { Id = 3, Name = "Eraser", Price = 3 }
    };

    public IEnumerable<Cart> Carts = new List<Cart>();

    public IEnumerable<User> Users = new List<User>()
    {
        new User()
        {
            Id = 1,
            Name = "John Doe",
            Email = "aabbcc@g.com"
        }
    };
}
