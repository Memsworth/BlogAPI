namespace BlogApi.Web.Models;

public class Blog
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }

    public int BloggerId { get; set; }
    public Blogger Blogger { get; set; }

    public DateTime CreatedDate { get; set; }
    public List<Post> Posts { get; } = new List<Post>();
}
