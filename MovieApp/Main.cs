using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class Main : Form
    {
        private Film film = new Film();
        public Main()
        {
            InitializeComponent();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            flow_topfilm.Controls.Clear();
            flow_topfilm.Controls.Add(film);

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            DetailFilm film = new DetailFilm();
            film.TopLevel = false;
            film.Dock = DockStyle.Fill;
            this.panel_container.Controls.Add(film);
            film.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
