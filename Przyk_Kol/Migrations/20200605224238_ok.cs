using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Przyk_Kol.Migrations
{
    public partial class ok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "klient3",
                columns: table => new
                {
                    IdKlient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(maxLength: 50, nullable: false),
                    Nazwisko = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_klient3", x => x.IdKlient);
                });

            migrationBuilder.CreateTable(
                name: "pracownik3",
                columns: table => new
                {
                    IdPracownik = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(maxLength: 50, nullable: false),
                    Nazwisko = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pracownik3", x => x.IdPracownik);
                });

            migrationBuilder.CreateTable(
                name: "wyrobCukierniczy",
                columns: table => new
                {
                    IdWyrobuCukierniczego = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(maxLength: 200, nullable: false),
                    CenaZaSzt = table.Column<float>(nullable: false),
                    Typ = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wyrobCukierniczy", x => x.IdWyrobuCukierniczego);
                });

            migrationBuilder.CreateTable(
                name: "zamowienie",
                columns: table => new
                {
                    IdZamowienia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPrzyjecia = table.Column<DateTime>(nullable: false),
                    DataRealizacji = table.Column<DateTime>(nullable: false),
                    Uwagi = table.Column<string>(maxLength: 300, nullable: false),
                    IdKlient = table.Column<int>(nullable: false),
                    IdPracownik = table.Column<int>(nullable: false),
                    Klient3IdKlient = table.Column<int>(nullable: true),
                    Pracownik3IdPracownik = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zamowienie", x => x.IdZamowienia);
                    table.ForeignKey(
                        name: "FK_zamowienie_klient3_IdKlient",
                        column: x => x.IdKlient,
                        principalTable: "klient3",
                        principalColumn: "IdKlient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_zamowienie_pracownik3_IdPracownik",
                        column: x => x.IdPracownik,
                        principalTable: "pracownik3",
                        principalColumn: "IdPracownik",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_zamowienie_klient3_Klient3IdKlient",
                        column: x => x.Klient3IdKlient,
                        principalTable: "klient3",
                        principalColumn: "IdKlient",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_zamowienie_pracownik3_Pracownik3IdPracownik",
                        column: x => x.Pracownik3IdPracownik,
                        principalTable: "pracownik3",
                        principalColumn: "IdPracownik",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "zamowienie_Wyroby",
                columns: table => new
                {
                    IdWyrobuCukierniczego = table.Column<int>(nullable: false),
                    IdZamowienia = table.Column<int>(nullable: false),
                    Ilosc = table.Column<int>(nullable: false),
                    Uwagi = table.Column<string>(maxLength: 300, nullable: false),
                    WyrobCukierniczy3IdWyrobuCukierniczego = table.Column<int>(nullable: true),
                    Zamowienie3IdZamowienia = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zamowienie_Wyroby", x => new { x.IdWyrobuCukierniczego, x.IdZamowienia });
                    table.ForeignKey(
                        name: "FK_zamowienie_Wyroby_wyrobCukierniczy_IdWyrobuCukierniczego",
                        column: x => x.IdWyrobuCukierniczego,
                        principalTable: "wyrobCukierniczy",
                        principalColumn: "IdWyrobuCukierniczego",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_zamowienie_Wyroby_zamowienie_IdZamowienia",
                        column: x => x.IdZamowienia,
                        principalTable: "zamowienie",
                        principalColumn: "IdZamowienia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_zamowienie_Wyroby_wyrobCukierniczy_WyrobCukierniczy3IdWyrobuCukierniczego",
                        column: x => x.WyrobCukierniczy3IdWyrobuCukierniczego,
                        principalTable: "wyrobCukierniczy",
                        principalColumn: "IdWyrobuCukierniczego",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_zamowienie_Wyroby_zamowienie_Zamowienie3IdZamowienia",
                        column: x => x.Zamowienie3IdZamowienia,
                        principalTable: "zamowienie",
                        principalColumn: "IdZamowienia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "klient3",
                columns: new[] { "IdKlient", "Imie", "Nazwisko" },
                values: new object[,]
                {
                    { 1, "Ja", "AAA" },
                    { 2, "Ty", "BBB" },
                    { 3, "On", "CCC" }
                });

            migrationBuilder.InsertData(
                table: "pracownik3",
                columns: new[] { "IdPracownik", "Imie", "Nazwisko" },
                values: new object[,]
                {
                    { 1, "Ala", "AAA" },
                    { 2, "Bob", "BBB" },
                    { 3, "Cezary", "CCC" }
                });

            migrationBuilder.InsertData(
                table: "wyrobCukierniczy",
                columns: new[] { "IdWyrobuCukierniczego", "CenaZaSzt", "Nazwa", "Typ" },
                values: new object[,]
                {
                    { 1, 20f, "Mak", "Cukierka" },
                    { 2, 30f, "Artek", "Wafelka" }
                });

            migrationBuilder.InsertData(
                table: "zamowienie",
                columns: new[] { "IdZamowienia", "DataPrzyjecia", "DataRealizacji", "IdKlient", "IdPracownik", "Klient3IdKlient", "Pracownik3IdPracownik", "Uwagi" },
                values: new object[] { 1, new DateTime(2006, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null, null, "Wszystko ok" });

            migrationBuilder.InsertData(
                table: "zamowienie",
                columns: new[] { "IdZamowienia", "DataPrzyjecia", "DataRealizacji", "IdKlient", "IdPracownik", "Klient3IdKlient", "Pracownik3IdPracownik", "Uwagi" },
                values: new object[] { 2, new DateTime(2008, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, null, null, "Cos nie poszlo :( " });

            migrationBuilder.InsertData(
                table: "zamowienie_Wyroby",
                columns: new[] { "IdWyrobuCukierniczego", "IdZamowienia", "Ilosc", "Uwagi", "WyrobCukierniczy3IdWyrobuCukierniczego", "Zamowienie3IdZamowienia" },
                values: new object[] { 1, 1, 12, "Bardzo dobre slodycze", null, null });

            migrationBuilder.InsertData(
                table: "zamowienie_Wyroby",
                columns: new[] { "IdWyrobuCukierniczego", "IdZamowienia", "Ilosc", "Uwagi", "WyrobCukierniczy3IdWyrobuCukierniczego", "Zamowienie3IdZamowienia" },
                values: new object[] { 2, 2, 19, "Bardzo dobre wafelki", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_zamowienie_IdKlient",
                table: "zamowienie",
                column: "IdKlient");

            migrationBuilder.CreateIndex(
                name: "IX_zamowienie_IdPracownik",
                table: "zamowienie",
                column: "IdPracownik");

            migrationBuilder.CreateIndex(
                name: "IX_zamowienie_Klient3IdKlient",
                table: "zamowienie",
                column: "Klient3IdKlient");

            migrationBuilder.CreateIndex(
                name: "IX_zamowienie_Pracownik3IdPracownik",
                table: "zamowienie",
                column: "Pracownik3IdPracownik");

            migrationBuilder.CreateIndex(
                name: "IX_zamowienie_Wyroby_IdZamowienia",
                table: "zamowienie_Wyroby",
                column: "IdZamowienia");

            migrationBuilder.CreateIndex(
                name: "IX_zamowienie_Wyroby_WyrobCukierniczy3IdWyrobuCukierniczego",
                table: "zamowienie_Wyroby",
                column: "WyrobCukierniczy3IdWyrobuCukierniczego");

            migrationBuilder.CreateIndex(
                name: "IX_zamowienie_Wyroby_Zamowienie3IdZamowienia",
                table: "zamowienie_Wyroby",
                column: "Zamowienie3IdZamowienia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "zamowienie_Wyroby");

            migrationBuilder.DropTable(
                name: "wyrobCukierniczy");

            migrationBuilder.DropTable(
                name: "zamowienie");

            migrationBuilder.DropTable(
                name: "klient3");

            migrationBuilder.DropTable(
                name: "pracownik3");
        }
    }
}
