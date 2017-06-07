using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name, CountryOfOrigin) Values ('Ford', 'USA')");
            migrationBuilder.Sql("INSERT INTO Makes (Name, CountryOfOrigin) Values ('Mazda', 'Japan')");
            migrationBuilder.Sql("INSERT INTO Makes (Name, CountryOfOrigin) Values ('Mercedes-Benz', 'Germany')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId, Year) Values ('Mustang', (SELECT Id FROM Makes WHERE Name = 'Ford'), '2017')");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId, Year) Values ('F150', (SELECT Id FROM Makes WHERE Name = 'Ford'), '2017')");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId, Year) Values ('F250', (SELECT Id FROM Makes WHERE Name = 'Ford'), '2017')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId, Year) Values ('3', (SELECT Id FROM Makes WHERE Name = 'Mazda'), '2017')");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId, Year) Values ('6', (SELECT Id FROM Makes WHERE Name = 'Mazda'), '2017')");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId, Year) Values ('Miata', (SELECT Id FROM Makes WHERE Name = 'Mazda'), '2017')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId, Year) Values ('400E', (SELECT Id FROM Makes WHERE Name = 'Mercedes-Benz'), '2017')");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId, Year) Values ('SLK280', (SELECT Id FROM Makes WHERE Name = 'Mercedes-Benz'), '2017')");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId, Year) Values ('C350', (SELECT Id FROM Makes WHERE Name = 'Mercedes-Benz'), '2017')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes WHERE Name IN ('Ford', 'Mazda', 'Mercedes-Benz')");
            migrationBuilder.Sql("DELETE FROM Models");
        }
    }
}
