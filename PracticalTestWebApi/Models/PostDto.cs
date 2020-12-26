using PracticalTestWebApi.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace PracticalTestWebApi.Models
{
    public class PostDto
    {
        public long PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long UserId { get; set; }
        public DateTime CreationDtTm { get; set; }
        public DateTime LastUpdateDtTm { get; set; }

        public static PostDto CreatePostDto(Post post)
        {
            return new PostDto()
            {
                PostId = post.PostId,
                Title = post.Title,
                Description = post.Description,
                UserId = post.UserId,
                CreationDtTm = post.CreationDtTm,
                LastUpdateDtTm = post.LastUpdateDtTm,
            };
        }
    }
}