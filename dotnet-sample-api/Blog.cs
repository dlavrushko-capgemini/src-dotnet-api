namespace DotnetSampleApi;

public class Blog
{
    public int BlogId { get; set; }

    public List<Post> Posts { get; set; } = new List<Post>();
}
