using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSSI
{
    public partial class AnimaleDomestice : Form
    {
        public AnimaleDomestice()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            CharactersPageHandler.Instance.PlayReguliAnimaleDomestice();
            this.Chicken.Enabled = false;
            this.Fox.Enabled = false;
            this.Dog.Enabled = false;
            this.Bear.Enabled = false;
            this.Goose.Enabled = false;
            this.Cow.Enabled = false;
            this.Deer.Enabled = false;
            CharactersPageHandler.Instance.WaitSeconds(13);
        }

 
        private void Chicken_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayCorrectSound();
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score +=
                1;
            this.Chicken.Enabled = false;
            if(this.Dog.Enabled == false && this.Goose.Enabled == false && this.Cow.Enabled == false)
            {
                this.Next.Visible = true;
                CharactersPageHandler.Instance.PlayToateAnimaleGasite();
            }
        }

        private void Fox_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
            this.Fox.Enabled = false;
        }

        private void Dog_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayCorrectSound();
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score +=
                1;
            this.Dog.Enabled = false;
            if (this.Chicken.Enabled == false && this.Goose.Enabled == false && this.Cow.Enabled == false)
            {
                this.Next.Visible = true;
                CharactersPageHandler.Instance.PlayToateAnimaleGasite();
            }
        }

        private void Bear_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
            this.Bear.Enabled = false;
        }

        private void Goose_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayCorrectSound();
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score +=
                1;
            this.Goose.Enabled = false;
            if (this.Chicken.Enabled == false && this.Dog.Enabled == false && this.Cow.Enabled == false)
            {
                this.Next.Visible = true;
                CharactersPageHandler.Instance.PlayToateAnimaleGasite();
            }
        }

        private void Cow_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayCorrectSound();
            CharactersPageHandler.Instance.Characters[CharactersPageHandler.Instance.CurrentCharacterPosition].score +=
                1;
            this.Cow.Enabled = false;
            if (this.Chicken.Enabled == false && this.Goose.Enabled == false && this.Dog.Enabled == false)
            {
                this.Next.Visible = true;
                CharactersPageHandler.Instance.PlayToateAnimaleGasite();
            }
        }

        private void Deer_Click(object sender, EventArgs e)
        {
            CharactersPageHandler.Instance.PlayWrongSound();
            this.Deer.Enabled = false;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimaleSalbatice animaleSalbatice = new AnimaleSalbatice();
            animaleSalbatice.Show();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Chicken.Enabled = true;
            this.Fox.Enabled = true;
            this.Dog.Enabled = true;
            this.Bear.Enabled = true;
            this.Goose.Enabled = true;
            this.Cow.Enabled = true;
            this.Deer.Enabled = true;
            this.Start.Enabled = false;
        }
    }
}
