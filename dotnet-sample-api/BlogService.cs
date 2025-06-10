using System;
using System.Linq;
using System.Collections.Generic;

namespace DotnetSampleApi;

public interface IBlogService
{
    IEnumerable<Blog> GetBlogs();
    Blog? GetBlogById(int id);
}

public class BlogService : IBlogService
{
    private readonly List<Blog> _blogs = new List<Blog>();

    public IEnumerable<Blog> GetBlogs()
    {
        return _blogs;
    }

    public Blog? GetBlogById(int id)
    {
        return _blogs.FirstOrDefault(b => b.BlogId == id);
    }
}