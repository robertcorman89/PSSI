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
    public partial class PozitiiSpatialeJos : Form
    {
        public PozitiiSpatialeJos()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            CharactersPageHandler.Instance.PlayInstructiuniJos();
        }

        private void Sus_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
        }

        private void Jos_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayCorrectSound();
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score +=
                1;
            PozitiiSpatialeDreapta dreapta = new PozitiiSpatialeDreapta();
            this.Hide();
            dreapta.Show();
        }

        private void Stanga_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
        }

        private void Dreapta_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
        }
    }
}
