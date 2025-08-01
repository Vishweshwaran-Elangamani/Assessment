﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlaylistServices.Data;
namespace PlaylistEditorService.Migrations
{    [DbContext(typeof(AppDbContext))]   partial class AppDbContextModelSnapshot : ModelSnapshot{protected override void BuildModel(ModelBuilder modelBuilder){
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("PlaylistService.Model.PlaylistItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ArtistName")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SongName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PlaylistItems");
                });
#pragma warning restore 612, 618
        }
    }
}
