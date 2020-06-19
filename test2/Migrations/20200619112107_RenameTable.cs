using Microsoft.EntityFrameworkCore.Migrations;

namespace test2.Migrations
{
    public partial class RenameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model2_Model1_IdBreedType",
                table: "Model2");

            migrationBuilder.DropForeignKey(
                name: "FK_Model3_Model2_PetIdPet",
                table: "Model3");

            migrationBuilder.DropForeignKey(
                name: "FK_Model3_Model4_VolunteerIdVolunteer",
                table: "Model3");

            migrationBuilder.DropForeignKey(
                name: "FK_Model4_Model4_IdSupervisor",
                table: "Model4");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model4",
                table: "Model4");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model3",
                table: "Model3");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model2",
                table: "Model2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model1",
                table: "Model1");

            migrationBuilder.RenameTable(
                name: "Model4",
                newName: "Volunteer");

            migrationBuilder.RenameTable(
                name: "Model3",
                newName: "Volunteer_Pet");

            migrationBuilder.RenameTable(
                name: "Model2",
                newName: "Pet");

            migrationBuilder.RenameTable(
                name: "Model1",
                newName: "BreedType");

            migrationBuilder.RenameIndex(
                name: "IX_Model4_IdSupervisor",
                table: "Volunteer",
                newName: "IX_Volunteer_IdSupervisor");

            migrationBuilder.RenameIndex(
                name: "IX_Model3_VolunteerIdVolunteer",
                table: "Volunteer_Pet",
                newName: "IX_Volunteer_Pet_VolunteerIdVolunteer");

            migrationBuilder.RenameIndex(
                name: "IX_Model3_PetIdPet",
                table: "Volunteer_Pet",
                newName: "IX_Volunteer_Pet_PetIdPet");

            migrationBuilder.RenameIndex(
                name: "IX_Model2_IdBreedType",
                table: "Pet",
                newName: "IX_Pet_IdBreedType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Volunteer",
                table: "Volunteer",
                column: "IdVolunteer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Volunteer_Pet",
                table: "Volunteer_Pet",
                columns: new[] { "IdVolunteer", "IdPet" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pet",
                table: "Pet",
                column: "IdPet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BreedType",
                table: "BreedType",
                column: "idBreedType");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_BreedType_IdBreedType",
                table: "Pet",
                column: "IdBreedType",
                principalTable: "BreedType",
                principalColumn: "idBreedType",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Volunteer_Volunteer_IdSupervisor",
                table: "Volunteer",
                column: "IdSupervisor",
                principalTable: "Volunteer",
                principalColumn: "IdVolunteer",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Volunteer_Pet_Pet_PetIdPet",
                table: "Volunteer_Pet",
                column: "PetIdPet",
                principalTable: "Pet",
                principalColumn: "IdPet",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Volunteer_Pet_Volunteer_VolunteerIdVolunteer",
                table: "Volunteer_Pet",
                column: "VolunteerIdVolunteer",
                principalTable: "Volunteer",
                principalColumn: "IdVolunteer",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_BreedType_IdBreedType",
                table: "Pet");

            migrationBuilder.DropForeignKey(
                name: "FK_Volunteer_Volunteer_IdSupervisor",
                table: "Volunteer");

            migrationBuilder.DropForeignKey(
                name: "FK_Volunteer_Pet_Pet_PetIdPet",
                table: "Volunteer_Pet");

            migrationBuilder.DropForeignKey(
                name: "FK_Volunteer_Pet_Volunteer_VolunteerIdVolunteer",
                table: "Volunteer_Pet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Volunteer_Pet",
                table: "Volunteer_Pet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Volunteer",
                table: "Volunteer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pet",
                table: "Pet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BreedType",
                table: "BreedType");

            migrationBuilder.RenameTable(
                name: "Volunteer_Pet",
                newName: "Model3");

            migrationBuilder.RenameTable(
                name: "Volunteer",
                newName: "Model4");

            migrationBuilder.RenameTable(
                name: "Pet",
                newName: "Model2");

            migrationBuilder.RenameTable(
                name: "BreedType",
                newName: "Model1");

            migrationBuilder.RenameIndex(
                name: "IX_Volunteer_Pet_VolunteerIdVolunteer",
                table: "Model3",
                newName: "IX_Model3_VolunteerIdVolunteer");

            migrationBuilder.RenameIndex(
                name: "IX_Volunteer_Pet_PetIdPet",
                table: "Model3",
                newName: "IX_Model3_PetIdPet");

            migrationBuilder.RenameIndex(
                name: "IX_Volunteer_IdSupervisor",
                table: "Model4",
                newName: "IX_Model4_IdSupervisor");

            migrationBuilder.RenameIndex(
                name: "IX_Pet_IdBreedType",
                table: "Model2",
                newName: "IX_Model2_IdBreedType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model3",
                table: "Model3",
                columns: new[] { "IdVolunteer", "IdPet" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model4",
                table: "Model4",
                column: "IdVolunteer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model2",
                table: "Model2",
                column: "IdPet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model1",
                table: "Model1",
                column: "idBreedType");

            migrationBuilder.AddForeignKey(
                name: "FK_Model2_Model1_IdBreedType",
                table: "Model2",
                column: "IdBreedType",
                principalTable: "Model1",
                principalColumn: "idBreedType",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Model3_Model2_PetIdPet",
                table: "Model3",
                column: "PetIdPet",
                principalTable: "Model2",
                principalColumn: "IdPet",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Model3_Model4_VolunteerIdVolunteer",
                table: "Model3",
                column: "VolunteerIdVolunteer",
                principalTable: "Model4",
                principalColumn: "IdVolunteer",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Model4_Model4_IdSupervisor",
                table: "Model4",
                column: "IdSupervisor",
                principalTable: "Model4",
                principalColumn: "IdVolunteer",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
