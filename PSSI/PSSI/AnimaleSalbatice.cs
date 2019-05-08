using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSSI
{
    public partial class AnimaleSalbatice : Form
    {
        public AnimaleSalbatice()
        {
            InitializeComponent();
        }

        private void Tiger_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score +=
                1;
            this.Tiger.Enabled = false;
        }

        private void Lion_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score +=
                1;
            this.Lion.Enabled = false;
        }

        private void Snake_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score +=
                1;
            this.Snake.Enabled = false;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            CharactersPage charactersPage = new CharactersPage();
            charactersPage.Show();
            this.Hide();
        }

        private void Pig_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score -=
                1;
            this.Pig.Enabled = false;
        }

        private void Cow_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score -=
                1;
            this.Cow.Enabled = false;
        }

        private void Bunny_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score +=
                1;
            this.Bunny.Enabled = false;
        }
    }
}
