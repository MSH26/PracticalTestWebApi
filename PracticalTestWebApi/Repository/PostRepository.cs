using PracticalTestWebApi.Context;
using PracticalTestWebApi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticalTestWebApi.Repository
{
    public class PostRepository
    {
        readonly DatabaseContext context = new DatabaseContext();

        public Post GetPost(long postId)
        {
            return context.Posts.FirstOrDefault(post => post.PostId == postId);
        }
        public List<Post> GetAllPosts()
        {
            return context.Posts.ToList();
        }
        public List<Post> GetPostsByUser(long userId)
        {
            return context.Posts.Where(post => post.UserId == userId).ToList();
        }
        public List<Post> SearchPosts(string searchQuery)
        {
            return context.Posts.Where(post => post.Title.Contains(searchQuery) || post.Description.Contains(searchQuery)).ToList();
        }
    }
}