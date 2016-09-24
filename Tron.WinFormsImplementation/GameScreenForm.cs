using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tron.DataAccessObjects;

namespace Tron.WinFormsImplementation
{
    public partial class GameScreenForm : Form
    {
        public GameScreenForm(int rowsCount, int columnsCount, List<PlayerDAO> players)
        {
            InitializeComponent();
            var visualBoard = new TableLayoutPanel();
            visualBoard.ColumnCount = columnsCount;
            visualBoard.RowCount = rowsCount;
            visualBoard.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            visualBoard.Dock = DockStyle.Fill;
            for (int i = 0; i < rowsCount;i++)
            {
                visualBoard.RowStyles.Add(new ColumnStyle(SizeType.Percent, (100/rowsCount)));
            }
            for (int i = 0; i < columnsCount; i++)
            {
                visualBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (100 / columnsCount)));
            }
            splitContainer1.Panel1.Controls.Add(visualBoard);
        }

        private void btnNextMovement_Click(object sender, EventArgs e)
        {

        }
    }
}
