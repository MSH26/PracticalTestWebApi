using PracticalTestWebApi.Context;
using PracticalTestWebApi.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PracticalTestWebApi.Repository
{
    public class VoteRepository
    {
        readonly DatabaseContext context = new DatabaseContext();

        public long GetTotalLikesCounts(long commentId)
        {
            return context.Votes.Where(vote => vote.CommentId == commentId && vote.LikeOrDislike == 1).ToList().Count;
        }

        public long GetTotalDislikesCounts(long commentId)
        {
            return context.Votes.Where(vote => vote.CommentId == commentId && vote.LikeOrDislike == 2).ToList().Count;
        }

        public Vote SaveVote(Vote newVote)
        {
            Vote voteToUpdate = context.Votes.FirstOrDefault(v => v.CommentId == newVote.CommentId && v.UserId == newVote.UserId);
            if (voteToUpdate == null)
            {
                context.Votes.Add(newVote);
            }
            else
            {
                if (voteToUpdate.LikeOrDislike == 1)
                {
                    voteToUpdate.LikeOrDislike = 2;
                }
                else if (voteToUpdate.LikeOrDislike == 2)
                {
                    voteToUpdate.LikeOrDislike = 1;
                }
                context.Entry(voteToUpdate).State = EntityState.Modified;
            }
            context.SaveChanges();
            return voteToUpdate;
        }
    }
}