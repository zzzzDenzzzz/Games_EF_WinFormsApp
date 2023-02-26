using Games_EF_WinFormsApp.Entities;
using System.Data;

namespace Games_EF_WinFormsApp.Services
{
    public class TableCreatorService
    {
        public static DataTable CreateCreatorGameTable(List<CreatorGame> creators)
        {
            DataTable table = new();
            table.Clear();
            table.Columns.Add("Id");
            table.Columns.Add("Название");

            foreach (var creator in creators)
            {
                DataRow row = table.NewRow();
                row[0] = creator.Id;
                row[1] = creator.Name;
                table.Rows.Add(row);
            }
            return table;
        }

        public static DataTable CreateGameTable(List<Game> games)
        {
            DataTable table = new();
            table.Clear();
            table.Columns.Add("Id");
            table.Columns.Add("Название");
            table.Columns.Add("Создатель игры");
            table.Columns.Add("Жанр");
            table.Columns.Add("Дата релиза");

            foreach (var game in games)
            {
                DataRow row = table.NewRow();
                row[0] = game.Id;
                row[1] = game.Name;
                row[2] = game.CreatorGame.Name;
                row[3] = game.Genre.GetEnumDescription();
                row[4] = game.DateRelease;
                table.Rows.Add(row);
            }
            return table;
        }

        public static void ShowTable(DataGridView grid, DataTable table)
        {
            grid.DataSource = null;
            grid.DataSource = table;
            grid.Columns[0].Visible = false;
        }
    }
}
