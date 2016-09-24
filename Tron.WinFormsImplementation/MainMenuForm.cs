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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int rowsCount = decimal.ToInt32(this.numericUpDownRows.Value);
            int columnsCount = decimal.ToInt32(this.numericUpDownColumns.Value);
            var gameScreenForm = new GameScreenForm(rowsCount, columnsCount);
            gameScreenForm.Show();
        }
    }
}
