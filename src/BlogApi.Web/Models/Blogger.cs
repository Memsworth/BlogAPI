namespace BlogApi.Web.Models;

public class Blogger : Account
{
    public List<Blog> Blogs { get; } = new List<Blog>();
}