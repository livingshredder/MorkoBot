﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MorkoBotRavenEdition.Services;

namespace MorkoBotRavenEdition.Migrations
{
    [DbContext(typeof(BotDbContext))]
    [Migration("20180520132132_VanityRoles2")]
    partial class VanityRoles2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview2-30571")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MorkoBotRavenEdition.Models.ExtendedGuildInfo", b =>
                {
                    b.Property<decimal>("Identifier")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<string>("DefaultChannel");

                    b.Property<int>("IncrementCount");

                    b.Property<int>("IncrementTarget");

                    b.HasKey("Identifier");

                    b.ToTable("Guilds");
                });

            modelBuilder.Entity("MorkoBotRavenEdition.Models.UserProfile", b =>
                {
                    b.Property<decimal>("Identifier")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<int>("Experience");

                    b.Property<int>("ExperienceLevels");

                    b.Property<int>("ExperienceTarget");

                    b.Property<decimal>("GuildIdentifier")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<int>("Health");

                    b.Property<int>("IncrementCount");

                    b.Property<DateTime>("LastIncremented");

                    b.Property<int>("OpenSewerTokens");

                    b.HasKey("Identifier");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("MorkoBotRavenEdition.Models.UserWarning", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DaysExpiry");

                    b.Property<string>("Reason");

                    b.Property<DateTime>("TimeAdded");

                    b.Property<decimal>("UserId")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.HasKey("Id");

                    b.ToTable("UserWarnings");
                });

            modelBuilder.Entity("MorkoBotRavenEdition.Models.VanityRole", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<decimal>("Guild")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<string>("Name");

                    b.Property<string>("_RestrictionLevel");

                    b.HasKey("Id");

                    b.ToTable("VanityRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
