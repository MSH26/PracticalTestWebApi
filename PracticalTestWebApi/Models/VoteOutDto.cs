using PracticalTestWebApi.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace PracticalTestWebApi.Models
{
    public class VoteOutDto
    {
        public long VoteId { get; set; }
        public long CommentId { get; set; }
        public long UserId { get; set; }
        public int LikeOrDislike { get; set; }
        public DateTime CreationDtTm { get; set; }
        public DateTime LastUpdateDtTm { get; set; }

        public static VoteOutDto CreateVoteOutDto(Vote vote)
        {
            return new VoteOutDto()
            {
                VoteId = vote.VoteId,
                CommentId = vote.CommentId,
                UserId = vote.UserId,
                LikeOrDislike = vote.LikeOrDislike,
                CreationDtTm = vote.CreationDtTm,
                LastUpdateDtTm = vote.LastUpdateDtTm,
            };
        }
    }
}