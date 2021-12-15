using System.Windows.Forms;
using MetroFramework.Controls;

namespace ProyekRPL.Module
{
    class DataGridHelper
    {
        public static string GetValueSelectedRow(DataGridView grid, int cellRow)
        {
            var index = grid.SelectedCells[0].RowIndex;
            var data = grid.Rows[index].Cells[cellRow];
            if (data.Value != null) return data.Value.ToString();
            else return null;
        }

        public static int IsIncludeCell(DataGridView grid, int cell, string value)
        {
            int include = -1;
            if (grid.RowCount > 0)
            {
                for (int i = 0; i < grid.Rows.Count; i++)
                    if (grid.Rows[i].Cells[cell].Value.ToString() == value) include = i;
            }

            return include;
        }
    }
}
