using System;

namespace PracticalTestWebApi.Entity
{
    public class Vote
    {
        public long VoteId { get; set; }
        public long CommentId { get; set; }
        public long UserId { get; set; }
        public int LikeOrDislike { get; set; }
        public DateTime CreationDtTm { get; set; }
        public DateTime LastUpdateDtTm { get; set; }
    }
}