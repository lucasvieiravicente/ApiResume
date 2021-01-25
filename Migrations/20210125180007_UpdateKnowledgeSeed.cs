using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiResume.Migrations
{
    public partial class UpdateKnowledgeSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("0932e56c-791b-4f52-a08c-8f68d904d1d5"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("10de77cb-201c-42c5-8edc-3b4aba2a9fc2"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("2bf63f8f-de30-4c62-861a-99f9f98aa8ef"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("3c49a566-d4cc-407b-b5ea-e80198a45611"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("5cd07098-29e1-411f-afd8-22b014a23cfc"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("5efdbd12-f2e5-4492-956c-ec7f14f4d395"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("646c5b52-ae73-4351-9d2b-9819ae415a90"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("6ff645c2-7dca-49cf-a401-a842327555e2"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("88d7da39-5c17-4a80-9111-e3be7cd7d8a5"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("967589e9-fa1d-4a22-9a73-97bfb2a51cdc"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("b8e39e47-e841-4c2d-931a-c798ebe90699"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("d2702ba4-b264-41c0-b050-ea5a123cd639"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("dfb50ea1-9c95-4fbc-9939-cbda2f0a826e"));

            migrationBuilder.InsertData(
                table: "Knowledges",
                columns: new[] { "Id", "DateAdded", "DateModified", "FilePathImage", "FirstDescription", "FlagActive", "SecondDescription", "Title" },
                values: new object[,]
                {
                    { new Guid("f08bbb57-138d-4712-b547-72dd01c5bd4b"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "csharp.png", "C# é uma linguagem de programação, desenvolvida pela Microsoft como parte da plataforma .NET", true, "A línguagem que estudo desde o começo na faculdade e a que atuo no mercado atualmente, me sinto confortável em dizer que é a com mais experiência e expertise atuando com diversos projetos.", "C#" },
                    { new Guid("266fc120-1033-49c8-956f-14a30aaec5c0"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "netCoreIcon.png", ".NET Core é um framework livre e de código aberto para os sistemas operacionais Windows, Linux e macOS. É um sucessor de código aberto do .NET Framework.", true, "Framework ao qual posso dizer junto do C# que tenho mais expertise, apesar de estudar a mais tempo o .NET \"tradicional\", o .NET Core é o framework ao qual apliquei todo meu conhecimento de maneira profissional trazendo resoluções mais complexas.", ".NET Core" },
                    { new Guid("c2278d25-4081-4fc4-b9dc-6d730bbc58a3"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "netIcon.png", "O .NET Framework é uma iniciativa da empresa Microsoft, que visa uma plataforma única para desenvolvimento e execução de sistemas e aplicações. Todo e qualquer código gerado para .NET pode ser executado em qualquer dispositivo que possua um framework de tal plataforma.", true, "Framework que tenho um longo estudo seja a nível acadêmico e com alguns projetos, desenvolvendo simples projetos em WinForms e manutenções em WCF.", ".NET Framework" },
                    { new Guid("efae61c0-8e3d-42ad-ad4f-4e14c513b898"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "javaScript.png", "JavaScript é uma linguagem de programação interpretada estruturada, Juntamente com HTML e CSS, o JavaScript é uma das três principais tecnologias da World Wide Web.", true, "Linguagem a qual me sinto confortavel em prestar manutenção ou criar algum script para alguma necessidade web", "JavaScript" },
                    { new Guid("1bd45a14-2176-49e5-abc3-317a03f37216"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "typescript.png", "TypeScript é um superconjunto de JavaScript desenvolvido pela Microsoft que adiciona tipagem e alguns outros recursos a linguagem. Anders Hejlsberg, arquiteto da linguagem C# e criador das linguagens Delphi e Turbo Pascal, trabalhou no desenvolvimento do TypeScript.", true, "Sigo da mesma maneira do JavaScript com relação ao TypeScript, já que comecei a imersão em frameworks front-end antes fui atrás de estudar um pouco sobre TS.", "TypeScript" },
                    { new Guid("f151f5ad-09d4-48e5-a1e0-e7fe6d4a4ac4"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "jquery.png", "JQuery é uma biblioteca de funções JavaScript que interage com o HTML, desenvolvida para simplificar os scripts interpretados no navegador do cliente.", true, "Tenho bastante conhecimento em tal framework já que no meu início de carreira foi o que mais utilizei para auxiliar no front-end.", "JQuery" },
                    { new Guid("e2623502-c2d5-46fc-83e7-6cc03fc06f2a"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "bootstrap.png", "Bootstrap é um framework web com código-fonte aberto para desenvolvimento de componentes de interface e front-end para sites e aplicações web usando HTML, CSS e JavaScript.", true, "Tenho conhecimento considerável por ser uma ferramenta que normalmente utilizo quando necessito criar uma página do \"zero\" para acelerar o processo de desenvolvimento, então me sinto confortável para trabalhar com a mesma.", "Bootstrap" },
                    { new Guid("8247277f-0e28-4556-b0a2-412821548d85"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "azure.png", "O Microsoft Azure é uma plataforma destinada à execução de aplicativos e serviços, baseada nos conceitos da computação em nuvem.", true, "Uma ferramenta que comecei a conhecer no estágio, porém continuo os estudos por fora desde então, já que utilizo muito atualmente, pois os projetos Web estão armazenados na App Services, além de utilizarem o SQL no Azure, Blobs para armazenamento, e CDN para a página estática. Atualmente além de utilizar o portal Azure utilizo as ferramentas Azure Storage Explorer e Azure Storage Emulator.", "Azure" },
                    { new Guid("a548b384-2661-47fe-b448-f48d0ba33a8b"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "sqlServer.png", "O Microsoft SQL Server é um sistema gerenciador de Banco de dados relacional desenvolvido pela Sybase em parceria com a Microsoft. Esta parceria durou até 1994, com o lançamento da versão para Windows NT e desde então a Microsoft mantém a manutenção do produto.", true, "Banco de dados ao qual tenho mais conhecimento, estudo e utilizo o mesmo desce o início da minha jornada, ao qual atualmente utilizo o SQL Server Management Studio para gerenciamento dos DBs.", "SQL Server" },
                    { new Guid("235d392a-ed14-494f-b6b1-b107686c2292"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "git.png", "Git é um sistema de controle de versões distribuído, usado principalmente no desenvolvimento de software, mas pode ser usado para registrar o histórico de edições de qualquer tipo de arquivo.", true, "O sistema de versionamento ao qual estou habituado a trabalhar, sempre utilizei o Git, e fiz o versionamento ou pelo GitHub ou GitLab.", "Git" },
                    { new Guid("9a286814-5bc9-4247-893a-4aaa216ba599"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "angular.png", "Angular é uma plataforma de aplicações web de código-fonte aberto e front-end baseado em TypeScript liderado pela Equipe Angular do Google e por uma comunidade de indivíduos e corporações. Angular é uma reescrita completa do AngularJS, feito pela mesma equipe que o construiu.", true, "Framework front-end ao qual venho estudando e ganhando cada vez mais experiência, atualmente consigo construir aplicações para necessidades simples.", "Angular" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("1bd45a14-2176-49e5-abc3-317a03f37216"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("235d392a-ed14-494f-b6b1-b107686c2292"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("266fc120-1033-49c8-956f-14a30aaec5c0"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("8247277f-0e28-4556-b0a2-412821548d85"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("9a286814-5bc9-4247-893a-4aaa216ba599"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("a548b384-2661-47fe-b448-f48d0ba33a8b"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("c2278d25-4081-4fc4-b9dc-6d730bbc58a3"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("e2623502-c2d5-46fc-83e7-6cc03fc06f2a"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("efae61c0-8e3d-42ad-ad4f-4e14c513b898"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("f08bbb57-138d-4712-b547-72dd01c5bd4b"));

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: new Guid("f151f5ad-09d4-48e5-a1e0-e7fe6d4a4ac4"));

            migrationBuilder.InsertData(
                table: "Knowledges",
                columns: new[] { "Id", "DateAdded", "DateModified", "FilePathImage", "FirstDescription", "FlagActive", "SecondDescription", "Title" },
                values: new object[,]
                {
                    { new Guid("10de77cb-201c-42c5-8edc-3b4aba2a9fc2"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "csharp.png", "C# é uma linguagem de programação, desenvolvida pela Microsoft como parte da plataforma .NET", true, "A línguagem que estudo desde o começo na faculdade e a que atuo no mercado atualmente, me sinto confortável em dizer que é a com mais experiência e expertise atuando com diversos projetos.", "C#" },
                    { new Guid("6ff645c2-7dca-49cf-a401-a842327555e2"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "netCoreIcon.png", ".NET Core é um framework livre e de código aberto para os sistemas operacionais Windows, Linux e macOS. É um sucessor de código aberto do .NET Framework.", true, "Framework ao qual posso dizer junto do C# que tenho mais expertise, apesar de estudar a mais tempo o .NET \"tradicional\", o .NET Core é o framework ao qual apliquei todo meu conhecimento de maneira profissional trazendo resoluções mais complexas.", ".NET Core" },
                    { new Guid("967589e9-fa1d-4a22-9a73-97bfb2a51cdc"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "netIcon.png", "O .NET Framework é uma iniciativa da empresa Microsoft, que visa uma plataforma única para desenvolvimento e execução de sistemas e aplicações. Todo e qualquer código gerado para .NET pode ser executado em qualquer dispositivo que possua um framework de tal plataforma.", true, "Framework que tenho um longo estudo seja a nível acadêmico e com alguns projetos, desenvolvendo simples projetos em WinForms e manutenções em WCF.", ".NET Framework" },
                    { new Guid("0932e56c-791b-4f52-a08c-8f68d904d1d5"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "netIcon.png", "JavaScript é uma linguagem de programação interpretada estruturada, Juntamente com HTML e CSS, o JavaScript é uma das três principais tecnologias da World Wide Web.", true, "Linguagem a qual me sinto confortavel em prestar manutenção ou criar algum script para alguma necessidade web", "JavaScript" },
                    { new Guid("5efdbd12-f2e5-4492-956c-ec7f14f4d395"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "typescript.png", "TypeScript é um superconjunto de JavaScript desenvolvido pela Microsoft que adiciona tipagem e alguns outros recursos a linguagem. Anders Hejlsberg, arquiteto da linguagem C# e criador das linguagens Delphi e Turbo Pascal, trabalhou no desenvolvimento do TypeScript.", true, "Sigo da mesma maneira do JavaScript com relação ao TypeScript, já que comecei a imersão em frameworks front-end antes fui atrás de estudar um pouco sobre TS.", "TypeScript" },
                    { new Guid("5cd07098-29e1-411f-afd8-22b014a23cfc"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "typescript.png", "TypeScript é um superconjunto de JavaScript desenvolvido pela Microsoft que adiciona tipagem e alguns outros recursos a linguagem. Anders Hejlsberg, arquiteto da linguagem C# e criador das linguagens Delphi e Turbo Pascal, trabalhou no desenvolvimento do TypeScript.", true, "Sigo da mesma maneira do JavaScript com relação ao TypeScript, já que comecei a imersão em frameworks front-end antes fui atrás de estudar um pouco sobre TS.", "TypeScript" },
                    { new Guid("dfb50ea1-9c95-4fbc-9939-cbda2f0a826e"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "jquery.png", "JQuery é uma biblioteca de funções JavaScript que interage com o HTML, desenvolvida para simplificar os scripts interpretados no navegador do cliente.", true, "Tenho bastante conhecimento em tal framework já que no meu início de carreira foi o que mais utilizei para auxiliar no front-end.", "JQuery" },
                    { new Guid("d2702ba4-b264-41c0-b050-ea5a123cd639"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "jquery.png", "JQuery é uma biblioteca de funções JavaScript que interage com o HTML, desenvolvida para simplificar os scripts interpretados no navegador do cliente.", true, "Tenho bastante conhecimento em tal framework já que no meu início de carreira foi o que mais utilizei para auxiliar no front-end.", "JQuery" },
                    { new Guid("3c49a566-d4cc-407b-b5ea-e80198a45611"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "bootstrap.png", "Bootstrap é um framework web com código-fonte aberto para desenvolvimento de componentes de interface e front-end para sites e aplicações web usando HTML, CSS e JavaScript.", true, "Tenho conhecimento considerável por ser uma ferramenta que normalmente utilizo quando necessito criar uma página do \"zero\" para acelerar o processo de desenvolvimento, então me sinto confortável para trabalhar com a mesma.", "Bootstrap" },
                    { new Guid("b8e39e47-e841-4c2d-931a-c798ebe90699"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "azure.png", "O Microsoft Azure é uma plataforma destinada à execução de aplicativos e serviços, baseada nos conceitos da computação em nuvem.", true, "Uma ferramenta que comecei a conhecer no estágio, porém continuo os estudos por fora desde então, já que utilizo muito atualmente, pois os projetos Web estão armazenados na App Services, além de utilizarem o SQL no Azure, Blobs para armazenamento, e CDN para a página estática. Atualmente além de utilizar o portal Azure utilizo as ferramentas Azure Storage Explorer e Azure Storage Emulator.", "Azure" },
                    { new Guid("646c5b52-ae73-4351-9d2b-9819ae415a90"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "sqlServer.png", "O Microsoft SQL Server é um sistema gerenciador de Banco de dados relacional desenvolvido pela Sybase em parceria com a Microsoft. Esta parceria durou até 1994, com o lançamento da versão para Windows NT e desde então a Microsoft mantém a manutenção do produto.", true, "Banco de dados ao qual tenho mais conhecimento, estudo e utilizo o mesmo desce o início da minha jornada, ao qual atualmente utilizo o SQL Server Management Studio para gerenciamento dos DBs.", "SQL Server" },
                    { new Guid("88d7da39-5c17-4a80-9111-e3be7cd7d8a5"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "git.png", "Git é um sistema de controle de versões distribuído, usado principalmente no desenvolvimento de software, mas pode ser usado para registrar o histórico de edições de qualquer tipo de arquivo.", true, "O sistema de versionamento ao qual estou habituado a trabalhar, sempre utilizei o Git, e fiz o versionamento ou pelo GitHub ou GitLab.", "Git" },
                    { new Guid("2bf63f8f-de30-4c62-861a-99f9f98aa8ef"), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "angular.png", "Angular é uma plataforma de aplicações web de código-fonte aberto e front-end baseado em TypeScript liderado pela Equipe Angular do Google e por uma comunidade de indivíduos e corporações. Angular é uma reescrita completa do AngularJS, feito pela mesma equipe que o construiu.", true, "Framework front-end ao qual venho estudando e ganhando cada vez mais experiência, atualmente consigo construir aplicações para necessidades simples.", "Angular" }
                });
        }
    }
}
