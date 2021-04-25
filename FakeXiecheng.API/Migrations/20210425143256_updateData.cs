using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeXiecheng.API.Migrations
{
    public partial class updateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("106e9a23-681c-4206-a197-c14d58221410"),
                columns: new[] { "Description", "Features", "Fees", "Notes", "Title" },
                values: new object[] { "华山真好玩", "<p>吃喝玩乐</p>", "<p>费用全包</p>", "<p>注意小偷</p>", "华山" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("106e9a23-681c-4206-a197-c14d58221410"),
                columns: new[] { "Description", "Features", "Fees", "Notes", "Title" },
                values: new object[] { "��ɽ�����", "<p>��ס�����ֹ������</p>", "<p>��ͨ����ȫ������</p>", "<p>С��Σ�պ�ɽ��</p>", "��ɽ" });
        }
    }
}
