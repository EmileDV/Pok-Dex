using Pokemon.Models;
using Pokemon.ORM;

namespace Pokemon
{
    public partial class Pokemon : Form
    {
        ApiRequest api = new ApiRequest();

        PokémonRepo repo = new PokémonRepo();

        public Pokemon()
        {
            InitializeComponent();
        }



        private void Pokemon_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            PokéList pokéList = new PokéList();
            pokéList = api.obtainList();
            foreach (var item in pokéList.Listpokemons)
            {
                flowLayoutPanel1.Controls.Add(new PokeVista(item.namepokemon, item.Getimages()));
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void cragarDatos()
        {

            flowLayoutPanel1.Controls.Clear();

            PokéList pokéList = new PokéList();
            pokéList = api.obtainList(+10);
            foreach (var item in pokéList.Listpokemons)
            {
                flowLayoutPanel1.Controls.Add(new PokeVista(item.namepokemon, item.Getimages()));
            }
        }
        public void notcragarDatos()
        {
            flowLayoutPanel1.Controls.Clear();
            PokéList pokéList = new PokéList();
            pokéList = api.obtainList(-10);
            foreach (var item in pokéList.Listpokemons)
            {
                flowLayoutPanel1.Controls.Add(new PokeVista(item.namepokemon, item.Getimages()));
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            cragarDatos();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            notcragarDatos();
        }

        private void Favorites_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var item in repo.GetFavorites())
            {
                flowLayoutPanel1.Controls.Add(new FavoNames(item.name));
            }
        }
    }
}