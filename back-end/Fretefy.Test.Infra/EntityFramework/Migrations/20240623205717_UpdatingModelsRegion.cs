using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    public partial class UpdatingModelsRegion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cidade_Regiao_RegiaoId",
                table: "Cidade");

            migrationBuilder.DropIndex(
                name: "IX_Cidade_RegiaoId",
                table: "Cidade");

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("009bf40f-5151-49a6-8d3e-2ed1fdf9eff9"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0322f421-cabf-43d2-bfa8-940aefe81335"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("05f418ea-e145-43ec-80f4-91364843ed06"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("21944bfc-1b1d-4638-b33f-4d59f77911c4"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("23b79468-ab86-4754-9e75-e306cb53a1a4"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2b75bc34-d22a-4a23-b870-7969eece2a38"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("399d4017-1b2c-4eae-aac0-3b8e1dbbc28f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6bb67ad8-5527-4d0f-8e28-9f8e20f14b40"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6f13a8e6-96d0-4131-a765-2bad3ba63ee6"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("73a4bd88-79fb-40a7-a585-878337be7978"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7a055054-2b7b-40ba-919f-187a94c7f529"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("8256a0ee-90ad-45e2-b198-fc1261130743"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("98b48aec-8408-4a98-8397-10ee0e80af09"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a2c4f3fc-a094-4f1c-94a2-bd61661142cb"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a7dbcc3d-0a51-43b0-95df-6b1c42a912c8"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("bc2e2707-b6ed-48bd-9bf3-fd946369738d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c99866de-e631-4671-bd84-60feef0a4400"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("cf754d1f-ed3f-4126-852b-4b8735fe967b"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("dc89eee0-8230-40c5-95f6-09948478aaa7"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("dd90febd-aab5-4a75-afc6-619f51783076"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e9990b57-1105-48d1-bc1a-0962c50feb7c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ef71bfcc-f094-4b49-8d35-37c402d7656f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ef8db920-21cc-4b59-a819-a7fe94469c1c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f0402ad9-9f47-43c0-8ed8-bf1fd6a9c601"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fb0681dd-d004-4f74-9820-18f10095b949"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fccb11ce-a4f5-4aa7-8eda-d6d1ec5b577a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fff475d3-3784-49e5-83e3-9a51201d29a4"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("056b175d-2d58-460f-a76a-97b561e68905"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("0b90bb63-7316-4b50-bb8c-7b317b0842a9"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("0d4cefbc-902e-4bd9-a345-e9d5b22b8558"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("1e276809-4fe1-4e34-8bfe-8238ccae9f79"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("22011e31-fa0f-4115-a8ec-437b0e00d648"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("26556445-19a8-4c01-b3d8-d076a2cfe1f8"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("2a6ffe39-d193-490e-b37d-bbb385ddffb2"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("392b4666-9bf9-4c6c-a751-f6d6bbeb327d"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("3fc5e32e-0c9d-4894-88ef-398846115aab"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("40b11505-a5cf-49f7-8fe4-e24a9dad12f7"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("40b6c2dd-4cc4-4659-9b3c-38a99574b2b2"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("40f6487d-3c24-4fa1-a4b2-8f60468401dd"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("445ff104-5e37-42b2-b7c5-f3f658407cb0"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("46c4c238-3738-42e2-8e64-7da4da5e73eb"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("478add8a-bb5a-4d8a-bd89-5ebf9a77ddbe"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("503733fc-18ac-4473-b2c9-ba105bd5eee6"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("724e7e04-693a-488c-8816-33f62693db15"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("7df97669-af4b-4c47-8e50-b08fa0a5e9ab"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("98b6ed3a-7e9c-4b0b-be07-7c1417ef4d20"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("a0e2345e-9b10-41be-91d7-9a135da18ee6"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("db2c9370-6240-4f14-bc21-b8cecfeadc40"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("db8fbe01-1d7a-4518-8074-054569f05c83"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("dc0e2d7c-0793-4d5b-902c-0d9eb273cb85"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("e22cdc73-0848-405b-a506-5315ee945f09"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("e4cde0eb-d66d-4808-9fa1-1851e3376dee"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("eb8dc656-9ff9-41be-8176-5293f049497b"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("ef8fa12a-01e3-4dfe-98e7-b800d0177349"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("f628731a-cfea-4571-8f50-fb8b71ae960b"));

            migrationBuilder.DropColumn(
                name: "RegiaoId",
                table: "Cidade");

            migrationBuilder.RenameColumn(
                name: "IdRegiao",
                table: "RegiaoCidade",
                newName: "RegiaoId");

            migrationBuilder.AddColumn<int>(
                name: "RegiaoId1",
                table: "RegiaoCidade",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6cc5876b-96b9-4083-8e08-5d7d1ad414a4"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c65b4008-0334-4e4c-9c85-79ca57dfc486"), "Palmas", "TO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("717055e4-4b84-4b6f-a959-734aa921fa2d"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("de9f5fd2-7987-48cc-bc36-af6161c25308"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("d34c7270-9577-4cf9-9730-3ce2df4cc79f"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e678d2df-6b96-4c20-8eb9-bff6e20af188"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("1b5531e6-cb4b-46f0-99d5-4845a5c1bfb4"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("21dfb8b8-17d2-4532-92fd-fce9556cc7b8"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("efae0d5c-d7d5-4cf7-b3ea-6cb366d782ea"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a5b51886-d21c-4b12-bb1b-e197b0c81901"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("164c263b-5c7b-4a7f-902c-ba0acef6c170"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("96759d2d-ceac-48ed-b7d6-3d134053353c"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("83d4a0f0-d399-48fe-8f0a-f71569b307b7"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("2cab41c6-4dbc-4eaa-a38c-cbd8caf40010"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("7ccfef4a-2c6f-459b-98a8-65b2d4d36686"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("83476b65-75c9-4f3e-9880-4489e3094a05"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("30ed8a18-d852-4039-a9fa-b993fd1d15f4"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("13f10c9c-9157-415b-a996-b514eb8e9258"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("38ee575a-4eac-428d-956d-f5d5952c25ff"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("588146c8-8873-4456-8fcb-68f4cd69a4ca"), "Fortaleza", "CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("624ad870-9374-49c2-8d03-95b81c56f4d0"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("3b2e8be0-8d3e-4874-97a1-01869634afcd"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("d8bfc4cd-2a53-4c97-97ea-36b54d97dc46"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("2c2d6923-a397-4d3c-a328-2e78e859ad6a"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("d3f717b7-abdd-4e7f-bb5f-2d26f879e472"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("feda1335-e78c-499f-ad5d-7bffe8b43547"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("be05056c-da1a-4385-abcc-0282b70234c2"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("0ac2bd51-71dc-4928-a64f-599eab6e57c6"), "Teresina", 4, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("1d08ff88-fd66-4ba2-83fc-b7564350d565"), "Aracaju", 4, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("fca1c4f8-7da4-4167-ac25-efa6a0d06ce5"), "Boa Vista", 4, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("a64f8238-584b-4ec9-8b04-9d8dc52bf64b"), "Natal", 4, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("81f0c104-0272-4c84-b2d7-47dd0faac2c3"), "Brasília", 3, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("5304873f-4017-4e96-8c0f-35428596edb1"), "Cuiabá", 3, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("615c93f1-ea58-46b3-9892-65acd6a973d8"), "Belo Horizonte", 2, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("8bf1b5d4-c869-4924-bf0b-87d73feefed4"), "Vitória", 2, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("ea6ba947-3020-41c5-a0c5-7e993142c969"), "Rio de Janeiro", 2, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("7f951a50-3a05-4f45-8717-040e52b04f12"), "São Paulo", 2, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("12b76098-4374-43a4-a534-97ebdfd34f3b"), "Curitiba", 1, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("6a9e71d9-1f1e-4f7c-a23c-8c4b313b2bea"), "Campo Grande", 3, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("455519e9-eabf-4d5b-beb1-de97199f15b9"), "Recife", 4, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("17799cc6-e0a5-43ee-8c58-fe8b44458a59"), "Rio Branco", 5, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("cebf30f8-faf0-4c1d-b026-e1315f9eb5d0"), "Cuiabá", 4, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("ab8f5b8d-460d-44e2-8174-1b7aed699fb3"), "São Luís", 4, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("0db7d727-b96c-48db-90a8-4aa316dc73ff"), "Fortaleza", 4, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("3390865a-ba83-41f8-8923-ae8488253df5"), "Salvador", 4, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("07d43818-5f38-4566-8d7a-5b137ce514e4"), "Macapá", 4, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("08cceef9-1c86-4a81-aeaa-b828a95ec4fe"), "Maceió", 4, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("121a2d00-baa2-4c30-a1cc-998faf07b64e"), "Porto Velho", 5, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("c7b052ac-a540-4854-842f-ee17a860d759"), "Palmas", 5, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("a9233146-ed42-48fe-abe9-0508a709bff3"), "Belém", 5, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("6b477f02-b023-4aeb-8864-05bd6ebf0762"), "Goiânia", 5, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("a6444746-4bbe-41e5-8636-e9c1265e59d7"), "Manaus", 5, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("ffd0e1d4-37f7-4105-a841-46fce8593f50"), "Florianópolis", 1, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("31aa5e0d-8e46-4ca0-8830-83a7e4464409"), "João Pessoa", 4, null });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "NomeCidade", "RegiaoId", "RegiaoId1" },
                values: new object[] { new Guid("d81e739e-21aa-4dc4-8f23-75ced7dcc276"), "Porto Alegre", 1, null });

            migrationBuilder.CreateIndex(
                name: "IX_RegiaoCidade_RegiaoId",
                table: "RegiaoCidade",
                column: "RegiaoId");

            migrationBuilder.CreateIndex(
                name: "IX_RegiaoCidade_RegiaoId1",
                table: "RegiaoCidade",
                column: "RegiaoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_RegiaoCidade_Regiao_RegiaoId",
                table: "RegiaoCidade",
                column: "RegiaoId",
                principalTable: "Regiao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegiaoCidade_Regiao_RegiaoId1",
                table: "RegiaoCidade",
                column: "RegiaoId1",
                principalTable: "Regiao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegiaoCidade_Regiao_RegiaoId",
                table: "RegiaoCidade");

            migrationBuilder.DropForeignKey(
                name: "FK_RegiaoCidade_Regiao_RegiaoId1",
                table: "RegiaoCidade");

            migrationBuilder.DropIndex(
                name: "IX_RegiaoCidade_RegiaoId",
                table: "RegiaoCidade");

            migrationBuilder.DropIndex(
                name: "IX_RegiaoCidade_RegiaoId1",
                table: "RegiaoCidade");

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("13f10c9c-9157-415b-a996-b514eb8e9258"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("164c263b-5c7b-4a7f-902c-ba0acef6c170"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1b5531e6-cb4b-46f0-99d5-4845a5c1bfb4"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("21dfb8b8-17d2-4532-92fd-fce9556cc7b8"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2c2d6923-a397-4d3c-a328-2e78e859ad6a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2cab41c6-4dbc-4eaa-a38c-cbd8caf40010"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("30ed8a18-d852-4039-a9fa-b993fd1d15f4"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("38ee575a-4eac-428d-956d-f5d5952c25ff"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("3b2e8be0-8d3e-4874-97a1-01869634afcd"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("588146c8-8873-4456-8fcb-68f4cd69a4ca"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("624ad870-9374-49c2-8d03-95b81c56f4d0"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6cc5876b-96b9-4083-8e08-5d7d1ad414a4"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("717055e4-4b84-4b6f-a959-734aa921fa2d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7ccfef4a-2c6f-459b-98a8-65b2d4d36686"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("83476b65-75c9-4f3e-9880-4489e3094a05"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("83d4a0f0-d399-48fe-8f0a-f71569b307b7"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("96759d2d-ceac-48ed-b7d6-3d134053353c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a5b51886-d21c-4b12-bb1b-e197b0c81901"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("be05056c-da1a-4385-abcc-0282b70234c2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c65b4008-0334-4e4c-9c85-79ca57dfc486"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d34c7270-9577-4cf9-9730-3ce2df4cc79f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d3f717b7-abdd-4e7f-bb5f-2d26f879e472"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d8bfc4cd-2a53-4c97-97ea-36b54d97dc46"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("de9f5fd2-7987-48cc-bc36-af6161c25308"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e678d2df-6b96-4c20-8eb9-bff6e20af188"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("efae0d5c-d7d5-4cf7-b3ea-6cb366d782ea"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("feda1335-e78c-499f-ad5d-7bffe8b43547"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("07d43818-5f38-4566-8d7a-5b137ce514e4"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("08cceef9-1c86-4a81-aeaa-b828a95ec4fe"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("0ac2bd51-71dc-4928-a64f-599eab6e57c6"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("0db7d727-b96c-48db-90a8-4aa316dc73ff"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("121a2d00-baa2-4c30-a1cc-998faf07b64e"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("12b76098-4374-43a4-a534-97ebdfd34f3b"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("17799cc6-e0a5-43ee-8c58-fe8b44458a59"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("1d08ff88-fd66-4ba2-83fc-b7564350d565"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("31aa5e0d-8e46-4ca0-8830-83a7e4464409"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("3390865a-ba83-41f8-8923-ae8488253df5"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("455519e9-eabf-4d5b-beb1-de97199f15b9"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("5304873f-4017-4e96-8c0f-35428596edb1"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("615c93f1-ea58-46b3-9892-65acd6a973d8"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("6a9e71d9-1f1e-4f7c-a23c-8c4b313b2bea"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("6b477f02-b023-4aeb-8864-05bd6ebf0762"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("7f951a50-3a05-4f45-8717-040e52b04f12"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("81f0c104-0272-4c84-b2d7-47dd0faac2c3"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("8bf1b5d4-c869-4924-bf0b-87d73feefed4"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("a6444746-4bbe-41e5-8636-e9c1265e59d7"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("a64f8238-584b-4ec9-8b04-9d8dc52bf64b"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("a9233146-ed42-48fe-abe9-0508a709bff3"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("ab8f5b8d-460d-44e2-8174-1b7aed699fb3"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("c7b052ac-a540-4854-842f-ee17a860d759"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("cebf30f8-faf0-4c1d-b026-e1315f9eb5d0"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("d81e739e-21aa-4dc4-8f23-75ced7dcc276"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("ea6ba947-3020-41c5-a0c5-7e993142c969"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("fca1c4f8-7da4-4167-ac25-efa6a0d06ce5"));

            migrationBuilder.DeleteData(
                table: "RegiaoCidade",
                keyColumn: "Id",
                keyValue: new Guid("ffd0e1d4-37f7-4105-a841-46fce8593f50"));

            migrationBuilder.DropColumn(
                name: "RegiaoId1",
                table: "RegiaoCidade");

            migrationBuilder.RenameColumn(
                name: "RegiaoId",
                table: "RegiaoCidade",
                newName: "IdRegiao");

            migrationBuilder.AddColumn<int>(
                name: "RegiaoId",
                table: "Cidade",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("ef8db920-21cc-4b59-a819-a7fe94469c1c"), "Rio Branco", null, "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("009bf40f-5151-49a6-8d3e-2ed1fdf9eff9"), "Palmas", null, "TO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("21944bfc-1b1d-4638-b33f-4d59f77911c4"), "Aracaju", null, "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("6f13a8e6-96d0-4131-a765-2bad3ba63ee6"), "São Paulo", null, "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("a7dbcc3d-0a51-43b0-95df-6b1c42a912c8"), "Florianópolis", null, "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("fccb11ce-a4f5-4aa7-8eda-d6d1ec5b577a"), "Boa Vista", null, "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("23b79468-ab86-4754-9e75-e306cb53a1a4"), "Porto Velho", null, "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("73a4bd88-79fb-40a7-a585-878337be7978"), "Porto Alegre", null, "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("ef71bfcc-f094-4b49-8d35-37c402d7656f"), "Rio de Janeiro", null, "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("0322f421-cabf-43d2-bfa8-940aefe81335"), "Teresina", null, "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("fff475d3-3784-49e5-83e3-9a51201d29a4"), "Recife", null, "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("7a055054-2b7b-40ba-919f-187a94c7f529"), "Curitiba", null, "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("bc2e2707-b6ed-48bd-9bf3-fd946369738d"), "João Pessoa", null, "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("2b75bc34-d22a-4a23-b870-7969eece2a38"), "Natal", null, "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("c99866de-e631-4671-bd84-60feef0a4400"), "Belo Horizonte", null, "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("399d4017-1b2c-4eae-aac0-3b8e1dbbc28f"), "Belém", null, "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("a2c4f3fc-a094-4f1c-94a2-bd61661142cb"), "Macapá", null, "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("f0402ad9-9f47-43c0-8ed8-bf1fd6a9c601"), "Manaus", null, "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("e9990b57-1105-48d1-bc1a-0962c50feb7c"), "Salvador", null, "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("dd90febd-aab5-4a75-afc6-619f51783076"), "Fortaleza", null, "CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("dc89eee0-8230-40c5-95f6-09948478aaa7"), "Brasília", null, "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("8256a0ee-90ad-45e2-b198-fc1261130743"), "Maceió", null, "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("6bb67ad8-5527-4d0f-8e28-9f8e20f14b40"), "Goiânia", null, "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("05f418ea-e145-43ec-80f4-91364843ed06"), "São Luís", null, "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("cf754d1f-ed3f-4126-852b-4b8735fe967b"), "Cuiabá", null, "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("98b48aec-8408-4a98-8397-10ee0e80af09"), "Campo Grande", null, "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("fb0681dd-d004-4f74-9820-18f10095b949"), "Vitória", null, "ES" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("ef8fa12a-01e3-4dfe-98e7-b800d0177349"), 4, "Teresina" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("724e7e04-693a-488c-8816-33f62693db15"), 4, "Aracaju" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("db2c9370-6240-4f14-bc21-b8cecfeadc40"), 4, "Boa Vista" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("dc0e2d7c-0793-4d5b-902c-0d9eb273cb85"), 4, "Natal" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("0b90bb63-7316-4b50-bb8c-7b317b0842a9"), 3, "Brasília" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("40b6c2dd-4cc4-4659-9b3c-38a99574b2b2"), 3, "Cuiabá" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("0d4cefbc-902e-4bd9-a345-e9d5b22b8558"), 2, "Belo Horizonte" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("1e276809-4fe1-4e34-8bfe-8238ccae9f79"), 2, "Vitória" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("40f6487d-3c24-4fa1-a4b2-8f60468401dd"), 2, "Rio de Janeiro" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("eb8dc656-9ff9-41be-8176-5293f049497b"), 2, "São Paulo" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("98b6ed3a-7e9c-4b0b-be07-7c1417ef4d20"), 1, "Curitiba" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("7df97669-af4b-4c47-8e50-b08fa0a5e9ab"), 3, "Campo Grande" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("46c4c238-3738-42e2-8e64-7da4da5e73eb"), 4, "Recife" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("db8fbe01-1d7a-4518-8074-054569f05c83"), 5, "Rio Branco" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("a0e2345e-9b10-41be-91d7-9a135da18ee6"), 4, "Cuiabá" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("40b11505-a5cf-49f7-8fe4-e24a9dad12f7"), 4, "São Luís" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("f628731a-cfea-4571-8f50-fb8b71ae960b"), 4, "Fortaleza" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("503733fc-18ac-4473-b2c9-ba105bd5eee6"), 4, "Salvador" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("3fc5e32e-0c9d-4894-88ef-398846115aab"), 4, "Macapá" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("478add8a-bb5a-4d8a-bd89-5ebf9a77ddbe"), 4, "Maceió" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("445ff104-5e37-42b2-b7c5-f3f658407cb0"), 5, "Porto Velho" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("056b175d-2d58-460f-a76a-97b561e68905"), 5, "Palmas" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("2a6ffe39-d193-490e-b37d-bbb385ddffb2"), 5, "Belém" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("e22cdc73-0848-405b-a506-5315ee945f09"), 5, "Goiânia" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("26556445-19a8-4c01-b3d8-d076a2cfe1f8"), 5, "Manaus" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("e4cde0eb-d66d-4808-9fa1-1851e3376dee"), 1, "Florianópolis" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("22011e31-fa0f-4115-a8ec-437b0e00d648"), 4, "João Pessoa" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("392b4666-9bf9-4c6c-a751-f6d6bbeb327d"), 1, "Porto Alegre" });

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_RegiaoId",
                table: "Cidade",
                column: "RegiaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cidade_Regiao_RegiaoId",
                table: "Cidade",
                column: "RegiaoId",
                principalTable: "Regiao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
