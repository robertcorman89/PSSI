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
            FormBorderStyle = FormBorderStyle.None;
            CharactersPageHandler.Instance.PlayReguliAnimaleSalbatice();
            this.Bunny.Enabled = false;
            this.Cow.Enabled = false;
            this.Snake.Enabled = false;
            this.Lion.Enabled = false;
            this.Tiger.Enabled = false;
            this.Pig.Enabled = false;
        }

        private void Tiger_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayCorrectSound();
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score +=
                1;
            this.Tiger.Enabled = false;
            if(this.Lion.Enabled == false && this.Snake.Enabled == false && this.Bunny.Enabled == false)
            {
                this.Next.Visible = true;
                CharactersPageHandler.Instance.PlayToateAnimaleGasite();
            }
        }

        private void Lion_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayCorrectSound();
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score +=
                1;
            this.Lion.Enabled = false;
            if (this.Tiger.Enabled == false && this.Snake.Enabled == false && this.Bunny.Enabled == false)
            {
                this.Next.Visible = true;
                CharactersPageHandler.Instance.PlayToateAnimaleGasite();
            }
        }

        private void Snake_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayCorrectSound();
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score +=
                1;
            this.Snake.Enabled = false;
            if (this.Lion.Enabled == false && this.Tiger.Enabled == false && this.Bunny.Enabled == false)
            {
                this.Next.Visible = true;
                CharactersPageHandler.Instance.PlayToateAnimaleGasite();
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Anotimpuri_Iarna iarna = new Anotimpuri_Iarna();
            iarna.Show();
            this.Hide();
        }

        private void Pig_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
            this.Pig.Enabled = false;
        }

        private void Cow_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
            this.Cow.Enabled = false;
        }

        private void Bunny_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayCorrectSound();
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score +=
                1;
            this.Bunny.Enabled = false;
            if (this.Lion.Enabled == false && this.Snake.Enabled == false && this.Tiger.Enabled == false)
            {
                this.Next.Visible = true;
                CharactersPageHandler.Instance.PlayToateAnimaleGasite();
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Bunny.Enabled = true;
            this.Cow.Enabled = true;
            this.Snake.Enabled = true;
            this.Lion.Enabled = true;
            this.Tiger.Enabled = true;
            this.Pig.Enabled = true;
            this.Start.Enabled = false;
        }
    }
}
