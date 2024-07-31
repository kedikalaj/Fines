using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fines.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingTheDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "VehicleId", "LicensePlate" },
                values: new object[,]
                {
                    { 1, "AA 123 BB" },
                    { 2, "BB 456 CC" },
                    { 3, "CC 789 DD" },
                    { 4, "DD 012 EE" },
                    { 5, "EE 345 FF" },
                    { 6, "FF 678 GG" },
                    { 7, "GG 901 HH" },
                    { 8, "HH 234 II" },
                    { 9, "II 567 JJ" },
                    { 10, "JJ 890 KK" }
                });

            migrationBuilder.InsertData(
                table: "Fine",
                columns: new[] { "Id", "Amount", "DateOfFine", "IsPaid", "PaymentDate", "Reason", "VehicleId" },
                values: new object[,]
                {
                    { 1, 50m, new DateTime(2024, 7, 30, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4006), false, null, "Parkim i paligjshëm", 1 },
                    { 2, 100m, new DateTime(2024, 7, 29, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4052), false, null, "Shpejtësi e tepërt", 1 },
                    { 3, 75m, new DateTime(2024, 7, 28, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4055), false, null, "Mungesë sigurie", 1 },
                    { 4, 50m, new DateTime(2024, 7, 27, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4058), false, null, "Parkim i paligjshëm", 2 },
                    { 5, 100m, new DateTime(2024, 7, 26, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4060), false, null, "Shpejtësi e tepërt", 2 },
                    { 6, 75m, new DateTime(2024, 7, 25, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4062), false, null, "Mungesë sigurie", 2 },
                    { 7, 50m, new DateTime(2024, 7, 24, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4063), false, null, "Parkim i paligjshëm", 4 },
                    { 8, 100m, new DateTime(2024, 7, 23, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4065), false, null, "Shpejtësi e tepërt", 4 },
                    { 9, 75m, new DateTime(2024, 7, 22, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4070), false, null, "Mungesë sigurie", 4 },
                    { 10, 50m, new DateTime(2024, 7, 21, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4072), false, null, "Parkim i paligjshëm", 5 },
                    { 11, 100m, new DateTime(2024, 7, 20, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4074), false, null, "Shpejtësi e tepërt", 5 },
                    { 12, 75m, new DateTime(2024, 7, 19, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4075), false, null, "Mungesë sigurie", 5 },
                    { 13, 50m, new DateTime(2024, 7, 18, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4078), false, null, "Parkim i paligjshëm", 6 },
                    { 14, 100m, new DateTime(2024, 7, 17, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4080), false, null, "Shpejtësi e tepërt", 6 },
                    { 15, 75m, new DateTime(2024, 7, 16, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4082), false, null, "Mungesë sigurie", 6 },
                    { 16, 50m, new DateTime(2024, 7, 15, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4084), false, null, "Parkim i paligjshëm", 7 },
                    { 17, 100m, new DateTime(2024, 7, 14, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4086), false, null, "Shpejtësi e tepërt", 7 },
                    { 18, 75m, new DateTime(2024, 7, 13, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4088), false, null, "Mungesë sigurie", 7 },
                    { 19, 50m, new DateTime(2024, 7, 12, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4089), false, null, "Parkim i paligjshëm", 8 },
                    { 20, 100m, new DateTime(2024, 7, 11, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4091), false, null, "Shpejtësi e tepërt", 8 },
                    { 21, 75m, new DateTime(2024, 7, 10, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4093), false, null, "Mungesë sigurie", 8 },
                    { 22, 50m, new DateTime(2024, 7, 9, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4095), false, null, "Parkim i paligjshëm", 9 },
                    { 23, 100m, new DateTime(2024, 7, 8, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4097), false, null, "Shpejtësi e tepërt", 9 },
                    { 24, 75m, new DateTime(2024, 7, 7, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4099), false, null, "Mungesë sigurie", 9 },
                    { 25, 50m, new DateTime(2024, 7, 6, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4101), false, null, "Parkim i paligjshëm", 10 },
                    { 26, 100m, new DateTime(2024, 7, 5, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4103), false, null, "Shpejtësi e tepërt", 10 },
                    { 27, 75m, new DateTime(2024, 7, 4, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4105), false, null, "Mungesë sigurie", 10 },
                    { 28, 50m, new DateTime(2024, 7, 3, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4106), false, null, "Parkim i paligjshëm", 1 },
                    { 29, 100m, new DateTime(2024, 7, 2, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4108), false, null, "Shpejtësi e tepërt", 1 },
                    { 30, 50m, new DateTime(2024, 7, 1, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4110), false, null, "Parkim i paligjshëm", 2 },
                    { 31, 100m, new DateTime(2024, 6, 30, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4112), false, null, "Shpejtësi e tepërt", 2 },
                    { 32, 50m, new DateTime(2024, 6, 29, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4113), false, null, "Parkim i paligjshëm", 4 },
                    { 33, 100m, new DateTime(2024, 6, 28, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4115), false, null, "Shpejtësi e tepërt", 4 },
                    { 34, 50m, new DateTime(2024, 6, 27, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4117), false, null, "Parkim i paligjshëm", 5 },
                    { 35, 100m, new DateTime(2024, 6, 26, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4120), false, null, "Shpejtësi e tepërt", 5 },
                    { 36, 50m, new DateTime(2024, 6, 25, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4121), false, null, "Parkim i paligjshëm", 6 },
                    { 37, 100m, new DateTime(2024, 6, 24, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4123), false, null, "Shpejtësi e tepërt", 6 },
                    { 38, 50m, new DateTime(2024, 6, 23, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4125), false, null, "Parkim i paligjshëm", 7 },
                    { 39, 100m, new DateTime(2024, 6, 22, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4127), false, null, "Shpejtësi e tepërt", 7 },
                    { 40, 50m, new DateTime(2024, 6, 21, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4129), false, null, "Parkim i paligjshëm", 8 },
                    { 41, 100m, new DateTime(2024, 6, 20, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4130), false, null, "Shpejtësi e tepërt", 8 },
                    { 42, 50m, new DateTime(2024, 6, 19, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4132), false, null, "Parkim i paligjshëm", 9 },
                    { 43, 100m, new DateTime(2024, 6, 18, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4134), false, null, "Shpejtësi e tepërt", 9 },
                    { 44, 50m, new DateTime(2024, 6, 17, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4136), false, null, "Parkim i paligjshëm", 10 },
                    { 45, 100m, new DateTime(2024, 6, 16, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4137), false, null, "Shpejtësi e tepërt", 10 },
                    { 46, 50m, new DateTime(2024, 6, 15, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4146), false, null, "Parkim i paligjshëm", 1 },
                    { 47, 100m, new DateTime(2024, 6, 14, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4147), false, null, "Shpejtësi e tepërt", 1 },
                    { 48, 50m, new DateTime(2024, 6, 13, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4149), false, null, "Parkim i paligjshëm", 2 },
                    { 49, 50m, new DateTime(2024, 6, 12, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4151), false, null, "Parkim i paligjshëm", 4 },
                    { 50, 50m, new DateTime(2024, 6, 11, 10, 41, 55, 294, DateTimeKind.Local).AddTicks(4153), false, null, "Parkim i paligjshëm", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Fine",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 10);
        }
    }
}
