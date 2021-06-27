using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoldBankLite.Data.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerTbl",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountTbl",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccountNumber = table.Column<string>(nullable: true),
                    CustomerId = table.Column<string>(nullable: true),
                    AccountType = table.Column<string>(nullable: true),
                    Balance = table.Column<decimal>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountTbl_CustomerTbl_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerTbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransactionTbl",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    TransactionType = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    AccountId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionTbl_AccountTbl_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AccountTbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountTbl_CustomerId",
                table: "AccountTbl",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionTbl_AccountId",
                table: "TransactionTbl",
                column: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionTbl");

            migrationBuilder.DropTable(
                name: "AccountTbl");

            migrationBuilder.DropTable(
                name: "CustomerTbl");
        }
    }
}
