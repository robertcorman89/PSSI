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
    public partial class PozitiiSpatialeDreapta : Form
    {
        public PozitiiSpatialeDreapta()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            CharactersPageHandler.Instance.PlayInstructiuniDreapta();
        }

        private void sus_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
        }

        private void jos_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
        }

        private void stanga_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
        }

        private void dreapta_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayCorrectSound();
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score +=
                1;
            PozitiiSpatialeStanga stanga = new PozitiiSpatialeStanga();
            this.Hide();
            stanga.Show();
        }
    }
}
