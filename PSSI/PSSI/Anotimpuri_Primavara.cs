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
    public partial class Anotimpuri_Primavara : Form
    {
        public Anotimpuri_Primavara()
        {
            InitializeComponent();
        }

        private void Primavara_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayCorrectSound();
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score +=
                1;
            CharactersPage characters = new CharactersPage();
            characters.Show();
            this.Hide();
        }

        private void Vara_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score -=
                1;
        }

        private void Iarna_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score -=
                1;
        }

        private void Toamna_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score -=
                1;
        }
    }
}
