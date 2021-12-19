using Pokemon.Models;
using Pokemon.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class PokeVista : UserControl
    {
        PokémonRepo repo = new PokémonRepo();
        public PokeVista(string name, Image images)
        {
            InitializeComponent();
            this.name.Text = name;
            this.images.Image = images;
        }

        public PokeVista(Button name)
        {
            this.name = name;
        }

        private void PokeVista_Load(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {
            FavoritePokémons favoritePokémons = new FavoritePokémons(name.Text);
            repo.FavoritePokémon(favoritePokémons);
        }
    }
}
