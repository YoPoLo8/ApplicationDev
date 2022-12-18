using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "3df8195a-8d7c-44fa-9210-51e574419ebb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d0b7eb2e-f396-44dc-83f9-58da115621f7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "32fcfe7d-2d31-4639-84de-2fe3e55c977d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8752a01b-4334-46de-af86-fd545dc0e231", "AQAAAAEAACcQAAAAEPFEdWD/3tD2dZo/utTfsOBdbDK+dHme3KAIPhmGz1PERWCpZHCY5s8K3eDOV01yPw==", "f18c6f8e-bb28-417f-8ce5-7c07576a43b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa95c3cb-222d-4b4a-b941-fb7fcdd02979", "AQAAAAEAACcQAAAAEIO3SCJ0xkdZjHUNJVmbGvYdnWNYesUqA2stxxF00FAkDWGrbCN04uOgsmribAWMSA==", "16f7b2a8-ef32-49bc-a563-c6cd68e5daa8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2dba3aa-b31e-4982-853c-217dc02d7bb1", "AQAAAAEAACcQAAAAEHQXmpPxrYWlLn6IQjGZjqL9h+66i6LPUAAnlSl/z2D+VTam0oqONd0p8sDUV4w4tg==", "59d18f40-f479-4d31-a659-b5c7ccb30a74" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5853b943-3a80-49f9-bbbe-477de984c30c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2a8cd641-6497-477b-b2e1-7a9e723e63b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "857f5d79-1f12-482c-8dae-49eed4800967");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7ae4fd2-bb0b-4f5e-a8ce-7860f2136126", "AQAAAAEAACcQAAAAEB3ZncNYP5L+ZLRSUgEMyWtoKOuzsi/ZMvC/u1caYRh/ZWee9v7s002MUMfpkkR7/A==", "9a66dd34-3ac6-4fcb-bb64-23a4a2880477" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50d348b5-aacb-4455-9046-5479d984f957", "AQAAAAEAACcQAAAAEEWG7ltEzA92bcUWGDHHM5vNq1dY5yMSEzjrSkqKH2JSY1+gUqaCC+jX4OnO9Prr+w==", "5efa5ebf-39b9-4fe2-a0b6-f3f6a482b008" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37f882f3-d1ff-43a3-90e7-371f37992afd", "AQAAAAEAACcQAAAAEOtsNoSRuGiS0sRRGMa16sJaeTLcPO0SwVC0hYrgnIGBGZjMEcSaBLn/CWBxbgQkbQ==", "3036f144-b69a-47e7-bb5c-ca599e7ef6cd" });
        }
    }
}
