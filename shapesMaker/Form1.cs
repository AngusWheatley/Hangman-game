using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapesMaker
{
    public partial class Form1 : Form
    {
        const string wordFile = "wordList.txt";
        string randomWord = "";
        int score = 0;

        public Form1()
        {
            InitializeComponent();

            this.Width = 1100;                  //Creates the window to be a set size
            this.Height = 800;

            txtInstructions.Hide();
            txtInstructions.Width = 700;
            txtInstructions.Height = 200;
            txtInstructions.Left = 200;
            txtInstructions.Top = 220;
            txtInstructions.Font = new Font(txtInstructions.Font.FontFamily, 12);
            txtInstructions.Text = "The objective of the game is to guess the word before the man is hung. If you don't correctly guess the word before the man is hung you lose. ";


            btnNewWord.Hide();
            btnNewWord.Width = 160;
            btnNewWord.Height = 50;
            btnNewWord.Left = 50;
            btnNewWord.Top = 680;

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


            lblScore.Hide();
            lblScore.Width = 50;
            lblScore.Height = 20;

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

            g.DrawLine(blackPen, 50, 100, 50, 600);
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


            Title(e);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewWord_Load(object sender, EventArgs e)
        {
            
        }


        private void btnNewWord_Click(object sender, EventArgs e)
        {

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

            StreamReader sr = new StreamReader(wordFile);   //Creates a streamreader used to read the words from the external file
            string line = "";   //Stores each word temporarily 
            using (sr);    //The streamreader that reads each word in the external file 

        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            btnInstructions.Hide();
            btnStart.Top = 580;
            btnStart.Left = 400;
            txtInstructions.Show(); 

           



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

        private void btnInstructionsHide_Click(object sender, EventArgs e)
        {
            btnInstructionsHide.Hide();
            txtInstructions.Hide();
            LetterButtonsEnable();
        }

        private void btnInstructions2_Click(object sender, EventArgs e)
        {
            txtInstructions.Show();
            btnInstructionsHide.Show();
            btnInstructionsHide.BringToFront();
            LetterButtonsDisable();
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
    }
}
