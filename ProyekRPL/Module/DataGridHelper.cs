using MetroFramework.Controls;

namespace ProyekRPL.Module
{
    class DataGridHelper
    {
        public static string GetValueSelectedRow(MetroGrid grid, int cellRow)
        {
            var data = grid.SelectedRows[0].Cells[cellRow];
            if (data.Value != null) return data.Value.ToString();
            else return null;
        }
    }
}
