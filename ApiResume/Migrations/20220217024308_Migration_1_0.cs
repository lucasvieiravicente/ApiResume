using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiResume.Migrations
{
    public partial class Migration_1_0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "00be71a1-496f-4109-a7ab-6554f0c375fb");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "2d6d7943-c9e6-442b-8e0e-d014b3aac5f8");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "3239af84-4975-4b87-8c3c-34d3c75d8df3");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "401a5e07-7946-434c-8d8e-1a39a9ef8161");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "4f08438e-4396-4ad8-9f58-c48d9cc7615a");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "6344613a-a5a4-43bd-b2c5-96febe7c8232");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "84dfdb61-f111-4306-956f-8a98aa46cf9f");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "8b9052b5-54e0-47b9-977b-0bc22e6c0362");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "a71c562d-b1e9-4879-a305-823325790b9d");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "ba9a1895-bb7f-43ad-a411-fd4318d8bd78");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "eac1044e-0a88-421c-a603-895770c75701");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Knowledges",
                type: "varchar(36)",
                maxLength: 36,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "StackId",
                table: "Knowledges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Stacks",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", maxLength: 36, nullable: false),
                    StackName = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true),
                    StackId = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: false),
                    FlagActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stacks", x => x.Id);
                    table.UniqueConstraint("AK_Stacks_StackId", x => x.StackId);
                });

            migrationBuilder.InsertData(
                table: "Stacks",
                columns: new[] { "Id", "DateAdded", "DateModified", "FlagActive", "StackId", "StackName" },
                values: new object[,]
                {
                    { "87260062-83d5-47cb-8258-b099327c3dee", new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589), new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589), true, 1, "Linguagens de programação" },
                    { "4a65d26b-666a-4949-98c9-d62665f01bd2", new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589), new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589), true, 2, "Frameworks back-end" },
                    { "919d1e02-036e-4dbb-b6ff-45d8e5b97223", new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589), new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589), true, 3, "Frameworks front-end" },
                    { "4b2634ee-5615-433e-ad10-1b95ca660dfe", new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589), new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589), true, 4, "Banco de dados" },
                    { "a2038d30-e041-4e1b-8579-15f3f16ac754", new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589), new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589), true, 5, "CI/CD" },
                    { "7a2e35f5-495c-4f31-8605-e5432edb0884", new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589), new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589), true, 6, "Ferramentas de versionamento" },
                    { "713c3d89-1f0e-483b-ad3f-1c770fc7762d", new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589), new DateTime(2022, 2, 16, 23, 43, 8, 495, DateTimeKind.Local).AddTicks(1589), true, 7, "Outros" }
                });

            migrationBuilder.InsertData(
                table: "Knowledges",
                columns: new[] { "Id", "DateAdded", "DateModified", "FilePathImage", "FirstDescription", "FlagActive", "SecondDescription", "StackId", "Title" },
                values: new object[,]
                {
                    { "4eaae7a6-80cd-4bad-9b5c-0b9bc3e5e4fb", new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), "csharp.png", "C# é uma linguagem de programação, desenvolvida pela Microsoft como parte da plataforma .NET", true, "A línguagem que estudo desde o começo na faculdade e a que atuo no mercado atualmente, me sinto confortável em dizer que é a com mais experiência e expertise atuando com diversos projetos.", 1, "C#" },
                    { "9d8dbb46-5c48-4f59-a483-a50c0d3fb1b0", new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), "javaScript.png", "JavaScript é uma linguagem de programação interpretada estruturada, Juntamente com HTML e CSS, o JavaScript é uma das três principais tecnologias da World Wide Web.", true, "Linguagem a qual me sinto confortavel em prestar manutenção ou criar algum script para alguma necessidade web", 1, "JavaScript" },
                    { "623cae28-ac59-4eec-896c-d34b23cced90", new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), "typescript.png", "TypeScript é um superconjunto de JavaScript desenvolvido pela Microsoft que adiciona tipagem e alguns outros recursos a linguagem. Anders Hejlsberg, arquiteto da linguagem C# e criador das linguagens Delphi e Turbo Pascal, trabalhou no desenvolvimento do TypeScript.", true, "Sigo da mesma maneira do JavaScript com relação ao TypeScript, já que comecei a imersão em frameworks front-end antes fui atrás de estudar um pouco sobre TS.", 1, "TypeScript" },
                    { "d9223e60-e9dc-45dc-a6b1-c69dbfcbc014", new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), "netCoreIcon.png", ".NET Core é um framework livre e de código aberto para os sistemas operacionais Windows, Linux e macOS. É um sucessor de código aberto do .NET Framework.", true, "Framework ao qual posso dizer junto do C# que tenho mais expertise, apesar de estudar a mais tempo o .NET \"tradicional\", o .NET Core é o framework ao qual apliquei todo meu conhecimento de maneira profissional trazendo resoluções mais complexas.", 2, ".NET Core" },
                    { "9e03ef7a-996d-438c-b676-eaddfeeb8812", new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), "netIcon.png", "O .NET Framework é uma iniciativa da empresa Microsoft, que visa uma plataforma única para desenvolvimento e execução de sistemas e aplicações. Todo e qualquer código gerado para .NET pode ser executado em qualquer dispositivo que possua um framework de tal plataforma.", true, "Framework que tenho um longo estudo seja a nível acadêmico e com alguns projetos, desenvolvendo simples projetos em WinForms e manutenções em WCF.", 2, ".NET Framework" },
                    { "0f10cefe-6a4e-4077-88f1-4e54e0df1b34", new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), "jquery.png", "JQuery é uma biblioteca de funções JavaScript que interage com o HTML, desenvolvida para simplificar os scripts interpretados no navegador do cliente.", true, "Tenho bastante conhecimento em tal framework já que no meu início de carreira foi o que mais utilizei para auxiliar no front-end.", 3, "JQuery" },
                    { "28826509-8b01-4902-a44b-c49376b9db85", new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), "bootstrap.png", "Bootstrap é um framework web com código-fonte aberto para desenvolvimento de componentes de interface e front-end para sites e aplicações web usando HTML, CSS e JavaScript.", true, "Tenho conhecimento considerável por ser uma ferramenta que normalmente utilizo quando necessito criar uma página do \"zero\" para acelerar o processo de desenvolvimento, então me sinto confortável para trabalhar com a mesma.", 3, "Bootstrap" },
                    { "65e2b599-f620-439c-a2fa-0722f2dab18e", new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), "angular.png", "Angular é uma plataforma de aplicações web de código-fonte aberto e front-end baseado em TypeScript liderado pela Equipe Angular do Google e por uma comunidade de indivíduos e corporações. Angular é uma reescrita completa do AngularJS, feito pela mesma equipe que o construiu.", true, "Framework front-end ao qual venho estudando e ganhando cada vez mais experiência, atualmente consigo construir aplicações para necessidades simples.", 3, "Angular" },
                    { "069e5fe8-c0e8-4b96-90b5-e71550921be0", new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), "sqlServer.png", "O Microsoft SQL Server é um sistema gerenciador de Banco de dados relacional desenvolvido pela Sybase em parceria com a Microsoft. Esta parceria durou até 1994, com o lançamento da versão para Windows NT e desde então a Microsoft mantém a manutenção do produto.", true, "Banco de dados ao qual tenho mais conhecimento, estudo e utilizo o mesmo desce o início da minha jornada, ao qual atualmente utilizo o SQL Server Management Studio para gerenciamento dos DBs.", 4, "SQL Server" },
                    { "69c144aa-10c7-4c51-86ba-ad7ba00558cd", new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), "git.png", "Git é um sistema de controle de versões distribuído, usado principalmente no desenvolvimento de software, mas pode ser usado para registrar o histórico de edições de qualquer tipo de arquivo.", true, "O sistema de versionamento ao qual estou habituado a trabalhar, sempre utilizei o Git, e fiz o versionamento ou pelo GitHub ou GitLab.", 6, "Git" },
                    { "b6f29fff-c1ad-447a-8514-f60df8555094", new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), new DateTime(2022, 2, 16, 23, 43, 8, 500, DateTimeKind.Local).AddTicks(8437), "azure.png", "O Microsoft Azure é uma plataforma destinada à execução de aplicativos e serviços, baseada nos conceitos da computação em nuvem.", true, "Uma ferramenta que comecei a conhecer no estágio, porém continuo os estudos por fora desde então, já que utilizo muito atualmente, pois os projetos Web estão armazenados na App Services, além de utilizarem o SQL no Azure, Blobs para armazenamento, e CDN para a página estática. Atualmente além de utilizar o portal Azure utilizo as ferramentas Azure Storage Explorer e Azure Storage Emulator.", 7, "Azure" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Knowledges_StackId",
                table: "Knowledges",
                column: "StackId");

            migrationBuilder.AddForeignKey(
                name: "FK_Knowledges_Stacks_StackId",
                table: "Knowledges",
                column: "StackId",
                principalTable: "Stacks",
                principalColumn: "StackId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Knowledges_Stacks_StackId",
                table: "Knowledges");

            migrationBuilder.DropTable(
                name: "Stacks");

            migrationBuilder.DropIndex(
                name: "IX_Knowledges_StackId",
                table: "Knowledges");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "069e5fe8-c0e8-4b96-90b5-e71550921be0");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "0f10cefe-6a4e-4077-88f1-4e54e0df1b34");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "28826509-8b01-4902-a44b-c49376b9db85");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "4eaae7a6-80cd-4bad-9b5c-0b9bc3e5e4fb");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "623cae28-ac59-4eec-896c-d34b23cced90");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "65e2b599-f620-439c-a2fa-0722f2dab18e");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "69c144aa-10c7-4c51-86ba-ad7ba00558cd");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "9d8dbb46-5c48-4f59-a483-a50c0d3fb1b0");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "9e03ef7a-996d-438c-b676-eaddfeeb8812");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "b6f29fff-c1ad-447a-8514-f60df8555094");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "d9223e60-e9dc-45dc-a6b1-c69dbfcbc014");

            migrationBuilder.DropColumn(
                name: "StackId",
                table: "Knowledges");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Knowledges",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(36)",
                oldMaxLength: 36);

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
    }
}
