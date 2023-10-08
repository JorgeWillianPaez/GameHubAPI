using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameHubAPI.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Usuario_usuarioid",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Desenvolvedora_Categoria_categoriaid",
                table: "Desenvolvedora");

            migrationBuilder.DropForeignKey(
                name: "FK_Gameplay_Jogo_jogoid",
                table: "Gameplay");

            migrationBuilder.DropForeignKey(
                name: "FK_GameplayConquista_Conquista_conquistaid",
                table: "GameplayConquista");

            migrationBuilder.DropForeignKey(
                name: "FK_ImagemJogo_Jogo_jogoid",
                table: "ImagemJogo");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogo_Desenvolvedora_desenvolvedoraid",
                table: "Jogo");

            migrationBuilder.DropForeignKey(
                name: "FK_Noticia_Categoria_Categoriaid",
                table: "Noticia");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgressoConquista_Conquista_conquistaid",
                table: "ProgressoConquista");

            migrationBuilder.DropForeignKey(
                name: "FK_Promocao_Categoria_categoriaid",
                table: "Promocao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jogo",
                table: "Jogo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Desenvolvedora",
                table: "Desenvolvedora");

            migrationBuilder.DropIndex(
                name: "IX_Desenvolvedora_categoriaid",
                table: "Desenvolvedora");

            migrationBuilder.DropColumn(
                name: "categoriaid",
                table: "Desenvolvedora");

            migrationBuilder.RenameTable(
                name: "Jogo",
                newName: "Jogos");

            migrationBuilder.RenameTable(
                name: "Desenvolvedora",
                newName: "Desenvolvedoras");

            migrationBuilder.RenameColumn(
                name: "categoriaid",
                table: "Promocao",
                newName: "categoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Promocao_categoriaid",
                table: "Promocao",
                newName: "IX_Promocao_categoriaId");

            migrationBuilder.RenameColumn(
                name: "conquistaid",
                table: "ProgressoConquista",
                newName: "conquistaId");

            migrationBuilder.RenameIndex(
                name: "IX_ProgressoConquista_conquistaid",
                table: "ProgressoConquista",
                newName: "IX_ProgressoConquista_conquistaId");

            migrationBuilder.RenameColumn(
                name: "Categoriaid",
                table: "Noticia",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Noticia_Categoriaid",
                table: "Noticia",
                newName: "IX_Noticia_CategoriaId");

            migrationBuilder.RenameColumn(
                name: "jogoid",
                table: "ImagemJogo",
                newName: "jogoId");

            migrationBuilder.RenameIndex(
                name: "IX_ImagemJogo_jogoid",
                table: "ImagemJogo",
                newName: "IX_ImagemJogo_jogoId");

            migrationBuilder.RenameColumn(
                name: "conquistaid",
                table: "GameplayConquista",
                newName: "conquistaId");

            migrationBuilder.RenameIndex(
                name: "IX_GameplayConquista_conquistaid",
                table: "GameplayConquista",
                newName: "IX_GameplayConquista_conquistaId");

            migrationBuilder.RenameColumn(
                name: "jogoid",
                table: "Gameplay",
                newName: "jogoId");

            migrationBuilder.RenameIndex(
                name: "IX_Gameplay_jogoid",
                table: "Gameplay",
                newName: "IX_Gameplay_jogoId");

            migrationBuilder.RenameColumn(
                name: "pontos",
                table: "Conquista",
                newName: "Pontos");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Conquista",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "Conquista",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Conquista",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuarioid",
                table: "Compra",
                newName: "Usuarioid");

            migrationBuilder.RenameColumn(
                name: "total",
                table: "Compra",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "metodoPagamento",
                table: "Compra",
                newName: "MetodoPagamento");

            migrationBuilder.RenameColumn(
                name: "dataCompra",
                table: "Compra",
                newName: "DataCompra");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Compra",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Compra_usuarioid",
                table: "Compra",
                newName: "IX_Compra_Usuarioid");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Categoria",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "Categoria",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Categoria",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "Jogos",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Jogos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "desenvolvedoraid",
                table: "Jogos",
                newName: "DesenvolvedoraId");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "Jogos",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "dataLancamento",
                table: "Jogos",
                newName: "DataLancamento");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Jogos",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Jogo_desenvolvedoraid",
                table: "Jogos",
                newName: "IX_Jogos_DesenvolvedoraId");

            migrationBuilder.RenameColumn(
                name: "porte",
                table: "Desenvolvedoras",
                newName: "Porte");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Desenvolvedoras",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Desenvolvedoras",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Categoria",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Categoria",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Jogos",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DesenvolvedoraId",
                table: "Jogos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Jogos",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jogos",
                table: "Jogos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Desenvolvedoras",
                table: "Desenvolvedoras",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_CompraJogo_CompraId",
                table: "CompraJogo",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_JogosCategorias_CategoriaId",
                table: "JogosCategorias",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Usuario_Usuarioid",
                table: "Compra",
                column: "Usuarioid",
                principalTable: "Usuario",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Gameplay_Jogos_jogoId",
                table: "Gameplay",
                column: "jogoId",
                principalTable: "Jogos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GameplayConquista_Conquista_conquistaId",
                table: "GameplayConquista",
                column: "conquistaId",
                principalTable: "Conquista",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagemJogo_Jogos_jogoId",
                table: "ImagemJogo",
                column: "jogoId",
                principalTable: "Jogos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogos_Desenvolvedoras_DesenvolvedoraId",
                table: "Jogos",
                column: "DesenvolvedoraId",
                principalTable: "Desenvolvedoras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Noticia_Categoria_CategoriaId",
                table: "Noticia",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProgressoConquista_Conquista_conquistaId",
                table: "ProgressoConquista",
                column: "conquistaId",
                principalTable: "Conquista",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Promocao_Categoria_categoriaId",
                table: "Promocao",
                column: "categoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Usuario_Usuarioid",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Gameplay_Jogos_jogoId",
                table: "Gameplay");

            migrationBuilder.DropForeignKey(
                name: "FK_GameplayConquista_Conquista_conquistaId",
                table: "GameplayConquista");

            migrationBuilder.DropForeignKey(
                name: "FK_ImagemJogo_Jogos_jogoId",
                table: "ImagemJogo");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogos_Desenvolvedoras_DesenvolvedoraId",
                table: "Jogos");

            migrationBuilder.DropForeignKey(
                name: "FK_Noticia_Categoria_CategoriaId",
                table: "Noticia");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgressoConquista_Conquista_conquistaId",
                table: "ProgressoConquista");

            migrationBuilder.DropForeignKey(
                name: "FK_Promocao_Categoria_categoriaId",
                table: "Promocao");

            migrationBuilder.DropTable(
                name: "CompraJogo");

            migrationBuilder.DropTable(
                name: "JogosCategorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jogos",
                table: "Jogos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Desenvolvedoras",
                table: "Desenvolvedoras");

            migrationBuilder.RenameTable(
                name: "Jogos",
                newName: "Jogo");

            migrationBuilder.RenameTable(
                name: "Desenvolvedoras",
                newName: "Desenvolvedora");

            migrationBuilder.RenameColumn(
                name: "categoriaId",
                table: "Promocao",
                newName: "categoriaid");

            migrationBuilder.RenameIndex(
                name: "IX_Promocao_categoriaId",
                table: "Promocao",
                newName: "IX_Promocao_categoriaid");

            migrationBuilder.RenameColumn(
                name: "conquistaId",
                table: "ProgressoConquista",
                newName: "conquistaid");

            migrationBuilder.RenameIndex(
                name: "IX_ProgressoConquista_conquistaId",
                table: "ProgressoConquista",
                newName: "IX_ProgressoConquista_conquistaid");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Noticia",
                newName: "Categoriaid");

            migrationBuilder.RenameIndex(
                name: "IX_Noticia_CategoriaId",
                table: "Noticia",
                newName: "IX_Noticia_Categoriaid");

            migrationBuilder.RenameColumn(
                name: "jogoId",
                table: "ImagemJogo",
                newName: "jogoid");

            migrationBuilder.RenameIndex(
                name: "IX_ImagemJogo_jogoId",
                table: "ImagemJogo",
                newName: "IX_ImagemJogo_jogoid");

            migrationBuilder.RenameColumn(
                name: "conquistaId",
                table: "GameplayConquista",
                newName: "conquistaid");

            migrationBuilder.RenameIndex(
                name: "IX_GameplayConquista_conquistaId",
                table: "GameplayConquista",
                newName: "IX_GameplayConquista_conquistaid");

            migrationBuilder.RenameColumn(
                name: "jogoId",
                table: "Gameplay",
                newName: "jogoid");

            migrationBuilder.RenameIndex(
                name: "IX_Gameplay_jogoId",
                table: "Gameplay",
                newName: "IX_Gameplay_jogoid");

            migrationBuilder.RenameColumn(
                name: "Pontos",
                table: "Conquista",
                newName: "pontos");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Conquista",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Conquista",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Conquista",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Usuarioid",
                table: "Compra",
                newName: "usuarioid");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Compra",
                newName: "total");

            migrationBuilder.RenameColumn(
                name: "MetodoPagamento",
                table: "Compra",
                newName: "metodoPagamento");

            migrationBuilder.RenameColumn(
                name: "DataCompra",
                table: "Compra",
                newName: "dataCompra");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Compra",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Compra_Usuarioid",
                table: "Compra",
                newName: "IX_Compra_usuarioid");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Categoria",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Categoria",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categoria",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Jogo",
                newName: "preco");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Jogo",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "DesenvolvedoraId",
                table: "Jogo",
                newName: "desenvolvedoraid");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Jogo",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "DataLancamento",
                table: "Jogo",
                newName: "dataLancamento");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Jogo",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Jogos_DesenvolvedoraId",
                table: "Jogo",
                newName: "IX_Jogo_desenvolvedoraid");

            migrationBuilder.RenameColumn(
                name: "Porte",
                table: "Desenvolvedora",
                newName: "porte");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Desenvolvedora",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Desenvolvedora",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Categoria",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Categoria",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Jogo",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "desenvolvedoraid",
                table: "Jogo",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Jogo",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "categoriaid",
                table: "Desenvolvedora",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jogo",
                table: "Jogo",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Desenvolvedora",
                table: "Desenvolvedora",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Desenvolvedora_categoriaid",
                table: "Desenvolvedora",
                column: "categoriaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Usuario_usuarioid",
                table: "Compra",
                column: "usuarioid",
                principalTable: "Usuario",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Desenvolvedora_Categoria_categoriaid",
                table: "Desenvolvedora",
                column: "categoriaid",
                principalTable: "Categoria",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gameplay_Jogo_jogoid",
                table: "Gameplay",
                column: "jogoid",
                principalTable: "Jogo",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_GameplayConquista_Conquista_conquistaid",
                table: "GameplayConquista",
                column: "conquistaid",
                principalTable: "Conquista",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagemJogo_Jogo_jogoid",
                table: "ImagemJogo",
                column: "jogoid",
                principalTable: "Jogo",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogo_Desenvolvedora_desenvolvedoraid",
                table: "Jogo",
                column: "desenvolvedoraid",
                principalTable: "Desenvolvedora",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Noticia_Categoria_Categoriaid",
                table: "Noticia",
                column: "Categoriaid",
                principalTable: "Categoria",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProgressoConquista_Conquista_conquistaid",
                table: "ProgressoConquista",
                column: "conquistaid",
                principalTable: "Conquista",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Promocao_Categoria_categoriaid",
                table: "Promocao",
                column: "categoriaid",
                principalTable: "Categoria",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
