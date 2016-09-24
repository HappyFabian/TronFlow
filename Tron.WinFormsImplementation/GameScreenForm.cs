using Autofac;
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
using Tron.Logic;
using Tron.Logic.GameLogic;

namespace Tron.WinFormsImplementation
{
    public partial class GameScreenForm : Form
    {
        public TableLayoutPanel visualBoard  { get; set; }
        public List<PlayerDAO> Players { get; set; }
        public IGame MainGame { get; set; }
        public GameScreenForm(int rowsCount, int columnsCount, List<PlayerDAO> players)
        {
            InitializeComponent();
            visualBoard = new TableLayoutPanel();
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
            for (int i = 0; i < players.Count; i++)
            {
                listBox1.Items.Add(players[i].Name);
            }

            var container = AutofacConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var game = scope.Resolve<IGame>();
                List<IPlayer> playersParameter = players.Select(t =>(IPlayer) new Player(new Coordinate(t.x,t.y),t.Name,t.Color)).ToList();
                game.Prepare(new Coordinate(visualBoard.ColumnCount, visualBoard.RowCount),playersParameter);
            }
        }

        private void btnNextMovement_Click(object sender, EventArgs e)
        {
            paintPlayers();
        }

        private void paintPlayers()
        {
            int singleCellWidth = this.visualBoard.Width / this.visualBoard.RowCount;
            int singleCellHeight = this.visualBoard.Height / this.visualBoard.ColumnCount;

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            foreach(var player in Players){
                myBrush = selectPlayerColor(myBrush, player);
                System.Drawing.Graphics formGraphics;
                formGraphics = visualBoard.CreateGraphics();
                formGraphics.FillRectangle(myBrush, 
                    new Rectangle(
                            (player.x * singleCellWidth) - singleCellWidth, 
                            (player.y * singleCellHeight) - singleCellHeight, 
                            singleCellWidth, singleCellHeight)
                        );
                myBrush.Dispose();
                formGraphics.Dispose();
            }
        }

        private static SolidBrush selectPlayerColor(System.Drawing.SolidBrush myBrush, PlayerDAO player)
        {
            if (player.Color == "RED")
                myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            if (player.Color == "GREEN")
                myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            if (player.Color == "BLUE")
                myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
            if (player.Color == "YELLOW")
                myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            if (player.Color == "GREY")
                myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            if (player.Color == "PINK")
                myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            if (player.Color == "BLACK")
                myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            if (player.Color == "ORANGE")
                myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            return myBrush;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class AutofacConfig
    {
        public static Autofac.IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Game>().As<IGame>();
            builder.RegisterType<Tile>().As<ITile>();

            return builder.Build();
        }
    }
}
