using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PSSI
{
    public sealed class CharactersPageHandler
    {
        private static CharactersPageHandler _instance = null;
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

        public void PlayCorrectSound()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\sounds\\correct.wav";
            player.Play();
        }

        public void PlayWrongSound()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\sounds\\wrong.wav";
            player.Play();
        }
    }
    
}
