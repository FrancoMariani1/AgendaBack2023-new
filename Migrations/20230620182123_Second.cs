using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaBack2023.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Location_LocationId",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TelephoneNumber",
                table: "Contacts",
                newName: "telephoneNumber");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Contacts",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Contacts",
                newName: "locationid");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Contacts",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Contacts",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Contacts",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "CelularNumber",
                table: "Contacts",
                newName: "celularNumber");

            migrationBuilder.RenameColumn(
                name: "Avatar",
                table: "Contacts",
                newName: "avatar");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Contacts",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_LocationId",
                table: "Contacts",
                newName: "IX_Contacts_locationid");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Locations",
                newName: "longitude");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Locations",
                newName: "latitude");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Locations",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Locations",
                newName: "id");

            migrationBuilder.AlterColumn<long>(
                name: "telephoneNumber",
                table: "Contacts",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "celularNumber",
                table: "Contacts",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Locations_locationid",
                table: "Contacts",
                column: "locationid",
                principalTable: "Locations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Locations_locationid",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "telephoneNumber",
                table: "Contacts",
                newName: "TelephoneNumber");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Contacts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "locationid",
                table: "Contacts",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Contacts",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Contacts",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Contacts",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "celularNumber",
                table: "Contacts",
                newName: "CelularNumber");

            migrationBuilder.RenameColumn(
                name: "avatar",
                table: "Contacts",
                newName: "Avatar");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Contacts",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_locationid",
                table: "Contacts",
                newName: "IX_Contacts_LocationId");

            migrationBuilder.RenameColumn(
                name: "longitude",
                table: "Location",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "latitude",
                table: "Location",
                newName: "Latitude");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Location",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Location",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "TelephoneNumber",
                table: "Contacts",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CelularNumber",
                table: "Contacts",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Location_LocationId",
                table: "Contacts",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
