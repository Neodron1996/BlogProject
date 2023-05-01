﻿namespace BlogProject.Server.Models
{
    public class BlogPost
    {
        public int PostId { get; set; }

        public string PostUrl { get; set; }

        public string PostTitle { get; set; }

        public string PostContent { get; set; }

        public string PostDescription { get; set; }

        public string PostAuthor { get; set; }

        public DateTime PostDate { get; set; } = DateTime.Now;

        public bool IsPublished { get; set; } = true;

        public bool IsDeleted { get; set; } = false;
    }
}
