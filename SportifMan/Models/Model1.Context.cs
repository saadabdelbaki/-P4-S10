﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportifMan.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sportsEntities : DbContext
    {
        public sportsEntities()
            : base("name=sportsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CatégorieAge> CatégorieAge { get; set; }
        public virtual DbSet<Compétition> Compétition { get; set; }
        public virtual DbSet<Critère> Critère { get; set; }
        public virtual DbSet<Critére_santé> Critére_santé { get; set; }
        public virtual DbSet<Entitésportif> Entitésportif { get; set; }
        public virtual DbSet<Performance> Performance { get; set; }
        public virtual DbSet<Santéathléte> Santéathléte { get; set; }
        public virtual DbSet<Sport> Sport { get; set; }
        public virtual DbSet<TypeCompétition> TypeCompétition { get; set; }
        public virtual DbSet<Entitéathléte> Entitéathléte { get; set; }
        public virtual DbSet<Athléte> Athléte { get; set; }
    }
}