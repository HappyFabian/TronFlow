using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tron.WinFormsImplementation
{
    public partial class AddUsersForm : Form
    {
        public int RowsCount { get; set; }
        public int ColumsCount { get; set; }
        public AddUsersForm(int rowsCount, int columnsCount)
        {
            InitializeComponent();
            this.RowsCount = rowsCount;
            this.ColumsCount = columnsCount;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            var players = new List<String>();
            foreach(DataGridViewRow row in dataGridView1.Rows){
                players.Add(row.Cells[0].ToString());
            }
            
            var gameScreenForm = new GameScreenForm(RowsCount, ColumsCount);
            gameScreenForm.Show();
        }
    }
}
