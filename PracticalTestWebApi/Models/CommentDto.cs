using PracticalTestWebApi.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace PracticalTestWebApi.Models
{
    public class CommentDto
    {
        public long CommentId { get; set; }
        public string Description { get; set; }
        public long PostId { get; set; }
        public long UserId { get; set; }
        public DateTime CreationDtTm { get; set; }
        public DateTime LastUpdateDtTm { get; set; }
        public long TotalLikeCount { get; set; }
        public long TotalDislikeCount { get; set; }

        public static CommentDto CreateCommentDto(Comment comment)
        {
            return new CommentDto()
            {
                CommentId = comment.CommentId,
                Description = comment.Description,
                PostId = comment.PostId,
                UserId = comment.UserId,
                CreationDtTm = comment.CreationDtTm,
                LastUpdateDtTm = comment.LastUpdateDtTm,
                TotalLikeCount = 0,
                TotalDislikeCount = 0
            };
        }
    }
}