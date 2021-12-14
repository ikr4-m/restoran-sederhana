using System.Windows.Forms;
using MetroFramework.Controls;

namespace ProyekRPL.Module
{
    class DataGridHelper
    {
        public static string GetValueSelectedRow(DataGridView grid, int cellRow, int reduceRow = 0)
        {
            var index = grid.SelectedCells[0].RowIndex - reduceRow;
            var data = grid.Rows[index].Cells[cellRow];
            if (data.Value != null) return data.Value.ToString();
            else return null;
        }

        public static int IsIncludeCell(DataGridView grid, int cell, string value)
        {
            int include = -1;
            for (int i = 0; i < grid.Rows.Count; i++)
                if (grid.Rows[i].Cells[cell].Value.ToString() == value) include = i;

            return include;
        }
    }
}
