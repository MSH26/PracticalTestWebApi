using System;

namespace PracticalTestWebApi.Entity
{
    public class RelationShipBetweenComments
    {
        public long RelationshipBetweenCommentsId { get; set; }
        public long CommentId { get; set; }
        public long RepliedCommentId { get; set; }
        public long MainCommentId { get; set; }
        public DateTime CreationDtTm { get; set; }
        public DateTime LastUpdateDtTm { get; set; }
    }
}