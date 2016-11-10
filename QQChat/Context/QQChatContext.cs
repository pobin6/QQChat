namespace QQChat.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Model;

    public partial class QQChatContext : DbContext
    {
        public QQChatContext()
            : base("name=QQChatContext")
        {
        }

        public virtual DbSet<MESSAGE> MESSAGE { get; set; }
        public virtual DbSet<NOTICE> NOTICE { get; set; }
        public virtual DbSet<USER> USER { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<USER>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.MESSAGE)
                .WithRequired(e => e.USER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.NOTICE)
                .WithRequired(e => e.USER)
                .WillCascadeOnDelete(false);
        }
    }
}
