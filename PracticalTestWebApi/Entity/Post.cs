using System;

namespace PracticalTestWebApi.Entity
{
    public class Post
    {
        public long PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long UserId { get; set; }
        public DateTime CreationDtTm { get; set; }
        public DateTime LastUpdateDtTm { get; set; }
    }
}