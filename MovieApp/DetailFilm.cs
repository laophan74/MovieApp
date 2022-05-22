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
    public partial class DetailFilm : Form
    {
        private Film film = new Film();

        public DetailFilm()
        {
            InitializeComponent();
        }

        private void aaa_Load(object sender, EventArgs e)
        {
            flow_relateto.Controls.Clear();
            flow_relateto.Controls.Add(film);
            guna2RatingStar1.Value = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel_Detailfilm.Controls.Clear();
            FilmWatching film = new FilmWatching();
            film.TopLevel = false;
            film.Dock = DockStyle.Fill;
            this.panel_Detailfilm.Controls.Add(film);
            film.Show();
        }
    }
}
