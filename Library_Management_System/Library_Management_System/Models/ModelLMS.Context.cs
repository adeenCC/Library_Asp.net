﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_Management_System.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LMSEntities2 : DbContext
    {
        public LMSEntities2()
            : base("name=LMSEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<author> authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<member> members { get; set; }
        public virtual DbSet<publisher> publishers { get; set; }
    }
}