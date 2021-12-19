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
    public partial class FavoNames : UserControl
    {
        PokémonRepo repo = new PokémonRepo();
        public FavoNames(string Name)
        {
            InitializeComponent();
            this.Name.Text = Name;
        }

        private void Name_Click(object sender, EventArgs e)
        {
            repo.DeleteFavo(Name.Text);
        }
    }
}
