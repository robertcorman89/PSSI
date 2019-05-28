using System;
using System.Drawing;
using System.Windows.Forms;

namespace PSSI
{
    public partial class CharactersPage : Form
    {
        private CharactersPageHandler charactersPageHandler = CharactersPageHandler.Instance;
        public CharactersPage()
        {
            InitializeComponent();
            CharactersPageHandler.Instance.PlayIntroducere();
            if (this.charactersPageHandler.Characters[0].usedBefore)
            {
                this.mcqueenPicture.Enabled = false;
                this.mcqueenLabel.Text = this.charactersPageHandler.Characters[0].score.ToString();
            }
            if (this.charactersPageHandler.Characters[1].usedBefore)
            {
                this.annaPicture.Enabled = false;
                this.annaLabel.Text = this.charactersPageHandler.Characters[1].score.ToString();
            }
            if (this.charactersPageHandler.Characters[2].usedBefore)
            {
                this.spiderPicture.Enabled = false;
                this.spiderLabel.Text = this.charactersPageHandler.Characters[2].score.ToString();
            }
            if (this.charactersPageHandler.Characters[3].usedBefore)
            {
                this.tweetyPicture.Enabled = false;
                this.TweetyLabel.Text = this.charactersPageHandler.Characters[3].score.ToString();
            }
            if (this.charactersPageHandler.Characters[4].usedBefore)
            {
                this.GoofyPicture.Enabled = false;
                this.GoofyLabel.Text = this.charactersPageHandler.Characters[4].score.ToString();
            }
            if (this.charactersPageHandler.Characters[5].usedBefore)
            {
                this.supermanPicture.Enabled = false;
                this.SuperManLabel.Text = this.charactersPageHandler.Characters[5].score.ToString();
            }
            if (this.charactersPageHandler.Characters[6].usedBefore)
            {
                this.MickeyPicture.Enabled = false;
                this.MickeyLabel.Text = this.charactersPageHandler.Characters[6].score.ToString();
            }
            if (this.charactersPageHandler.Characters[7].usedBefore)
            {
                this.RoadrunnerPicture.Enabled = false;
                this.roadRunnerLabel.Text = this.charactersPageHandler.Characters[7].score.ToString();
            }
            if (this.charactersPageHandler.Characters[8].usedBefore)
            {
                this.IronManPicture.Enabled = false;
                this.IronManLabel.Text = this.charactersPageHandler.Characters[8].score.ToString();
            }
            if (this.charactersPageHandler.Characters[9].usedBefore)
            {
                this.MinniePicture.Enabled = false;
                this.MinnieLabel.Text = this.charactersPageHandler.Characters[9].score.ToString();
            }
            if (this.charactersPageHandler.Characters[10].usedBefore)
            {
                this.jerryPicture.Enabled = false;
                this.jerryLabel.Text = this.charactersPageHandler.Characters[10].score.ToString();
            }
            if (this.charactersPageHandler.Characters[11].usedBefore)
            {
                this.donaldPicture.Enabled = false;
                this.donaldLabel.Text = this.charactersPageHandler.Characters[11].score.ToString();
            }
            if (this.charactersPageHandler.Characters[12].usedBefore)
            {
                this.bambiPicture.Enabled = false;
                this.bambiLabel.Text = this.charactersPageHandler.Characters[12].score.ToString();
            }
            if (this.charactersPageHandler.Characters[13].usedBefore)
            {
                this.HulkPicture.Enabled = false;
                this.HulkLabel.Text = this.charactersPageHandler.Characters[13].score.ToString();
            }
            if (this.charactersPageHandler.Characters[14].usedBefore)
            {
                this.TomPicture.Enabled = false;
                this.TomLabel.Text = this.charactersPageHandler.Characters[14].score.ToString();
            }
            if (this.charactersPageHandler.Characters[15].usedBefore)
            {
                this.BatmanPicture.Enabled = false;
                this.batmanLabel.Text = this.charactersPageHandler.Characters[15].score.ToString();
            }
            if (this.charactersPageHandler.Characters[16].usedBefore)
            {
                this.ElsaPicture.Enabled = false;
                this.ElsaLabel.Text = this.charactersPageHandler.Characters[16].score.ToString();
            }
            if (this.charactersPageHandler.Characters[17].usedBefore)
            {
                this.AlbaCaZapadaPicture.Enabled = false;
                this.AlbaCaZapadaLabel.Text = this.charactersPageHandler.Characters[17].score.ToString();
            }
            if (this.charactersPageHandler.Characters[18].usedBefore)
            {
                this.ArielPicture.Enabled = false;
                this.ArielLabel.Text = this.charactersPageHandler.Characters[18].score.ToString();
            }
            if (this.charactersPageHandler.Characters[19].usedBefore)
            {
                this.BeanPicture.Enabled = false;
                this.BeanLabel.Text = this.charactersPageHandler.Characters[19].score.ToString();
            }
            if (this.charactersPageHandler.Characters[20].usedBefore)
            {
                this.BlossomPicture.Enabled = false;
                this.BlossomLabel.Text = this.charactersPageHandler.Characters[20].score.ToString();
            }
            if (this.charactersPageHandler.Characters[21].usedBefore)
            {
                this.FlashPicture.Enabled = false;
                this.FlashLabel.Text = this.charactersPageHandler.Characters[21].score.ToString();
            }
            if (this.charactersPageHandler.Characters[22].usedBefore)
            {
                this.OlafPicture.Enabled = false;
                this.OlafLabel.Text = this.charactersPageHandler.Characters[22].score.ToString();
            }
            if (this.charactersPageHandler.Characters[23].usedBefore)
            {
                this.PapaSmurfPicture.Enabled = false;
                this.PapaSmurfLabel.Text = this.charactersPageHandler.Characters[23].score.ToString();
            }
            if (this.charactersPageHandler.Characters[24].usedBefore)
            {
                this.ButtercupPicture.Enabled = false;
                this.ButtercupLabel.Text = this.charactersPageHandler.Characters[24].score.ToString();
            }
            if (this.charactersPageHandler.Characters[25].usedBefore)
            {
                this.CaptainAmericaPicture.Enabled = false;
                this.CaptainAmericaLabel.Text = this.charactersPageHandler.Characters[25].score.ToString();
            }
            if (this.charactersPageHandler.Characters[26].usedBefore)
            {
                this.WinniePicture.Enabled = false;
                this.WinnieLabel.Text = this.charactersPageHandler.Characters[26].score.ToString();
            }
            if (this.charactersPageHandler.Characters[27].usedBefore)
            {
                this.PatrickPicture.Enabled = false;
                this.PatrickLabel.Text = this.charactersPageHandler.Characters[27].score.ToString();
            }
            if (this.charactersPageHandler.Characters[28].usedBefore)
            {
                this.SpongeBobPicture.Enabled = false;
                this.SpongeBobLabel.Text = this.charactersPageHandler.Characters[28].score.ToString();
            }
            if (this.charactersPageHandler.Characters[29].usedBefore)
            {
                this.BubblePicture.Enabled = false;
                this.BubbleLabel.Text = this.charactersPageHandler.Characters[29].score.ToString();
            }
            if (this.charactersPageHandler.Characters[30].usedBefore)
            {
                this.ShaggyPicture.Enabled = false;
                this.ShaggyLabel.Text = this.charactersPageHandler.Characters[30].score.ToString();
            }
            if (this.charactersPageHandler.Characters[31].usedBefore)
            {
                this.ScoobyPicture.Enabled = false;
                this.ScoobyLabel.Text = this.charactersPageHandler.Characters[31].score.ToString();
            }
        }

        private void SelectCharacter(int index)
        {
            this.charactersPageHandler.Characters[index].usedBefore = true;
            this.charactersPageHandler.CurrentCharacterPosition = index;
            AnimaleDomestice firstQuestion = new AnimaleDomestice();
            firstQuestion.Show();
            this.Hide();
        }
        private void Mcqueen_Click(object sender, EventArgs e)
        {
          SelectCharacter(0);
        }

        private void AnnaPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(1);
        }

        private void SpiderPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(2);
        }

        private void TweetyPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(3);
        }

        private void Goofy_Click(object sender, EventArgs e)
        {
            SelectCharacter(4);
        }

        private void SupermanPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(5);
        }

        private void Mickey_Click(object sender, EventArgs e)
        {
            SelectCharacter(6);
        }

        private void Roadrunner_Click(object sender, EventArgs e)
        {
            SelectCharacter(7);
        }

        private void IronManPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(8);
        }

        private void MinniePicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(9);
        }

        private void JerryPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(10);
        }

        private void DonaldPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(11);
        }
        private void BambiPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(12);
        }
        private void HulkPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(13);
        }
        private void TomPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(14);
        }
        private void BatmanPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(15);
        }
        private void ElsaPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(16);
        }
        private void AlbaCaZapadaPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(17);
        }
        private void ArielPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(18);
        }
        private void BeanPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(19);
        }
        private void BlossomPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(20);
        }
        private void FlashPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(21);
        }
        private void OlafPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(22);
        }
        private void PapaSmurfPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(23);
        }
        private void ButtercupPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(24);
        }
        private void CaptainAmericaPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(25);
        }
        private void WinniePicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(26);
        }
        private void PatrickPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(27);
        }
        private void SpongeBobPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(28);
        }
        private void BubblePicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(29);
        }
        private void ShaggyPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(30);
        }
        private void ScoobyPicture_Click(object sender, EventArgs e)
        {
            SelectCharacter(31);
        }

        private void CharactersPage_Load(object sender, EventArgs e)
        {

        }
    }
}
