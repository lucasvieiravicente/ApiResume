﻿// <auto-generated />
using System;
using ApiResume.Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiResume.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20210125180007_UpdateKnowledgeSeed")]
    partial class UpdateKnowledgeSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ApiResume.Domain.Models.Knowledge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("FilePathImage")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("FirstDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("FlagActive")
                        .HasColumnType("bit");

                    b.Property<string>("SecondDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Knowledges");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f08bbb57-138d-4712-b547-72dd01c5bd4b"),
                            DateAdded = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FilePathImage = "csharp.png",
                            FirstDescription = "C# é uma linguagem de programação, desenvolvida pela Microsoft como parte da plataforma .NET",
                            FlagActive = true,
                            SecondDescription = "A línguagem que estudo desde o começo na faculdade e a que atuo no mercado atualmente, me sinto confortável em dizer que é a com mais experiência e expertise atuando com diversos projetos.",
                            Title = "C#"
                        },
                        new
                        {
                            Id = new Guid("266fc120-1033-49c8-956f-14a30aaec5c0"),
                            DateAdded = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FilePathImage = "netCoreIcon.png",
                            FirstDescription = ".NET Core é um framework livre e de código aberto para os sistemas operacionais Windows, Linux e macOS. É um sucessor de código aberto do .NET Framework.",
                            FlagActive = true,
                            SecondDescription = "Framework ao qual posso dizer junto do C# que tenho mais expertise, apesar de estudar a mais tempo o .NET \"tradicional\", o .NET Core é o framework ao qual apliquei todo meu conhecimento de maneira profissional trazendo resoluções mais complexas.",
                            Title = ".NET Core"
                        },
                        new
                        {
                            Id = new Guid("c2278d25-4081-4fc4-b9dc-6d730bbc58a3"),
                            DateAdded = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FilePathImage = "netIcon.png",
                            FirstDescription = "O .NET Framework é uma iniciativa da empresa Microsoft, que visa uma plataforma única para desenvolvimento e execução de sistemas e aplicações. Todo e qualquer código gerado para .NET pode ser executado em qualquer dispositivo que possua um framework de tal plataforma.",
                            FlagActive = true,
                            SecondDescription = "Framework que tenho um longo estudo seja a nível acadêmico e com alguns projetos, desenvolvendo simples projetos em WinForms e manutenções em WCF.",
                            Title = ".NET Framework"
                        },
                        new
                        {
                            Id = new Guid("efae61c0-8e3d-42ad-ad4f-4e14c513b898"),
                            DateAdded = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FilePathImage = "javaScript.png",
                            FirstDescription = "JavaScript é uma linguagem de programação interpretada estruturada, Juntamente com HTML e CSS, o JavaScript é uma das três principais tecnologias da World Wide Web.",
                            FlagActive = true,
                            SecondDescription = "Linguagem a qual me sinto confortavel em prestar manutenção ou criar algum script para alguma necessidade web",
                            Title = "JavaScript"
                        },
                        new
                        {
                            Id = new Guid("1bd45a14-2176-49e5-abc3-317a03f37216"),
                            DateAdded = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FilePathImage = "typescript.png",
                            FirstDescription = "TypeScript é um superconjunto de JavaScript desenvolvido pela Microsoft que adiciona tipagem e alguns outros recursos a linguagem. Anders Hejlsberg, arquiteto da linguagem C# e criador das linguagens Delphi e Turbo Pascal, trabalhou no desenvolvimento do TypeScript.",
                            FlagActive = true,
                            SecondDescription = "Sigo da mesma maneira do JavaScript com relação ao TypeScript, já que comecei a imersão em frameworks front-end antes fui atrás de estudar um pouco sobre TS.",
                            Title = "TypeScript"
                        },
                        new
                        {
                            Id = new Guid("f151f5ad-09d4-48e5-a1e0-e7fe6d4a4ac4"),
                            DateAdded = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FilePathImage = "jquery.png",
                            FirstDescription = "JQuery é uma biblioteca de funções JavaScript que interage com o HTML, desenvolvida para simplificar os scripts interpretados no navegador do cliente.",
                            FlagActive = true,
                            SecondDescription = "Tenho bastante conhecimento em tal framework já que no meu início de carreira foi o que mais utilizei para auxiliar no front-end.",
                            Title = "JQuery"
                        },
                        new
                        {
                            Id = new Guid("e2623502-c2d5-46fc-83e7-6cc03fc06f2a"),
                            DateAdded = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FilePathImage = "bootstrap.png",
                            FirstDescription = "Bootstrap é um framework web com código-fonte aberto para desenvolvimento de componentes de interface e front-end para sites e aplicações web usando HTML, CSS e JavaScript.",
                            FlagActive = true,
                            SecondDescription = "Tenho conhecimento considerável por ser uma ferramenta que normalmente utilizo quando necessito criar uma página do \"zero\" para acelerar o processo de desenvolvimento, então me sinto confortável para trabalhar com a mesma.",
                            Title = "Bootstrap"
                        },
                        new
                        {
                            Id = new Guid("8247277f-0e28-4556-b0a2-412821548d85"),
                            DateAdded = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FilePathImage = "azure.png",
                            FirstDescription = "O Microsoft Azure é uma plataforma destinada à execução de aplicativos e serviços, baseada nos conceitos da computação em nuvem.",
                            FlagActive = true,
                            SecondDescription = "Uma ferramenta que comecei a conhecer no estágio, porém continuo os estudos por fora desde então, já que utilizo muito atualmente, pois os projetos Web estão armazenados na App Services, além de utilizarem o SQL no Azure, Blobs para armazenamento, e CDN para a página estática. Atualmente além de utilizar o portal Azure utilizo as ferramentas Azure Storage Explorer e Azure Storage Emulator.",
                            Title = "Azure"
                        },
                        new
                        {
                            Id = new Guid("a548b384-2661-47fe-b448-f48d0ba33a8b"),
                            DateAdded = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FilePathImage = "sqlServer.png",
                            FirstDescription = "O Microsoft SQL Server é um sistema gerenciador de Banco de dados relacional desenvolvido pela Sybase em parceria com a Microsoft. Esta parceria durou até 1994, com o lançamento da versão para Windows NT e desde então a Microsoft mantém a manutenção do produto.",
                            FlagActive = true,
                            SecondDescription = "Banco de dados ao qual tenho mais conhecimento, estudo e utilizo o mesmo desce o início da minha jornada, ao qual atualmente utilizo o SQL Server Management Studio para gerenciamento dos DBs.",
                            Title = "SQL Server"
                        },
                        new
                        {
                            Id = new Guid("235d392a-ed14-494f-b6b1-b107686c2292"),
                            DateAdded = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FilePathImage = "git.png",
                            FirstDescription = "Git é um sistema de controle de versões distribuído, usado principalmente no desenvolvimento de software, mas pode ser usado para registrar o histórico de edições de qualquer tipo de arquivo.",
                            FlagActive = true,
                            SecondDescription = "O sistema de versionamento ao qual estou habituado a trabalhar, sempre utilizei o Git, e fiz o versionamento ou pelo GitHub ou GitLab.",
                            Title = "Git"
                        },
                        new
                        {
                            Id = new Guid("9a286814-5bc9-4247-893a-4aaa216ba599"),
                            DateAdded = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateModified = new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FilePathImage = "angular.png",
                            FirstDescription = "Angular é uma plataforma de aplicações web de código-fonte aberto e front-end baseado em TypeScript liderado pela Equipe Angular do Google e por uma comunidade de indivíduos e corporações. Angular é uma reescrita completa do AngularJS, feito pela mesma equipe que o construiu.",
                            FlagActive = true,
                            SecondDescription = "Framework front-end ao qual venho estudando e ganhando cada vez mais experiência, atualmente consigo construir aplicações para necessidades simples.",
                            Title = "Angular"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
