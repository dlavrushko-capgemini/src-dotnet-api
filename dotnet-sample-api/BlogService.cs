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