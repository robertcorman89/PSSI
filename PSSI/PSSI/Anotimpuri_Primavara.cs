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
            FormBorderStyle = FormBorderStyle.None;
            CharactersPageHandler.Instance.PlayApasaButonStart();
            this.Vara.Enabled = false;
            this.Iarna.Enabled = false;
            this.Primavara.Enabled = false;
            this.Toamna.Enabled = false;
            this.Start.Enabled = true;
            this.repeat.Enabled = false;
        }

        private void Primavara_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayCorrectSound();
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score +=
                1;
            this.Hide();
            PozitiiSpatialeSus pozitiiSpatialeColorate = new PozitiiSpatialeSus();
            pozitiiSpatialeColorate.Show();
        }

        private void Vara_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
        }

        private void Iarna_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
        }

        private void Toamna_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Vara.Enabled = true;
            this.Iarna.Enabled = true;
            this.Primavara.Enabled = true;
            this.Toamna.Enabled = true;
            this.Start.Enabled = false;
            this.repeat.Enabled = true;
            CharactersPageHandler.Instance.PlayPoeziePrimavara();
        }

        private void repeat_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayPoeziePrimavara();
        }
    }
}
