﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Whoaverse.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class whoaverseEntities : DbContext
    {
        public whoaverseEntities()
            : base("name=whoaverseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Commentvotingtracker> Commentvotingtrackers { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Votingtracker> Votingtrackers { get; set; }
        public virtual DbSet<Subverse> Subverses { get; set; }
        public virtual DbSet<Defaultsubverse> Defaultsubverses { get; set; }
        public virtual DbSet<SubverseAdmin> SubverseAdmins { get; set; }
        public virtual DbSet<Promotedsubmission> Promotedsubmissions { get; set; }
        public virtual DbSet<Savedsubmission> Savedsubmissions { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<Badge> Badges { get; set; }
        public virtual DbSet<Userbadge> Userbadges { get; set; }
        public virtual DbSet<Banneddomain> Banneddomains { get; set; }
        public virtual DbSet<Privatemessage> Privatemessages { get; set; }
        public virtual DbSet<Commentreplynotification> Commentreplynotifications { get; set; }
        public virtual DbSet<Postreplynotification> Postreplynotifications { get; set; }
        public virtual DbSet<Userpreference> Userpreferences { get; set; }
    }
}
