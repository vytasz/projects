using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geimas
{
    public class Game
    {
        public string originalText, playerText;
        public bool isGame;

        public Game(string text)
        {
            originalText = text;
            UpdatePlayerText(0);
            isGame = true;
        }

        public void UpdatePlayerText(int current)
        {
            playerText += originalText[current];
        }

        public bool CheckPlayerText(int check, string input)
        {
            if (input[0] == originalText[check-1])
            {
                return true;
            }
            return false;
        }

        public void PlayerInput(string input)
        {
            int check = playerText.Length;
            if (CheckPlayerText(check, input) && isGame)
            {
                if (check < originalText.Length)
                {
                    UpdatePlayerText(check);
                }
                else isGame = false;
            }
        }
    }
}
