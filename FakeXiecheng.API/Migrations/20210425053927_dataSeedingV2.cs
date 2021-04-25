using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeXiecheng.API.Migrations
{
    public partial class dataSeedingV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("106e9a23-681c-4206-a197-c14d58221409"));

            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("5aee5daf-378f-422c-a9fd-c1f99d009dc0"));

            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreatedTime", "DepartureTime", "Description", "DiscountPercentage", "Features", "Fees", "Notes", "OriginalPrice", "Title", "UpdateTime" },
                values: new object[] { new Guid("106e9a23-681c-4206-a197-c14d58221410"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "��ɽ�����", 0.10000000000000001, "<p>��ס�����ֹ������</p>", "<p>��ͨ����ȫ������</p>", "<p>С��Σ�պ�ɽ��</p>", 11999.99m, "��ɽ", null });

            migrationBuilder.InsertData(
                table: "TouristRoutePictures",
                columns: new[] { "Id", "TouristRouteId", "Url" },
                values: new object[] { 1, new Guid("106e9a23-681c-4206-a197-c14d58221410"), "../../assets/images/songshan.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("106e9a23-681c-4206-a197-c14d58221410"));

            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreatedTime", "DepartureTime", "Description", "DiscountPercentage", "Features", "Fees", "Notes", "OriginalPrice", "Title", "UpdateTime" },
                values: new object[] { new Guid("106e9a23-681c-4206-a197-c14d58221409"), new DateTime(2021, 4, 25, 5, 10, 30, 768, DateTimeKind.Utc).AddTicks(9466), null, "黄山真好玩", null, "<p>吃住行娱乐购买</p>", "<p>交通费用自理</p>", "<p>小心危险</p>", 1299m, "黄山", null });

            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreatedTime", "DepartureTime", "Description", "DiscountPercentage", "Features", "Fees", "Notes", "OriginalPrice", "Title", "UpdateTime" },
                values: new object[] { new Guid("5aee5daf-378f-422c-a9fd-c1f99d009dc0"), new DateTime(2021, 4, 25, 5, 10, 30, 768, DateTimeKind.Utc).AddTicks(9931), null, "华山真好玩", null, "<p>吃住行娱乐购买</p>", "<p>交通费用自理</p>", "<p>小心危险</p>", 1299m, "华山", null });
        }
    }
}
