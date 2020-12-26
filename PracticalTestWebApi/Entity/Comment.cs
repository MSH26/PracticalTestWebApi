using System;

namespace PracticalTestWebApi.Entity
{
    public class Comment
    {
        public long CommentId { get; set; }
        public string Description { get; set; }
        public long PostId { get; set; }
        public long UserId { get; set; }
        public DateTime CreationDtTm { get; set; }
        public DateTime LastUpdateDtTm { get; set; }
    }
}