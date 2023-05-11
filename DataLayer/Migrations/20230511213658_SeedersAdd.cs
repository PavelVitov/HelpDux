using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class SeedersAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Password", "PictureUrl", "Roles", "Username" },
                values: new object[,]
                {
                    { 1, "pavelvitov02@gmail.com", "$2a$11$lfdaa3MQFsVgziZV984tWOUTUqPwyeXoz3hPnhBk/uD6g1xllPBRS", "https://example.com/johndoe.jpg", "Admin", "Lucifer23" },
                    { 9, "adamsmith@example.com", "$2a$11$kkOzkcPmSDcj.Hhv/qQWY.Rkr2wDjx8i2R4UIsiWYYQWSQlloP/vS", "https://example.com/adamsmith.jpg", "User", "AdamSmith" },
                    { 8, "samanthabrown@example.com", "$2a$11$93dNS56UDYkeQdJNRYu/gO5UDJiZ5D3ip06DmJ8Ut1ujEYvVPoHlK", "https://example.com/samanthabrown.jpg", "User", "SamanthaBrown" },
                    { 7, "mikewilliams@example.com", "$2a$11$4vydcI3xWT00niFfK.1SyOo6kqhIgFBBivXMggxKbBdj/XUQA3At.", "https://example.com/mikewilliams.jpg", "User", "MikeWilliams" },
                    { 6, "lisawang@example.com", "$2a$11$DBLcNc9eR9jz5rzWodca9.1RKesCnPAqR0RJfN2Nc8.lsyYEuZo5m", "https://example.com/lisawang.jpg", "User", "LisaWang" },
                    { 10, "oliviajones@example.com", "$2a$11$8zmr5ZfjzL15F1BnhSjyT.u1PF/jOC3vSwM5F/8d7GodObU6Qzqka", "https://example.com/oliviajones.jpg", "User", "OliviaJones" },
                    { 4, "alicejohnson@example.com", "$2a$11$S3JpLyvHTot2wRhPeNUiQ.el7QA4QrEgjBwjpaxbV1.iCYB8366B2", "https://example.com/alicejohnson.jpg", "User", "AliceJohnson" },
                    { 3, "bobsmith@example.com", "$2a$11$P.nr7V6pBB2HNMB8mrjceOAUJnrHESHohNXEVTmLsdD3r9wfcAHrq", "https://example.com/bobsmith.jpg", "User", "BobSmith" },
                    { 2, "janedoe@example.com", "$2a$11$l8fXvrISj6Z5sBgj6lJwFuIiAxKefX0tNFTYPSAu1oVGdo0MK1fki", "https://example.com/janedoe.jpg", "User", "JaneDoe" },
                    { 5, "davidlee@example.com", "$2a$11$YtIyTuOPbBY9.CQRS.AYeOu5GkOUtR8Deazc8yHPuxrUTEoDeRAc6", "https://example.com/davidlee.jpg", "User", "DavidLee" }
                });

            migrationBuilder.InsertData(
                table: "Websites",
                columns: new[] { "WebsiteId", "CreatedAt", "Description", "ImageUrl", "IsActive", "Name", "Tag", "UpdatedAt", "Url" },
                values: new object[,]
                {
                    { 8, new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(6363), "Social media platform", "https://example.com/instagram.jpg", true, "Instagram", "Social_Media", new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(6364), "https://www.instagram.com" },
                    { 1, new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(5859), "Search engine", "https://example.com/google.jpg", true, "Google", "Search_Engine", new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(5861), "https://www.google.com" },
                    { 2, new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(6346), "Social media platform", "https://example.com/twitter.jpg", true, "Twitter", "Social_Media", new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(6347), "https://www.twitter.com" },
                    { 3, new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(6350), "Code hosting platform", "https://example.com/github.jpg", true, "GitHub", "Code_Hosting", new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(6351), "https://www.github.com" },
                    { 4, new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(6353), "Video sharing platform", "https://example.com/youtube.jpg", true, "YouTube", "Entertainment", new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(6354), "https://www.youtube.com" },
                    { 5, new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(6356), "Social media platform", "https://example.com/facebook.jpg", true, "Facebook", "Social_Media", new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(6356), "https://www.facebook.com" },
                    { 6, new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(6358), "Streaming platform", "https://example.com/netflix.jpg", true, "Netflix", "Entertainment", new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(6359), "https://www.netflix.com" },
                    { 7, new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(6361), "Music streaming platform", "https://example.com/spotify.jpg", true, "Spotify", "Music", new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(6361), "https://www.spotify.com" },
                    { 9, new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(6366), "Social media platform", "https://example.com/tiktok.jpg", true, "TikTok", "Social_Media", new DateTime(2023, 5, 11, 21, 36, 56, 742, DateTimeKind.Utc).AddTicks(6366), "https://www.tiktok.com" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "CreatedAt", "Rating", "UpdatedAt", "UserId", "WebsiteId" },
                values: new object[,]
                {
                    { 1, "Great search engine!", new DateTime(2023, 5, 11, 21, 36, 57, 948, DateTimeKind.Utc).AddTicks(7267), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 2, "Love using Twitter!", new DateTime(2023, 5, 11, 21, 36, 57, 948, DateTimeKind.Utc).AddTicks(7272), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 3, "GitHub is amazing for open-source projects!", new DateTime(2023, 5, 11, 21, 36, 57, 948, DateTimeKind.Utc).AddTicks(7274), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 4, "I find YouTube very entertaining!", new DateTime(2023, 5, 11, 21, 36, 57, 948, DateTimeKind.Utc).AddTicks(7276), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 5, "Facebook helps me stay connected with friends and family!", new DateTime(2023, 5, 11, 21, 36, 57, 948, DateTimeKind.Utc).AddTicks(7278), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5 },
                    { 6, "Netflix has the best shows and movies!", new DateTime(2023, 5, 11, 21, 36, 57, 948, DateTimeKind.Utc).AddTicks(7279), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 6 },
                    { 7, "I love listening to music on Spotify!", new DateTime(2023, 5, 11, 21, 36, 57, 948, DateTimeKind.Utc).AddTicks(7281), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7 },
                    { 8, "Instagram is my favorite social media app!", new DateTime(2023, 5, 11, 21, 36, 57, 948, DateTimeKind.Utc).AddTicks(7283), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "WebsiteId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "WebsiteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "WebsiteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "WebsiteId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "WebsiteId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "WebsiteId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "WebsiteId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "WebsiteId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "WebsiteId",
                keyValue: 8);
        }
    }
}
