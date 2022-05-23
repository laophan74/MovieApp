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
    public partial class MainScreen : Form
    {
        private Film film = new Film();

        public MainScreen()
        {
            InitializeComponent();
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

        private void MainScreen_Load(object sender, EventArgs e)
        {  
            this.panel_container.Controls.Clear();
            MainScreenFilm film = new MainScreenFilm();
            film.TopLevel = false;
            film.Dock = DockStyle.Fill;
            this.panel_container.Controls.Add(film);
            film.Show();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.panel_container.Controls.Clear();
            UserProfile film = new UserProfile();
            film.TopLevel = false;
            film.Dock = DockStyle.Fill;
            this.panel_container.Controls.Add(film);
            film.Show();
        }
    }
}
