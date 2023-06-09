﻿// <auto-generated />
using System;
using Interview.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Interview.Infrastructure.Migrations
{
    [DbContext(typeof(InterviewDbContext))]
    [Migration("20230423163722_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Interview.ApplicationCore.Entity.AInterview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FeedBackId")
                        .HasColumnType("int");

                    b.Property<int>("InterviewRound")
                        .HasColumnType("int");

                    b.Property<int>("InterviewTypeId")
                        .HasColumnType("int");

                    b.Property<int>("InterviewerId")
                        .HasColumnType("int");

                    b.Property<int>("RecruiterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ScheduledOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("SubmissionId")
                        .HasColumnType("int");

                    b.Property<int>("interviewFeedBackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InterviewTypeId");

                    b.HasIndex("InterviewerId");

                    b.HasIndex("RecruiterId");

                    b.HasIndex("interviewFeedBackId");

                    b.ToTable("AInterviews");
                });

            modelBuilder.Entity("Interview.ApplicationCore.Entity.InterviewFeedBack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("InterviewFeedBacks");
                });

            modelBuilder.Entity("Interview.ApplicationCore.Entity.InterviewType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.HasKey("Id");

                    b.ToTable("InterviewTypes");
                });

            modelBuilder.Entity("Interview.ApplicationCore.Entity.Interviewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Interviewers");
                });

            modelBuilder.Entity("Interview.ApplicationCore.Entity.Recruiter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Recruiters");
                });

            modelBuilder.Entity("Interview.ApplicationCore.Entity.AInterview", b =>
                {
                    b.HasOne("Interview.ApplicationCore.Entity.InterviewType", "InterviewType")
                        .WithMany("Interviews")
                        .HasForeignKey("InterviewTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Interview.ApplicationCore.Entity.Interviewer", "Interviewer")
                        .WithMany("Interviews")
                        .HasForeignKey("InterviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Interview.ApplicationCore.Entity.Recruiter", "Recruiter")
                        .WithMany("Interviews")
                        .HasForeignKey("RecruiterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Interview.ApplicationCore.Entity.InterviewFeedBack", "interviewFeedBack")
                        .WithMany("Interviews")
                        .HasForeignKey("interviewFeedBackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InterviewType");

                    b.Navigation("Interviewer");

                    b.Navigation("Recruiter");

                    b.Navigation("interviewFeedBack");
                });

            modelBuilder.Entity("Interview.ApplicationCore.Entity.InterviewFeedBack", b =>
                {
                    b.Navigation("Interviews");
                });

            modelBuilder.Entity("Interview.ApplicationCore.Entity.InterviewType", b =>
                {
                    b.Navigation("Interviews");
                });

            modelBuilder.Entity("Interview.ApplicationCore.Entity.Interviewer", b =>
                {
                    b.Navigation("Interviews");
                });

            modelBuilder.Entity("Interview.ApplicationCore.Entity.Recruiter", b =>
                {
                    b.Navigation("Interviews");
                });
#pragma warning restore 612, 618
        }
    }
}
