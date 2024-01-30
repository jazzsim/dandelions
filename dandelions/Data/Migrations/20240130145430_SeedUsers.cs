using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dandelions.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PostedBy",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "14e908ad-573b-414b-a4c4-9845a83e49da", 0, "21cbca0a-919d-4864-a58a-961910dd6cb1", "CCCAQX46@gmail.com", true, false, null, "CCCAQX46@GMAIL.COM", "CCCAQX46@GMAIL.COM", "AQAAAAIAAYagAAAAELHczJbjg+LiQJ1+/gXapk0pVF9ToaTj6v8ppbtQSuCxpWZmAr3tPj1hUUft51cxKw==", null, false, "813a4291-1e76-44a3-ad88-f4779cccfcd2", false, "CCCAQX46@gmail.com" },
                    { "1530b980-cf9a-4ab7-a0af-b5da690821fc", 0, "4732d3cf-fa18-48a6-a132-6ed90999bb40", "okhvy8Yb@gmail.com", true, false, null, "OKHVY8YB@GMAIL.COM", "OKHVY8YB@GMAIL.COM", "AQAAAAIAAYagAAAAEPbSfSvg31FeFveo+XXUNN7PLv2JprzyyKH7vMVSwVcgDJKc+lSPusOBeRXAw/HELw==", null, false, "172749fe-75e9-4976-a214-e1ef95837ba3", false, "okhvy8Yb@gmail.com" },
                    { "19fb8908-57d8-4d9c-ae32-618ce4724e13", 0, "dc7b3dc1-be43-4bef-a1a3-1147a5a02766", "tCrogKdy@gmail.com", true, false, null, "TCROGKDY@GMAIL.COM", "TCROGKDY@GMAIL.COM", "AQAAAAIAAYagAAAAEHWsgX2VCwwhI4HUjoPiSNC2aN9rVgw0613o+QVGTBo2+1HD41ejGNCflRj76rvG/g==", null, false, "0aee5956-1b1b-478c-9e1b-cecc6e0213ae", false, "tCrogKdy@gmail.com" },
                    { "1a0b3b96-3dab-4541-bd17-2dfe2046f858", 0, "15a52d63-324a-4866-b9a3-4c99166466a3", "QGMUWUIO@gmail.com", true, false, null, "QGMUWUIO@GMAIL.COM", "QGMUWUIO@GMAIL.COM", "AQAAAAIAAYagAAAAEHNDAg1MdkwpRgo619KQwYSiU/iVrjouBVZSX68NNq3vwWKb+W7UHnP5oTL+d4mjLA==", null, false, "c03ec368-5ecd-4af6-ac6f-2a7501f0ff42", false, "QGMUWUIO@gmail.com" },
                    { "1de7844a-868b-40a9-adc1-47fb39266fbc", 0, "4370fc9b-097e-4470-879c-00f67a9e9923", "5GIjVsiE@gmail.com", true, false, null, "5GIJVSIE@GMAIL.COM", "5GIJVSIE@GMAIL.COM", "AQAAAAIAAYagAAAAEAhDnvmt9aGTdDgikh2X8hcLNphVWCOXWPmdOq3vTW+aIawCz5zHMpWFCGGt1+6ZTQ==", null, false, "00fa2158-3a58-464c-8e0b-6b0c4445fc7e", false, "5GIjVsiE@gmail.com" },
                    { "201ce957-f7f3-45c2-9910-d793b0563839", 0, "b0c11253-f076-4446-934a-66c168b7b616", "xzkxuvzK@gmail.com", true, false, null, "XZKXUVZK@GMAIL.COM", "XZKXUVZK@GMAIL.COM", "AQAAAAIAAYagAAAAEMjbFN8jiDMU9YjGjjVNaqWY7dRuMOoAZ0CDnF0XU2Z/HAHVUSlq2flYFXYOIiro3g==", null, false, "763f6fa8-74e4-4d1c-b394-cec409e1f8d8", false, "xzkxuvzK@gmail.com" },
                    { "25657a6c-2741-4a5f-8054-dedf43c11871", 0, "4d3ffc4c-f317-4d36-af79-280036631af7", "Bgmej0Fx@gmail.com", true, false, null, "BGMEJ0FX@GMAIL.COM", "BGMEJ0FX@GMAIL.COM", "AQAAAAIAAYagAAAAENBeXXUkumKjwOfXs1mvgY4eI6+OxK/x06MzrH241iz4p3Hg6eSPWjkZhkkOWkk6Gw==", null, false, "17cfd5b1-684c-439e-8acd-d55c70d67864", false, "Bgmej0Fx@gmail.com" },
                    { "2627ae25-4ec9-4bb2-a184-b20a02b6d718", 0, "61af11b2-03ef-4d6a-a085-c075d9f5859e", "5CRPgdy8@gmail.com", true, false, null, "5CRPGDY8@GMAIL.COM", "5CRPGDY8@GMAIL.COM", "AQAAAAIAAYagAAAAEJde9Of/OdsZFwSrfjdezmh0ZQc1HLeYEASM2F0HCDeNpAupeHvYmKPzEQtJPsbBMA==", null, false, "dc1893de-3f62-453d-a0e2-59fa829cae1d", false, "5CRPgdy8@gmail.com" },
                    { "36473574-c3a6-4394-b634-fa8e6202576d", 0, "4ad1b349-ae03-4343-ac4b-18095bce54a6", "nJVj8Yot@gmail.com", true, false, null, "NJVJ8YOT@GMAIL.COM", "NJVJ8YOT@GMAIL.COM", "AQAAAAIAAYagAAAAEHlY3O71KmnNnI/x7ZJaPHEJ/Hh6gzO0UDzax/NvLfn8tL3lEb1yc7gZqZmJSuPEhw==", null, false, "f937fc81-79bc-4065-90dc-eca6be4c9771", false, "nJVj8Yot@gmail.com" },
                    { "3d102d09-9286-40ad-a015-33f1061c4440", 0, "65779ef3-1503-479c-a46c-4c694fa195bd", "eycknINR@gmail.com", true, false, null, "EYCKNINR@GMAIL.COM", "EYCKNINR@GMAIL.COM", "AQAAAAIAAYagAAAAEEX8wczzDx/dsuDnSWitqD/hX/h4ehey4dkSQytZuP2oxoYkf2OrFSTuuc8nGbA9tA==", null, false, "34720beb-2b6b-4f53-870c-a40e944779c8", false, "eycknINR@gmail.com" },
                    { "4ca459fd-16c0-4445-bd8e-64b597a5c5df", 0, "7eb68429-695f-4d34-8329-2de665f9deda", "vZKThObZ@gmail.com", true, false, null, "VZKTHOBZ@GMAIL.COM", "VZKTHOBZ@GMAIL.COM", "AQAAAAIAAYagAAAAEFFP+KALVNqlFD2U8tdXUAdJxmT199NS2gP355J3xBWmGP1409FaGkCAsW9zNdfivg==", null, false, "e055a2bb-a76e-432a-a4d2-09ed69573d7a", false, "vZKThObZ@gmail.com" },
                    { "4db1173b-29cf-47da-9bf4-a825f82cb954", 0, "3c78906a-a1d4-4600-ac55-7ee399c1af1f", "QEvljpUi@gmail.com", true, false, null, "QEVLJPUI@GMAIL.COM", "QEVLJPUI@GMAIL.COM", "AQAAAAIAAYagAAAAEJiKtB88dA24sO+6eNYB6XSNuz0Yd1Vi73mGCCOyLdWH9z/Jrmony/Dv+aukzqNcpw==", null, false, "cdc390d3-0c91-4aa0-b369-300799ecd8e7", false, "QEvljpUi@gmail.com" },
                    { "4e751681-aede-4586-918b-f7c10999e9e6", 0, "37a3a13c-fe91-4589-8f47-304b9c550db6", "Wd4YA7SG@gmail.com", true, false, null, "WD4YA7SG@GMAIL.COM", "WD4YA7SG@GMAIL.COM", "AQAAAAIAAYagAAAAENI5Yo3wxDf0e+03T6/NLkAcv41UaPrgdQgS4no6iPLGJBTd0fiWEgqvsBcj5or0kQ==", null, false, "5352e775-3074-4ca9-983d-f94e556602b1", false, "Wd4YA7SG@gmail.com" },
                    { "51234d3a-bb14-40fa-ba40-e95c103df3f3", 0, "f958a12e-9361-42ca-8802-85b72848fa69", "lcHp3TSi@gmail.com", true, false, null, "LCHP3TSI@GMAIL.COM", "LCHP3TSI@GMAIL.COM", "AQAAAAIAAYagAAAAECgXLYjHjIIQ/WeU+8AwQuiTxbI8Ofis77IB+6XKs59va4h1gH8akO4Il5aXDY0KvA==", null, false, "6046b0b0-c2ba-4fce-ad83-47fd42a68627", false, "lcHp3TSi@gmail.com" },
                    { "54ae9e22-e1aa-434d-9104-b48286a3e3b8", 0, "13382488-7a29-4fdc-ae10-d889c3250dac", "ZeaxVMNt@gmail.com", true, false, null, "ZEAXVMNT@GMAIL.COM", "ZEAXVMNT@GMAIL.COM", "AQAAAAIAAYagAAAAED5dvRj5eAZB2/zr6e1Gv1cEsxyfbfNn75/pBGbqqrh/ti9lji1of3Qy/DzAa97rZw==", null, false, "2a699343-a07c-41ec-acdb-cdbfa8e7468b", false, "ZeaxVMNt@gmail.com" },
                    { "5c49ea74-7c5a-45b5-91f6-8cf6c7959b17", 0, "e41dcedc-ee7d-45b1-8960-f866a1fe4968", "RG29MvsA@gmail.com", true, false, null, "RG29MVSA@GMAIL.COM", "RG29MVSA@GMAIL.COM", "AQAAAAIAAYagAAAAEFjaWpjLC2wGPf20tLpMOxVBMvGwDFOjdyxr25eEXnnvGOkeiYtlAFKHQnn4RRLWNQ==", null, false, "01a1e98c-10e6-4c78-a5b1-f032cbf7a951", false, "RG29MvsA@gmail.com" },
                    { "5d98629c-8a87-4fd4-8abb-b9f7133f84ae", 0, "caa3f17c-9537-4b97-9de4-fdd0741d7bba", "XR6xee7g@gmail.com", true, false, null, "XR6XEE7G@GMAIL.COM", "XR6XEE7G@GMAIL.COM", "AQAAAAIAAYagAAAAEMN99ExhoZhSm24vKReoeQjWmeuGkue5NleAbdMzamc966UYhLv5Cebperzw0gLpBw==", null, false, "a5173296-8944-4eba-af0d-de76d59b183b", false, "XR6xee7g@gmail.com" },
                    { "608b0c64-aa5c-4e1c-8944-178f02cbeccc", 0, "f99c7338-9d61-4c8f-a28f-871bda986bc9", "VYoM6htf@gmail.com", true, false, null, "VYOM6HTF@GMAIL.COM", "VYOM6HTF@GMAIL.COM", "AQAAAAIAAYagAAAAEGCTUGVYFVU/TYzJl/40ok90Bg3K6r84meyKpxc6t/mKw0vFTER7LaHiQY88j6swUA==", null, false, "6c041375-4f6e-4d3f-8edb-1caa6c67560b", false, "VYoM6htf@gmail.com" },
                    { "6ed6e001-0ab1-40e8-92ec-c40f44b1da4a", 0, "e1e4a44a-12e2-474f-9525-d518b680bae8", "ZPypaCn1@gmail.com", true, false, null, "ZPYPACN1@GMAIL.COM", "ZPYPACN1@GMAIL.COM", "AQAAAAIAAYagAAAAEFcRakPyfC8f7oseay7WHc+XNU3c2l9lhzU78/x042K2mhG2Eins/pr5d1S6ErnqBA==", null, false, "d31d0dab-2d93-421e-a5c3-5d498f065926", false, "ZPypaCn1@gmail.com" },
                    { "6fbbf736-e555-40ea-9a3f-ffba368ce809", 0, "ab9b1b7c-8810-4a13-afc4-22245ffdce1f", "bCXGG2WS@gmail.com", true, false, null, "BCXGG2WS@GMAIL.COM", "BCXGG2WS@GMAIL.COM", "AQAAAAIAAYagAAAAEKHfhGrv0TI4/DWv6I3FwNqZYXTQZMd8a50jCgHJUlkhouPI+WFc6rEXopFNI/LIvw==", null, false, "c27be4b2-abe6-4a4f-9bf1-6486645265c0", false, "bCXGG2WS@gmail.com" },
                    { "7078d013-b6ed-4f9e-83a0-933d5f0fc3cb", 0, "c8d47ecf-510f-4d43-9e7c-4cb67e6506b1", "RE96McUY@gmail.com", true, false, null, "RE96MCUY@GMAIL.COM", "RE96MCUY@GMAIL.COM", "AQAAAAIAAYagAAAAEPJ9sadMaNyVwtDAt6c8/GGkLQrEMXXCiUh2AX5r7eENl1HGBVMe36XaE8jpHs/2qg==", null, false, "e8a6cdf2-82d5-4a32-9467-965b2e1dca09", false, "RE96McUY@gmail.com" },
                    { "7cae7cf2-b199-44d4-9f43-3d50caf19687", 0, "3df5ba7f-facf-42b0-b9be-c696daa3f7fe", "H5Uf8o8w@gmail.com", true, false, null, "H5UF8O8W@GMAIL.COM", "H5UF8O8W@GMAIL.COM", "AQAAAAIAAYagAAAAEFErJjN6u/K7d+Mt5JHOXIKC/rxj5SPzZLLRQrJ4QiK+KnD46spHh3zzaJlzymirmA==", null, false, "8a6fd981-6396-4a45-9997-3ee9a02bbde5", false, "H5Uf8o8w@gmail.com" },
                    { "a87ca810-f8d6-4674-8995-408192d3a999", 0, "2815c2aa-48b3-4573-b816-e7b9919ffb6f", "qvatLK2Q@gmail.com", true, false, null, "QVATLK2Q@GMAIL.COM", "QVATLK2Q@GMAIL.COM", "AQAAAAIAAYagAAAAEFjL+IWCYoZZiuIuBEXTHpUiTlOGk9xnkj+euA4LWkJczLt9vXvNC4m7FLd6/rXAyQ==", null, false, "0aa558e2-6951-45ea-ae1e-887544ba3efb", false, "qvatLK2Q@gmail.com" },
                    { "c1f5e712-0d9b-449a-80b3-b2f079bda33d", 0, "32593f50-0358-4621-831b-4ea9311e5abc", "bjAjI8EZ@gmail.com", true, false, null, "BJAJI8EZ@GMAIL.COM", "BJAJI8EZ@GMAIL.COM", "AQAAAAIAAYagAAAAEEkodT8BHzJ+JvnVjcstUiEGJnnCIskK/VG9DO6KGYqkOjAQrFToVk2DOCg+4xz/nw==", null, false, "3c4c4464-d938-4df9-9168-8637c2d3c55c", false, "bjAjI8EZ@gmail.com" },
                    { "c8702158-e017-452a-9d3b-db78fe18abf9", 0, "d7d7c50e-c738-4b05-84e3-82c8a6246315", "LmEq09ZR@gmail.com", true, false, null, "LMEQ09ZR@GMAIL.COM", "LMEQ09ZR@GMAIL.COM", "AQAAAAIAAYagAAAAEHrsokiR0togqCNOTMQjcyHdKHR+T8E1sqP801G3xlNPc+v0TQm43u+Xp8u71FEfuA==", null, false, "34e57bb2-c1c5-4a3b-acb6-e51bc3d4af23", false, "LmEq09ZR@gmail.com" },
                    { "d297ac37-3507-470d-86e6-076ffc7e45a1", 0, "63bab07d-adb4-4f64-a43b-8528a0605992", "4BRsZHeF@gmail.com", true, false, null, "4BRSZHEF@GMAIL.COM", "4BRSZHEF@GMAIL.COM", "AQAAAAIAAYagAAAAEKUVN3CYtgAAt33jcXfehHVM64knDz0VLGIg61C64oMWUoJZ1FdxNuZewJzXErUJSw==", null, false, "5f7347b0-de60-4f28-978b-dca3c3f426a9", false, "4BRsZHeF@gmail.com" },
                    { "dca63fc0-1827-4633-9d99-b79083eec8bd", 0, "8050297c-b6ec-4411-9bb8-27a7d22f93b3", "abCRPdSP@gmail.com", true, false, null, "ABCRPDSP@GMAIL.COM", "ABCRPDSP@GMAIL.COM", "AQAAAAIAAYagAAAAEB9GHnQkcakRuyt77xmouQg/Ycn5jQsuuyg6q6CP/hPyL5lLCU1zVTMJXv43uIh7FA==", null, false, "90a2a49a-39cf-4496-b3a9-6b5bc35c8be4", false, "abCRPdSP@gmail.com" },
                    { "f4be2d97-ec0d-4d68-b27c-cc85c384cadf", 0, "f5526529-4f55-4a8a-bb2d-d811461ef01a", "1fIyst1z@gmail.com", true, false, null, "1FIYST1Z@GMAIL.COM", "1FIYST1Z@GMAIL.COM", "AQAAAAIAAYagAAAAEILtKNrZnHLcMj7VrlC1WXosQkXgugo3bc6LE5dkfi5B3hlIMnc6TelmJAIphGswmA==", null, false, "e0843d69-d53d-48ce-b4df-95fb733a5362", false, "1fIyst1z@gmail.com" },
                    { "f88457be-f161-4341-b4c0-25ecf8755574", 0, "82e4ef2b-c185-458c-80bd-b45418f94b38", "Ml7FGG6v@gmail.com", true, false, null, "ML7FGG6V@GMAIL.COM", "ML7FGG6V@GMAIL.COM", "AQAAAAIAAYagAAAAEAwE2lFJYe82J8I4F99ZlP+oOowm2udl8Nnkga17/0SDybkTDmLM4VctEDiag0gxNg==", null, false, "ec4105f7-3702-472b-bf7c-204825671739", false, "Ml7FGG6v@gmail.com" },
                    { "fdb27760-4752-446b-9b66-309df3e3a22c", 0, "cae63cf1-d28c-4fbb-8dac-4afb45be587b", "vJY90N1j@gmail.com", true, false, null, "VJY90N1J@GMAIL.COM", "VJY90N1J@GMAIL.COM", "AQAAAAIAAYagAAAAENQTwoNIYPJnZXP/GQY8y/H2IpH1T2QaLgS3zjKEDP4ckB2AUku1qmFFTe3Y+rsQMw==", null, false, "d20890c7-bb2f-4051-9f69-92c4acf58e9a", false, "vJY90N1j@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedBy",
                value: "d297ac37-3507-470d-86e6-076ffc7e45a1");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedBy",
                value: "d297ac37-3507-470d-86e6-076ffc7e45a1");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedBy",
                value: "54ae9e22-e1aa-434d-9104-b48286a3e3b8");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedBy",
                value: "fdb27760-4752-446b-9b66-309df3e3a22c");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedBy",
                value: "1de7844a-868b-40a9-adc1-47fb39266fbc");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedBy",
                value: "f4be2d97-ec0d-4d68-b27c-cc85c384cadf");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedBy",
                value: "25657a6c-2741-4a5f-8054-dedf43c11871");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                column: "PostedBy",
                value: "14e908ad-573b-414b-a4c4-9845a83e49da");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                column: "PostedBy",
                value: "201ce957-f7f3-45c2-9910-d793b0563839");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                column: "PostedBy",
                value: "7078d013-b6ed-4f9e-83a0-933d5f0fc3cb");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                column: "PostedBy",
                value: "fdb27760-4752-446b-9b66-309df3e3a22c");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                column: "PostedBy",
                value: "608b0c64-aa5c-4e1c-8944-178f02cbeccc");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                column: "PostedBy",
                value: "4ca459fd-16c0-4445-bd8e-64b597a5c5df");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                column: "PostedBy",
                value: "dca63fc0-1827-4633-9d99-b79083eec8bd");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                column: "PostedBy",
                value: "19fb8908-57d8-4d9c-ae32-618ce4724e13");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                column: "PostedBy",
                value: "54ae9e22-e1aa-434d-9104-b48286a3e3b8");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                column: "PostedBy",
                value: "6ed6e001-0ab1-40e8-92ec-c40f44b1da4a");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                column: "PostedBy",
                value: "5d98629c-8a87-4fd4-8abb-b9f7133f84ae");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                column: "PostedBy",
                value: "c1f5e712-0d9b-449a-80b3-b2f079bda33d");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                column: "PostedBy",
                value: "2627ae25-4ec9-4bb2-a184-b20a02b6d718");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                column: "PostedBy",
                value: "1530b980-cf9a-4ab7-a0af-b5da690821fc");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                column: "PostedBy",
                value: "c1f5e712-0d9b-449a-80b3-b2f079bda33d");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                column: "PostedBy",
                value: "7078d013-b6ed-4f9e-83a0-933d5f0fc3cb");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                column: "PostedBy",
                value: "4db1173b-29cf-47da-9bf4-a825f82cb954");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                column: "PostedBy",
                value: "25657a6c-2741-4a5f-8054-dedf43c11871");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                column: "PostedBy",
                value: "dca63fc0-1827-4633-9d99-b79083eec8bd");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                column: "PostedBy",
                value: "d297ac37-3507-470d-86e6-076ffc7e45a1");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                column: "PostedBy",
                value: "f4be2d97-ec0d-4d68-b27c-cc85c384cadf");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                column: "PostedBy",
                value: "4db1173b-29cf-47da-9bf4-a825f82cb954");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                column: "PostedBy",
                value: "51234d3a-bb14-40fa-ba40-e95c103df3f3");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31,
                column: "PostedBy",
                value: "608b0c64-aa5c-4e1c-8944-178f02cbeccc");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32,
                column: "PostedBy",
                value: "5d98629c-8a87-4fd4-8abb-b9f7133f84ae");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33,
                column: "PostedBy",
                value: "1de7844a-868b-40a9-adc1-47fb39266fbc");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34,
                column: "PostedBy",
                value: "1de7844a-868b-40a9-adc1-47fb39266fbc");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35,
                column: "PostedBy",
                value: "14e908ad-573b-414b-a4c4-9845a83e49da");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 36,
                column: "PostedBy",
                value: "f4be2d97-ec0d-4d68-b27c-cc85c384cadf");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 37,
                column: "PostedBy",
                value: "54ae9e22-e1aa-434d-9104-b48286a3e3b8");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 38,
                column: "PostedBy",
                value: "4e751681-aede-4586-918b-f7c10999e9e6");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 39,
                column: "PostedBy",
                value: "36473574-c3a6-4394-b634-fa8e6202576d");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 40,
                column: "PostedBy",
                value: "f4be2d97-ec0d-4d68-b27c-cc85c384cadf");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 41,
                column: "PostedBy",
                value: "fdb27760-4752-446b-9b66-309df3e3a22c");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 42,
                column: "PostedBy",
                value: "d297ac37-3507-470d-86e6-076ffc7e45a1");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 43,
                column: "PostedBy",
                value: "a87ca810-f8d6-4674-8995-408192d3a999");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 44,
                column: "PostedBy",
                value: "c8702158-e017-452a-9d3b-db78fe18abf9");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 45,
                column: "PostedBy",
                value: "4e751681-aede-4586-918b-f7c10999e9e6");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 46,
                column: "PostedBy",
                value: "7078d013-b6ed-4f9e-83a0-933d5f0fc3cb");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 47,
                column: "PostedBy",
                value: "7cae7cf2-b199-44d4-9f43-3d50caf19687");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 48,
                column: "PostedBy",
                value: "1a0b3b96-3dab-4541-bd17-2dfe2046f858");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 49,
                column: "PostedBy",
                value: "a87ca810-f8d6-4674-8995-408192d3a999");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 50,
                column: "PostedBy",
                value: "1530b980-cf9a-4ab7-a0af-b5da690821fc");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 51,
                column: "PostedBy",
                value: "d297ac37-3507-470d-86e6-076ffc7e45a1");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 52,
                column: "PostedBy",
                value: "4db1173b-29cf-47da-9bf4-a825f82cb954");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 53,
                column: "PostedBy",
                value: "7cae7cf2-b199-44d4-9f43-3d50caf19687");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 54,
                column: "PostedBy",
                value: "7cae7cf2-b199-44d4-9f43-3d50caf19687");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 55,
                column: "PostedBy",
                value: "201ce957-f7f3-45c2-9910-d793b0563839");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 56,
                column: "PostedBy",
                value: "3d102d09-9286-40ad-a015-33f1061c4440");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 57,
                column: "PostedBy",
                value: "4ca459fd-16c0-4445-bd8e-64b597a5c5df");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 58,
                column: "PostedBy",
                value: "54ae9e22-e1aa-434d-9104-b48286a3e3b8");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 59,
                column: "PostedBy",
                value: "5c49ea74-7c5a-45b5-91f6-8cf6c7959b17");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 60,
                column: "PostedBy",
                value: "dca63fc0-1827-4633-9d99-b79083eec8bd");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 61,
                column: "PostedBy",
                value: "54ae9e22-e1aa-434d-9104-b48286a3e3b8");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 62,
                column: "PostedBy",
                value: "14e908ad-573b-414b-a4c4-9845a83e49da");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 63,
                column: "PostedBy",
                value: "c1f5e712-0d9b-449a-80b3-b2f079bda33d");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 64,
                column: "PostedBy",
                value: "4db1173b-29cf-47da-9bf4-a825f82cb954");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 65,
                column: "PostedBy",
                value: "3d102d09-9286-40ad-a015-33f1061c4440");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 66,
                column: "PostedBy",
                value: "14e908ad-573b-414b-a4c4-9845a83e49da");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 67,
                column: "PostedBy",
                value: "4ca459fd-16c0-4445-bd8e-64b597a5c5df");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 68,
                column: "PostedBy",
                value: "6ed6e001-0ab1-40e8-92ec-c40f44b1da4a");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 69,
                column: "PostedBy",
                value: "f4be2d97-ec0d-4d68-b27c-cc85c384cadf");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 70,
                column: "PostedBy",
                value: "608b0c64-aa5c-4e1c-8944-178f02cbeccc");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 71,
                column: "PostedBy",
                value: "25657a6c-2741-4a5f-8054-dedf43c11871");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 72,
                column: "PostedBy",
                value: "f88457be-f161-4341-b4c0-25ecf8755574");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 73,
                column: "PostedBy",
                value: "fdb27760-4752-446b-9b66-309df3e3a22c");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 74,
                column: "PostedBy",
                value: "3d102d09-9286-40ad-a015-33f1061c4440");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 75,
                column: "PostedBy",
                value: "f88457be-f161-4341-b4c0-25ecf8755574");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 76,
                column: "PostedBy",
                value: "f4be2d97-ec0d-4d68-b27c-cc85c384cadf");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 77,
                column: "PostedBy",
                value: "c1f5e712-0d9b-449a-80b3-b2f079bda33d");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 78,
                column: "PostedBy",
                value: "1a0b3b96-3dab-4541-bd17-2dfe2046f858");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 79,
                column: "PostedBy",
                value: "2627ae25-4ec9-4bb2-a184-b20a02b6d718");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14e908ad-573b-414b-a4c4-9845a83e49da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1530b980-cf9a-4ab7-a0af-b5da690821fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19fb8908-57d8-4d9c-ae32-618ce4724e13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a0b3b96-3dab-4541-bd17-2dfe2046f858");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1de7844a-868b-40a9-adc1-47fb39266fbc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "201ce957-f7f3-45c2-9910-d793b0563839");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25657a6c-2741-4a5f-8054-dedf43c11871");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2627ae25-4ec9-4bb2-a184-b20a02b6d718");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36473574-c3a6-4394-b634-fa8e6202576d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d102d09-9286-40ad-a015-33f1061c4440");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ca459fd-16c0-4445-bd8e-64b597a5c5df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4db1173b-29cf-47da-9bf4-a825f82cb954");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e751681-aede-4586-918b-f7c10999e9e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51234d3a-bb14-40fa-ba40-e95c103df3f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54ae9e22-e1aa-434d-9104-b48286a3e3b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c49ea74-7c5a-45b5-91f6-8cf6c7959b17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d98629c-8a87-4fd4-8abb-b9f7133f84ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608b0c64-aa5c-4e1c-8944-178f02cbeccc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ed6e001-0ab1-40e8-92ec-c40f44b1da4a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6fbbf736-e555-40ea-9a3f-ffba368ce809");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7078d013-b6ed-4f9e-83a0-933d5f0fc3cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cae7cf2-b199-44d4-9f43-3d50caf19687");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a87ca810-f8d6-4674-8995-408192d3a999");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1f5e712-0d9b-449a-80b3-b2f079bda33d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8702158-e017-452a-9d3b-db78fe18abf9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d297ac37-3507-470d-86e6-076ffc7e45a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dca63fc0-1827-4633-9d99-b79083eec8bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4be2d97-ec0d-4d68-b27c-cc85c384cadf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f88457be-f161-4341-b4c0-25ecf8755574");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fdb27760-4752-446b-9b66-309df3e3a22c");

            migrationBuilder.AlterColumn<int>(
                name: "PostedBy",
                table: "Book",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedBy",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedBy",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedBy",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedBy",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedBy",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedBy",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedBy",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                column: "PostedBy",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                column: "PostedBy",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                column: "PostedBy",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                column: "PostedBy",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                column: "PostedBy",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                column: "PostedBy",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                column: "PostedBy",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                column: "PostedBy",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                column: "PostedBy",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                column: "PostedBy",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                column: "PostedBy",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                column: "PostedBy",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                column: "PostedBy",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                column: "PostedBy",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                column: "PostedBy",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                column: "PostedBy",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                column: "PostedBy",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                column: "PostedBy",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                column: "PostedBy",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                column: "PostedBy",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                column: "PostedBy",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                column: "PostedBy",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                column: "PostedBy",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31,
                column: "PostedBy",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32,
                column: "PostedBy",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33,
                column: "PostedBy",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34,
                column: "PostedBy",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35,
                column: "PostedBy",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 36,
                column: "PostedBy",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 37,
                column: "PostedBy",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 38,
                column: "PostedBy",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 39,
                column: "PostedBy",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 40,
                column: "PostedBy",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 41,
                column: "PostedBy",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 42,
                column: "PostedBy",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 43,
                column: "PostedBy",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 44,
                column: "PostedBy",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 45,
                column: "PostedBy",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 46,
                column: "PostedBy",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 47,
                column: "PostedBy",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 48,
                column: "PostedBy",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 49,
                column: "PostedBy",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 50,
                column: "PostedBy",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 51,
                column: "PostedBy",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 52,
                column: "PostedBy",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 53,
                column: "PostedBy",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 54,
                column: "PostedBy",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 55,
                column: "PostedBy",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 56,
                column: "PostedBy",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 57,
                column: "PostedBy",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 58,
                column: "PostedBy",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 59,
                column: "PostedBy",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 60,
                column: "PostedBy",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 61,
                column: "PostedBy",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 62,
                column: "PostedBy",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 63,
                column: "PostedBy",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 64,
                column: "PostedBy",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 65,
                column: "PostedBy",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 66,
                column: "PostedBy",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 67,
                column: "PostedBy",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 68,
                column: "PostedBy",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 69,
                column: "PostedBy",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 70,
                column: "PostedBy",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 71,
                column: "PostedBy",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 72,
                column: "PostedBy",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 73,
                column: "PostedBy",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 74,
                column: "PostedBy",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 75,
                column: "PostedBy",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 76,
                column: "PostedBy",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 77,
                column: "PostedBy",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 78,
                column: "PostedBy",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 79,
                column: "PostedBy",
                value: 19);
        }
    }
}
