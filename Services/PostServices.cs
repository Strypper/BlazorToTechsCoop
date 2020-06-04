using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToTechsDotNet.Database;

namespace ToTechsDotNet.Data{
    public class PostServices{
        private readonly AppDbContext _db;
        public PostServices(AppDbContext db){
            this._db = db;
        }
        public async Task<List<Post>> GetPost(string type){
            var blogs = await _db.Posts.Where(s => s.Type == type).ToListAsync();
            return blogs;
        }

        public async Task<string> Create(Post post)
        {
            post.UploadDate = DateTime.Now;
            _db.Posts.Add(post);
            await _db.SaveChangesAsync();
            return "Save Successfully";
        }
    }
}