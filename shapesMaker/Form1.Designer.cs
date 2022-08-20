﻿namespace shapesMaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewWord = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.btnInstructionsHide = new System.Windows.Forms.Button();
            this.btnInstructions2 = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.btnGetRandomWord = new System.Windows.Forms.Button();
            this.labelYouWin = new System.Windows.Forms.Label();
            this.picStandBase = new System.Windows.Forms.PictureBox();
            this.picStandPole = new System.Windows.Forms.PictureBox();
            this.picStandTop = new System.Windows.Forms.PictureBox();
            this.picStandSupport = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStandBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStandPole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStandTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStandSupport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewWord
            // 
            this.btnNewWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnNewWord.Location = new System.Drawing.Point(11, 690);
            this.btnNewWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewWord.Name = "btnNewWord";
            this.btnNewWord.Size = new System.Drawing.Size(149, 39);
            this.btnNewWord.TabIndex = 0;
            this.btnNewWord.Text = "New Word";
            this.btnNewWord.UseVisualStyleBackColor = true;
            this.btnNewWord.Click += new System.EventHandler(this.btnNewWord_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.35F);
            this.lblScore.Location = new System.Drawing.Point(17, 24);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(52, 15);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: 0";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Load);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnStart.Location = new System.Drawing.Point(20, 64);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(269, 65);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnInstructions.Location = new System.Drawing.Point(20, 135);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(269, 134);
            this.btnInstructions.TabIndex = 3;
            this.btnInstructions.Text = "HOW TO PLAY";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(629, 548);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(54, 39);
            this.btnA.TabIndex = 4;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(685, 548);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(54, 39);
            this.btnB.TabIndex = 4;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(741, 548);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(54, 39);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(797, 548);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(54, 39);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(853, 548);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(54, 39);
            this.btnE.TabIndex = 4;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnF
            // 
            this.btnF.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(909, 548);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(54, 39);
            this.btnF.TabIndex = 4;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnG
            // 
            this.btnG.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(965, 548);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(54, 39);
            this.btnG.TabIndex = 4;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnH
            // 
            this.btnH.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(629, 588);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(54, 39);
            this.btnH.TabIndex = 4;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnI
            // 
            this.btnI.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(685, 588);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(54, 39);
            this.btnI.TabIndex = 4;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnJ
            // 
            this.btnJ.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.Location = new System.Drawing.Point(741, 588);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(54, 39);
            this.btnJ.TabIndex = 4;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            this.btnJ.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnK
            // 
            this.btnK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.Location = new System.Drawing.Point(797, 588);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(54, 39);
            this.btnK.TabIndex = 4;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnL
            // 
            this.btnL.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(853, 588);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(54, 39);
            this.btnL.TabIndex = 4;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(909, 588);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(54, 39);
            this.btnM.TabIndex = 4;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnN
            // 
            this.btnN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(965, 588);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(54, 39);
            this.btnN.TabIndex = 4;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnO
            // 
            this.btnO.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.Location = new System.Drawing.Point(657, 628);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(54, 39);
            this.btnO.TabIndex = 4;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnP
            // 
            this.btnP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(713, 628);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(54, 39);
            this.btnP.TabIndex = 4;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnQ
            // 
            this.btnQ.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.Location = new System.Drawing.Point(769, 628);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(54, 39);
            this.btnQ.TabIndex = 4;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnR
            // 
            this.btnR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(825, 628);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(54, 39);
            this.btnR.TabIndex = 4;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(881, 628);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(54, 39);
            this.btnS.TabIndex = 4;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnT
            // 
            this.btnT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(937, 628);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(54, 39);
            this.btnT.TabIndex = 4;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnU
            // 
            this.btnU.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.Location = new System.Drawing.Point(657, 668);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(54, 39);
            this.btnU.TabIndex = 4;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnV
            // 
            this.btnV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(713, 668);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(54, 39);
            this.btnV.TabIndex = 4;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnW
            // 
            this.btnW.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.Location = new System.Drawing.Point(769, 668);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(54, 39);
            this.btnW.TabIndex = 4;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnX
            // 
            this.btnX.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(825, 668);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(54, 39);
            this.btnX.TabIndex = 4;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnY
            // 
            this.btnY.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.Location = new System.Drawing.Point(881, 668);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(54, 39);
            this.btnY.TabIndex = 4;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.LetterPress);
            // 
            // btnZ
            // 
            this.btnZ.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.Location = new System.Drawing.Point(937, 668);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(54, 39);
            this.btnZ.TabIndex = 4;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.LetterPress);
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.SystemColors.Window;
            this.txtInstructions.Enabled = false;
            this.txtInstructions.Location = new System.Drawing.Point(638, 300);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(428, 113);
            this.txtInstructions.TabIndex = 5;
            this.txtInstructions.Text = "Text";
            // 
            // btnInstructionsHide
            // 
            this.btnInstructionsHide.Location = new System.Drawing.Point(20, 415);
            this.btnInstructionsHide.Name = "btnInstructionsHide";
            this.btnInstructionsHide.Size = new System.Drawing.Size(269, 134);
            this.btnInstructionsHide.TabIndex = 6;
            this.btnInstructionsHide.Text = "Hide Instructions";
            this.btnInstructionsHide.UseVisualStyleBackColor = true;
            this.btnInstructionsHide.Click += new System.EventHandler(this.btnInstructionsHide_Click);
            // 
            // btnInstructions2
            // 
            this.btnInstructions2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnInstructions2.Location = new System.Drawing.Point(20, 275);
            this.btnInstructions2.Name = "btnInstructions2";
            this.btnInstructions2.Size = new System.Drawing.Size(269, 134);
            this.btnInstructions2.TabIndex = 3;
            this.btnInstructions2.Text = "How To Play";
            this.btnInstructions2.UseVisualStyleBackColor = true;
            this.btnInstructions2.Click += new System.EventHandler(this.btnInstructions2_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(577, 434);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(35, 13);
            this.lblWord.TabIndex = 7;
            this.lblWord.Text = "label1";
            // 
            // btnGetRandomWord
            // 
            this.btnGetRandomWord.Enabled = false;
            this.btnGetRandomWord.Location = new System.Drawing.Point(11, 653);
            this.btnGetRandomWord.Name = "btnGetRandomWord";
            this.btnGetRandomWord.Size = new System.Drawing.Size(75, 23);
            this.btnGetRandomWord.TabIndex = 8;
            this.btnGetRandomWord.Text = "button1";
            this.btnGetRandomWord.UseVisualStyleBackColor = true;
            this.btnGetRandomWord.Click += new System.EventHandler(this.btnGetRandomWord_Click);
            // 
            // labelYouWin
            // 
            this.labelYouWin.AutoSize = true;
            this.labelYouWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelYouWin.Location = new System.Drawing.Point(452, 471);
            this.labelYouWin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYouWin.Name = "labelYouWin";
            this.labelYouWin.Size = new System.Drawing.Size(86, 31);
            this.labelYouWin.TabIndex = 9;
            this.labelYouWin.Text = "label1";
            // 
            // picStandBase
            // 
            this.picStandBase.BackColor = System.Drawing.Color.BurlyWood;
            this.picStandBase.Location = new System.Drawing.Point(392, 192);
            this.picStandBase.Name = "picStandBase";
            this.picStandBase.Size = new System.Drawing.Size(220, 10);
            this.picStandBase.TabIndex = 10;
            this.picStandBase.TabStop = false;
            // 
            // picStandPole
            // 
            this.picStandPole.BackColor = System.Drawing.Color.BurlyWood;
            this.picStandPole.Location = new System.Drawing.Point(392, 212);
            this.picStandPole.Name = "picStandPole";
            this.picStandPole.Size = new System.Drawing.Size(220, 10);
            this.picStandPole.TabIndex = 10;
            this.picStandPole.TabStop = false;
            // 
            // picStandTop
            // 
            this.picStandTop.BackColor = System.Drawing.Color.BurlyWood;
            this.picStandTop.Location = new System.Drawing.Point(392, 232);
            this.picStandTop.Name = "picStandTop";
            this.picStandTop.Size = new System.Drawing.Size(220, 10);
            this.picStandTop.TabIndex = 10;
            this.picStandTop.TabStop = false;
            // 
            // picStandSupport
            // 
            this.picStandSupport.BackColor = System.Drawing.Color.BurlyWood;
            this.picStandSupport.Location = new System.Drawing.Point(392, 252);
            this.picStandSupport.Name = "picStandSupport";
            this.picStandSupport.Size = new System.Drawing.Size(65, 10);
            this.picStandSupport.TabIndex = 10;
            this.picStandSupport.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.picStandSupport);
            this.Controls.Add(this.picStandTop);
            this.Controls.Add(this.picStandPole);
            this.Controls.Add(this.picStandBase);
            this.Controls.Add(this.labelYouWin);
            this.Controls.Add(this.btnGetRandomWord);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnInstructionsHide);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnInstructions2);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnNewWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picStandBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStandPole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStandTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStandSupport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewWord;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Button btnInstructionsHide;
        private System.Windows.Forms.Button btnInstructions2;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnGetRandomWord;
        private System.Windows.Forms.Label labelYouWin;
        private System.Windows.Forms.PictureBox picStandBase;
        private System.Windows.Forms.PictureBox picStandPole;
        private System.Windows.Forms.PictureBox picStandTop;
        private System.Windows.Forms.PictureBox picStandSupport;
    }
}

