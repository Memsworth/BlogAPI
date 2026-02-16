namespace BlogApi.Web.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public DateTime CreatedDate { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set;  }
    public List<Comment> Comments { get; } = new List<Comment>();
}
