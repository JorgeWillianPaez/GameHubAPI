using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameHubAPI.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInicial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conquista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    Pontos = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conquista", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Desenvolvedoras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Porte = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desenvolvedoras", x => x.Id);
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
                name: "Promocao",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    dataInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    dataFinal = table.Column<DateTime>(type: "TEXT", nullable: false),
                    status = table.Column<string>(type: "TEXT", nullable: false),
                    categoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promocao", x => x.id);
                    table.ForeignKey(
                        name: "FK_Promocao_Categoria_categoriaId",
                        column: x => x.categoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jogos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    Preco = table.Column<double>(type: "REAL", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DesenvolvedoraId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jogos_Desenvolvedoras_DesenvolvedoraId",
                        column: x => x.DesenvolvedoraId,
                        principalTable: "Desenvolvedoras",
                        principalColumn: "Id",
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataCompra = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Total = table.Column<double>(type: "REAL", nullable: false),
                    MetodoPagamento = table.Column<string>(type: "TEXT", nullable: true),
                    Usuarioid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compra_Usuario_Usuarioid",
                        column: x => x.Usuarioid,
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
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Noticia_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id");
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
                    conquistaId = table.Column<int>(type: "INTEGER", nullable: true),
                    usuarioid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressoConquista", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProgressoConquista_Conquista_conquistaId",
                        column: x => x.conquistaId,
                        principalTable: "Conquista",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProgressoConquista_Usuario_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "Usuario",
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
                    jogoId = table.Column<int>(type: "INTEGER", nullable: true),
                    usuarioid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gameplay", x => x.id);
                    table.ForeignKey(
                        name: "FK_Gameplay_Jogos_jogoId",
                        column: x => x.jogoId,
                        principalTable: "Jogos",
                        principalColumn: "Id");
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
                    jogoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagemJogo", x => x.id);
                    table.ForeignKey(
                        name: "FK_ImagemJogo_Jogos_jogoId",
                        column: x => x.jogoId,
                        principalTable: "Jogos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JogosCategorias",
                columns: table => new
                {
                    JogoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JogosCategorias", x => new { x.JogoId, x.CategoriaId });
                    table.ForeignKey(
                        name: "FK_JogosCategorias_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JogosCategorias_Jogos_JogoId",
                        column: x => x.JogoId,
                        principalTable: "Jogos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompraJogo",
                columns: table => new
                {
                    JogoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CompraId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraJogo", x => new { x.JogoId, x.CompraId });
                    table.ForeignKey(
                        name: "FK_CompraJogo_Compra_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompraJogo_Jogos_JogoId",
                        column: x => x.JogoId,
                        principalTable: "Jogos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameplayConquista",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    conquistaId = table.Column<int>(type: "INTEGER", nullable: true),
                    gameplayid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameplayConquista", x => x.id);
                    table.ForeignKey(
                        name: "FK_GameplayConquista_Conquista_conquistaId",
                        column: x => x.conquistaId,
                        principalTable: "Conquista",
                        principalColumn: "Id");
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
                name: "IX_Compra_Usuarioid",
                table: "Compra",
                column: "Usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_CompraJogo_CompraId",
                table: "CompraJogo",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Gameplay_jogoId",
                table: "Gameplay",
                column: "jogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Gameplay_usuarioid",
                table: "Gameplay",
                column: "usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_GameplayConquista_conquistaId",
                table: "GameplayConquista",
                column: "conquistaId");

            migrationBuilder.CreateIndex(
                name: "IX_GameplayConquista_gameplayid",
                table: "GameplayConquista",
                column: "gameplayid");

            migrationBuilder.CreateIndex(
                name: "IX_ImagemJogo_jogoId",
                table: "ImagemJogo",
                column: "jogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogos_DesenvolvedoraId",
                table: "Jogos",
                column: "DesenvolvedoraId");

            migrationBuilder.CreateIndex(
                name: "IX_JogosCategorias_CategoriaId",
                table: "JogosCategorias",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Noticia_CategoriaId",
                table: "Noticia",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Noticia_Usuarioid",
                table: "Noticia",
                column: "Usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressoConquista_conquistaId",
                table: "ProgressoConquista",
                column: "conquistaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressoConquista_usuarioid",
                table: "ProgressoConquista",
                column: "usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Promocao_categoriaId",
                table: "Promocao",
                column: "categoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amizade");

            migrationBuilder.DropTable(
                name: "Biblioteca");

            migrationBuilder.DropTable(
                name: "CompraJogo");

            migrationBuilder.DropTable(
                name: "GameplayConquista");

            migrationBuilder.DropTable(
                name: "ImagemJogo");

            migrationBuilder.DropTable(
                name: "JogosCategorias");

            migrationBuilder.DropTable(
                name: "Noticia");

            migrationBuilder.DropTable(
                name: "ProgressoConquista");

            migrationBuilder.DropTable(
                name: "Promocao");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Gameplay");

            migrationBuilder.DropTable(
                name: "Conquista");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Jogos");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Desenvolvedoras");
        }
    }
}
