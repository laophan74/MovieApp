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
    public partial class MainScreenFilm : Form
    {
        private Film film = new Film();
        public MainScreenFilm()
        {
            InitializeComponent();
        }

        private void MainScreenFilm_Load(object sender, EventArgs e)
        {
            flow_topfilm.Controls.Clear();
            flow_topfilm.Controls.Add(film);
        }
    }
}
