﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using testCrm.API.Persistence;

namespace testCrm.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190918201414_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("testCrm.API.Model.ContactData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContactId");

                    b.Property<int>("ContactTypeId");

                    b.Property<int>("Country");

                    b.Property<string>("DNI");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsDataValidated");

                    b.Property<string>("LastName");

                    b.Property<string>("Mail");

                    b.Property<string>("Phone");

                    b.Property<string>("Phone2");

                    b.HasKey("Id");

                    b.ToTable("ContactData");
                });

            modelBuilder.Entity("testCrm.API.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActiveDirectoryId");

                    b.Property<DateTime>("Birthday");

                    b.Property<int>("CountryId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsWorking");

                    b.Property<string>("JobTitle");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.Property<string>("UserPrincipalName");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("testCrm.API.Model.TaskTicket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActionTypeId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("DueDate");

                    b.Property<bool>("IsCompleted");

                    b.Property<int>("QueueId");

                    b.Property<int>("StateId");

                    b.Property<int>("TicketId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("TaskTickets");
                });

            modelBuilder.Entity("testCrm.API.Model.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContactId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("DueDate");

                    b.Property<DateTime>("ModiﬁcationDate");

                    b.Property<string>("Name");

                    b.Property<int>("PriorityId");

                    b.Property<int>("RolId");

                    b.Property<int>("TicketStateId");

                    b.Property<int>("TicketTypeId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("testCrm.API.Model.TicketType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsAutomaticAssignation");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TicketType");
                });
#pragma warning restore 612, 618
        }
    }
}
