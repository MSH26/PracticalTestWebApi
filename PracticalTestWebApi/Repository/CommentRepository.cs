using PracticalTestWebApi.Context;
using PracticalTestWebApi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticalTestWebApi.Repository
{
    public class CommentRepository
    {
        readonly DatabaseContext context = new DatabaseContext();

        public List<Comment> GetComments(long postId)
        {
            return context.Comments.Where(comment => comment.PostId == postId).ToList();
        }

        public Comment GetComment(long commentId)
        {
            return context.Comments.FirstOrDefault(comment => comment.CommentId == commentId);
        }
    }
}