using System;
using System.ComponentModel.DataAnnotations;

namespace ToTechsDotNet.Data
{
    public class Post
    {
        [Key]
        public int DPostID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime UploadDate { get; set; }
        public string Type { get; set; }
    }
}
