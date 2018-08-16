﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using ZohrChangeSystem.Data;

namespace ZohrChangeSystem.Migrations
{
    [DbContext(typeof(ZohrContext))]
    [Migration("20180730075951_changeDatetoString2")]
    partial class changeDatetoString2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ZohrChangeSystem.Data.Entities.ChangeForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("category");

                    b.Property<string>("date");

                    b.Property<string>("description");

                    b.Property<string>("implementedBy");

                    b.Property<string>("initiatedBy");

                    b.Property<string>("status");

                    b.Property<string>("title");

                    b.HasKey("Id");

                    b.ToTable("changeForms");
                });

            modelBuilder.Entity("ZohrChangeSystem.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("password");

                    b.Property<string>("username");

                    b.HasKey("Id");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
