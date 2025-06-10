using System;
using System.Linq;
using System.Collections.Generic;

namespace DotnetSampleApi;

public interface IBlogService
{
    IEnumerable<Blog> GetBlogs();
}

public class BlogService : IBlogService
{
    private const int FetchCount = 5;

    private readonly List<Blog> _blogs = new List<Blog>();

    public IEnumerable<Blog> GetBlogs()
    {
        return _blogs.Take(FetchCount).ToList();
    }
}

public interface IPostsService
{
    IEnumerable<Post> GetPosts();
}

public class PostsService : IPostsService
{
    private const int FetchCount = 5;

    private readonly List<Post> _posts = new List<Post>();

    public IEnumerable<Post> GetPosts()
    {
        return _posts.Take(FetchCount).ToList();
    }
}