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
    [Migration("20220312204817_AtualizadoStackSeed")]
    partial class AtualizadoStackSeed
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
                            Id = "34f3aa08-4b54-48fe-8ece-10286f631199",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "csharp.png",
                            FirstDescription = "C# é uma linguagem de programação, desenvolvida pela Microsoft como parte da plataforma .NET",
                            FlagActive = true,
                            SecondDescription = "A línguagem que estudo desde o começo na faculdade e a que mais utilizo no mercado atualmente, me sinto confortável em dizer que é a com mais experiência e expertise atuando em diversos projetos.",
                            StackId = 1,
                            Title = "C#"
                        },
                        new
                        {
                            Id = "5b2c45fc-8201-4557-aefb-cf6f13b18012",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "netCoreIcon.png",
                            FirstDescription = ".NET Core é um framework livre e de código aberto para os sistemas operacionais Windows, Linux e macOS. É um sucessor de código aberto do .NET Framework.",
                            FlagActive = true,
                            SecondDescription = "Conjunto de ferramentas .NET é onde tenho minha maior base de conhecimento e apliquei soluções mais complexas.",
                            StackId = 2,
                            Title = ".NET Core"
                        },
                        new
                        {
                            Id = "3666a253-0a5d-4639-9ca9-bb5f1f60df7f",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "netIcon.png",
                            FirstDescription = "O .NET Framework é uma iniciativa da empresa Microsoft, que visa uma plataforma única para desenvolvimento e execução de sistemas e aplicações. Todo e qualquer código gerado para .NET pode ser executado em qualquer dispositivo que possua um framework de tal plataforma.",
                            FlagActive = true,
                            SecondDescription = "Conjunto de ferramentas .NET é onde tenho minha maior base de conhecimento e apliquei soluções mais complexas.",
                            StackId = 2,
                            Title = ".NET Framework"
                        },
                        new
                        {
                            Id = "3cfdfacd-9c2f-46cd-a544-2660a8e13639",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "javaScript.png",
                            FirstDescription = "JavaScript é uma linguagem de programação interpretada estruturada, Juntamente com HTML e CSS, o JavaScript é uma das três principais tecnologias da World Wide Web.",
                            FlagActive = true,
                            SecondDescription = "Linguagem a qual me sinto confortavel em prestar manutenção ou criar algum script para alguma necessidade web",
                            StackId = 1,
                            Title = "JavaScript"
                        },
                        new
                        {
                            Id = "7b2c60a4-4a0b-4c0f-8dda-290f2033cdd9",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "typescript.png",
                            FirstDescription = "TypeScript é um superconjunto de JavaScript desenvolvido pela Microsoft que adiciona tipagem e alguns outros recursos a linguagem. Anders Hejlsberg, arquiteto da linguagem C# e criador das linguagens Delphi e Turbo Pascal, trabalhou no desenvolvimento do TypeScript.",
                            FlagActive = true,
                            SecondDescription = "Sigo da mesma maneira do JavaScript com relação ao TypeScript, já que comecei a imersão em frameworks front-end antes fui atrás de estudar um pouco sobre TS.",
                            StackId = 1,
                            Title = "TypeScript"
                        },
                        new
                        {
                            Id = "a75651d7-aab3-4c45-8f23-cc8f4b98e36e",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "jquery.png",
                            FirstDescription = "JQuery é uma biblioteca de funções JavaScript que interage com o HTML, desenvolvida para simplificar os scripts interpretados no navegador do cliente.",
                            FlagActive = true,
                            SecondDescription = "Tenho bastante conhecimento em tal framework já que no meu início de carreira foi o que mais utilizei para auxiliar no front-end.",
                            StackId = 3,
                            Title = "JQuery"
                        },
                        new
                        {
                            Id = "ff65bd97-33ef-4f56-b5ed-151b83eb6361",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "bootstrap.png",
                            FirstDescription = "Bootstrap é um framework web com código-fonte aberto para desenvolvimento de componentes de interface e front-end para sites e aplicações web usando HTML, CSS e JavaScript.",
                            FlagActive = true,
                            SecondDescription = "Tenho um bom conhecimento por ser uma ferramenta que normalmente utilizo quando necessito criar uma página do \"zero\" para acelerar o processo de desenvolvimento, então me sinto confortável para trabalhar com a mesma.",
                            StackId = 3,
                            Title = "Bootstrap"
                        },
                        new
                        {
                            Id = "af2fff41-f554-449e-8006-353ece62bf4d",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "azure.png",
                            FirstDescription = "O Microsoft Azure é uma plataforma destinada à execução de aplicativos e serviços, baseada nos conceitos da computação em nuvem.",
                            FlagActive = true,
                            SecondDescription = "Ferramenta que conheço mais sobre, já que utilizo muito atualmente, alguns dos meus projetos antigos eram armazenados na App Services, além de utilizarem o SQL no Azure, Blobs para armazenamento, e CDN para a página estática.",
                            StackId = 7,
                            Title = "Azure"
                        },
                        new
                        {
                            Id = "9d436c9f-7b4c-4b0e-b43e-7fd5858419d1",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "aws.png",
                            FirstDescription = "Amazon Web Services, também conhecido como AWS, é uma plataforma de serviços de computação em nuvem, que formam uma plataforma de computação na nuvem oferecida pela Amazon.com. Os serviços são oferecidos em várias áreas geográficas distribuídas pelo mundo.",
                            FlagActive = true,
                            SecondDescription = "Ferramenta que venho me aprimorando sobre, apesar de utilizar seus produtos em projetos de clientes não tenho uma grande expertise como a Azure.",
                            StackId = 7,
                            Title = "AWS"
                        },
                        new
                        {
                            Id = "7308b165-ca70-4d99-a4d4-a3b26773d103",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "sqlServer.png",
                            FirstDescription = "O Microsoft SQL Server é um sistema gerenciador de Banco de dados relacional desenvolvido pela Sybase em parceria com a Microsoft. Esta parceria durou até 1994, com o lançamento da versão para Windows NT e desde então a Microsoft mantém a manutenção do produto.",
                            FlagActive = true,
                            SecondDescription = "Banco de dados ao qual tenho mais conhecimento, estudo e utilizo o mesmo desce o início da minha jornada com DBs.",
                            StackId = 4,
                            Title = "SQL Server"
                        },
                        new
                        {
                            Id = "96ba16c2-841c-451b-8403-64066528e2a4",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "mysql.png",
                            FirstDescription = "O MySQL é um sistema de gerenciamento de banco de dados, que utiliza a linguagem SQL como interface. É atualmente um dos sistemas de gerenciamento de bancos de dados mais populares da Oracle Corporation, com mais de 10 milhões de instalações pelo mundo.",
                            FlagActive = true,
                            SecondDescription = "Banco de dados que comecei a utilizar com mais frequencia recentemente para poder reduzir custos nos projetos que participei.",
                            StackId = 4,
                            Title = "MySQL"
                        },
                        new
                        {
                            Id = "526c6502-9deb-4c4e-8030-075718c390d2",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "oracleDb.png",
                            FirstDescription = "O Oracle é um SGBD que surgiu no fim dos anos 70, quando Larry Ellison vislumbrou uma oportunidade que outras companhias não haviam percebido, quando encontrou uma descrição de um protótipo funcional de um banco de dados relacional e descobriu que nenhuma empresa tinha se empenhado em comercializar essa tecnologia.",
                            FlagActive = true,
                            SecondDescription = "Banco de dados que comecei a utilizar com mais frequencia recentemente já que muitos projetos legados de alguns clientes utilizavam este banco de dados.",
                            StackId = 4,
                            Title = "Oracle Database"
                        },
                        new
                        {
                            Id = "3091d28b-13ef-49c2-8e0e-4144f2a480ff",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "git.png",
                            FirstDescription = "Git é um sistema de controle de versões distribuído, usado principalmente no desenvolvimento de software, mas pode ser usado para registrar o histórico de edições de qualquer tipo de arquivo.",
                            FlagActive = true,
                            SecondDescription = "O sistema de versionamento ao qual estou habituado a trabalhar, sempre utilizei o Git, e fiz o versionamento ou pelo GitHub ou GitLab.",
                            StackId = 6,
                            Title = "Git"
                        },
                        new
                        {
                            Id = "b63baed7-8174-4775-b579-ac0ca49bc079",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "angular.png",
                            FirstDescription = "Angular é uma plataforma de aplicações web de código-fonte aberto e front-end baseado em TypeScript liderado pela Equipe Angular do Google e por uma comunidade de indivíduos e corporações. Angular é uma reescrita completa do AngularJS, feito pela mesma equipe que o construiu.",
                            FlagActive = true,
                            SecondDescription = "Framework front-end que tenho mais experiência, atualmente consigo construir aplicações com certo nível de complexidade com esta ferramenta.",
                            StackId = 3,
                            Title = "Angular"
                        },
                        new
                        {
                            Id = "ba2b2f0d-0030-45b6-bf07-f94112d65e62",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "reactjs.png",
                            FirstDescription = "O React é uma biblioteca JavaScript de código aberto com foco em criar interfaces de usuário em páginas web. É mantido pelo Facebook, Instagram, outras empresas e uma comunidade de desenvolvedores individuais. É utilizado nos sites da Netflix, Imgur, Feedly, Airbnb, SeatGeek, HelloSign, Walmart e outros.",
                            FlagActive = true,
                            SecondDescription = "Framework front-end ao qual venho estudando e ganhando cada vez mais experiência, atualmente consigo construir aplicações para necessidades simples.",
                            StackId = 3,
                            Title = "ReactJS"
                        },
                        new
                        {
                            Id = "fd409aab-4789-4cb6-9b26-f0b0cc338542",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "azurePipelines.png",
                            FirstDescription = "Azure Pipelines cria e testa automaticamente projetos de código para torná-los disponíveis para outras pessoas. Ele funciona com praticamente qualquer linguagem ou tipo de projeto. Azure Pipelines combina CI (integração contínua) e CD (entrega contínua) para testar e criar seu código e enviar para qualquer destino.",
                            FlagActive = true,
                            SecondDescription = "Tenho certo conhecimento já que utilizei do mesmo para fazer deploy de projetos simples que criei e utilizo na Azure.",
                            StackId = 5,
                            Title = "Azure Pipelines"
                        },
                        new
                        {
                            Id = "74bfd81b-393e-48fd-9cc4-ca2e3d037ec1",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "gitlabcicd.png",
                            FirstDescription = "GitLab é uma plataforma de DevOps de código aberto que oferece soluções para todo o fluxo de desenvolvimento e implantação, como repositórios Git (para versionamento de código), Wikis (para gestão de conhecimento e documentação), quadros de tarefas (similar ao Jira), monitoramento e implantação.",
                            FlagActive = true,
                            SecondDescription = "Conheço somente como utilizar por utilizar na época de estagiário, porém nunca tive a oportunidade de criar um serviço com o mesmo.",
                            StackId = 5,
                            Title = "GitLab CI/CD"
                        },
                        new
                        {
                            Id = "0eb717f0-33b1-47d0-9d78-812d1a3c33d8",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116),
                            FilePathImage = "jenkins.png",
                            FirstDescription = "Jenkins é um servidor de automação de código aberto. Ele ajuda a automatizar as partes do desenvolvimento de software relacionadas à construção, teste e implantação, facilitando a integração e entrega contínuas. É um sistema baseado em servidor que é executado em contêineres de servlet, como o Apache Tomcat.",
                            FlagActive = true,
                            SecondDescription = "Conheço somente como utilizar pois atuei em projetos que utilizam do mesmo junto do Bitbucket, porém nunca tive a oportunidade de criar um serviço com o mesmo.",
                            StackId = 5,
                            Title = "Jenkins"
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
                            Id = "ac715df1-fae0-4872-8aba-1fa5174f87df",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125),
                            FlagActive = true,
                            StackId = 1,
                            StackName = "Linguagens de programação"
                        },
                        new
                        {
                            Id = "fef6ea08-fe4d-40d3-8686-1e948e38e292",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125),
                            FlagActive = true,
                            StackId = 2,
                            StackName = "Frameworks back-end"
                        },
                        new
                        {
                            Id = "f1c74ab2-c280-4da2-9630-d99335ee9c20",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125),
                            FlagActive = true,
                            StackId = 3,
                            StackName = "Frameworks front-end"
                        },
                        new
                        {
                            Id = "11395a1f-ea11-4352-ab1e-f7328006132b",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125),
                            FlagActive = true,
                            StackId = 4,
                            StackName = "Banco de dados"
                        },
                        new
                        {
                            Id = "e320e689-523a-418b-b7a0-ca6b28fb41df",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125),
                            FlagActive = true,
                            StackId = 5,
                            StackName = "CI/CD"
                        },
                        new
                        {
                            Id = "fafac25d-f191-4125-9405-2462f960e568",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125),
                            FlagActive = true,
                            StackId = 6,
                            StackName = "Ferramentas de versionamento"
                        },
                        new
                        {
                            Id = "83e1db14-955e-4415-91f6-797625fd0b4b",
                            DateAdded = new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125),
                            DateModified = new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125),
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