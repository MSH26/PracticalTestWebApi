using PracticalTestWebApi.Entity;
using System;
using System.Data.Entity;
using System.Linq;

namespace PracticalTestWebApi.Context
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<RelationShipBetweenComments> RelationShipBetweenComments { get; set; }

    }
}
