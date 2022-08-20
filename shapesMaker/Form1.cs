﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace shapesMaker
{
    public partial class Form1 : Form
    {
        const string wordFile = "wordList.txt";
        string randomWord = "";
        int score = 0;
        int lettersIncorrect = 0;
        int lettersCorrect = 0;

        List<Button> pressedLetter = new List<Button>();


        public Form1()
        {
            InitializeComponent();

            this.Width = 1100;                  //Creates the window to be a set size
            this.Height = 820;

            txtInstructions.Hide();
            txtInstructions.Width = 700;
            txtInstructions.Height = 200;
            txtInstructions.Left = 200;
            txtInstructions.Top = 220;
            txtInstructions.Font = new Font(txtInstructions.Font.FontFamily, 12);
            txtInstructions.Text = "The objective of the game is to guess the word before the man is hung. Press each letter to guess if the letter is in the word. If it is not then one piece of the 'hangman' is drawn. If all eleven pieces of the 'hangman' is drawn before you correctly guess the word you lose. If you win you can choose to keep playing or leave the game. ";

            lblWord.Visible = false;

            btnNewWord.Hide();
            btnNewWord.Enabled = false;
            btnNewWord.Width = 160;
            btnNewWord.Height = 50;
            btnNewWord.Left = 50;
            btnNewWord.Top = 680;

            btnNewGame.Hide();
            btnNewGame.Enabled = false;
            btnNewGame.Width = 160;
            btnNewGame.Height = 50;
            btnNewGame.Left = 50;
            btnNewGame.Top = 680;

            btnStart.Width = 300;
            btnStart.Height = 150;
            btnStart.Left = 200;
            btnStart.Top = 200;

            btnInstructions.Width = 300;
            btnInstructions.Height = 150;
            btnInstructions.Left = 600;
            btnInstructions.Top = 200;

            btnInstructions2.Hide();
            btnInstructions2.Width = 230;
            btnInstructions2.Height = 50;
            btnInstructions2.Left = 230;
            btnInstructions2.Top = 680;
            btnInstructions2.Font = new Font(txtInstructions.Font.FontFamily, 20);

            btnInstructionsHide.Hide();
            btnInstructionsHide.Width = 120;
            btnInstructionsHide.Height = 40;
            btnInstructionsHide.Left = 768;
            btnInstructionsHide.Top = 370;

            lblGameOutcome.Hide();

            lblScore.Hide();
            lblScore.Width = 50;
            lblScore.Height = 20;

            txtIncorrectLetters.Hide();
            txtIncorrectLetters.Width = 100;
            txtIncorrectLetters.Height = 35;
            txtIncorrectLetters.Left = 800;
            txtIncorrectLetters.Top = 400;
            txtIncorrectLetters.Text = "Incorrect Letters: \n";


            picStandBase.Hide();
            picStandBase.Width = 300;
            picStandBase.Height = 10;
            picStandBase.Left = 50;
            picStandBase.Top = 550;

            picStandPole.Hide();
            picStandPole.Width = 15;
            picStandPole.Height = 400;
            picStandPole.Left = 75;
            picStandPole.Top = 150;

            picStandTop.Hide();
            picStandTop.Width = 230;
            picStandTop.Height = 15;
            picStandTop.Left = 75;
            picStandTop.Top = 150;

            //Image picStandSupportImage = picStandSupport.Image;
            //picStandSupportImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            //picStandSupport.Image = picStandSupportImage;
            picStandSupport.Hide();
            picStandSupport.Width = 120;
            picStandSupport.Height = 15;
            picStandSupport.Left = 80;
            picStandSupport.Top = 200;

            picRope.Hide();
            picRope.Width = 10;
            picRope.Height = 40;
            picRope.Left = 260;
            picRope.Top = 165;

            picHead.Hide();
            picHead.Width = 50;
            picHead.Height = 50;
            picHead.Left = 240;
            picHead.Top = 205;

            picTorso.Hide();
            picTorso.Width = 30;
            picTorso.Height = 100;
            picTorso.Left = 250;
            picTorso.Top = 255;

            picLeftArm.Hide();
            picLeftArm.Width = 50;
            picLeftArm.Height = 8;
            picLeftArm.Left = 280;
            picLeftArm.Top = 270;

            picRightArm.Hide();
            picRightArm.Width = 50;
            picRightArm.Height = 8;
            picRightArm.Left = 200;
            picRightArm.Top = 270;

            picLeftLeg.Hide();
            picLeftLeg.Width = 10;
            picLeftLeg.Height = 40;
            picLeftLeg.Left = 269;
            picLeftLeg.Top = 355;

            picRightLeg.Hide();
            picRightLeg.Width = 10;
            picRightLeg.Height = 40;
            picRightLeg.Left = 251;
            picRightLeg.Top = 355;




            LetterButtonsHide();

            {
                /*
                btnA.Hide();
                btnA.Width = 50;
                btnA.Height = 34;
                btnA.Left = 597;
                btnA.Top = 505;

                btnB.Hide();
                btnB.Width = 50;
                btnB.Height = 34;
                btnB.Left = 653;
                btnB.Top = 505;

                btnC.Hide();
                btnC.Width = 50;
                btnC.Height = 34;
                btnC.Left = 709;
                btnC.Top = 505;

                btnD.Hide();
                btnD.Width = 50;
                btnD.Height = 34;
                btnD.

                btnE.Hide();
                btnE.Width = 50;
                btnE.Height = 34;

                btnF.Hide();
                btnF.Width = 50;
                btnF.Height = 34;

                btnG.Hide();
                btnG.Width = 50;
                btnG.Height = 34;

                btnH.Hide();
                btnH.Width = 50;
                btnH.Height = 34;

                btnI.Hide();
                btnI.Width = 50;
                btnI.Height = 34;

                btnJ.Hide();
                btnJ.Width = 50;
                btnJ.Height = 34;

                btnK.Hide();
                btnK.Width = 50;
                btnK.Height = 34;

                btnL.Hide();
                btnL.Width = 50;
                btnL.Height = 34;

                btnM.Hide();
                btnM.Width = 50;
                btnM.Height = 34;

                btnN.Hide();
                btnN.Width = 50;
                btnN.Height = 34;

                btnO.Hide();
                btnO.Width = 50;
                btnO.Height = 34;

                btnP.Hide();
                btnP.Width = 50;
                btnP.Height = 34;

                btnQ.Hide();
                btnQ.Width = 50;
                btnQ.Height = 34;

                btnR.Hide();
                btnR.Width = 50;
                btnR.Height = 34;

                btnS.Hide();
                btnS.Width = 50;
                btnS.Height = 34;

                btnT.Hide();
                btnT.Width = 50;
                btnT.Height = 34;

                btnU.Hide();
                btnU.Width = 50;
                btnU.Height = 34;

                btnV.Hide();
                btnV.Width = 50;
                btnV.Height = 34;

                btnW.Hide();
                btnW.Width = 50;
                btnW.Height = 34;

                btnX.Hide();
                btnX.Width = 50;
                btnX.Height = 34;

                btnY.Hide();
                btnY.Width = 50;
                btnY.Height = 34;

                btnZ.Hide();
                btnZ.Width = 50;
                btnZ.Height = 34;
                */
            }

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black);               //Pen for drawing lines
            Brush brush = new SolidBrush(Color.Red);        //Brush for drawing shapes

            /*
            g.DrawLine(myPen, 2, 2, 400, 450);
            g.DrawRectangle(myPen, 100, 100, 200, 150);
            g.DrawEllipse(myPen, 300, 200, 50, 50);
            g.DrawArc(myPen, 400, 100, 50, 50, 0, 315);
            */

            /*
            g.DrawLine(blackPen, 50, 100, 270, 100);
            g.DrawLine(blackPen, 50, 190, 140, 100);
            g.DrawLine(blackPen, 270, 100, 270, 180);
            g.DrawArc(blackPen, 230, 180, 80, 80, 0, 360);
            g.DrawLine(blackPen, 270, 260, 270, 400);
            g.DrawLine(blackPen, 270, 260, 220, 340);
            g.DrawLine(blackPen, 270, 260, 320, 340);
            g.DrawLine(blackPen, 270, 400, 220, 480);
            g.DrawLine(blackPen, 270, 400, 320, 480);
            g.DrawLine(blackPen, 245, 200, 260, 215);
            g.DrawLine(blackPen, 245, 215, 260, 200);
            g.DrawLine(blackPen, 295, 215, 280, 200);
            g.DrawLine(blackPen, 295, 200, 280, 215);
            */

            Title(e);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            List<string> words = new List<string>();
            RemoveAllPlaceHolders();
            ReadTextFile(words);
            SelectRandomWord(words);
            CreateLabelsForRandomWord();
            LetterButtonsEnable();
            HangmanHide();
            txtIncorrectLetters.Text = "Incorrect Letters: \n";
            lblScore.Text = "Score: " + Convert.ToString(score);
            lettersIncorrect = 0;
            lettersCorrect = 0;
            score = 0;
            lblScore.Text = "Score: " + Convert.ToString(score);
            btnNewGame.Visible = false;
            btnInstructions2.Enabled = true;
            btnNewWord.Enabled = false;
            btnNewWord.Visible = true;
            lblGameOutcome.Visible = false;
        }

        private void btnNewWord_Click(object sender, EventArgs e)
        {
            List<string> words = new List<string>();
            RemoveAllPlaceHolders();
            ReadTextFile(words);
            SelectRandomWord(words);
            CreateLabelsForRandomWord();
            LetterButtonsEnable();
            HangmanHide();
            txtIncorrectLetters.Text = "Incorrect Letters: \n";
            lblScore.Text = "Score: " + Convert.ToString(score);
            lettersIncorrect = 0;
            lettersCorrect = 0;
            btnNewWord.Enabled = false;
            btnInstructions2.Enabled = true;
            lblGameOutcome.Visible = false;
        }

        private void lblScore_Load(object sender, EventArgs e)
        {
            lblScore.Hide();
            lblScore.Text = "Score: " + score;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            btnStart.Hide();

            lblScore.Show();
            btnNewWord.Show();
            LetterButtonsShow();
            btnInstructions.Hide();
            btnInstructions2.Show();
            txtInstructions.Hide();

            List<string> words = new List<string>();
            RemoveAllPlaceHolders();
            ReadTextFile(words);
            SelectRandomWord(words);
            CreateLabelsForRandomWord();
            txtIncorrectLetters.Show();


        }

        private void LetterPress(object sender, EventArgs e)
        {
            Button button = sender as Button;



            List<Label> placeHoldersToAdd = new List<Label>();
            foreach (Label label in Controls.OfType<Label>())
            {
                if (label.Tag != null && label.Tag.ToString() == "placeHolder")
                {
                    placeHoldersToAdd.Add(label);
                }
            }

            for (int i = 0; i < randomWord.Length; i++)
            {
                button.Enabled = false;

                if (randomWord[i] == Convert.ToChar(button.Text.ToLower()))
                {
                    placeHoldersToAdd[i].Text = Convert.ToString(button.Text);
                    lettersCorrect++;
                }
            }


            if (randomWord.Contains(button.Text.ToLower()))
            {

            }
            else
            {
                lblGameOutcome.Text = "no";
                lettersIncorrect++;
                txtIncorrectLetters.Text += button.Text;
            }

            {
                if (lettersIncorrect == 1)
                {
                    picStandBase.Show();
                }
                if (lettersIncorrect == 2)
                {
                    picStandPole.Show();
                }
                if (lettersIncorrect == 3)
                {
                    picStandTop.Show();
                }
                if (lettersIncorrect == 4)
                {
                    picStandSupport.Show();
                }
                if (lettersIncorrect == 5)
                {
                    picRope.Show();
                }
                if (lettersIncorrect == 6)
                {
                    picHead.Show();
                }
                if (lettersIncorrect == 7)
                {
                    picTorso.Show();
                }
                if (lettersIncorrect == 8)
                {
                    picLeftArm.Show();
                }
                if (lettersIncorrect == 9)
                {
                    picRightArm.Show();
                }
                if (lettersIncorrect == 10)
                {
                    picLeftLeg.Show();
                }
                if (lettersIncorrect == 11)
                {
                    picRightLeg.Show();
                    LetterButtonsDisable();
                    btnNewGame.Show();
                    btnNewGame.Enabled = true;
                    btnNewWord.Hide();
                    btnNewWord.Enabled = false;
                    btnInstructions2.Enabled = false;
                    lblGameOutcome.Visible = true;
                    lblGameOutcome.Text = "You lost with a score of " + score + ".\nThe word was " + randomWord;
                }
            }

            if (lettersCorrect == randomWord.Length)
            {
                lblGameOutcome.Show();
                lblGameOutcome.Text = "You win!";
                LetterButtonsDisable();
                score++;

                btnNewGame.Hide();
                btnNewGame.Enabled = false;
                btnNewWord.Show();
                btnNewWord.Enabled = true;

                btnInstructions2.Enabled = false;

            }



            /*
            foreach (char letter in randomWord)
            {
                int i = 1;
                if (button.Text.ToLower().Contains(letter))
                {
                    labelYouWin.Text = "yes";

                }

                for (i = i; i > 1; i++)
                {
                    labelYouWin.Text = "no";
                }

            }
            */
        }






        void Title(PaintEventArgs e)
        {
            Graphics g = e.Graphics;                                        //Code for writing the title
            String drawString = "HANGMAN";
            Font drawFont = new Font("", 60, FontStyle.Underline);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            PointF drawPoint = new PointF(318.0F, 25.0F);
            g.DrawString(drawString, drawFont, drawBrush, drawPoint);
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            btnInstructions.Hide();
            btnStart.Top = 580;
            btnStart.Left = 400;
            txtInstructions.Show();
        }

        private void btnInstructions2_Click(object sender, EventArgs e)
        {

            foreach (Button button in Controls.OfType<Button>())
            {
                if (button.Enabled == false)
                {
                    pressedLetter.Add(button);
                }
            }

            txtInstructions.Show();
            btnInstructionsHide.Show();
            btnInstructionsHide.BringToFront();
            LetterButtonsDisable();
            btnInstructions2.Enabled = false;
            btnNewWord.Enabled = false;

            foreach (Button button in pressedLetter)
            {
                button.Enabled = false;
            }
        }

        private void btnInstructionsHide_Click(object sender, EventArgs e)
        {
            btnInstructionsHide.Hide();
            txtInstructions.Hide();
            LetterButtonsEnable();
            btnInstructions2.Enabled = true;
            btnNewWord.Enabled = true;

            foreach (Button button in pressedLetter)
            {
                button.Enabled = false;
            }

        }

        private void LetterButtonsShow()
        {
            btnA.Show();            //Code for showing all letter buttons
            btnB.Show();
            btnC.Show();
            btnD.Show();
            btnE.Show();
            btnF.Show();
            btnG.Show();
            btnH.Show();
            btnI.Show();
            btnJ.Show();
            btnK.Show();
            btnL.Show();
            btnM.Show();
            btnN.Show();
            btnO.Show();
            btnP.Show();
            btnQ.Show();
            btnR.Show();
            btnS.Show();
            btnT.Show();
            btnU.Show();
            btnV.Show();
            btnW.Show();
            btnX.Show();
            btnY.Show();
            btnZ.Show();
        }

        private void LetterButtonsHide()
        {
            btnA.Hide();            //Code for hiding all letter buttons
            btnB.Hide();
            btnC.Hide();
            btnD.Hide();
            btnE.Hide();
            btnF.Hide();
            btnG.Hide();
            btnH.Hide();
            btnI.Hide();
            btnJ.Hide();
            btnK.Hide();
            btnL.Hide();
            btnM.Hide();
            btnN.Hide();
            btnO.Hide();
            btnP.Hide();
            btnQ.Hide();
            btnR.Hide();
            btnS.Hide();
            btnT.Hide();
            btnU.Hide();
            btnV.Hide();
            btnW.Hide();
            btnX.Hide();
            btnY.Hide();
            btnZ.Hide();
        }

        private void LetterButtonsDisable()
        {
            btnA.Enabled = false;            //Code for hiding all letter buttons
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
            btnG.Enabled = false;
            btnH.Enabled = false;
            btnI.Enabled = false;
            btnJ.Enabled = false;
            btnK.Enabled = false;
            btnL.Enabled = false;
            btnM.Enabled = false;
            btnN.Enabled = false;
            btnO.Enabled = false;
            btnP.Enabled = false;
            btnQ.Enabled = false;
            btnR.Enabled = false;
            btnS.Enabled = false;
            btnT.Enabled = false;
            btnU.Enabled = false;
            btnV.Enabled = false;
            btnW.Enabled = false;
            btnX.Enabled = false;
            btnY.Enabled = false;
            btnZ.Enabled = false;
        }

        private void LetterButtonsEnable()
        {
            btnA.Enabled = true;            //Code for hiding all letter buttons
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btnG.Enabled = true;
            btnH.Enabled = true;
            btnI.Enabled = true;
            btnJ.Enabled = true;
            btnK.Enabled = true;
            btnL.Enabled = true;
            btnM.Enabled = true;
            btnN.Enabled = true;
            btnO.Enabled = true;
            btnP.Enabled = true;
            btnQ.Enabled = true;
            btnR.Enabled = true;
            btnS.Enabled = true;
            btnT.Enabled = true;
            btnU.Enabled = true;
            btnV.Enabled = true;
            btnW.Enabled = true;
            btnX.Enabled = true;
            btnY.Enabled = true;
            btnZ.Enabled = true;
        }

        private void HangmanHide()
        {
            picStandBase.Hide();
            picStandPole.Hide();
            picStandTop.Hide();
            picStandSupport.Hide();
            picRope.Hide();
            picHead.Hide();
            picTorso.Hide();
            picLeftArm.Hide();
            picRightArm.Hide();
            picLeftLeg.Hide();
            picRightLeg.Hide();
        }

        private void RemoveAllPlaceHolders()
        {


            List<Label> placeHoldersToRemove = new List<Label>();
            foreach (Label label in Controls.OfType<Label>())
            {
                if (label.Tag != null && label.Tag.ToString() == "placeHolder")
                {
                    placeHoldersToRemove.Add(label);
                }
            }
            foreach (Label label in placeHoldersToRemove)
            {
                label.Dispose();
            }
        }

        private static void ReadTextFile(List<string> words)
        {
            StreamReader sr = new StreamReader(wordFile);   //Creates a streamreader used to read the words from the external file
            string line = "";   //Stores each word temporarily 
            using (sr)    //The streamreader that reads each word in the external file 
            {
                while ((line = sr.ReadLine()) != null)
                {
                    words.Add(line);
                }
            }
        }

        private void SelectRandomWord(List<string> words)
        {
            Random random = new Random();
            int randomWordNumber = random.Next(words.Count);
            randomWord = words[randomWordNumber];
            lblWord.Text = randomWord;
        }

        private void CreateLabelsForRandomWord()
        {
            Label[] labels = new Label[randomWord.Length];
            int xPos = 632;
            for (int i = 0; i < randomWord.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = "-";
                labels[i].Location = new Point(xPos, 450);
                labels[i].Enabled = true;
                labels[i].Visible = true;
                labels[i].Width = 30;
                labels[i].Height = 12;
                labels[i].Tag = "placeHolder";
                xPos += 30;
            }
            for (int i = 0; i < randomWord.Length; i++)
            {
                this.Controls.Add(labels[i]);
            }
        }

        /*
        private void printFirstLine(PaintEventArgs pe, int x)
        {
            Graphics gr = pe.Graphics;
            Pen blackPen = new Pen(Color.Black);
            gr.DrawLine(blackPen, 50, 100, 50, 600);
        }*/
    }
}
