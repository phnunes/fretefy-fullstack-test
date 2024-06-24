﻿// <auto-generated />
using System;
using Fretefy.Test.Infra.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    [DbContext(typeof(TestDbContext))]
    partial class TestDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Cidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cidade");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6cc5876b-96b9-4083-8e08-5d7d1ad414a4"),
                            Nome = "Rio Branco",
                            UF = "AC"
                        },
                        new
                        {
                            Id = new Guid("3b2e8be0-8d3e-4874-97a1-01869634afcd"),
                            Nome = "Maceió",
                            UF = "AL"
                        },
                        new
                        {
                            Id = new Guid("30ed8a18-d852-4039-a9fa-b993fd1d15f4"),
                            Nome = "Macapá",
                            UF = "AP"
                        },
                        new
                        {
                            Id = new Guid("13f10c9c-9157-415b-a996-b514eb8e9258"),
                            Nome = "Manaus",
                            UF = "AM"
                        },
                        new
                        {
                            Id = new Guid("38ee575a-4eac-428d-956d-f5d5952c25ff"),
                            Nome = "Salvador",
                            UF = "BA"
                        },
                        new
                        {
                            Id = new Guid("588146c8-8873-4456-8fcb-68f4cd69a4ca"),
                            Nome = "Fortaleza",
                            UF = "CE"
                        },
                        new
                        {
                            Id = new Guid("624ad870-9374-49c2-8d03-95b81c56f4d0"),
                            Nome = "Brasília",
                            UF = "DF"
                        },
                        new
                        {
                            Id = new Guid("be05056c-da1a-4385-abcc-0282b70234c2"),
                            Nome = "Vitória",
                            UF = "ES"
                        },
                        new
                        {
                            Id = new Guid("d8bfc4cd-2a53-4c97-97ea-36b54d97dc46"),
                            Nome = "Goiânia",
                            UF = "GO"
                        },
                        new
                        {
                            Id = new Guid("2c2d6923-a397-4d3c-a328-2e78e859ad6a"),
                            Nome = "São Luís",
                            UF = "MA"
                        },
                        new
                        {
                            Id = new Guid("d3f717b7-abdd-4e7f-bb5f-2d26f879e472"),
                            Nome = "Cuiabá",
                            UF = "MT"
                        },
                        new
                        {
                            Id = new Guid("feda1335-e78c-499f-ad5d-7bffe8b43547"),
                            Nome = "Campo Grande",
                            UF = "MS"
                        },
                        new
                        {
                            Id = new Guid("7ccfef4a-2c6f-459b-98a8-65b2d4d36686"),
                            Nome = "Belo Horizonte",
                            UF = "MG"
                        },
                        new
                        {
                            Id = new Guid("83476b65-75c9-4f3e-9880-4489e3094a05"),
                            Nome = "Belém",
                            UF = "PA"
                        },
                        new
                        {
                            Id = new Guid("83d4a0f0-d399-48fe-8f0a-f71569b307b7"),
                            Nome = "João Pessoa",
                            UF = "PB"
                        },
                        new
                        {
                            Id = new Guid("96759d2d-ceac-48ed-b7d6-3d134053353c"),
                            Nome = "Curitiba",
                            UF = "PR"
                        },
                        new
                        {
                            Id = new Guid("164c263b-5c7b-4a7f-902c-ba0acef6c170"),
                            Nome = "Recife",
                            UF = "PE"
                        },
                        new
                        {
                            Id = new Guid("a5b51886-d21c-4b12-bb1b-e197b0c81901"),
                            Nome = "Teresina",
                            UF = "PI"
                        },
                        new
                        {
                            Id = new Guid("efae0d5c-d7d5-4cf7-b3ea-6cb366d782ea"),
                            Nome = "Rio de Janeiro",
                            UF = "RJ"
                        },
                        new
                        {
                            Id = new Guid("2cab41c6-4dbc-4eaa-a38c-cbd8caf40010"),
                            Nome = "Natal",
                            UF = "RN"
                        },
                        new
                        {
                            Id = new Guid("21dfb8b8-17d2-4532-92fd-fce9556cc7b8"),
                            Nome = "Porto Alegre",
                            UF = "RS"
                        },
                        new
                        {
                            Id = new Guid("1b5531e6-cb4b-46f0-99d5-4845a5c1bfb4"),
                            Nome = "Porto Velho",
                            UF = "RO"
                        },
                        new
                        {
                            Id = new Guid("e678d2df-6b96-4c20-8eb9-bff6e20af188"),
                            Nome = "Boa Vista",
                            UF = "RR"
                        },
                        new
                        {
                            Id = new Guid("d34c7270-9577-4cf9-9730-3ce2df4cc79f"),
                            Nome = "Florianópolis",
                            UF = "SC"
                        },
                        new
                        {
                            Id = new Guid("de9f5fd2-7987-48cc-bc36-af6161c25308"),
                            Nome = "São Paulo",
                            UF = "SP"
                        },
                        new
                        {
                            Id = new Guid("717055e4-4b84-4b6f-a959-734aa921fa2d"),
                            Nome = "Aracaju",
                            UF = "SE"
                        },
                        new
                        {
                            Id = new Guid("c65b4008-0334-4e4c-9c85-79ca57dfc486"),
                            Nome = "Palmas",
                            UF = "TO"
                        });
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Regiao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Regiao");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Sul"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Sudeste"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Centro-Oeste"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Nordeste"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Norte"
                        });
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.RegiaoCidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeCidade")
                        .HasColumnType("TEXT");

                    b.Property<int>("RegiaoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RegiaoId1")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RegiaoId");

                    b.HasIndex("RegiaoId1");

                    b.ToTable("RegiaoCidade");

                    b.HasData(
                        new
                        {
                            Id = new Guid("17799cc6-e0a5-43ee-8c58-fe8b44458a59"),
                            NomeCidade = "Rio Branco",
                            RegiaoId = 5
                        },
                        new
                        {
                            Id = new Guid("a6444746-4bbe-41e5-8636-e9c1265e59d7"),
                            NomeCidade = "Manaus",
                            RegiaoId = 5
                        },
                        new
                        {
                            Id = new Guid("6b477f02-b023-4aeb-8864-05bd6ebf0762"),
                            NomeCidade = "Goiânia",
                            RegiaoId = 5
                        },
                        new
                        {
                            Id = new Guid("a9233146-ed42-48fe-abe9-0508a709bff3"),
                            NomeCidade = "Belém",
                            RegiaoId = 5
                        },
                        new
                        {
                            Id = new Guid("c7b052ac-a540-4854-842f-ee17a860d759"),
                            NomeCidade = "Palmas",
                            RegiaoId = 5
                        },
                        new
                        {
                            Id = new Guid("121a2d00-baa2-4c30-a1cc-998faf07b64e"),
                            NomeCidade = "Porto Velho",
                            RegiaoId = 5
                        },
                        new
                        {
                            Id = new Guid("08cceef9-1c86-4a81-aeaa-b828a95ec4fe"),
                            NomeCidade = "Maceió",
                            RegiaoId = 4
                        },
                        new
                        {
                            Id = new Guid("07d43818-5f38-4566-8d7a-5b137ce514e4"),
                            NomeCidade = "Macapá",
                            RegiaoId = 4
                        },
                        new
                        {
                            Id = new Guid("3390865a-ba83-41f8-8923-ae8488253df5"),
                            NomeCidade = "Salvador",
                            RegiaoId = 4
                        },
                        new
                        {
                            Id = new Guid("0db7d727-b96c-48db-90a8-4aa316dc73ff"),
                            NomeCidade = "Fortaleza",
                            RegiaoId = 4
                        },
                        new
                        {
                            Id = new Guid("ab8f5b8d-460d-44e2-8174-1b7aed699fb3"),
                            NomeCidade = "São Luís",
                            RegiaoId = 4
                        },
                        new
                        {
                            Id = new Guid("cebf30f8-faf0-4c1d-b026-e1315f9eb5d0"),
                            NomeCidade = "Cuiabá",
                            RegiaoId = 4
                        },
                        new
                        {
                            Id = new Guid("31aa5e0d-8e46-4ca0-8830-83a7e4464409"),
                            NomeCidade = "João Pessoa",
                            RegiaoId = 4
                        },
                        new
                        {
                            Id = new Guid("455519e9-eabf-4d5b-beb1-de97199f15b9"),
                            NomeCidade = "Recife",
                            RegiaoId = 4
                        },
                        new
                        {
                            Id = new Guid("0ac2bd51-71dc-4928-a64f-599eab6e57c6"),
                            NomeCidade = "Teresina",
                            RegiaoId = 4
                        },
                        new
                        {
                            Id = new Guid("1d08ff88-fd66-4ba2-83fc-b7564350d565"),
                            NomeCidade = "Aracaju",
                            RegiaoId = 4
                        },
                        new
                        {
                            Id = new Guid("fca1c4f8-7da4-4167-ac25-efa6a0d06ce5"),
                            NomeCidade = "Boa Vista",
                            RegiaoId = 4
                        },
                        new
                        {
                            Id = new Guid("a64f8238-584b-4ec9-8b04-9d8dc52bf64b"),
                            NomeCidade = "Natal",
                            RegiaoId = 4
                        },
                        new
                        {
                            Id = new Guid("81f0c104-0272-4c84-b2d7-47dd0faac2c3"),
                            NomeCidade = "Brasília",
                            RegiaoId = 3
                        },
                        new
                        {
                            Id = new Guid("5304873f-4017-4e96-8c0f-35428596edb1"),
                            NomeCidade = "Cuiabá",
                            RegiaoId = 3
                        },
                        new
                        {
                            Id = new Guid("6a9e71d9-1f1e-4f7c-a23c-8c4b313b2bea"),
                            NomeCidade = "Campo Grande",
                            RegiaoId = 3
                        },
                        new
                        {
                            Id = new Guid("8bf1b5d4-c869-4924-bf0b-87d73feefed4"),
                            NomeCidade = "Vitória",
                            RegiaoId = 2
                        },
                        new
                        {
                            Id = new Guid("615c93f1-ea58-46b3-9892-65acd6a973d8"),
                            NomeCidade = "Belo Horizonte",
                            RegiaoId = 2
                        },
                        new
                        {
                            Id = new Guid("ea6ba947-3020-41c5-a0c5-7e993142c969"),
                            NomeCidade = "Rio de Janeiro",
                            RegiaoId = 2
                        },
                        new
                        {
                            Id = new Guid("7f951a50-3a05-4f45-8717-040e52b04f12"),
                            NomeCidade = "São Paulo",
                            RegiaoId = 2
                        },
                        new
                        {
                            Id = new Guid("12b76098-4374-43a4-a534-97ebdfd34f3b"),
                            NomeCidade = "Curitiba",
                            RegiaoId = 1
                        },
                        new
                        {
                            Id = new Guid("ffd0e1d4-37f7-4105-a841-46fce8593f50"),
                            NomeCidade = "Florianópolis",
                            RegiaoId = 1
                        },
                        new
                        {
                            Id = new Guid("d81e739e-21aa-4dc4-8f23-75ced7dcc276"),
                            NomeCidade = "Porto Alegre",
                            RegiaoId = 1
                        });
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.RegiaoCidade", b =>
                {
                    b.HasOne("Fretefy.Test.Domain.Entities.Regiao", null)
                        .WithMany("RegiaoCidade")
                        .HasForeignKey("RegiaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fretefy.Test.Domain.Entities.Regiao", "Regiao")
                        .WithMany()
                        .HasForeignKey("RegiaoId1");

                    b.Navigation("Regiao");
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Regiao", b =>
                {
                    b.Navigation("RegiaoCidade");
                });
#pragma warning restore 612, 618
        }
    }
}
