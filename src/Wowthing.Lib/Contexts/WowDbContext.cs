﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Wowthing.Lib.Models;
using Wowthing.Lib.Models.Query;

namespace Wowthing.Lib.Contexts
{
    public class WowDbContext : IdentityDbContext<ApplicationUser, IdentityRole<long>, long>
    {
        private readonly string _connectionString;

        public DbSet<WowClass> WowClass { get; set; }
        public DbSet<WowRace> WowRace { get; set; }
        public DbSet<WowRealm> WowRealm { get; set; }
        public DbSet<WowTitle> WowTitle { get; set; }

        public DbSet<PlayerAccount> PlayerAccount { get; set; }
        public DbSet<PlayerCharacter> PlayerCharacter { get; set; }

        // Garbage query types
        public DbSet<SchedulerCharacterQuery> SchedulerCharacterQuery { get; set; }

        public WowDbContext(string connectionString)
            : base()
        {
            _connectionString = connectionString;
        }

        public WowDbContext(DbContextOptions<WowDbContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(_connectionString);
            }
            optionsBuilder.UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().ToTable("asp_net_users");
            builder.Entity<IdentityUserToken<long>>().ToTable("asp_net_user_tokens");
            builder.Entity<IdentityUserLogin<long>>().ToTable("asp_net_user_logins");
            builder.Entity<IdentityUserClaim<long>>().ToTable("asp_net_user_claims");
            builder.Entity<IdentityRole>().ToTable("asp_net_roles");
            builder.Entity<IdentityUserRole<long>>().ToTable("asp_net_user_roles");
            builder.Entity<IdentityRoleClaim<long>>().ToTable("asp_net_role_claims");

            // Update WowCharacter table if related WowAccount is deleted
            builder.Entity<PlayerCharacter>()
                .HasOne(c => c.Account)
                .WithMany(a => a.Characters)
                .OnDelete(DeleteBehavior.SetNull);

            // Query types have no keys
            builder.Entity<SchedulerCharacterQuery>()
                .HasNoKey();
        }

        public NpgsqlConnection GetConnection() => (NpgsqlConnection)Database.GetDbConnection();
    }
}
