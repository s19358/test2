using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace test2.Migrations
{
    public partial class TablesCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Model1",
                columns: table => new
                {
                    idBreedType = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model1", x => x.idBreedType);
                });

            migrationBuilder.CreateTable(
                name: "Model4",
                columns: table => new
                {
                    IdVolunteer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSupervisor = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    Surname = table.Column<string>(maxLength: 80, nullable: false),
                    Phone = table.Column<string>(maxLength: 30, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 80, nullable: false),
                    StartingDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model4", x => x.IdVolunteer);
                    table.ForeignKey(
                        name: "FK_Model4_Model4_IdSupervisor",
                        column: x => x.IdSupervisor,
                        principalTable: "Model4",
                        principalColumn: "IdVolunteer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Model2",
                columns: table => new
                {
                    IdPet = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdBreedType = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    isMale = table.Column<bool>(nullable: false),
                    DateRegistered = table.Column<DateTime>(type: "date", nullable: false),
                    ApprocimateDateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    AdoptedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model2", x => x.IdPet);
                    table.ForeignKey(
                        name: "FK_Model2_Model1_IdBreedType",
                        column: x => x.IdBreedType,
                        principalTable: "Model1",
                        principalColumn: "idBreedType",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Model3",
                columns: table => new
                {
                    IdVolunteer = table.Column<int>(nullable: false),
                    IdPet = table.Column<int>(nullable: false),
                    DateAccepted = table.Column<DateTime>(type: "date", nullable: false),
                    PetIdPet = table.Column<int>(nullable: true),
                    VolunteerIdVolunteer = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model3", x => new { x.IdVolunteer, x.IdPet });
                    table.ForeignKey(
                        name: "FK_Model3_Model2_PetIdPet",
                        column: x => x.PetIdPet,
                        principalTable: "Model2",
                        principalColumn: "IdPet",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Model3_Model4_VolunteerIdVolunteer",
                        column: x => x.VolunteerIdVolunteer,
                        principalTable: "Model4",
                        principalColumn: "IdVolunteer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Model2_IdBreedType",
                table: "Model2",
                column: "IdBreedType");

            migrationBuilder.CreateIndex(
                name: "IX_Model3_PetIdPet",
                table: "Model3",
                column: "PetIdPet");

            migrationBuilder.CreateIndex(
                name: "IX_Model3_VolunteerIdVolunteer",
                table: "Model3",
                column: "VolunteerIdVolunteer");

            migrationBuilder.CreateIndex(
                name: "IX_Model4_IdSupervisor",
                table: "Model4",
                column: "IdSupervisor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Model3");

            migrationBuilder.DropTable(
                name: "Model2");

            migrationBuilder.DropTable(
                name: "Model4");

            migrationBuilder.DropTable(
                name: "Model1");
        }
    }
}
