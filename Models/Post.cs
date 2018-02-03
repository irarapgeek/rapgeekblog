using System;
namespace RapGeekBlog.Models
{
    public class Post
    {
        public int PostId
        {
            get;
            set;
        }

        public string PostTitle
        {
            get;
            set;
        }
        public string Body
        {
            get;
            set;
        }
        public int CategoryId
        {
            get;
            set;
        }
        public DateTime CreateDate
        {
            get;
            set;
        }
        public int AuthorId
        {
            get;
            set;
        }
    }
}
