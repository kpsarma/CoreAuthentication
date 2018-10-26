using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreAuthentication.Migrations
{
    public partial class Teacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    DistrinctId = table.Column<string>(maxLength: 450, nullable: true),
                    StateId = table.Column<string>(maxLength: 450, nullable: true),
                    CountryId = table.Column<string>(maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    StateId = table.Column<string>(maxLength: 450, nullable: true),
                    CountryId = table.Column<string>(maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EducationBoard",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationBoard", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    EMail = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EmailsGroup",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailsGroup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EmailsOfEmailsGroup",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    EmailId = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    EmailsGroupId = table.Column<decimal>(type: "numeric(12, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailsOfEmailsGroup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fax",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Fax = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fax", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FaxsGroup",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaxsGroup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FaxsOfFaxsGroup",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    FaxId = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    FaxsGroupId = table.Column<decimal>(type: "numeric(12, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaxsOfFaxsGroup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    PhNumber = table.Column<decimal>(type: "numeric(12, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PhonesGroup",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhonesGroup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PhonesOfPhonesGroup",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    PhoneId = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    PhoneGroupId = table.Column<decimal>(type: "numeric(12, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhonesOfPhonesGroup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    AddressLine1 = table.Column<string>(maxLength: 450, nullable: true),
                    AddressLine2 = table.Column<string>(maxLength: 450, nullable: true),
                    AddressLine3 = table.Column<string>(maxLength: 450, nullable: true),
                    PIN = table.Column<string>(maxLength: 450, nullable: true),
                    CityId = table.Column<string>(maxLength: 450, nullable: true),
                    DistrictId = table.Column<string>(maxLength: 450, nullable: true),
                    StateId = table.Column<string>(maxLength: 450, nullable: true),
                    CountryId = table.Column<string>(maxLength: 450, nullable: true),
                    PhonesGroupId = table.Column<string>(maxLength: 450, nullable: true),
                    EmailsGroupId = table.Column<string>(maxLength: 450, nullable: true),
                    FaxsGroupId = table.Column<string>(maxLength: 450, nullable: true),
                    WebSitesGroupId = table.Column<string>(maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    CountryId = table.Column<string>(maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StudentAddress",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    FatherName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    MotherName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    GurdianName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    AddressLine1 = table.Column<string>(maxLength: 450, nullable: true),
                    AddressLine2 = table.Column<string>(maxLength: 450, nullable: true),
                    AddressLine3 = table.Column<string>(maxLength: 450, nullable: true),
                    PIN = table.Column<string>(maxLength: 450, nullable: true),
                    CityId = table.Column<string>(maxLength: 450, nullable: true),
                    DistrictId = table.Column<string>(maxLength: 450, nullable: true),
                    StateId = table.Column<string>(maxLength: 450, nullable: true),
                    CountryId = table.Column<string>(maxLength: 450, nullable: true),
                    PhonesGroupId = table.Column<string>(maxLength: 450, nullable: true),
                    EmailsGroupId = table.Column<string>(maxLength: 450, nullable: true),
                    FaxsGroupId = table.Column<string>(maxLength: 450, nullable: true),
                    WebSitesGroupId = table.Column<string>(maxLength: 450, nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAddress", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StudentEducation",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    StudentId = table.Column<string>(maxLength: 450, nullable: true),
                    ClassId = table.Column<string>(maxLength: 450, nullable: true),
                    SchoolId = table.Column<string>(maxLength: 450, nullable: true),
                    SyllabusId = table.Column<string>(maxLength: 450, nullable: true),
                    BoardId = table.Column<string>(maxLength: 450, nullable: true),
                    ForAcademicYearFrom = table.Column<DateTime>(type: "datetime", nullable: true),
                    ForAcademicYearTo = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEducation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SyllabusType",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SyllabusType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WebSite",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    WebSite = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebSite", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WebSitesGroup",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebSitesGroup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WebSitesOfWebSitesGroup",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    WebSiteId = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    WebSitesGroupId = table.Column<decimal>(type: "numeric(12, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebSitesOfWebSitesGroup", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "EducationBoard");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "EmailsGroup");

            migrationBuilder.DropTable(
                name: "EmailsOfEmailsGroup");

            migrationBuilder.DropTable(
                name: "Fax");

            migrationBuilder.DropTable(
                name: "FaxsGroup");

            migrationBuilder.DropTable(
                name: "FaxsOfFaxsGroup");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "PhonesGroup");

            migrationBuilder.DropTable(
                name: "PhonesOfPhonesGroup");

            migrationBuilder.DropTable(
                name: "School");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "StudentAddress");

            migrationBuilder.DropTable(
                name: "StudentEducation");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "SyllabusType");

            migrationBuilder.DropTable(
                name: "WebSite");

            migrationBuilder.DropTable(
                name: "WebSitesGroup");

            migrationBuilder.DropTable(
                name: "WebSitesOfWebSitesGroup");
        }
    }
}
