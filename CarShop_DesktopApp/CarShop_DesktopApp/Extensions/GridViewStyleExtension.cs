using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop_DesktopApp.Extensions
{
    class GridViewStyleExtension
    {
        public static void SetStyle(DataGridView dataGridView)
        {
            dataGridView.DefaultCellStyle.BackColor = SystemColors.MenuHighlight;
            dataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular);
            dataGridView.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 41, 44);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            dataGridView.EnableHeadersVisualStyles = false;
        }
    }
}
