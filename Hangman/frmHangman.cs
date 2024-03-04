using Hangman.Models;
using Hangman.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class frmHangman : Form
    {
        string chars = "ABCDEFGHIJKLMNOPRSTOQUVXWYZ";
        public List<String> UsedChars = new List<String>();
        List<String> words;
        string selectedWord;
        string secretWord;

        int retryCount = 6;

        public frmHangman()
        {
            InitializeComponent();
            createCharButtons();
            words= HagmanWord.getWords();
            startNewGame();

        }

        private void startNewGame()
        {
            secretWord = "";
            lblLetter.Text = "";
            retryCount = 6;
            int randomNumber = new Random().Next(0, words.Count() - 1);
            selectedWord = words[randomNumber];
            Text = selectedWord;
            UsedChars.Clear();
            for (int i = 0; i < selectedWord.Length; i++)
            {
                secretWord += " _ ";
            }
            lblDesc.Text = secretWord;
        }

        private void frmHangman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                checkLetter(e.KeyChar.ToString().ToUpper());
            }
        }

        private void createCharButtons()
        {
            grbButtons.Controls.Clear();
            int posX = 0;
            int posY = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                Button btn = new Button();
                btn.Text = chars.Substring(i, 1);
                if (i == 13)
                {
                    posX = 0;
                    posY++;
                }
                if (UsedChars.Contains(btn.Text))
                {
                    btn.Enabled = false;
                }
                else
                {
                    btn.Enabled = true;
                }

                btn.Top = (posY*50) + 10;
                btn.Left = posX * 50;
                btn.Size = new Size(45, 45);
                grbButtons.Controls.Add(btn);
                posX++;

                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            checkLetter(btn.Text);
           
        }

        private void checkLetter(String letter)
        {
            if (!UsedChars.Contains(letter))
            {
               

                if (!selectedWord.Contains(letter[0]))
                {
                    retryCount--;
                }
                UsedChars.Add(letter);
                lblLetter.Text = letter;
                contolLetter();
                
                if (UsedChars.Count != 0)
                {
                    ResourceManager rm = Resources.ResourceManager;
                    Bitmap hangmanImage = (Bitmap)rm.GetObject("_" + (7-retryCount).ToString("000"));
                    pBoxHangman.Image = hangmanImage;

                }
                if (retryCount < 0)
                {
                    MessageBox.Show("You Lost");
                    startNewGame();
                }


                createCharButtons();
            }
        }

        private void contolLetter()
        {
            secretWord = "";
            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (UsedChars.Contains(selectedWord[i].ToString()))
                {
                    secretWord += " " + selectedWord[i].ToString() +  " ";
                }
                else
                {
                    secretWord += "_ ";
                }
            }
            lblDesc.Text = secretWord;
        }
    }
}
