using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiResume.Migrations
{
    public partial class AtualizadoStackSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "094cef77-35ff-463c-b736-f0fda2b6816c");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "0ab87175-1923-4c7b-b34d-1136b5dc6763");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "15e5ce3e-403d-4f29-9897-214ca2781a84");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "1a25e2e4-469e-449d-8286-411a252d2b57");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "1afe485e-3826-4878-939b-1d52b1e58caf");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "3eaedc2b-c240-40c2-a7bd-f5f563dec7fc");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "457e4700-2ace-4088-b2b7-3c6eb95bbea7");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "4c378044-5ec3-4bc7-94fa-ea511ee41980");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "59f86ed4-ed0e-4747-8f28-b1fc5fe0ef2e");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "9b7f66f4-51f3-4b71-aa4c-69c6716a1572");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "a2c85709-d103-476d-a830-07fdd70c4174");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "bc2e7b25-6fed-4687-9553-e2c559daee57");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "bc309f0c-e34f-406a-bdee-72cf611672fd");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "c1e91168-d8d6-4148-a73f-60327e5dd7fb");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "c7d959d4-a22b-442d-b8dd-ee80b13d6944");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "db900515-44fb-4be6-b665-12f4b35c07a7");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "e0e7acbc-0c25-497c-a280-b9317edb2294");

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: "4e9cee14-458e-4ce9-84df-448c206ff4de");

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: "57c512ee-280d-4753-b0a6-733e4eb55766");

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: "820dea28-07f4-4e67-b5a8-2fea313e4569");

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: "9ae0e988-c5b1-4303-afc2-1d67229f7c2c");

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: "c4e5d6d2-ae17-4db4-b51b-225f90dce674");

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: "cbbb3ac5-22a8-4f9f-ab3f-ae06a7024182");

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: "db6f828b-39f1-4a77-b0b0-e22ce9082a58");

            migrationBuilder.InsertData(
                table: "Stacks",
                columns: new[] { "Id", "DateAdded", "DateModified", "FlagActive", "StackId", "StackName" },
                values: new object[,]
                {
                    { "ac715df1-fae0-4872-8aba-1fa5174f87df", new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125), new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125), true, 1, "Linguagens de programação" },
                    { "fef6ea08-fe4d-40d3-8686-1e948e38e292", new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125), new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125), true, 2, "Frameworks back-end" },
                    { "f1c74ab2-c280-4da2-9630-d99335ee9c20", new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125), new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125), true, 3, "Frameworks front-end" },
                    { "11395a1f-ea11-4352-ab1e-f7328006132b", new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125), new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125), true, 4, "Banco de dados" },
                    { "e320e689-523a-418b-b7a0-ca6b28fb41df", new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125), new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125), true, 5, "CI/CD" },
                    { "fafac25d-f191-4125-9405-2462f960e568", new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125), new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125), true, 6, "Ferramentas de versionamento" },
                    { "83e1db14-955e-4415-91f6-797625fd0b4b", new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125), new DateTime(2022, 3, 12, 17, 48, 17, 231, DateTimeKind.Local).AddTicks(4125), true, 7, "Outros" }
                });

            migrationBuilder.InsertData(
                table: "Knowledges",
                columns: new[] { "Id", "DateAdded", "DateModified", "FilePathImage", "FirstDescription", "FlagActive", "SecondDescription", "StackId", "Title" },
                values: new object[,]
                {
                    { "34f3aa08-4b54-48fe-8ece-10286f631199", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "csharp.png", "C# é uma linguagem de programação, desenvolvida pela Microsoft como parte da plataforma .NET", true, "A línguagem que estudo desde o começo na faculdade e a que mais utilizo no mercado atualmente, me sinto confortável em dizer que é a com mais experiência e expertise atuando em diversos projetos.", 1, "C#" },
                    { "3091d28b-13ef-49c2-8e0e-4144f2a480ff", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "git.png", "Git é um sistema de controle de versões distribuído, usado principalmente no desenvolvimento de software, mas pode ser usado para registrar o histórico de edições de qualquer tipo de arquivo.", true, "O sistema de versionamento ao qual estou habituado a trabalhar, sempre utilizei o Git, e fiz o versionamento ou pelo GitHub ou GitLab.", 6, "Git" },
                    { "0eb717f0-33b1-47d0-9d78-812d1a3c33d8", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "jenkins.png", "Jenkins é um servidor de automação de código aberto. Ele ajuda a automatizar as partes do desenvolvimento de software relacionadas à construção, teste e implantação, facilitando a integração e entrega contínuas. É um sistema baseado em servidor que é executado em contêineres de servlet, como o Apache Tomcat.", true, "Conheço somente como utilizar pois atuei em projetos que utilizam do mesmo junto do Bitbucket, porém nunca tive a oportunidade de criar um serviço com o mesmo.", 5, "Jenkins" },
                    { "74bfd81b-393e-48fd-9cc4-ca2e3d037ec1", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "gitlabcicd.png", "GitLab é uma plataforma de DevOps de código aberto que oferece soluções para todo o fluxo de desenvolvimento e implantação, como repositórios Git (para versionamento de código), Wikis (para gestão de conhecimento e documentação), quadros de tarefas (similar ao Jira), monitoramento e implantação.", true, "Conheço somente como utilizar por utilizar na época de estagiário, porém nunca tive a oportunidade de criar um serviço com o mesmo.", 5, "GitLab CI/CD" },
                    { "fd409aab-4789-4cb6-9b26-f0b0cc338542", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "azurePipelines.png", "Azure Pipelines cria e testa automaticamente projetos de código para torná-los disponíveis para outras pessoas. Ele funciona com praticamente qualquer linguagem ou tipo de projeto. Azure Pipelines combina CI (integração contínua) e CD (entrega contínua) para testar e criar seu código e enviar para qualquer destino.", true, "Tenho certo conhecimento já que utilizei do mesmo para fazer deploy de projetos simples que criei e utilizo na Azure.", 5, "Azure Pipelines" },
                    { "526c6502-9deb-4c4e-8030-075718c390d2", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "oracleDb.png", "O Oracle é um SGBD que surgiu no fim dos anos 70, quando Larry Ellison vislumbrou uma oportunidade que outras companhias não haviam percebido, quando encontrou uma descrição de um protótipo funcional de um banco de dados relacional e descobriu que nenhuma empresa tinha se empenhado em comercializar essa tecnologia.", true, "Banco de dados que comecei a utilizar com mais frequencia recentemente já que muitos projetos legados de alguns clientes utilizavam este banco de dados.", 4, "Oracle Database" },
                    { "96ba16c2-841c-451b-8403-64066528e2a4", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "mysql.png", "O MySQL é um sistema de gerenciamento de banco de dados, que utiliza a linguagem SQL como interface. É atualmente um dos sistemas de gerenciamento de bancos de dados mais populares da Oracle Corporation, com mais de 10 milhões de instalações pelo mundo.", true, "Banco de dados que comecei a utilizar com mais frequencia recentemente para poder reduzir custos nos projetos que participei.", 4, "MySQL" },
                    { "7308b165-ca70-4d99-a4d4-a3b26773d103", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "sqlServer.png", "O Microsoft SQL Server é um sistema gerenciador de Banco de dados relacional desenvolvido pela Sybase em parceria com a Microsoft. Esta parceria durou até 1994, com o lançamento da versão para Windows NT e desde então a Microsoft mantém a manutenção do produto.", true, "Banco de dados ao qual tenho mais conhecimento, estudo e utilizo o mesmo desce o início da minha jornada com DBs.", 4, "SQL Server" },
                    { "ba2b2f0d-0030-45b6-bf07-f94112d65e62", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "reactjs.png", "O React é uma biblioteca JavaScript de código aberto com foco em criar interfaces de usuário em páginas web. É mantido pelo Facebook, Instagram, outras empresas e uma comunidade de desenvolvedores individuais. É utilizado nos sites da Netflix, Imgur, Feedly, Airbnb, SeatGeek, HelloSign, Walmart e outros.", true, "Framework front-end ao qual venho estudando e ganhando cada vez mais experiência, atualmente consigo construir aplicações para necessidades simples.", 3, "ReactJS" },
                    { "b63baed7-8174-4775-b579-ac0ca49bc079", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "angular.png", "Angular é uma plataforma de aplicações web de código-fonte aberto e front-end baseado em TypeScript liderado pela Equipe Angular do Google e por uma comunidade de indivíduos e corporações. Angular é uma reescrita completa do AngularJS, feito pela mesma equipe que o construiu.", true, "Framework front-end que tenho mais experiência, atualmente consigo construir aplicações com certo nível de complexidade com esta ferramenta.", 3, "Angular" },
                    { "ff65bd97-33ef-4f56-b5ed-151b83eb6361", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "bootstrap.png", "Bootstrap é um framework web com código-fonte aberto para desenvolvimento de componentes de interface e front-end para sites e aplicações web usando HTML, CSS e JavaScript.", true, "Tenho um bom conhecimento por ser uma ferramenta que normalmente utilizo quando necessito criar uma página do \"zero\" para acelerar o processo de desenvolvimento, então me sinto confortável para trabalhar com a mesma.", 3, "Bootstrap" },
                    { "a75651d7-aab3-4c45-8f23-cc8f4b98e36e", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "jquery.png", "JQuery é uma biblioteca de funções JavaScript que interage com o HTML, desenvolvida para simplificar os scripts interpretados no navegador do cliente.", true, "Tenho bastante conhecimento em tal framework já que no meu início de carreira foi o que mais utilizei para auxiliar no front-end.", 3, "JQuery" },
                    { "3666a253-0a5d-4639-9ca9-bb5f1f60df7f", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "netIcon.png", "O .NET Framework é uma iniciativa da empresa Microsoft, que visa uma plataforma única para desenvolvimento e execução de sistemas e aplicações. Todo e qualquer código gerado para .NET pode ser executado em qualquer dispositivo que possua um framework de tal plataforma.", true, "Conjunto de ferramentas .NET é onde tenho minha maior base de conhecimento e apliquei soluções mais complexas.", 2, ".NET Framework" },
                    { "5b2c45fc-8201-4557-aefb-cf6f13b18012", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "netCoreIcon.png", ".NET Core é um framework livre e de código aberto para os sistemas operacionais Windows, Linux e macOS. É um sucessor de código aberto do .NET Framework.", true, "Conjunto de ferramentas .NET é onde tenho minha maior base de conhecimento e apliquei soluções mais complexas.", 2, ".NET Core" },
                    { "7b2c60a4-4a0b-4c0f-8dda-290f2033cdd9", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "typescript.png", "TypeScript é um superconjunto de JavaScript desenvolvido pela Microsoft que adiciona tipagem e alguns outros recursos a linguagem. Anders Hejlsberg, arquiteto da linguagem C# e criador das linguagens Delphi e Turbo Pascal, trabalhou no desenvolvimento do TypeScript.", true, "Sigo da mesma maneira do JavaScript com relação ao TypeScript, já que comecei a imersão em frameworks front-end antes fui atrás de estudar um pouco sobre TS.", 1, "TypeScript" },
                    { "3cfdfacd-9c2f-46cd-a544-2660a8e13639", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "javaScript.png", "JavaScript é uma linguagem de programação interpretada estruturada, Juntamente com HTML e CSS, o JavaScript é uma das três principais tecnologias da World Wide Web.", true, "Linguagem a qual me sinto confortavel em prestar manutenção ou criar algum script para alguma necessidade web", 1, "JavaScript" },
                    { "af2fff41-f554-449e-8006-353ece62bf4d", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "azure.png", "O Microsoft Azure é uma plataforma destinada à execução de aplicativos e serviços, baseada nos conceitos da computação em nuvem.", true, "Ferramenta que conheço mais sobre, já que utilizo muito atualmente, alguns dos meus projetos antigos eram armazenados na App Services, além de utilizarem o SQL no Azure, Blobs para armazenamento, e CDN para a página estática.", 7, "Azure" },
                    { "9d436c9f-7b4c-4b0e-b43e-7fd5858419d1", new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), new DateTime(2022, 3, 12, 17, 48, 17, 237, DateTimeKind.Local).AddTicks(4116), "aws.png", "Amazon Web Services, também conhecido como AWS, é uma plataforma de serviços de computação em nuvem, que formam uma plataforma de computação na nuvem oferecida pela Amazon.com. Os serviços são oferecidos em várias áreas geográficas distribuídas pelo mundo.", true, "Ferramenta que venho me aprimorando sobre, apesar de utilizar seus produtos em projetos de clientes não tenho uma grande expertise como a Azure.", 7, "AWS" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "0eb717f0-33b1-47d0-9d78-812d1a3c33d8");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "3091d28b-13ef-49c2-8e0e-4144f2a480ff");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "34f3aa08-4b54-48fe-8ece-10286f631199");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "3666a253-0a5d-4639-9ca9-bb5f1f60df7f");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "3cfdfacd-9c2f-46cd-a544-2660a8e13639");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "526c6502-9deb-4c4e-8030-075718c390d2");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "5b2c45fc-8201-4557-aefb-cf6f13b18012");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "7308b165-ca70-4d99-a4d4-a3b26773d103");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "74bfd81b-393e-48fd-9cc4-ca2e3d037ec1");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "7b2c60a4-4a0b-4c0f-8dda-290f2033cdd9");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "96ba16c2-841c-451b-8403-64066528e2a4");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "9d436c9f-7b4c-4b0e-b43e-7fd5858419d1");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "a75651d7-aab3-4c45-8f23-cc8f4b98e36e");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "af2fff41-f554-449e-8006-353ece62bf4d");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "b63baed7-8174-4775-b579-ac0ca49bc079");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "ba2b2f0d-0030-45b6-bf07-f94112d65e62");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "fd409aab-4789-4cb6-9b26-f0b0cc338542");

            migrationBuilder.DeleteData(
                table: "Knowledges",
                keyColumn: "Id",
                keyValue: "ff65bd97-33ef-4f56-b5ed-151b83eb6361");

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: "11395a1f-ea11-4352-ab1e-f7328006132b");

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: "83e1db14-955e-4415-91f6-797625fd0b4b");

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: "ac715df1-fae0-4872-8aba-1fa5174f87df");

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: "e320e689-523a-418b-b7a0-ca6b28fb41df");

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: "f1c74ab2-c280-4da2-9630-d99335ee9c20");

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: "fafac25d-f191-4125-9405-2462f960e568");

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: "fef6ea08-fe4d-40d3-8686-1e948e38e292");

            migrationBuilder.InsertData(
                table: "Stacks",
                columns: new[] { "Id", "DateAdded", "DateModified", "FlagActive", "StackId", "StackName" },
                values: new object[,]
                {
                    { "4e9cee14-458e-4ce9-84df-448c206ff4de", new DateTime(2022, 2, 19, 18, 27, 21, 469, DateTimeKind.Local).AddTicks(9074), new DateTime(2022, 2, 19, 18, 27, 21, 469, DateTimeKind.Local).AddTicks(9074), true, 1, "Linguagens de programação" },
                    { "57c512ee-280d-4753-b0a6-733e4eb55766", new DateTime(2022, 2, 19, 18, 27, 21, 469, DateTimeKind.Local).AddTicks(9074), new DateTime(2022, 2, 19, 18, 27, 21, 469, DateTimeKind.Local).AddTicks(9074), true, 2, "Frameworks back-end" },
                    { "c4e5d6d2-ae17-4db4-b51b-225f90dce674", new DateTime(2022, 2, 19, 18, 27, 21, 469, DateTimeKind.Local).AddTicks(9074), new DateTime(2022, 2, 19, 18, 27, 21, 469, DateTimeKind.Local).AddTicks(9074), true, 3, "Frameworks front-end" },
                    { "820dea28-07f4-4e67-b5a8-2fea313e4569", new DateTime(2022, 2, 19, 18, 27, 21, 469, DateTimeKind.Local).AddTicks(9074), new DateTime(2022, 2, 19, 18, 27, 21, 469, DateTimeKind.Local).AddTicks(9074), true, 4, "Banco de dados" },
                    { "cbbb3ac5-22a8-4f9f-ab3f-ae06a7024182", new DateTime(2022, 2, 19, 18, 27, 21, 469, DateTimeKind.Local).AddTicks(9074), new DateTime(2022, 2, 19, 18, 27, 21, 469, DateTimeKind.Local).AddTicks(9074), true, 5, "CI/CD" },
                    { "db6f828b-39f1-4a77-b0b0-e22ce9082a58", new DateTime(2022, 2, 19, 18, 27, 21, 469, DateTimeKind.Local).AddTicks(9074), new DateTime(2022, 2, 19, 18, 27, 21, 469, DateTimeKind.Local).AddTicks(9074), true, 6, "Ferramentas de versionamento" },
                    { "9ae0e988-c5b1-4303-afc2-1d67229f7c2c", new DateTime(2022, 2, 19, 18, 27, 21, 469, DateTimeKind.Local).AddTicks(9074), new DateTime(2022, 2, 19, 18, 27, 21, 469, DateTimeKind.Local).AddTicks(9074), true, 7, "Outros" }
                });

            migrationBuilder.InsertData(
                table: "Knowledges",
                columns: new[] { "Id", "DateAdded", "DateModified", "FilePathImage", "FirstDescription", "FlagActive", "SecondDescription", "StackId", "Title" },
                values: new object[,]
                {
                    { "bc309f0c-e34f-406a-bdee-72cf611672fd", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "csharp.png", "C# é uma linguagem de programação, desenvolvida pela Microsoft como parte da plataforma .NET", true, "A línguagem que estudo desde o começo na faculdade e a que mais utilizo no mercado atualmente, me sinto confortável em dizer que é a com mais experiência e expertise atuando em diversos projetos.", 1, "C#" },
                    { "c7d959d4-a22b-442d-b8dd-ee80b13d6944", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "git.png", "Git é um sistema de controle de versões distribuído, usado principalmente no desenvolvimento de software, mas pode ser usado para registrar o histórico de edições de qualquer tipo de arquivo.", true, "O sistema de versionamento ao qual estou habituado a trabalhar, sempre utilizei o Git, e fiz o versionamento ou pelo GitHub ou GitLab.", 6, "Git" },
                    { "9b7f66f4-51f3-4b71-aa4c-69c6716a1572", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "jenkins.png", "Jenkins é um servidor de automação de código aberto. Ele ajuda a automatizar as partes do desenvolvimento de software relacionadas à construção, teste e implantação, facilitando a integração e entrega contínuas. É um sistema baseado em servidor que é executado em contêineres de servlet, como o Apache Tomcat.", true, "Conheço somente como utilizar pois atuei em projetos que utilizam do mesmo junto do Bitbucket, porém nunca tive a oportunidade de criar um serviço com o mesmo.", 5, "Jenkins" },
                    { "bc2e7b25-6fed-4687-9553-e2c559daee57", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "gitlabcicd.png", "GitLab é uma plataforma de DevOps de código aberto que oferece soluções para todo o fluxo de desenvolvimento e implantação, como repositórios Git (para versionamento de código), Wikis (para gestão de conhecimento e documentação), quadros de tarefas (similar ao Jira), monitoramento e implantação.", true, "Conheço somente como utilizar por utilizar na época de estagiário, porém nunca tive a oportunidade de criar um serviço com o mesmo.", 5, "GitLab CI/CD" },
                    { "15e5ce3e-403d-4f29-9897-214ca2781a84", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "azurePipelines.png", "Azure Pipelines cria e testa automaticamente projetos de código para torná-los disponíveis para outras pessoas. Ele funciona com praticamente qualquer linguagem ou tipo de projeto. Azure Pipelines combina CI (integração contínua) e CD (entrega contínua) para testar e criar seu código e enviar para qualquer destino.", true, "Tenho certo conhecimento já que utilizei do mesmo para fazer deploy de projetos simples que criei e utilizo na Azure.", 5, "Azure Pipelines" },
                    { "db900515-44fb-4be6-b665-12f4b35c07a7", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "mysql.png", "O MySQL é um sistema de gerenciamento de banco de dados, que utiliza a linguagem SQL como interface. É atualmente um dos sistemas de gerenciamento de bancos de dados mais populares da Oracle Corporation, com mais de 10 milhões de instalações pelo mundo..", true, "Banco de dados que comecei a utilizar com mais frequencia recentemente para poder reduzir custos nos projetos que participei.", 4, "MySQL" },
                    { "e0e7acbc-0c25-497c-a280-b9317edb2294", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "sqlServer.png", "O Microsoft SQL Server é um sistema gerenciador de Banco de dados relacional desenvolvido pela Sybase em parceria com a Microsoft. Esta parceria durou até 1994, com o lançamento da versão para Windows NT e desde então a Microsoft mantém a manutenção do produto.", true, "Banco de dados ao qual tenho mais conhecimento, estudo e utilizo o mesmo desce o início da minha jornada com DBs.", 4, "SQL Server" },
                    { "c1e91168-d8d6-4148-a73f-60327e5dd7fb", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "azure.png", "O Microsoft Azure é uma plataforma destinada à execução de aplicativos e serviços, baseada nos conceitos da computação em nuvem.", true, "Ferramenta que conheço mais sobre, já que utilizo muito atualmente, alguns dos meus projetos antigos eram armazenados na App Services, além de utilizarem o SQL no Azure, Blobs para armazenamento, e CDN para a página estática.", 7, "Azure" },
                    { "3eaedc2b-c240-40c2-a7bd-f5f563dec7fc", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "reactjs.png", "O React é uma biblioteca JavaScript de código aberto com foco em criar interfaces de usuário em páginas web. É mantido pelo Facebook, Instagram, outras empresas e uma comunidade de desenvolvedores individuais. É utilizado nos sites da Netflix, Imgur, Feedly, Airbnb, SeatGeek, HelloSign, Walmart e outros.", true, "Framework front-end ao qual venho estudando e ganhando cada vez mais experiência, atualmente consigo construir aplicações para necessidades simples.", 3, "ReactJS" },
                    { "a2c85709-d103-476d-a830-07fdd70c4174", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "bootstrap.png", "Bootstrap é um framework web com código-fonte aberto para desenvolvimento de componentes de interface e front-end para sites e aplicações web usando HTML, CSS e JavaScript.", true, "Tenho um bom conhecimento por ser uma ferramenta que normalmente utilizo quando necessito criar uma página do \"zero\" para acelerar o processo de desenvolvimento, então me sinto confortável para trabalhar com a mesma.", 3, "Bootstrap" },
                    { "1afe485e-3826-4878-939b-1d52b1e58caf", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "jquery.png", "JQuery é uma biblioteca de funções JavaScript que interage com o HTML, desenvolvida para simplificar os scripts interpretados no navegador do cliente.", true, "Tenho bastante conhecimento em tal framework já que no meu início de carreira foi o que mais utilizei para auxiliar no front-end.", 3, "JQuery" },
                    { "0ab87175-1923-4c7b-b34d-1136b5dc6763", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "netIcon.png", "O .NET Framework é uma iniciativa da empresa Microsoft, que visa uma plataforma única para desenvolvimento e execução de sistemas e aplicações. Todo e qualquer código gerado para .NET pode ser executado em qualquer dispositivo que possua um framework de tal plataforma.", true, "Conjunto de ferramentas .NET é onde tenho minha maior base de conhecimento e apliquei soluções mais complexas.", 2, ".NET Framework" },
                    { "457e4700-2ace-4088-b2b7-3c6eb95bbea7", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "netCoreIcon.png", ".NET Core é um framework livre e de código aberto para os sistemas operacionais Windows, Linux e macOS. É um sucessor de código aberto do .NET Framework.", true, "Conjunto de ferramentas .NET é onde tenho minha maior base de conhecimento e apliquei soluções mais complexas.", 2, ".NET Core" },
                    { "094cef77-35ff-463c-b736-f0fda2b6816c", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "typescript.png", "TypeScript é um superconjunto de JavaScript desenvolvido pela Microsoft que adiciona tipagem e alguns outros recursos a linguagem. Anders Hejlsberg, arquiteto da linguagem C# e criador das linguagens Delphi e Turbo Pascal, trabalhou no desenvolvimento do TypeScript.", true, "Sigo da mesma maneira do JavaScript com relação ao TypeScript, já que comecei a imersão em frameworks front-end antes fui atrás de estudar um pouco sobre TS.", 1, "TypeScript" },
                    { "59f86ed4-ed0e-4747-8f28-b1fc5fe0ef2e", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "javaScript.png", "JavaScript é uma linguagem de programação interpretada estruturada, Juntamente com HTML e CSS, o JavaScript é uma das três principais tecnologias da World Wide Web.", true, "Linguagem a qual me sinto confortavel em prestar manutenção ou criar algum script para alguma necessidade web", 1, "JavaScript" },
                    { "1a25e2e4-469e-449d-8286-411a252d2b57", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "angular.png", "Angular é uma plataforma de aplicações web de código-fonte aberto e front-end baseado em TypeScript liderado pela Equipe Angular do Google e por uma comunidade de indivíduos e corporações. Angular é uma reescrita completa do AngularJS, feito pela mesma equipe que o construiu.", true, "Framework front-end que tenho mais experiência, atualmente consigo construir aplicações com certo nível de complexidade com esta ferramenta.", 3, "Angular" },
                    { "4c378044-5ec3-4bc7-94fa-ea511ee41980", new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 2, 19, 18, 27, 21, 476, DateTimeKind.Local).AddTicks(8756), "aws.png", "Amazon Web Services, também conhecido como AWS, é uma plataforma de serviços de computação em nuvem, que formam uma plataforma de computação na nuvem oferecida pela Amazon.com. Os serviços são oferecidos em várias áreas geográficas distribuídas pelo mundo.", true, "Ferramenta que venho me aprimorando sobre, apesar de utilizar seus produtos em projetos de clientes não tenho uma grande expertise como a Azure.", 7, "AWS" }
                });
        }
    }
}
