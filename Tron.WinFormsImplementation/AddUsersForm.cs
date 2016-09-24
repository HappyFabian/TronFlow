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
            var players = new List<PlayerDAO>();
            foreach(DataGridViewRow row in dataGridView1.Rows){
                if (row.Cells[0].Value != null && row.Cells[1].Value!= null)
                {
                    var newPlayer = new PlayerDAO(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                    players.Add(newPlayer);
                }
            }

            var gameScreenForm = new GameScreenForm(RowsCount, ColumsCount, players);
            gameScreenForm.Show();
        }
    }
}
