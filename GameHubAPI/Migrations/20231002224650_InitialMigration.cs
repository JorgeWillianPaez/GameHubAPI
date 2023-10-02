using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameHubAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: true),
                    descricao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Conquista",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    descricao = table.Column<string>(type: "TEXT", nullable: false),
                    pontos = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conquista", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: true),
                    nickName = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    dataNascimento = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    senha = table.Column<string>(type: "TEXT", nullable: true),
                    status = table.Column<string>(type: "TEXT", nullable: true),
                    usuarioAtivado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Desenvolvedora",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    porte = table.Column<string>(type: "TEXT", nullable: false),
                    categoriaid = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desenvolvedora", x => x.id);
                    table.ForeignKey(
                        name: "FK_Desenvolvedora_Categoria_categoriaid",
                        column: x => x.categoriaid,
                        principalTable: "Categoria",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Promocao",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    dataInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    dataFinal = table.Column<DateTime>(type: "TEXT", nullable: false),
                    status = table.Column<string>(type: "TEXT", nullable: false),
                    categoriaid = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promocao", x => x.id);
                    table.ForeignKey(
                        name: "FK_Promocao_Categoria_categoriaid",
                        column: x => x.categoriaid,
                        principalTable: "Categoria",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Amizade",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    usuario1id = table.Column<int>(type: "INTEGER", nullable: true),
                    usuario2id = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amizade", x => x.id);
                    table.ForeignKey(
                        name: "FK_Amizade_Usuario_usuario1id",
                        column: x => x.usuario1id,
                        principalTable: "Usuario",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Amizade_Usuario_usuario2id",
                        column: x => x.usuario2id,
                        principalTable: "Usuario",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Biblioteca",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: true),
                    descricao = table.Column<string>(type: "TEXT", nullable: true),
                    usuarioid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biblioteca", x => x.id);
                    table.ForeignKey(
                        name: "FK_Biblioteca_Usuario_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    dataCompra = table.Column<DateTime>(type: "TEXT", nullable: false),
                    total = table.Column<double>(type: "REAL", nullable: false),
                    metodoPagamento = table.Column<string>(type: "TEXT", nullable: true),
                    usuarioid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.id);
                    table.ForeignKey(
                        name: "FK_Compra_Usuario_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Noticia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    DataPublicacao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Usuarioid = table.Column<int>(type: "INTEGER", nullable: true),
                    Categoriaid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Noticia_Categoria_Categoriaid",
                        column: x => x.Categoriaid,
                        principalTable: "Categoria",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Noticia_Usuario_Usuarioid",
                        column: x => x.Usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ProgressoConquista",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    progresso = table.Column<double>(type: "REAL", nullable: false),
                    conquistaid = table.Column<int>(type: "INTEGER", nullable: true),
                    usuarioid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressoConquista", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProgressoConquista_Conquista_conquistaid",
                        column: x => x.conquistaid,
                        principalTable: "Conquista",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ProgressoConquista_Usuario_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Jogo",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: true),
                    descricao = table.Column<string>(type: "TEXT", nullable: true),
                    preco = table.Column<double>(type: "REAL", nullable: false),
                    dataLancamento = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    desenvolvedoraid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogo", x => x.id);
                    table.ForeignKey(
                        name: "FK_Jogo_Desenvolvedora_desenvolvedoraid",
                        column: x => x.desenvolvedoraid,
                        principalTable: "Desenvolvedora",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Gameplay",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    dataInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    dataFim = table.Column<DateTime>(type: "TEXT", nullable: false),
                    jogoid = table.Column<int>(type: "INTEGER", nullable: true),
                    usuarioid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gameplay", x => x.id);
                    table.ForeignKey(
                        name: "FK_Gameplay_Jogo_jogoid",
                        column: x => x.jogoid,
                        principalTable: "Jogo",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Gameplay_Usuario_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ImagemJogo",
                columns: table => new
                {
                    id = table.Column<string>(type: "TEXT", nullable: false),
                    jogoid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagemJogo", x => x.id);
                    table.ForeignKey(
                        name: "FK_ImagemJogo_Jogo_jogoid",
                        column: x => x.jogoid,
                        principalTable: "Jogo",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "GameplayConquista",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    conquistaid = table.Column<int>(type: "INTEGER", nullable: true),
                    gameplayid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameplayConquista", x => x.id);
                    table.ForeignKey(
                        name: "FK_GameplayConquista_Conquista_conquistaid",
                        column: x => x.conquistaid,
                        principalTable: "Conquista",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_GameplayConquista_Gameplay_gameplayid",
                        column: x => x.gameplayid,
                        principalTable: "Gameplay",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amizade_usuario1id",
                table: "Amizade",
                column: "usuario1id");

            migrationBuilder.CreateIndex(
                name: "IX_Amizade_usuario2id",
                table: "Amizade",
                column: "usuario2id");

            migrationBuilder.CreateIndex(
                name: "IX_Biblioteca_usuarioid",
                table: "Biblioteca",
                column: "usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_usuarioid",
                table: "Compra",
                column: "usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Desenvolvedora_categoriaid",
                table: "Desenvolvedora",
                column: "categoriaid");

            migrationBuilder.CreateIndex(
                name: "IX_Gameplay_jogoid",
                table: "Gameplay",
                column: "jogoid");

            migrationBuilder.CreateIndex(
                name: "IX_Gameplay_usuarioid",
                table: "Gameplay",
                column: "usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_GameplayConquista_conquistaid",
                table: "GameplayConquista",
                column: "conquistaid");

            migrationBuilder.CreateIndex(
                name: "IX_GameplayConquista_gameplayid",
                table: "GameplayConquista",
                column: "gameplayid");

            migrationBuilder.CreateIndex(
                name: "IX_ImagemJogo_jogoid",
                table: "ImagemJogo",
                column: "jogoid");

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_desenvolvedoraid",
                table: "Jogo",
                column: "desenvolvedoraid");

            migrationBuilder.CreateIndex(
                name: "IX_Noticia_Categoriaid",
                table: "Noticia",
                column: "Categoriaid");

            migrationBuilder.CreateIndex(
                name: "IX_Noticia_Usuarioid",
                table: "Noticia",
                column: "Usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressoConquista_conquistaid",
                table: "ProgressoConquista",
                column: "conquistaid");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressoConquista_usuarioid",
                table: "ProgressoConquista",
                column: "usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Promocao_categoriaid",
                table: "Promocao",
                column: "categoriaid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amizade");

            migrationBuilder.DropTable(
                name: "Biblioteca");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "GameplayConquista");

            migrationBuilder.DropTable(
                name: "ImagemJogo");

            migrationBuilder.DropTable(
                name: "Noticia");

            migrationBuilder.DropTable(
                name: "ProgressoConquista");

            migrationBuilder.DropTable(
                name: "Promocao");

            migrationBuilder.DropTable(
                name: "Gameplay");

            migrationBuilder.DropTable(
                name: "Conquista");

            migrationBuilder.DropTable(
                name: "Jogo");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Desenvolvedora");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
