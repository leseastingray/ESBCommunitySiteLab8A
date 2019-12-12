﻿// <auto-generated />
using System;
using ESBCommunitySite.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ESBCommunitySite.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ESBCommunitySite.Models.Member", b =>
                {
                    b.Property<int>("MemberID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Board");

                    b.Property<string>("DateJoined");

                    b.Property<string>("Instrument");

                    b.Property<string>("Name");

                    b.Property<bool>("SectionLeader");

                    b.HasKey("MemberID");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("ESBCommunitySite.Models.MessageInfo", b =>
                {
                    b.Property<int>("MessageInfoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("MessageDate");

                    b.Property<string>("MessagePriority");

                    b.Property<string>("MessageText")
                        .IsRequired();

                    b.Property<string>("Recipient")
                        .IsRequired();

                    b.Property<string>("Sender")
                        .IsRequired();

                    b.HasKey("MessageInfoID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("ESBCommunitySite.Models.PotentialMember", b =>
                {
                    b.Property<int>("PotentialMemberID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Instrument")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("RequestDate");

                    b.HasKey("PotentialMemberID");

                    b.ToTable("PotentialMembers");
                });
#pragma warning restore 612, 618
        }
    }
}
