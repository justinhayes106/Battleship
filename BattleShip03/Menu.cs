using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip03
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Selection form = new Selection();
            form.Show();
            this.Hide();

            Human human = new Human();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stats");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rules");
        }
    }
}
