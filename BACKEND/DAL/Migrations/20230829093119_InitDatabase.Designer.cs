﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DAL.Data;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230829093119_InitDatabase")]
    partial class InitDatabase
    {/*
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("socialapp.Models.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecipientId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RecipientId");

                    b.HasIndex("SenderId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("socialapp.Models.FriendRequest", b =>
                {
                    b.Property<int>("SourceUserId")
                        .HasColumnType("int");

                    b.Property<int>("DestinationUserId")
                        .HasColumnType("int");

                    b.Property<int>("StarePrietenie")
                        .HasColumnType("int");

                    b.HasKey("SourceUserId", "DestinationUserId");

                    b.HasIndex("DestinationUserId");

                    b.ToTable("FriendRequests");
                });

            modelBuilder.Entity("socialapp.Models.Group", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("DescriereGrup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeGrup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OwnerId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("socialapp.Models.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DataPostarii")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagineURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextulPostarii")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("socialapp.Models.ProfilePicture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("ProfilePicture");
                });

            modelBuilder.Entity("socialapp.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DataInregistrare")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNasterii")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriere")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GroupID")
                        .HasColumnType("int");

                    b.Property<string>("ImagineProfilURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parola")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GroupID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("socialapp.Models.UserComments", b =>
                {
                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.Property<int>("Post_Id")
                        .HasColumnType("int");

                    b.Property<string>("ContinutComentariu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataComentariu")
                        .HasColumnType("datetime2");

                    b.HasKey("User_Id", "Post_Id");

                    b.HasIndex("Post_Id");

                    b.ToTable("UserComments");
                });

            modelBuilder.Entity("socialapp.Models.UserLikes", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "PostId");

                    b.HasIndex("PostId");

                    b.ToTable("UserLikes");
                });

            modelBuilder.Entity("socialapp.Models.Chat", b =>
                {
                    b.HasOne("socialapp.Models.User", "Recipient")
                        .WithMany("ReceivedChats")
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("socialapp.Models.User", "Sender")
                        .WithMany("SentChats")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Recipient");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("socialapp.Models.FriendRequest", b =>
                {
                    b.HasOne("socialapp.Models.User", "DestinationUser")
                        .WithMany("ReceivedFriendRequests")
                        .HasForeignKey("DestinationUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("socialapp.Models.User", "SourceUser")
                        .WithMany("SentFriendRequests")
                        .HasForeignKey("SourceUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DestinationUser");

                    b.Navigation("SourceUser");
                });

            modelBuilder.Entity("socialapp.Models.Group", b =>
                {
                    b.HasOne("socialapp.Models.User", "Owner")
                        .WithMany("CreatedGroups")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("socialapp.Models.Post", b =>
                {
                    b.HasOne("socialapp.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("socialapp.Models.ProfilePicture", b =>
                {
                    b.HasOne("socialapp.Models.User", "User")
                        .WithOne("ProfilePicture")
                        .HasForeignKey("socialapp.Models.ProfilePicture", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("socialapp.Models.User", b =>
                {
                    b.HasOne("socialapp.Models.Group", null)
                        .WithMany("Members")
                        .HasForeignKey("GroupID");
                });

            modelBuilder.Entity("socialapp.Models.UserComments", b =>
                {
                    b.HasOne("socialapp.Models.Post", "Post")
                        .WithMany("UserComments")
                        .HasForeignKey("Post_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("socialapp.Models.User", "User")
                        .WithMany("CommentedPosts")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("socialapp.Models.UserLikes", b =>
                {
                    b.HasOne("socialapp.Models.Post", "Post")
                        .WithMany("UserLikes")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("socialapp.Models.User", "User")
                        .WithMany("LikedPosts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("socialapp.Models.Group", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("socialapp.Models.Post", b =>
                {
                    b.Navigation("UserComments");

                    b.Navigation("UserLikes");
                });

            modelBuilder.Entity("socialapp.Models.User", b =>
                {
                    b.Navigation("CommentedPosts");

                    b.Navigation("CreatedGroups");

                    b.Navigation("LikedPosts");

                    b.Navigation("Posts");

                    b.Navigation("ProfilePicture")
                        .IsRequired();

                    b.Navigation("ReceivedChats");

                    b.Navigation("ReceivedFriendRequests");

                    b.Navigation("SentChats");

                    b.Navigation("SentFriendRequests");
                });
#pragma warning restore 612, 618
        }*/
    }
}
