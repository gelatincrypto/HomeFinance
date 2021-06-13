﻿// <auto-generated />
using System;
using HomeFinance.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HomeFinance.Infrastructure.Data.Migrations
{
    [DbContext(typeof(HomeFinanceContext))]
    partial class HomeFinanceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HomeFinance.Domain.Core.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IncomeOrExpense")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Сategories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IncomeOrExpense = false,
                            Name = "Сash withdrawal"
                        },
                        new
                        {
                            Id = 2L,
                            IncomeOrExpense = false,
                            Name = "Outgoing  transfer"
                        },
                        new
                        {
                            Id = 3L,
                            IncomeOrExpense = false,
                            Name = "Entertainment"
                        },
                        new
                        {
                            Id = 4L,
                            IncomeOrExpense = false,
                            Name = "Products"
                        },
                        new
                        {
                            Id = 5L,
                            IncomeOrExpense = false,
                            Name = "Cinema"
                        },
                        new
                        {
                            Id = 6L,
                            IncomeOrExpense = false,
                            Name = "Beauty and health"
                        },
                        new
                        {
                            Id = 7L,
                            IncomeOrExpense = true,
                            Name = "Salary"
                        },
                        new
                        {
                            Id = 8L,
                            IncomeOrExpense = true,
                            Name = "Cash"
                        },
                        new
                        {
                            Id = 9L,
                            IncomeOrExpense = true,
                            Name = "Receiving transfer"
                        },
                        new
                        {
                            Id = 10L,
                            IncomeOrExpense = true,
                            Name = "Investment"
                        });
                });

            modelBuilder.Entity("HomeFinance.Domain.Core.Operation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Operations");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Amount = 6959220L,
                            CategoryId = 5L,
                            Date = new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2L,
                            Amount = 953708809L,
                            CategoryId = 10L,
                            Date = new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3L,
                            Amount = 548374206L,
                            CategoryId = 1L,
                            Date = new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4L,
                            Amount = 384988137L,
                            CategoryId = 5L,
                            Date = new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5L,
                            Amount = 267102460L,
                            CategoryId = 1L,
                            Date = new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6L,
                            Amount = 615011866L,
                            CategoryId = 7L,
                            Date = new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7L,
                            Amount = 712668185L,
                            CategoryId = 5L,
                            Date = new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8L,
                            Amount = 449549850L,
                            CategoryId = 4L,
                            Date = new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9L,
                            Amount = 606388223L,
                            CategoryId = 7L,
                            Date = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10L,
                            Amount = 929418092L,
                            CategoryId = 10L,
                            Date = new DateTime(2021, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11L,
                            Amount = 104559580L,
                            CategoryId = 8L,
                            Date = new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12L,
                            Amount = 185410649L,
                            CategoryId = 6L,
                            Date = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13L,
                            Amount = 616772069L,
                            CategoryId = 9L,
                            Date = new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14L,
                            Amount = 988329657L,
                            CategoryId = 3L,
                            Date = new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15L,
                            Amount = 65253769L,
                            CategoryId = 1L,
                            Date = new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 16L,
                            Amount = 691213737L,
                            CategoryId = 2L,
                            Date = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 17L,
                            Amount = 741970824L,
                            CategoryId = 10L,
                            Date = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 18L,
                            Amount = 446577504L,
                            CategoryId = 10L,
                            Date = new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 19L,
                            Amount = 674034978L,
                            CategoryId = 10L,
                            Date = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 20L,
                            Amount = 251807021L,
                            CategoryId = 9L,
                            Date = new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 21L,
                            Amount = 167264653L,
                            CategoryId = 2L,
                            Date = new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 22L,
                            Amount = 275283811L,
                            CategoryId = 5L,
                            Date = new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 23L,
                            Amount = 190540128L,
                            CategoryId = 1L,
                            Date = new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 24L,
                            Amount = 752133026L,
                            CategoryId = 4L,
                            Date = new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 25L,
                            Amount = 199935160L,
                            CategoryId = 3L,
                            Date = new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 26L,
                            Amount = 247856554L,
                            CategoryId = 8L,
                            Date = new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 27L,
                            Amount = 257639091L,
                            CategoryId = 4L,
                            Date = new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 28L,
                            Amount = 490560111L,
                            CategoryId = 4L,
                            Date = new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 29L,
                            Amount = 54914767L,
                            CategoryId = 5L,
                            Date = new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 30L,
                            Amount = 828478216L,
                            CategoryId = 4L,
                            Date = new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 31L,
                            Amount = 147690048L,
                            CategoryId = 7L,
                            Date = new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 32L,
                            Amount = 690433094L,
                            CategoryId = 8L,
                            Date = new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 33L,
                            Amount = 505488517L,
                            CategoryId = 3L,
                            Date = new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 34L,
                            Amount = 984290613L,
                            CategoryId = 1L,
                            Date = new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 35L,
                            Amount = 59994257L,
                            CategoryId = 1L,
                            Date = new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 36L,
                            Amount = 232622552L,
                            CategoryId = 7L,
                            Date = new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 37L,
                            Amount = 298137704L,
                            CategoryId = 2L,
                            Date = new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 38L,
                            Amount = 595540489L,
                            CategoryId = 8L,
                            Date = new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 39L,
                            Amount = 259475416L,
                            CategoryId = 9L,
                            Date = new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 40L,
                            Amount = 327983140L,
                            CategoryId = 4L,
                            Date = new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 41L,
                            Amount = 313255162L,
                            CategoryId = 4L,
                            Date = new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 42L,
                            Amount = 377645585L,
                            CategoryId = 1L,
                            Date = new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 43L,
                            Amount = 602736808L,
                            CategoryId = 4L,
                            Date = new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 44L,
                            Amount = 555262708L,
                            CategoryId = 8L,
                            Date = new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 45L,
                            Amount = 171666745L,
                            CategoryId = 4L,
                            Date = new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 46L,
                            Amount = 642695688L,
                            CategoryId = 5L,
                            Date = new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 47L,
                            Amount = 949962591L,
                            CategoryId = 9L,
                            Date = new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 48L,
                            Amount = 473551009L,
                            CategoryId = 8L,
                            Date = new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 49L,
                            Amount = 922882249L,
                            CategoryId = 9L,
                            Date = new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 50L,
                            Amount = 690941211L,
                            CategoryId = 7L,
                            Date = new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 51L,
                            Amount = 509544261L,
                            CategoryId = 1L,
                            Date = new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 52L,
                            Amount = 5039203L,
                            CategoryId = 9L,
                            Date = new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 53L,
                            Amount = 150553542L,
                            CategoryId = 8L,
                            Date = new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 54L,
                            Amount = 511936948L,
                            CategoryId = 2L,
                            Date = new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 55L,
                            Amount = 947833725L,
                            CategoryId = 5L,
                            Date = new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 56L,
                            Amount = 308666531L,
                            CategoryId = 3L,
                            Date = new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 57L,
                            Amount = 800080867L,
                            CategoryId = 6L,
                            Date = new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 58L,
                            Amount = 460726833L,
                            CategoryId = 7L,
                            Date = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 59L,
                            Amount = 917147094L,
                            CategoryId = 3L,
                            Date = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 60L,
                            Amount = 439103474L,
                            CategoryId = 1L,
                            Date = new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 61L,
                            Amount = 925624183L,
                            CategoryId = 3L,
                            Date = new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 62L,
                            Amount = 527061202L,
                            CategoryId = 8L,
                            Date = new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 63L,
                            Amount = 671282393L,
                            CategoryId = 7L,
                            Date = new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 64L,
                            Amount = 8304769L,
                            CategoryId = 4L,
                            Date = new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 65L,
                            Amount = 420935811L,
                            CategoryId = 4L,
                            Date = new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 66L,
                            Amount = 717384629L,
                            CategoryId = 9L,
                            Date = new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 67L,
                            Amount = 260018015L,
                            CategoryId = 5L,
                            Date = new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 68L,
                            Amount = 563485038L,
                            CategoryId = 7L,
                            Date = new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 69L,
                            Amount = 198903752L,
                            CategoryId = 2L,
                            Date = new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 70L,
                            Amount = 670687586L,
                            CategoryId = 1L,
                            Date = new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 71L,
                            Amount = 947136023L,
                            CategoryId = 1L,
                            Date = new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 72L,
                            Amount = 208813247L,
                            CategoryId = 2L,
                            Date = new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 73L,
                            Amount = 789606053L,
                            CategoryId = 8L,
                            Date = new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 74L,
                            Amount = 363948722L,
                            CategoryId = 7L,
                            Date = new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 75L,
                            Amount = 464778755L,
                            CategoryId = 8L,
                            Date = new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 76L,
                            Amount = 660114378L,
                            CategoryId = 7L,
                            Date = new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 77L,
                            Amount = 705948352L,
                            CategoryId = 1L,
                            Date = new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 78L,
                            Amount = 837102794L,
                            CategoryId = 10L,
                            Date = new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 79L,
                            Amount = 245415098L,
                            CategoryId = 6L,
                            Date = new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 80L,
                            Amount = 505371459L,
                            CategoryId = 4L,
                            Date = new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 81L,
                            Amount = 143342058L,
                            CategoryId = 4L,
                            Date = new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 82L,
                            Amount = 73146590L,
                            CategoryId = 6L,
                            Date = new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 83L,
                            Amount = 982140071L,
                            CategoryId = 9L,
                            Date = new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 84L,
                            Amount = 154856551L,
                            CategoryId = 8L,
                            Date = new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 85L,
                            Amount = 488727694L,
                            CategoryId = 8L,
                            Date = new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 86L,
                            Amount = 440603573L,
                            CategoryId = 7L,
                            Date = new DateTime(2021, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 87L,
                            Amount = 166946885L,
                            CategoryId = 5L,
                            Date = new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 88L,
                            Amount = 584976433L,
                            CategoryId = 5L,
                            Date = new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 89L,
                            Amount = 163946353L,
                            CategoryId = 6L,
                            Date = new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 90L,
                            Amount = 330037917L,
                            CategoryId = 1L,
                            Date = new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 91L,
                            Amount = 723170059L,
                            CategoryId = 4L,
                            Date = new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 92L,
                            Amount = 747611909L,
                            CategoryId = 1L,
                            Date = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 93L,
                            Amount = 399618197L,
                            CategoryId = 8L,
                            Date = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 94L,
                            Amount = 273924487L,
                            CategoryId = 3L,
                            Date = new DateTime(2021, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 95L,
                            Amount = 75445344L,
                            CategoryId = 9L,
                            Date = new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 96L,
                            Amount = 827035611L,
                            CategoryId = 5L,
                            Date = new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 97L,
                            Amount = 769703946L,
                            CategoryId = 4L,
                            Date = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 98L,
                            Amount = 271761442L,
                            CategoryId = 8L,
                            Date = new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 99L,
                            Amount = 428778124L,
                            CategoryId = 8L,
                            Date = new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 100L,
                            Amount = 628727499L,
                            CategoryId = 3L,
                            Date = new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("HomeFinance.Domain.Core.Operation", b =>
                {
                    b.HasOne("HomeFinance.Domain.Core.Category", "Category")
                        .WithMany("Operations")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HomeFinance.Domain.Core.Category", b =>
                {
                    b.Navigation("Operations");
                });
#pragma warning restore 612, 618
        }
    }
}
