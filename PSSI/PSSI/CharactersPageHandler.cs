using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PSSI
{
    public sealed class CharactersPageHandler
    {
        private static CharactersPageHandler _instance = null;
        private static SoundPlayer soundPlayer = new SoundPlayer();
        public List<Character> Characters { get; set; }

        private static int _currentCharacterPosition;

      

        public static CharactersPageHandler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CharactersPageHandler();
                }

                return _instance;
            }
        }
        public int CurrentCharacterPosition
        {
            get
            {
                return _currentCharacterPosition;
            }
            set
            {
                _currentCharacterPosition = value;
            }
        }

        public CharactersPageHandler()
        {
            Characters = new List<Character>();
            for (var i = 0; i < 32; i++)
            {
                Characters.Add(new Character());
            }
        }
        private void PlaySoundFromLocation(String location)
        {
            soundPlayer.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + location;
            soundPlayer.Play();
        }

        public void PlayToateAnimaleGasite()
        {
            PlaySoundFromLocation("..\\..\\sounds\\Merged_toate_apasa.wav");
        }

        public void PlayIntroducere()
        {
            PlaySoundFromLocation("..\\..\\sounds\\Merged_intro_click.wav");
        }
        public void PlayCorrectSound()
        {
            PlaySoundFromLocation("..\\..\\sounds\\felic.wav");
        }

        public void PlayWrongSound()
        {
            PlaySoundFromLocation("..\\..\\sounds\\mai.wav");
        }

        public void PlaySfatClickPeCaracter()
        {
            PlaySoundFromLocation("..\\..\\sounds\\clickpecaracter.wav");
        }
        public void PlayReguliAnimaleDomestice()
        {
            PlaySoundFromLocation("..\\..\\sounds\\Merged_dom_buton.wav");
        }

        public void PlayReguliAnimaleSalbatice()
        {
            PlaySoundFromLocation("..\\..\\sounds\\Merged_salb_buton.wav");
        }

        public void PlayIntroducerePoezie()
        {
            PlaySoundFromLocation("..\\..\\sounds\\Merged_poezi_buton.wav");
        }

        public void PlayApasaButonStart()
        {
            PlaySoundFromLocation("..\\..\\sounds\\butonverde.wav");
        }
        public void PlayApasaButonAlbastru()
        {
            PlaySoundFromLocation("..\\..\\sounds\\butonalbastru.wav");
        }
        public void PlayPoezieIarna()
        {
            PlaySoundFromLocation("..\\..\\sounds\\Merged_iarna_albastru.wav");
        }

        public void PlayPoezieVara()
        {
            PlaySoundFromLocation("..\\..\\sounds\\Merged_vara_albastru.wav");
        }
        public void PlayPoeziePrimavara()
        {
            PlaySoundFromLocation("..\\..\\sounds\\Merged_prima_albastru.wav");
        }
        public void PlayPoezieToamna()
        {
            PlaySoundFromLocation("..\\..\\sounds\\Merged_yoamn_albastru.wav");
        }

        public void PlayInstructiuniSus()
        {
            PlaySoundFromLocation("..\\..\\sounds\\sus.wav");
        }
        public void PlayInstructiuniJos()
        {
            PlaySoundFromLocation("..\\..\\sounds\\jos.wav");
        }
        public void PlayInstructiuniStanga()
        { 
            PlaySoundFromLocation("..\\..\\sounds\\stanga.wav");
        }
        public void PlayInstructiuniDreapta()
        {
            PlaySoundFromLocation("..\\..\\sounds\\dreapta.wav");
        }
        public async void WaitSeconds(int miliseconds)
        {
            miliseconds = miliseconds * 100;
            await Task.Delay(miliseconds);
        }


        public void WriteResultsToFile(int index)
        {
            string strPath = Environment.GetFolderPath(
                         System.Environment.SpecialFolder.DesktopDirectory);
            using (StreamWriter writetext = new StreamWriter(strPath + "\\rezultate.txt", true))
            {
                writetext.WriteLine((Instance.CurrentCharacterPosition + 1).ToString() + " -> " + Instance.Characters[index].score.ToString() + " puncte");
            }
        }
    }
    
}
