﻿// <auto-generated />
using System;
using ApiResume.Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiResume.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20220217024308_Migration_1_0")]
    partial class Migration_1_0
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("ApiResume.Domain.Models.Knowledge", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime");

                    b.Property<string>("FilePathImage")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("FirstDescription")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<bool>("FlagActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecondDescription")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<int>("StackId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("StackId");

                    b.ToTable("Knowledges");

                    b.HasData(
                        new
                        {
                            Id = "4eaae7a6-80cd-4bad-9b5c-0b9bc3e5e4fb",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            FilePathImage = "csharp.png",
                            FirstDescription = "C# é uma linguagem de programação, desenvolvida pela Microsoft como parte da plataforma .NET",
                            FlagActive = true,
                            SecondDescription = "A línguagem que estudo desde o começo na faculdade e a que atuo no mercado atualmente, me sinto confortável em dizer que é a com mais experiência e expertise atuando com diversos projetos.",
                            StackId = 1,
                            Title = "C#"
                        },
                        new
                        {
                            Id = "d9223e60-e9dc-45dc-a6b1-c69dbfcbc014",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            FilePathImage = "netCoreIcon.png",
                            FirstDescription = ".NET Core é um framework livre e de código aberto para os sistemas operacionais Windows, Linux e macOS. É um sucessor de código aberto do .NET Framework.",
                            FlagActive = true,
                            SecondDescription = "Framework ao qual posso dizer junto do C# que tenho mais expertise, apesar de estudar a mais tempo o .NET \"tradicional\", o .NET Core é o framework ao qual apliquei todo meu conhecimento de maneira profissional trazendo resoluções mais complexas.",
                            StackId = 2,
                            Title = ".NET Core"
                        },
                        new
                        {
                            Id = "9e03ef7a-996d-438c-b676-eaddfeeb8812",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            FilePathImage = "netIcon.png",
                            FirstDescription = "O .NET Framework é uma iniciativa da empresa Microsoft, que visa uma plataforma única para desenvolvimento e execução de sistemas e aplicações. Todo e qualquer código gerado para .NET pode ser executado em qualquer dispositivo que possua um framework de tal plataforma.",
                            FlagActive = true,
                            SecondDescription = "Framework que tenho um longo estudo seja a nível acadêmico e com alguns projetos, desenvolvendo simples projetos em WinForms e manutenções em WCF.",
                            StackId = 2,
                            Title = ".NET Framework"
                        },
                        new
                        {
                            Id = "9d8dbb46-5c48-4f59-a483-a50c0d3fb1b0",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            FilePathImage = "javaScript.png",
                            FirstDescription = "JavaScript é uma linguagem de programação interpretada estruturada, Juntamente com HTML e CSS, o JavaScript é uma das três principais tecnologias da World Wide Web.",
                            FlagActive = true,
                            SecondDescription = "Linguagem a qual me sinto confortavel em prestar manutenção ou criar algum script para alguma necessidade web",
                            StackId = 1,
                            Title = "JavaScript"
                        },
                        new
                        {
                            Id = "623cae28-ac59-4eec-896c-d34b23cced90",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            FilePathImage = "typescript.png",
                            FirstDescription = "TypeScript é um superconjunto de JavaScript desenvolvido pela Microsoft que adiciona tipagem e alguns outros recursos a linguagem. Anders Hejlsberg, arquiteto da linguagem C# e criador das linguagens Delphi e Turbo Pascal, trabalhou no desenvolvimento do TypeScript.",
                            FlagActive = true,
                            SecondDescription = "Sigo da mesma maneira do JavaScript com relação ao TypeScript, já que comecei a imersão em frameworks front-end antes fui atrás de estudar um pouco sobre TS.",
                            StackId = 1,
                            Title = "TypeScript"
                        },
                        new
                        {
                            Id = "0f10cefe-6a4e-4077-88f1-4e54e0df1b34",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            FilePathImage = "jquery.png",
                            FirstDescription = "JQuery é uma biblioteca de funções JavaScript que interage com o HTML, desenvolvida para simplificar os scripts interpretados no navegador do cliente.",
                            FlagActive = true,
                            SecondDescription = "Tenho bastante conhecimento em tal framework já que no meu início de carreira foi o que mais utilizei para auxiliar no front-end.",
                            StackId = 3,
                            Title = "JQuery"
                        },
                        new
                        {
                            Id = "28826509-8b01-4902-a44b-c49376b9db85",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            FilePathImage = "bootstrap.png",
                            FirstDescription = "Bootstrap é um framework web com código-fonte aberto para desenvolvimento de componentes de interface e front-end para sites e aplicações web usando HTML, CSS e JavaScript.",
                            FlagActive = true,
                            SecondDescription = "Tenho conhecimento considerável por ser uma ferramenta que normalmente utilizo quando necessito criar uma página do \"zero\" para acelerar o processo de desenvolvimento, então me sinto confortável para trabalhar com a mesma.",
                            StackId = 3,
                            Title = "Bootstrap"
                        },
                        new
                        {
                            Id = "b6f29fff-c1ad-447a-8514-f60df8555094",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            FilePathImage = "azure.png",
                            FirstDescription = "O Microsoft Azure é uma plataforma destinada à execução de aplicativos e serviços, baseada nos conceitos da computação em nuvem.",
                            FlagActive = true,
                            SecondDescription = "Uma ferramenta que comecei a conhecer no estágio, porém continuo os estudos por fora desde então, já que utilizo muito atualmente, pois os projetos Web estão armazenados na App Services, além de utilizarem o SQL no Azure, Blobs para armazenamento, e CDN para a página estática. Atualmente além de utilizar o portal Azure utilizo as ferramentas Azure Storage Explorer e Azure Storage Emulator.",
                            StackId = 7,
                            Title = "Azure"
                        },
                        new
                        {
                            Id = "069e5fe8-c0e8-4b96-90b5-e71550921be0",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            FilePathImage = "sqlServer.png",
                            FirstDescription = "O Microsoft SQL Server é um sistema gerenciador de Banco de dados relacional desenvolvido pela Sybase em parceria com a Microsoft. Esta parceria durou até 1994, com o lançamento da versão para Windows NT e desde então a Microsoft mantém a manutenção do produto.",
                            FlagActive = true,
                            SecondDescription = "Banco de dados ao qual tenho mais conhecimento, estudo e utilizo o mesmo desce o início da minha jornada, ao qual atualmente utilizo o SQL Server Management Studio para gerenciamento dos DBs.",
                            StackId = 4,
                            Title = "SQL Server"
                        },
                        new
                        {
                            Id = "69c144aa-10c7-4c51-86ba-ad7ba00558cd",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            FilePathImage = "git.png",
                            FirstDescription = "Git é um sistema de controle de versões distribuído, usado principalmente no desenvolvimento de software, mas pode ser usado para registrar o histórico de edições de qualquer tipo de arquivo.",
                            FlagActive = true,
                            SecondDescription = "O sistema de versionamento ao qual estou habituado a trabalhar, sempre utilizei o Git, e fiz o versionamento ou pelo GitHub ou GitLab.",
                            StackId = 6,
                            Title = "Git"
                        },
                        new
                        {
                            Id = "65e2b599-f620-439c-a2fa-0722f2dab18e",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437),
                            FilePathImage = "angular.png",
                            FirstDescription = "Angular é uma plataforma de aplicações web de código-fonte aberto e front-end baseado em TypeScript liderado pela Equipe Angular do Google e por uma comunidade de indivíduos e corporações. Angular é uma reescrita completa do AngularJS, feito pela mesma equipe que o construiu.",
                            FlagActive = true,
                            SecondDescription = "Framework front-end ao qual venho estudando e ganhando cada vez mais experiência, atualmente consigo construir aplicações para necessidades simples.",
                            StackId = 3,
                            Title = "Angular"
                        });
                });

            modelBuilder.Entity("ApiResume.Domain.Models.Stack", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime");

                    b.Property<bool>("FlagActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("StackId")
                        .HasColumnType("int");

                    b.Property<string>("StackName")
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Stacks");

                    b.HasData(
                        new
                        {
                            Id = "87260062-83d5-47cb-8258-b099327c3dee",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589),
                            FlagActive = true,
                            StackId = 1,
                            StackName = "Linguagens de programação"
                        },
                        new
                        {
                            Id = "4a65d26b-666a-4949-98c9-d62665f01bd2",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589),
                            FlagActive = true,
                            StackId = 2,
                            StackName = "Frameworks back-end"
                        },
                        new
                        {
                            Id = "919d1e02-036e-4dbb-b6ff-45d8e5b97223",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589),
                            FlagActive = true,
                            StackId = 3,
                            StackName = "Frameworks front-end"
                        },
                        new
                        {
                            Id = "4b2634ee-5615-433e-ad10-1b95ca660dfe",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589),
                            FlagActive = true,
                            StackId = 4,
                            StackName = "Banco de dados"
                        },
                        new
                        {
                            Id = "a2038d30-e041-4e1b-8579-15f3f16ac754",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589),
                            FlagActive = true,
                            StackId = 5,
                            StackName = "CI/CD"
                        },
                        new
                        {
                            Id = "7a2e35f5-495c-4f31-8605-e5432edb0884",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589),
                            FlagActive = true,
                            StackId = 6,
                            StackName = "Ferramentas de versionamento"
                        },
                        new
                        {
                            Id = "713c3d89-1f0e-483b-ad3f-1c770fc7762d",
                            DateAdded = new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589),
                            DateModified = new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589),
                            FlagActive = true,
                            StackId = 7,
                            StackName = "Outros"
                        });
                });

            modelBuilder.Entity("ApiResume.Domain.Models.Knowledge", b =>
                {
                    b.HasOne("ApiResume.Domain.Models.Stack", "Stack")
                        .WithMany("Knowledges")
                        .HasForeignKey("StackId")
                        .HasPrincipalKey("StackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stack");
                });

            modelBuilder.Entity("ApiResume.Domain.Models.Stack", b =>
                {
                    b.Navigation("Knowledges");
                });
#pragma warning restore 612, 618
        }
    }
}
