using System;
using HomeFinance.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace HomeFinance.Infrastructure.Data
{
    public class HomeFinanceContext : DbContext
    {
        public HomeFinanceContext()
        {

        }

        public HomeFinanceContext(DbContextOptions<HomeFinanceContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category> Сategories { get; set; }
        public DbSet<Operation> Operations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Сash withdrawal", IncomeOrExpense = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Name = "Outgoing  transfer", IncomeOrExpense = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, Name = "Entertainment", IncomeOrExpense = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 4, Name = "Products", IncomeOrExpense = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 5, Name = "Cinema", IncomeOrExpense = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 6, Name = "Beauty and health", IncomeOrExpense = false });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 7, Name = "Salary", IncomeOrExpense = true });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 8, Name = "Cash", IncomeOrExpense = true });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 9, Name = "Receiving transfer", IncomeOrExpense = true });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 10, Name = "Investment", IncomeOrExpense = true });

            modelBuilder.Entity<Operation>().HasData(
            new Operation { Id = 1, Date = DateTime.Parse("2021-04-30"), Amount = 6959220, CategoryId = 5 },
            new Operation { Id = 2, Date = DateTime.Parse("2021-04-07"), Amount = 953708809, CategoryId = 10 },
            new Operation { Id = 3, Date = DateTime.Parse("2021-04-24"), Amount = 548374206, CategoryId = 1 },
            new Operation { Id = 4, Date = DateTime.Parse("2021-04-02"), Amount = 384988137, CategoryId = 5 },
            new Operation { Id = 5, Date = DateTime.Parse("2021-03-25"), Amount = 267102460, CategoryId = 1 },
            new Operation { Id = 6, Date = DateTime.Parse("2021-03-08"), Amount = 615011866, CategoryId = 7 },
            new Operation { Id = 7, Date = DateTime.Parse("2021-01-06"), Amount = 712668185, CategoryId = 5 },
            new Operation { Id = 8, Date = DateTime.Parse("2021-04-06"), Amount = 449549850, CategoryId = 4 },
            new Operation { Id = 9, Date = DateTime.Parse("2021-04-23"), Amount = 606388223, CategoryId = 7 },
            new Operation { Id = 10, Date = DateTime.Parse("2021-01-29"), Amount = 929418092, CategoryId = 10 },
            new Operation { Id = 11, Date = DateTime.Parse("2021-05-09"), Amount = 104559580, CategoryId = 8 },
            new Operation { Id = 12, Date = DateTime.Parse("2021-01-09"), Amount = 185410649, CategoryId = 6 },
            new Operation { Id = 13, Date = DateTime.Parse("2021-01-25"), Amount = 616772069, CategoryId = 9 },
            new Operation { Id = 14, Date = DateTime.Parse("2021-02-17"), Amount = 988329657, CategoryId = 3 },
            new Operation { Id = 15, Date = DateTime.Parse("2021-05-01"), Amount = 65253769, CategoryId = 1 },
            new Operation { Id = 16, Date = DateTime.Parse("2021-01-01"), Amount = 691213737, CategoryId = 2 },
            new Operation { Id = 17, Date = DateTime.Parse("2021-02-02"), Amount = 741970824, CategoryId = 10 },
            new Operation { Id = 18, Date = DateTime.Parse("2021-01-24"), Amount = 446577504, CategoryId = 10 },
            new Operation { Id = 19, Date = DateTime.Parse("2021-02-01"), Amount = 674034978, CategoryId = 10 },
            new Operation { Id = 20, Date = DateTime.Parse("2021-02-14"), Amount = 251807021, CategoryId = 9 },
            new Operation { Id = 21, Date = DateTime.Parse("2021-02-06"), Amount = 167264653, CategoryId = 2 },
            new Operation { Id = 22, Date = DateTime.Parse("2021-02-22"), Amount = 275283811, CategoryId = 5 },
            new Operation { Id = 23, Date = DateTime.Parse("2021-05-31"), Amount = 190540128, CategoryId = 1 },
            new Operation { Id = 24, Date = DateTime.Parse("2021-03-14"), Amount = 752133026, CategoryId = 4 },
            new Operation { Id = 25, Date = DateTime.Parse("2021-02-11"), Amount = 199935160, CategoryId = 3 },
            new Operation { Id = 26, Date = DateTime.Parse("2021-01-02"), Amount = 247856554, CategoryId = 8 },
            new Operation { Id = 27, Date = DateTime.Parse("2021-01-19"), Amount = 257639091, CategoryId = 4 },
            new Operation { Id = 28, Date = DateTime.Parse("2021-01-25"), Amount = 490560111, CategoryId = 4 },
            new Operation { Id = 29, Date = DateTime.Parse("2021-04-08"), Amount = 54914767, CategoryId = 5 },
            new Operation { Id = 30, Date = DateTime.Parse("2021-01-20"), Amount = 828478216, CategoryId = 4 },
            new Operation { Id = 31, Date = DateTime.Parse("2021-04-24"), Amount = 147690048, CategoryId = 7 },
            new Operation { Id = 32, Date = DateTime.Parse("2021-02-15"), Amount = 690433094, CategoryId = 8 },
            new Operation { Id = 33, Date = DateTime.Parse("2021-03-21"), Amount = 505488517, CategoryId = 3 },
            new Operation { Id = 34, Date = DateTime.Parse("2021-05-06"), Amount = 984290613, CategoryId = 1 },
            new Operation { Id = 35, Date = DateTime.Parse("2021-05-20"), Amount = 59994257, CategoryId = 1 },
            new Operation { Id = 36, Date = DateTime.Parse("2021-01-06"), Amount = 232622552, CategoryId = 7 },
            new Operation { Id = 37, Date = DateTime.Parse("2021-01-13"), Amount = 298137704, CategoryId = 2 },
            new Operation { Id = 38, Date = DateTime.Parse("2021-01-05"), Amount = 595540489, CategoryId = 8 },
            new Operation { Id = 39, Date = DateTime.Parse("2021-01-27"), Amount = 259475416, CategoryId = 9 },
            new Operation { Id = 40, Date = DateTime.Parse("2021-01-31"), Amount = 327983140, CategoryId = 4 },
            new Operation { Id = 41, Date = DateTime.Parse("2021-01-20"), Amount = 313255162, CategoryId = 4 },
            new Operation { Id = 42, Date = DateTime.Parse("2021-02-18"), Amount = 377645585, CategoryId = 1 },
            new Operation { Id = 43, Date = DateTime.Parse("2021-04-21"), Amount = 602736808, CategoryId = 4 },
            new Operation { Id = 44, Date = DateTime.Parse("2021-04-03"), Amount = 555262708, CategoryId = 8 },
            new Operation { Id = 45, Date = DateTime.Parse("2021-02-03"), Amount = 171666745, CategoryId = 4 },
            new Operation { Id = 46, Date = DateTime.Parse("2021-04-14"), Amount = 642695688, CategoryId = 5 },
            new Operation { Id = 47, Date = DateTime.Parse("2021-02-14"), Amount = 949962591, CategoryId = 9 },
            new Operation { Id = 48, Date = DateTime.Parse("2021-02-28"), Amount = 473551009, CategoryId = 8 },
            new Operation { Id = 49, Date = DateTime.Parse("2021-02-21"), Amount = 922882249, CategoryId = 9 },
            new Operation { Id = 50, Date = DateTime.Parse("2021-01-08"), Amount = 690941211, CategoryId = 7 },
            new Operation { Id = 51, Date = DateTime.Parse("2021-02-08"), Amount = 509544261, CategoryId = 1 },
            new Operation { Id = 52, Date = DateTime.Parse("2021-05-09"), Amount = 5039203, CategoryId = 9 },
            new Operation { Id = 53, Date = DateTime.Parse("2021-04-17"), Amount = 150553542, CategoryId = 8 },
            new Operation { Id = 54, Date = DateTime.Parse("2021-06-01"), Amount = 511936948, CategoryId = 2 },
            new Operation { Id = 55, Date = DateTime.Parse("2021-05-12"), Amount = 947833725, CategoryId = 5 },
            new Operation { Id = 56, Date = DateTime.Parse("2021-02-14"), Amount = 308666531, CategoryId = 3 },
            new Operation { Id = 57, Date = DateTime.Parse("2021-04-28"), Amount = 800080867, CategoryId = 6 },
            new Operation { Id = 58, Date = DateTime.Parse("2021-04-23"), Amount = 460726833, CategoryId = 7 },
            new Operation { Id = 59, Date = DateTime.Parse("2021-05-16"), Amount = 917147094, CategoryId = 3 },
            new Operation { Id = 60, Date = DateTime.Parse("2021-05-20"), Amount = 439103474, CategoryId = 1 },
            new Operation { Id = 61, Date = DateTime.Parse("2021-05-06"), Amount = 925624183, CategoryId = 3 },
            new Operation { Id = 62, Date = DateTime.Parse("2021-03-31"), Amount = 527061202, CategoryId = 8 },
            new Operation { Id = 63, Date = DateTime.Parse("2021-03-16"), Amount = 671282393, CategoryId = 7 },
            new Operation { Id = 64, Date = DateTime.Parse("2021-05-28"), Amount = 8304769, CategoryId = 4 },
            new Operation { Id = 65, Date = DateTime.Parse("2021-03-16"), Amount = 420935811, CategoryId = 4 },
            new Operation { Id = 66, Date = DateTime.Parse("2021-01-27"), Amount = 717384629, CategoryId = 9 },
            new Operation { Id = 67, Date = DateTime.Parse("2021-01-17"), Amount = 260018015, CategoryId = 5 },
            new Operation { Id = 68, Date = DateTime.Parse("2021-02-28"), Amount = 563485038, CategoryId = 7 },
            new Operation { Id = 69, Date = DateTime.Parse("2021-05-25"), Amount = 198903752, CategoryId = 2 },
            new Operation { Id = 70, Date = DateTime.Parse("2021-03-12"), Amount = 670687586, CategoryId = 1 },
            new Operation { Id = 71, Date = DateTime.Parse("2021-02-02"), Amount = 947136023, CategoryId = 1 },
            new Operation { Id = 72, Date = DateTime.Parse("2021-01-07"), Amount = 208813247, CategoryId = 2 },
            new Operation { Id = 73, Date = DateTime.Parse("2021-03-17"), Amount = 789606053, CategoryId = 8 },
            new Operation { Id = 74, Date = DateTime.Parse("2021-01-06"), Amount = 363948722, CategoryId = 7 },
            new Operation { Id = 75, Date = DateTime.Parse("2021-05-02"), Amount = 464778755, CategoryId = 8 },
            new Operation { Id = 76, Date = DateTime.Parse("2021-05-23"), Amount = 660114378, CategoryId = 7 },
            new Operation { Id = 77, Date = DateTime.Parse("2021-02-25"), Amount = 705948352, CategoryId = 1 },
            new Operation { Id = 78, Date = DateTime.Parse("2021-04-28"), Amount = 837102794, CategoryId = 10 },
            new Operation { Id = 79, Date = DateTime.Parse("2021-05-31"), Amount = 245415098, CategoryId = 6 },
            new Operation { Id = 80, Date = DateTime.Parse("2021-01-08"), Amount = 505371459, CategoryId = 4 },
            new Operation { Id = 81, Date = DateTime.Parse("2021-05-23"), Amount = 143342058, CategoryId = 4 },
            new Operation { Id = 82, Date = DateTime.Parse("2021-01-03"), Amount = 73146590, CategoryId = 6 },
            new Operation { Id = 83, Date = DateTime.Parse("2021-02-14"), Amount = 982140071, CategoryId = 9 },
            new Operation { Id = 84, Date = DateTime.Parse("2021-01-20"), Amount = 154856551, CategoryId = 8 },
            new Operation { Id = 85, Date = DateTime.Parse("2021-01-07"), Amount = 488727694, CategoryId = 8 },
            new Operation { Id = 86, Date = DateTime.Parse("2021-01-29"), Amount = 440603573, CategoryId = 7 },
            new Operation { Id = 87, Date = DateTime.Parse("2021-01-03"), Amount = 166946885, CategoryId = 5 },
            new Operation { Id = 88, Date = DateTime.Parse("2021-05-30"), Amount = 584976433, CategoryId = 5 },
            new Operation { Id = 89, Date = DateTime.Parse("2021-04-24"), Amount = 163946353, CategoryId = 6 },
            new Operation { Id = 90, Date = DateTime.Parse("2021-04-24"), Amount = 330037917, CategoryId = 1 },
            new Operation { Id = 91, Date = DateTime.Parse("2021-05-04"), Amount = 723170059, CategoryId = 4 },
            new Operation { Id = 92, Date = DateTime.Parse("2021-05-16"), Amount = 747611909, CategoryId = 1 },
            new Operation { Id = 93, Date = DateTime.Parse("2021-01-01"), Amount = 399618197, CategoryId = 8 },
            new Operation { Id = 94, Date = DateTime.Parse("2021-01-28"), Amount = 273924487, CategoryId = 3 },
            new Operation { Id = 95, Date = DateTime.Parse("2021-02-19"), Amount = 75445344, CategoryId = 9 },
            new Operation { Id = 96, Date = DateTime.Parse("2021-01-16"), Amount = 827035611, CategoryId = 5 },
            new Operation { Id = 97, Date = DateTime.Parse("2021-04-23"), Amount = 769703946, CategoryId = 4 },
            new Operation { Id = 98, Date = DateTime.Parse("2021-01-23"), Amount = 271761442, CategoryId = 8 },
            new Operation { Id = 99, Date = DateTime.Parse("2021-01-14"), Amount = 428778124, CategoryId = 8 },
            new Operation { Id = 100, Date = DateTime.Parse("2021-04-10"), Amount = 628727499, CategoryId = 3 });
        }
    }
}
