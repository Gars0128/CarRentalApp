﻿// <auto-generated />
using System;
using CarSharingApp.Infrastructure.MSSQL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarSharingApp.Infrastructure.Migrations
{
    [DbContext(typeof(CarSharingAppContext))]
    [Migration("20230127123919_ChangedActionNotesTableStructureMigration")]
    partial class ChangedActionNotesTableStructureMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarSharingApp.Domain.Entities.ActionNote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ActionEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ActionMadeTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ActorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ActionNotes");
                });
#pragma warning restore 612, 618
        }
    }
}
