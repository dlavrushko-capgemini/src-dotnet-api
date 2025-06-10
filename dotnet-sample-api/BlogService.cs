using System;
using System.Linq;
using System.Collections.Generic;

namespace DotnetSampleApi;

public class BlogService
{
    private const int FetchCount = 5;

    private readonly List<Blog> _blogs = new List<Blog>();

    public IEnumerable<Blog> GetBlogs()
    {
        return _blogs.Take(FetchCount).ToList();
    }
}

public class PostsService
{
    private readonly List<Post> _posts = new List<Post>();

    public IEnumerable<Post> GetPosts()
    {
        return _posts;
    }
}