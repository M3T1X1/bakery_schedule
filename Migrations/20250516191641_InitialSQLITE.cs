using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery_Schedule.Migrations
{
    /// <inheritdoc />
    public partial class InitialSQLITE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    ID_adresu = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ulica = table.Column<string>(type: "TEXT", nullable: false),
                    NrMieszkania = table.Column<string>(type: "TEXT", nullable: false),
                    Klatka = table.Column<string>(type: "TEXT", nullable: false),
                    Miasto = table.Column<string>(type: "TEXT", nullable: false),
                    NrDomu = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.ID_adresu);
                });

            migrationBuilder.CreateTable(
                name: "Produkt",
                columns: table => new
                {
                    ID_produktu = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    ŚredniKosztProdukcji = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkt", x => x.ID_produktu);
                });

            migrationBuilder.CreateTable(
                name: "Stanowisko",
                columns: table => new
                {
                    ID_stanowiska = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NazwaStanowiska = table.Column<string>(type: "TEXT", nullable: false),
                    ZarobkiNaGodzine = table.Column<decimal>(type: "TEXT", nullable: false),
                    Poziom = table.Column<string>(type: "TEXT", nullable: false),
                    ID_produktu = table.Column<int>(type: "INTEGER", nullable: true),
                    ProduktID_produktu = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stanowisko", x => x.ID_stanowiska);
                    table.ForeignKey(
                        name: "FK_Stanowisko_Produkt_ProduktID_produktu",
                        column: x => x.ProduktID_produktu,
                        principalTable: "Produkt",
                        principalColumn: "ID_produktu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pracownik",
                columns: table => new
                {
                    ID_pracownika = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Imie = table.Column<string>(type: "TEXT", nullable: false),
                    Nazwisko = table.Column<string>(type: "TEXT", nullable: false),
                    Telefon = table.Column<string>(type: "TEXT", nullable: false),
                    RodzajUmowy = table.Column<string>(type: "TEXT", nullable: false),
                    LataDoswiadczenia = table.Column<int>(type: "INTEGER", nullable: false),
                    ID_adresu = table.Column<int>(type: "INTEGER", nullable: true),
                    AdresID_adresu = table.Column<int>(type: "INTEGER", nullable: false),
                    ID_stanowiska = table.Column<int>(type: "INTEGER", nullable: true),
                    StanowiskoID_stanowiska = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracownik", x => x.ID_pracownika);
                    table.ForeignKey(
                        name: "FK_Pracownik_Adres_AdresID_adresu",
                        column: x => x.AdresID_adresu,
                        principalTable: "Adres",
                        principalColumn: "ID_adresu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pracownik_Stanowisko_StanowiskoID_stanowiska",
                        column: x => x.StanowiskoID_stanowiska,
                        principalTable: "Stanowisko",
                        principalColumn: "ID_stanowiska",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zmiana",
                columns: table => new
                {
                    ID_zmiany = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PoczatekZmiany = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    KoniecZmiany = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    Imie = table.Column<string>(type: "TEXT", nullable: false),
                    Nazwisko = table.Column<string>(type: "TEXT", nullable: false),
                    ID_pracownika = table.Column<int>(type: "INTEGER", nullable: true),
                    PracownikID_pracownika = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zmiana", x => x.ID_zmiany);
                    table.ForeignKey(
                        name: "FK_Zmiana_Pracownik_PracownikID_pracownika",
                        column: x => x.PracownikID_pracownika,
                        principalTable: "Pracownik",
                        principalColumn: "ID_pracownika",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pracownik_AdresID_adresu",
                table: "Pracownik",
                column: "AdresID_adresu");

            migrationBuilder.CreateIndex(
                name: "IX_Pracownik_StanowiskoID_stanowiska",
                table: "Pracownik",
                column: "StanowiskoID_stanowiska");

            migrationBuilder.CreateIndex(
                name: "IX_Stanowisko_ProduktID_produktu",
                table: "Stanowisko",
                column: "ProduktID_produktu");

            migrationBuilder.CreateIndex(
                name: "IX_Zmiana_PracownikID_pracownika",
                table: "Zmiana",
                column: "PracownikID_pracownika");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zmiana");

            migrationBuilder.DropTable(
                name: "Pracownik");

            migrationBuilder.DropTable(
                name: "Adres");

            migrationBuilder.DropTable(
                name: "Stanowisko");

            migrationBuilder.DropTable(
                name: "Produkt");
        }
    }
}
