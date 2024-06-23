using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    public partial class AddingRegionModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0a8248d1-3b62-4fb7-afc8-955b1c8ebc61"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0a8e109c-ee00-40d6-9a01-040618746f2f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("18e191f0-eef9-4451-bea1-de5f78d125f8"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("439a8192-2f0f-43a7-8a2c-ee9bbbd6c4d3"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("46698f17-4273-4e5c-a56d-dda97d426f26"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4b4077ab-47f7-44b6-bf44-56f03ca18532"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("588c12b7-703c-4944-b5ba-0fbed191eb02"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("596df90c-e617-45cb-be33-826801519e46"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("653fcdce-73b1-47ac-9e98-a5380bec8788"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6756d8f6-3f78-4886-91dd-e4753f9e72bc"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6ab3cbd8-bcdf-4287-bee3-5885fb656d08"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("72b8cfd2-617d-435e-8f79-6e6e46aac155"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("784647e2-5430-459e-898b-4c915ee4b412"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7d73f17e-90d6-4230-a391-31520365ca67"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a3fc3b39-3c3c-4a58-8c50-fdd19209777f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a71ac957-1859-49b7-aa65-cc9327f4a3ce"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("afc12ff5-eacd-420a-835a-69e9b3b7821c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("bb824c5c-a427-4a95-a7b4-f8183f3f8e94"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c04bb270-65a7-4577-bd4c-631fa931d0e2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c215fc2e-bcda-4404-8efb-4b23c4433c5b"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("dc5ff91b-68d1-4759-9dba-4ade4bd4740d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e3dcbced-4326-4007-94df-c33f8c77a204"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e7d03670-5d06-40dd-a4d8-41c4fe49a994"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ec209ffa-37ea-4587-8bc6-8afe7cd00042"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ec8390ca-f9a5-4a9e-9654-9405ccbabc7c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("eff2ddee-6df9-4d52-80b7-1e4b1164e343"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f8e6890f-e0d0-46ec-8f34-292de4b1f83b"));

            migrationBuilder.AddColumn<int>(
                name: "RegiaoId",
                table: "Cidade",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Regiao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegiaoCidade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    IdRegiao = table.Column<int>(type: "INTEGER", nullable: false),
                    NomeCidade = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegiaoCidade", x => x.Id);
                });

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
                values: new object[] { new Guid("2b75bc34-d22a-4a23-b870-7969eece2a38"), "Natal", null, "RN" });

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
                values: new object[] { new Guid("c99866de-e631-4671-bd84-60feef0a4400"), "Belo Horizonte", null, "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("98b48aec-8408-4a98-8397-10ee0e80af09"), "Campo Grande", null, "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("cf754d1f-ed3f-4126-852b-4b8735fe967b"), "Cuiabá", null, "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("05f418ea-e145-43ec-80f4-91364843ed06"), "São Luís", null, "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("6bb67ad8-5527-4d0f-8e28-9f8e20f14b40"), "Goiânia", null, "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("fb0681dd-d004-4f74-9820-18f10095b949"), "Vitória", null, "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("dc89eee0-8230-40c5-95f6-09948478aaa7"), "Brasília", null, "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("dd90febd-aab5-4a75-afc6-619f51783076"), "Fortaleza", null, "CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("e9990b57-1105-48d1-bc1a-0962c50feb7c"), "Salvador", null, "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("f0402ad9-9f47-43c0-8ed8-bf1fd6a9c601"), "Manaus", null, "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("a2c4f3fc-a094-4f1c-94a2-bd61661142cb"), "Macapá", null, "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("8256a0ee-90ad-45e2-b198-fc1261130743"), "Maceió", null, "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("399d4017-1b2c-4eae-aac0-3b8e1dbbc28f"), "Belém", null, "PA" });

            migrationBuilder.InsertData(
                table: "Regiao",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 5, "Norte" });

            migrationBuilder.InsertData(
                table: "Regiao",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 4, "Nordeste" });

            migrationBuilder.InsertData(
                table: "Regiao",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Centro-Oeste" });

            migrationBuilder.InsertData(
                table: "Regiao",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Sudeste" });

            migrationBuilder.InsertData(
                table: "Regiao",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Sul" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("98b6ed3a-7e9c-4b0b-be07-7c1417ef4d20"), 1, "Curitiba" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("eb8dc656-9ff9-41be-8176-5293f049497b"), 2, "São Paulo" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("40f6487d-3c24-4fa1-a4b2-8f60468401dd"), 2, "Rio de Janeiro" });

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
                values: new object[] { new Guid("7df97669-af4b-4c47-8e50-b08fa0a5e9ab"), 3, "Campo Grande" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("40b6c2dd-4cc4-4659-9b3c-38a99574b2b2"), 3, "Cuiabá" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("0b90bb63-7316-4b50-bb8c-7b317b0842a9"), 3, "Brasília" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("dc0e2d7c-0793-4d5b-902c-0d9eb273cb85"), 4, "Natal" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("db2c9370-6240-4f14-bc21-b8cecfeadc40"), 4, "Boa Vista" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("724e7e04-693a-488c-8816-33f62693db15"), 4, "Aracaju" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("ef8fa12a-01e3-4dfe-98e7-b800d0177349"), 4, "Teresina" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("46c4c238-3738-42e2-8e64-7da4da5e73eb"), 4, "Recife" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("22011e31-fa0f-4115-a8ec-437b0e00d648"), 4, "João Pessoa" });

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
                values: new object[] { new Guid("db8fbe01-1d7a-4518-8074-054569f05c83"), 5, "Rio Branco" });

            migrationBuilder.InsertData(
                table: "RegiaoCidade",
                columns: new[] { "Id", "IdRegiao", "NomeCidade" },
                values: new object[] { new Guid("e4cde0eb-d66d-4808-9fa1-1851e3376dee"), 1, "Florianópolis" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cidade_Regiao_RegiaoId",
                table: "Cidade");

            migrationBuilder.DropTable(
                name: "Regiao");

            migrationBuilder.DropTable(
                name: "RegiaoCidade");

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

            migrationBuilder.DropColumn(
                name: "RegiaoId",
                table: "Cidade");

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("afc12ff5-eacd-420a-835a-69e9b3b7821c"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c215fc2e-bcda-4404-8efb-4b23c4433c5b"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a71ac957-1859-49b7-aa65-cc9327f4a3ce"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c04bb270-65a7-4577-bd4c-631fa931d0e2"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0a8248d1-3b62-4fb7-afc8-955b1c8ebc61"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ec209ffa-37ea-4587-8bc6-8afe7cd00042"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f8e6890f-e0d0-46ec-8f34-292de4b1f83b"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6756d8f6-3f78-4886-91dd-e4753f9e72bc"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0a8e109c-ee00-40d6-9a01-040618746f2f"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("653fcdce-73b1-47ac-9e98-a5380bec8788"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("dc5ff91b-68d1-4759-9dba-4ade4bd4740d"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("eff2ddee-6df9-4d52-80b7-1e4b1164e343"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("7d73f17e-90d6-4230-a391-31520365ca67"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e7d03670-5d06-40dd-a4d8-41c4fe49a994"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("72b8cfd2-617d-435e-8f79-6e6e46aac155"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("588c12b7-703c-4944-b5ba-0fbed191eb02"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("18e191f0-eef9-4451-bea1-de5f78d125f8"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("bb824c5c-a427-4a95-a7b4-f8183f3f8e94"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("439a8192-2f0f-43a7-8a2c-ee9bbbd6c4d3"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("46698f17-4273-4e5c-a56d-dda97d426f26"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e3dcbced-4326-4007-94df-c33f8c77a204"), "Fortaleza", " CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("784647e2-5430-459e-898b-4c915ee4b412"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("596df90c-e617-45cb-be33-826801519e46"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ec8390ca-f9a5-4a9e-9654-9405ccbabc7c"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a3fc3b39-3c3c-4a58-8c50-fdd19209777f"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4b4077ab-47f7-44b6-bf44-56f03ca18532"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6ab3cbd8-bcdf-4287-bee3-5885fb656d08"), "Palmas", "TO" });
        }
    }
}
