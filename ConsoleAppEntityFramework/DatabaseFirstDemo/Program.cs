using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DatabaseFirstDemoEntities();
            var post = new Post()
            {
                PostID = 2,
                Title = "Title",
                Body = "Body",
                DatePublished = DateTime.Now
            };
            context.Posts.Add(post);
            context.SaveChanges();

        }
    }
}
