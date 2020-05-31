﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MorkoBotRavenEdition.Services;

namespace MorkoBotRavenEdition.Migrations
{
    [DbContext(typeof(BotDbContext))]
    [Migration("20200308210126_AddDeleted")]
    partial class AddDeleted
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MorkoBotRavenEdition.Models.Guild.ExtendedGuildInfo", b =>
                {
                    b.Property<long>("Identifier")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DefaultChannel");

                    b.Property<int>("IncrementCount");

                    b.Property<int>("IncrementTarget");

                    b.HasKey("Identifier");

                    b.ToTable("Guilds");
                });

            modelBuilder.Entity("MorkoBotRavenEdition.Models.Guild.LoggedMessage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Author");

                    b.Property<long>("Channel");

                    b.Property<string>("Content");

                    b.Property<bool>("Deleted");

                    b.Property<long>("Guild");

                    b.Property<long>("Message");

                    b.Property<long>("OriginalId");

                    b.Property<DateTimeOffset>("TimeStamp");

                    b.HasKey("Id");

                    b.ToTable("LoggedMessages");
                });

            modelBuilder.Entity("MorkoBotRavenEdition.Models.Infra.InfraCompetitionEntry", b =>
                {
                    b.Property<long>("Identifier")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Deleted");

                    b.Property<DateTime>("Entered");

                    b.Property<string>("ImageUrl");

                    b.Property<long>("UserId");

                    b.Property<int>("Votes");

                    b.HasKey("Identifier");

                    b.ToTable("InfraCompetitionEntries");
                });

            modelBuilder.Entity("MorkoBotRavenEdition.Models.User.UserProfile", b =>
                {
                    b.Property<long>("Identifier")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Experience");

                    b.Property<int>("ExperienceLevels");

                    b.Property<int>("ExperienceTarget");

                    b.Property<long>("GuildIdentifier");

                    b.Property<int>("Health");

                    b.Property<int>("IncrementCount");

                    b.Property<DateTime>("LastIncremented");

                    b.Property<int>("OpenSewerTokens");

                    b.HasKey("Identifier");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("MorkoBotRavenEdition.Models.User.UserWarning", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DaysExpiry");

                    b.Property<long>("GuildIdentifier");

                    b.Property<string>("Reason");

                    b.Property<long>("StaffId");

                    b.Property<DateTime>("TimeAdded");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserWarnings");
                });

            modelBuilder.Entity("MorkoBotRavenEdition.Models.User.VanityRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Guild");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("VanityRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
