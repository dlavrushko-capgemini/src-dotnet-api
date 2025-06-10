namespace DotnetSampleApi;

public class CommentsService
{
    private readonly List<Comment> _comments = new List<Comment>();

    public IEnumerable<Comment> GetComments()
    {
        return _comments;
    }
}