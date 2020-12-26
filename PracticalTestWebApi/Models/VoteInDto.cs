using PracticalTestWebApi.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace PracticalTestWebApi.Models
{
    public class VoteInDto
    {
        public long VoteId { get; set; }
        public long CommentId { get; set; }
        public long UserId { get; set; }
        public int LikeOrDislike { get; set; }
        public DateTime CreationDtTm { get; set; }
        public DateTime LastUpdateDtTm { get; set; }

        public static Vote CreateVote(VoteInDto voteInDto)
        {
            return new Vote()
            {
                VoteId = voteInDto.VoteId,
                CommentId = voteInDto.CommentId,
                UserId = voteInDto.UserId,
                LikeOrDislike = voteInDto.LikeOrDislike,
                CreationDtTm = voteInDto.CreationDtTm,
                LastUpdateDtTm = voteInDto.LastUpdateDtTm,
            };
        }
    }
}