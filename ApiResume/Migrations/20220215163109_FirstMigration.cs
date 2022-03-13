using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiResume.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Knowledges",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true),
                    FirstDescription = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    SecondDescription = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    FilePathImage = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    FlagActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knowledges", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Knowledges",
                columns: new[] { "Id", "DateAdded", "DateModified", "FilePathImage", "FirstDescription", "FlagActive", "SecondDescription", "Title" },
                values: new object[,]
                {
                    { "ba9a1895-bb7f-43ad-a411-fd4318d8bd78", new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), "csharp.png", "C# é uma linguagem de programação, desenvolvida pela Microsoft como parte da plataforma .NET", true, "A línguagem que estudo desde o começo na faculdade e a que atuo no mercado atualmente, me sinto confortável em dizer que é a com mais experiência e expertise atuando com diversos projetos.", "C#" },
                    { "4f08438e-4396-4ad8-9f58-c48d9cc7615a", new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), "netCoreIcon.png", ".NET Core é um framework livre e de código aberto para os sistemas operacionais Windows, Linux e macOS. É um sucessor de código aberto do .NET Framework.", true, "Framework ao qual posso dizer junto do C# que tenho mais expertise, apesar de estudar a mais tempo o .NET \"tradicional\", o .NET Core é o framework ao qual apliquei todo meu conhecimento de maneira profissional trazendo resoluções mais complexas.", ".NET Core" },
                    { "2d6d7943-c9e6-442b-8e0e-d014b3aac5f8", new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), "netIcon.png", "O .NET Framework é uma iniciativa da empresa Microsoft, que visa uma plataforma única para desenvolvimento e execução de sistemas e aplicações. Todo e qualquer código gerado para .NET pode ser executado em qualquer dispositivo que possua um framework de tal plataforma.", true, "Framework que tenho um longo estudo seja a nível acadêmico e com alguns projetos, desenvolvendo simples projetos em WinForms e manutenções em WCF.", ".NET Framework" },
                    { "a71c562d-b1e9-4879-a305-823325790b9d", new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), "javaScript.png", "JavaScript é uma linguagem de programação interpretada estruturada, Juntamente com HTML e CSS, o JavaScript é uma das três principais tecnologias da World Wide Web.", true, "Linguagem a qual me sinto confortavel em prestar manutenção ou criar algum script para alguma necessidade web", "JavaScript" },
                    { "84dfdb61-f111-4306-956f-8a98aa46cf9f", new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), "typescript.png", "TypeScript é um superconjunto de JavaScript desenvolvido pela Microsoft que adiciona tipagem e alguns outros recursos a linguagem. Anders Hejlsberg, arquiteto da linguagem C# e criador das linguagens Delphi e Turbo Pascal, trabalhou no desenvolvimento do TypeScript.", true, "Sigo da mesma maneira do JavaScript com relação ao TypeScript, já que comecei a imersão em frameworks front-end antes fui atrás de estudar um pouco sobre TS.", "TypeScript" },
                    { "6344613a-a5a4-43bd-b2c5-96febe7c8232", new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), "jquery.png", "JQuery é uma biblioteca de funções JavaScript que interage com o HTML, desenvolvida para simplificar os scripts interpretados no navegador do cliente.", true, "Tenho bastante conhecimento em tal framework já que no meu início de carreira foi o que mais utilizei para auxiliar no front-end.", "JQuery" },
                    { "3239af84-4975-4b87-8c3c-34d3c75d8df3", new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), "bootstrap.png", "Bootstrap é um framework web com código-fonte aberto para desenvolvimento de componentes de interface e front-end para sites e aplicações web usando HTML, CSS e JavaScript.", true, "Tenho conhecimento considerável por ser uma ferramenta que normalmente utilizo quando necessito criar uma página do \"zero\" para acelerar o processo de desenvolvimento, então me sinto confortável para trabalhar com a mesma.", "Bootstrap" },
                    { "eac1044e-0a88-421c-a603-895770c75701", new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), "azure.png", "O Microsoft Azure é uma plataforma destinada à execução de aplicativos e serviços, baseada nos conceitos da computação em nuvem.", true, "Uma ferramenta que comecei a conhecer no estágio, porém continuo os estudos por fora desde então, já que utilizo muito atualmente, pois os projetos Web estão armazenados na App Services, além de utilizarem o SQL no Azure, Blobs para armazenamento, e CDN para a página estática. Atualmente além de utilizar o portal Azure utilizo as ferramentas Azure Storage Explorer e Azure Storage Emulator.", "Azure" },
                    { "401a5e07-7946-434c-8d8e-1a39a9ef8161", new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), "sqlServer.png", "O Microsoft SQL Server é um sistema gerenciador de Banco de dados relacional desenvolvido pela Sybase em parceria com a Microsoft. Esta parceria durou até 1994, com o lançamento da versão para Windows NT e desde então a Microsoft mantém a manutenção do produto.", true, "Banco de dados ao qual tenho mais conhecimento, estudo e utilizo o mesmo desce o início da minha jornada, ao qual atualmente utilizo o SQL Server Management Studio para gerenciamento dos DBs.", "SQL Server" },
                    { "00be71a1-496f-4109-a7ab-6554f0c375fb", new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), "git.png", "Git é um sistema de controle de versões distribuído, usado principalmente no desenvolvimento de software, mas pode ser usado para registrar o histórico de edições de qualquer tipo de arquivo.", true, "O sistema de versionamento ao qual estou habituado a trabalhar, sempre utilizei o Git, e fiz o versionamento ou pelo GitHub ou GitLab.", "Git" },
                    { "8b9052b5-54e0-47b9-977b-0bc22e6c0362", new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), new DateTime(2022, 2, 15, 13, 31, 8, 793, DateTimeKind.Local).AddTicks(9065), "angular.png", "Angular é uma plataforma de aplicações web de código-fonte aberto e front-end baseado em TypeScript liderado pela Equipe Angular do Google e por uma comunidade de indivíduos e corporações. Angular é uma reescrita completa do AngularJS, feito pela mesma equipe que o construiu.", true, "Framework front-end ao qual venho estudando e ganhando cada vez mais experiência, atualmente consigo construir aplicações para necessidades simples.", "Angular" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Knowledges");
        }
    }
}
