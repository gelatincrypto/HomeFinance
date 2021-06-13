using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeFinance.Infrastructure.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Сategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncomeOrExpense = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Сategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operations_Сategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Сategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Сategories",
                columns: new[] { "Id", "IncomeOrExpense", "Name" },
                values: new object[,]
                {
                    { 1L, false, "Сash withdrawal" },
                    { 2L, false, "Outgoing  transfer" },
                    { 3L, false, "Entertainment" },
                    { 4L, false, "Products" },
                    { 5L, false, "Cinema" },
                    { 6L, false, "Beauty and health" },
                    { 7L, true, "Salary" },
                    { 8L, true, "Cash" },
                    { 9L, true, "Receiving transfer" },
                    { 10L, true, "Investment" }
                });

            migrationBuilder.InsertData(
                table: "Operations",
                columns: new[] { "Id", "Amount", "CategoryId", "Date" },
                values: new object[,]
                {
                    { 3L, 548374206L, 1L, new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32L, 690433094L, 8L, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26L, 247856554L, 8L, new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11L, 104559580L, 8L, new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86L, 440603573L, 7L, new DateTime(2021, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76L, 660114378L, 7L, new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74L, 363948722L, 7L, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68L, 563485038L, 7L, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63L, 671282393L, 7L, new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58L, 460726833L, 7L, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50L, 690941211L, 7L, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36L, 232622552L, 7L, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31L, 147690048L, 7L, new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9L, 606388223L, 7L, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, 615011866L, 7L, new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89L, 163946353L, 6L, new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82L, 73146590L, 6L, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79L, 245415098L, 6L, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57L, 800080867L, 6L, new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12L, 185410649L, 6L, new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96L, 827035611L, 5L, new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88L, 584976433L, 5L, new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38L, 595540489L, 8L, new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87L, 166946885L, 5L, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44L, 555262708L, 8L, new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53L, 150553542L, 8L, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18L, 446577504L, 10L, new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17L, 741970824L, 10L, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10L, 929418092L, 10L, new DateTime(2021, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, 953708809L, 10L, new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95L, 75445344L, 9L, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83L, 982140071L, 9L, new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66L, 717384629L, 9L, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52L, 5039203L, 9L, new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49L, 922882249L, 9L, new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47L, 949962591L, 9L, new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39L, 259475416L, 9L, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20L, 251807021L, 9L, new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13L, 616772069L, 9L, new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99L, 428778124L, 8L, new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98L, 271761442L, 8L, new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93L, 399618197L, 8L, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Operations",
                columns: new[] { "Id", "Amount", "CategoryId", "Date" },
                values: new object[,]
                {
                    { 85L, 488727694L, 8L, new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84L, 154856551L, 8L, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75L, 464778755L, 8L, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73L, 789606053L, 8L, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62L, 527061202L, 8L, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48L, 473551009L, 8L, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67L, 260018015L, 5L, new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55L, 947833725L, 5L, new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46L, 642695688L, 5L, new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25L, 199935160L, 3L, new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14L, 988329657L, 3L, new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72L, 208813247L, 2L, new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69L, 198903752L, 2L, new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54L, 511936948L, 2L, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37L, 298137704L, 2L, new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21L, 167264653L, 2L, new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16L, 691213737L, 2L, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92L, 747611909L, 1L, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90L, 330037917L, 1L, new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77L, 705948352L, 1L, new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71L, 947136023L, 1L, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70L, 670687586L, 1L, new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60L, 439103474L, 1L, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51L, 509544261L, 1L, new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42L, 377645585L, 1L, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35L, 59994257L, 1L, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34L, 984290613L, 1L, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23L, 190540128L, 1L, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15L, 65253769L, 1L, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, 267102460L, 1L, new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33L, 505488517L, 3L, new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56L, 308666531L, 3L, new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59L, 917147094L, 3L, new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61L, 925624183L, 3L, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29L, 54914767L, 5L, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22L, 275283811L, 5L, new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, 712668185L, 5L, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, 384988137L, 5L, new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1L, 6959220L, 5L, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97L, 769703946L, 4L, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91L, 723170059L, 4L, new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81L, 143342058L, 4L, new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Operations",
                columns: new[] { "Id", "Amount", "CategoryId", "Date" },
                values: new object[,]
                {
                    { 80L, 505371459L, 4L, new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65L, 420935811L, 4L, new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19L, 674034978L, 10L, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64L, 8304769L, 4L, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43L, 602736808L, 4L, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41L, 313255162L, 4L, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40L, 327983140L, 4L, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30L, 828478216L, 4L, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28L, 490560111L, 4L, new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27L, 257639091L, 4L, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24L, 752133026L, 4L, new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, 449549850L, 4L, new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100L, 628727499L, 3L, new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94L, 273924487L, 3L, new DateTime(2021, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45L, 171666745L, 4L, new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78L, 837102794L, 10L, new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Operations_CategoryId",
                table: "Operations",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropTable(
                name: "Сategories");
        }
    }
}
