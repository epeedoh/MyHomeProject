using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyHomeProject.Data.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EtatTransactions",
                columns: table => new
                {
                    EtatTransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeEtatTransaction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtatTransactions", x => x.EtatTransactionID);
                });

            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    PaysID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodePays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationalite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pays", x => x.PaysID);
                });

            migrationBuilder.CreateTable(
                name: "Sexes",
                columns: table => new
                {
                    SexeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeSexe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexes", x => x.SexeID);
                });

            migrationBuilder.CreateTable(
                name: "TypeProprietes",
                columns: table => new
                {
                    TypeProprieteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeProprietes", x => x.TypeProprieteID);
                });

            migrationBuilder.CreateTable(
                name: "TypeStandings",
                columns: table => new
                {
                    TypeStandingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeStandings", x => x.TypeStandingID);
                });

            migrationBuilder.CreateTable(
                name: "TypeTransactions",
                columns: table => new
                {
                    TypeTransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeTransactions", x => x.TypeTransactionID);
                });

            migrationBuilder.CreateTable(
                name: "Villes",
                columns: table => new
                {
                    VilleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeVille = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaysID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villes", x => x.VilleID);
                    table.ForeignKey(
                        name: "FK_Villes_Pays_PaysID",
                        column: x => x.PaysID,
                        principalTable: "Pays",
                        principalColumn: "PaysID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Communes",
                columns: table => new
                {
                    CommuneID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeCommune = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VilleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communes", x => x.CommuneID);
                    table.ForeignKey(
                        name: "FK_Communes_Villes_VilleID",
                        column: x => x.VilleID,
                        principalTable: "Villes",
                        principalColumn: "VilleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quartiers",
                columns: table => new
                {
                    QuartierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeQuartier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommuneID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quartiers", x => x.QuartierID);
                    table.ForeignKey(
                        name: "FK_Quartiers_Communes_CommuneID",
                        column: x => x.CommuneID,
                        principalTable: "Communes",
                        principalColumn: "CommuneID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammeImmobiliers",
                columns: table => new
                {
                    ProgrammeImmobilierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeProgrammeImmobilier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDebutProgramme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuartierID = table.Column<int>(type: "int", nullable: false),
                    EstActif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammeImmobiliers", x => x.ProgrammeImmobilierID);
                    table.ForeignKey(
                        name: "FK_ProgrammeImmobiliers_Quartiers_QuartierID",
                        column: x => x.QuartierID,
                        principalTable: "Quartiers",
                        principalColumn: "QuartierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Societes",
                columns: table => new
                {
                    SocieteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeSociete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomSociete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailsSiege = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuartierID = table.Column<int>(type: "int", nullable: false),
                    EstActif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Societes", x => x.SocieteID);
                    table.ForeignKey(
                        name: "FK_Societes_Quartiers_QuartierID",
                        column: x => x.QuartierID,
                        principalTable: "Quartiers",
                        principalColumn: "QuartierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proprietes",
                columns: table => new
                {
                    ProprieteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProprieteNom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Addresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Localisation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NbreChambre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NbreSalon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExistTerraste = table.Column<bool>(type: "bit", nullable: false),
                    NbreSalleDeBain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Superficie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeProprieteID = table.Column<int>(type: "int", nullable: false),
                    ProgrammeImmobilierID = table.Column<int>(type: "int", nullable: false),
                    QuartierID = table.Column<int>(type: "int", nullable: false),
                    TypeTransactionID = table.Column<int>(type: "int", nullable: false),
                    TypeStandingID = table.Column<int>(type: "int", nullable: false),
                    EtatTransactionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proprietes", x => x.ProprieteID);
                    table.ForeignKey(
                        name: "FK_Proprietes_EtatTransactions_EtatTransactionID",
                        column: x => x.EtatTransactionID,
                        principalTable: "EtatTransactions",
                        principalColumn: "EtatTransactionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proprietes_ProgrammeImmobiliers_ProgrammeImmobilierID",
                        column: x => x.ProgrammeImmobilierID,
                        principalTable: "ProgrammeImmobiliers",
                        principalColumn: "ProgrammeImmobilierID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proprietes_Quartiers_QuartierID",
                        column: x => x.QuartierID,
                        principalTable: "Quartiers",
                        principalColumn: "QuartierID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Proprietes_TypeProprietes_TypeProprieteID",
                        column: x => x.TypeProprieteID,
                        principalTable: "TypeProprietes",
                        principalColumn: "TypeProprieteID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proprietes_TypeStandings_TypeStandingID",
                        column: x => x.TypeStandingID,
                        principalTable: "TypeStandings",
                        principalColumn: "TypeStandingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proprietes_TypeTransactions_TypeTransactionID",
                        column: x => x.TypeTransactionID,
                        principalTable: "TypeTransactions",
                        principalColumn: "TypeTransactionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAjout = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    ProprieteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageID);
                    table.ForeignKey(
                        name: "FK_Images_Proprietes_ProprieteID",
                        column: x => x.ProprieteID,
                        principalTable: "Proprietes",
                        principalColumn: "ProprieteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personnes",
                columns: table => new
                {
                    PersonneID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenoms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomComplet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domicile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodeSexe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identifiant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CompteCreate = table.Column<bool>(type: "bit", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SexeID = table.Column<int>(type: "int", nullable: false),
                    PaysID = table.Column<int>(type: "int", nullable: false),
                    RoleTypeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnes", x => x.PersonneID);
                    table.ForeignKey(
                        name: "FK_Personnes_Pays_PaysID",
                        column: x => x.PaysID,
                        principalTable: "Pays",
                        principalColumn: "PaysID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personnes_Sexes_SexeID",
                        column: x => x.SexeID,
                        principalTable: "Sexes",
                        principalColumn: "SexeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    UtilisateurID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PersonneID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.UtilisateurID);
                    table.ForeignKey(
                        name: "FK_Utilisateurs_Personnes_PersonneID",
                        column: x => x.PersonneID,
                        principalTable: "Personnes",
                        principalColumn: "PersonneID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleTypes",
                columns: table => new
                {
                    RoleTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeTitre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleTypes", x => x.RoleTypeID);
                    table.ForeignKey(
                        name: "FK_RoleTypes_Utilisateurs_UtilisateurID",
                        column: x => x.UtilisateurID,
                        principalTable: "Utilisateurs",
                        principalColumn: "UtilisateurID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Communes_VilleID",
                table: "Communes",
                column: "VilleID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProprieteID",
                table: "Images",
                column: "ProprieteID");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_PaysID",
                table: "Personnes",
                column: "PaysID");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_RoleTypeID",
                table: "Personnes",
                column: "RoleTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_SexeID",
                table: "Personnes",
                column: "SexeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammeImmobiliers_QuartierID",
                table: "ProgrammeImmobiliers",
                column: "QuartierID");

            migrationBuilder.CreateIndex(
                name: "IX_Proprietes_EtatTransactionID",
                table: "Proprietes",
                column: "EtatTransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_Proprietes_ProgrammeImmobilierID",
                table: "Proprietes",
                column: "ProgrammeImmobilierID");

            migrationBuilder.CreateIndex(
                name: "IX_Proprietes_QuartierID",
                table: "Proprietes",
                column: "QuartierID");

            migrationBuilder.CreateIndex(
                name: "IX_Proprietes_TypeProprieteID",
                table: "Proprietes",
                column: "TypeProprieteID");

            migrationBuilder.CreateIndex(
                name: "IX_Proprietes_TypeStandingID",
                table: "Proprietes",
                column: "TypeStandingID");

            migrationBuilder.CreateIndex(
                name: "IX_Proprietes_TypeTransactionID",
                table: "Proprietes",
                column: "TypeTransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_Quartiers_CommuneID",
                table: "Quartiers",
                column: "CommuneID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleTypes_UtilisateurID",
                table: "RoleTypes",
                column: "UtilisateurID");

            migrationBuilder.CreateIndex(
                name: "IX_Societes_QuartierID",
                table: "Societes",
                column: "QuartierID");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_PersonneID",
                table: "Utilisateurs",
                column: "PersonneID");

            migrationBuilder.CreateIndex(
                name: "IX_Villes_PaysID",
                table: "Villes",
                column: "PaysID");

            migrationBuilder.AddForeignKey(
                name: "FK_Personnes_RoleTypes_RoleTypeID",
                table: "Personnes",
                column: "RoleTypeID",
                principalTable: "RoleTypes",
                principalColumn: "RoleTypeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnes_Pays_PaysID",
                table: "Personnes");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnes_RoleTypes_RoleTypeID",
                table: "Personnes");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Societes");

            migrationBuilder.DropTable(
                name: "Proprietes");

            migrationBuilder.DropTable(
                name: "EtatTransactions");

            migrationBuilder.DropTable(
                name: "ProgrammeImmobiliers");

            migrationBuilder.DropTable(
                name: "TypeProprietes");

            migrationBuilder.DropTable(
                name: "TypeStandings");

            migrationBuilder.DropTable(
                name: "TypeTransactions");

            migrationBuilder.DropTable(
                name: "Quartiers");

            migrationBuilder.DropTable(
                name: "Communes");

            migrationBuilder.DropTable(
                name: "Villes");

            migrationBuilder.DropTable(
                name: "Pays");

            migrationBuilder.DropTable(
                name: "RoleTypes");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "Personnes");

            migrationBuilder.DropTable(
                name: "Sexes");
        }
    }
}
