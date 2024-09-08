﻿// <auto-generated />
using System;
using Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Core.Auth.Model.CharacterInfoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid>("AccountNumber")
                        .HasColumnType("uuid");

                    b.Property<long>("BountyPoints")
                        .HasColumnType("bigint");

                    b.Property<long>("CharacterID")
                        .HasColumnType("bigint");

                    b.Property<long>("ClanMark")
                        .HasColumnType("bigint");

                    b.Property<string>("ClanName")
                        .HasMaxLength(17)
                        .HasColumnType("character varying(17)");

                    b.Property<long>("Deaths")
                        .HasColumnType("bigint");

                    b.Property<long>("Experience")
                        .HasColumnType("bigint");

                    b.Property<byte>("Hero")
                        .HasColumnType("smallint");

                    b.Property<long>("Kills")
                        .HasColumnType("bigint");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<int>("Losses")
                        .HasColumnType("integer");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("character varying(17)");

                    b.Property<long>("PlayerCash")
                        .HasColumnType("bigint");

                    b.Property<byte>("SkinColor")
                        .HasColumnType("smallint");

                    b.Property<long>("Wins")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("CharacterInfoModel");
                });
#pragma warning restore 612, 618
        }
    }
}
