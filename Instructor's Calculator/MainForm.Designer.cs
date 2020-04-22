namespace Instructor_s_Calculator
{
    partial class MainForm
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
            this.quizzesListLabel = new System.Windows.Forms.Label();
            this.quizMarkLabel = new System.Windows.Forms.Label();
            this.quizMarkTextbox = new System.Windows.Forms.TextBox();
            this.quizMarkTransferButton = new System.Windows.Forms.Button();
            this.readonlyQuizzesListMultilineTextbox = new System.Windows.Forms.TextBox();
            this.dropHighestLowestMarkCheckbox = new System.Windows.Forms.CheckBox();
            this.resetQuizMarksButton = new System.Windows.Forms.Button();
            this.midtermMarkLabel = new System.Windows.Forms.Label();
            this.midtermMarkTextbox = new System.Windows.Forms.TextBox();
            this.finalMarkLabel = new System.Windows.Forms.Label();
            this.finalMarkTextbox = new System.Windows.Forms.TextBox();
            this.calculateGradesButton = new System.Windows.Forms.Button();
            this.readonlyCalculatedFinalMarkTextbox = new System.Windows.Forms.TextBox();
            this.readonlyCalculatedLetterMarkTextbox = new System.Windows.Forms.TextBox();
            this.reserAllMarksButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quizzesListLabel
            // 
            this.quizzesListLabel.AutoSize = true;
            this.quizzesListLabel.Location = new System.Drawing.Point(207, 19);
            this.quizzesListLabel.Name = "quizzesListLabel";
            this.quizzesListLabel.Size = new System.Drawing.Size(63, 17);
            this.quizzesListLabel.TabIndex = 15;
            this.quizzesListLabel.Text = "Quizzes:";
            this.quizzesListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quizMarkLabel
            // 
            this.quizMarkLabel.AutoSize = true;
            this.quizMarkLabel.Location = new System.Drawing.Point(56, 51);
            this.quizMarkLabel.Name = "quizMarkLabel";
            this.quizMarkLabel.Size = new System.Drawing.Size(76, 17);
            this.quizMarkLabel.TabIndex = 15;
            this.quizMarkLabel.Text = "Quiz Mark:";
            this.quizMarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quizMarkTextbox
            // 
            this.quizMarkTextbox.Location = new System.Drawing.Point(139, 51);
            this.quizMarkTextbox.Name = "quizMarkTextbox";
            this.quizMarkTextbox.Size = new System.Drawing.Size(61, 22);
            this.quizMarkTextbox.TabIndex = 0;
            // 
            // quizMarkTransferButton
            // 
            this.quizMarkTransferButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizMarkTransferButton.Location = new System.Drawing.Point(210, 45);
            this.quizMarkTransferButton.Name = "quizMarkTransferButton";
            this.quizMarkTransferButton.Size = new System.Drawing.Size(60, 31);
            this.quizMarkTransferButton.TabIndex = 1;
            this.quizMarkTransferButton.Text = "";
            this.quizMarkTransferButton.UseVisualStyleBackColor = true;
            this.quizMarkTransferButton.Click += new System.EventHandler(this.quizMarkTransferButton_Click);
            // 
            // readonlyQuizzesListMultilineTextbox
            // 
            this.readonlyQuizzesListMultilineTextbox.Location = new System.Drawing.Point(279, 22);
            this.readonlyQuizzesListMultilineTextbox.Multiline = true;
            this.readonlyQuizzesListMultilineTextbox.Name = "readonlyQuizzesListMultilineTextbox";
            this.readonlyQuizzesListMultilineTextbox.ReadOnly = true;
            this.readonlyQuizzesListMultilineTextbox.Size = new System.Drawing.Size(131, 192);
            this.readonlyQuizzesListMultilineTextbox.TabIndex = 15;
            this.readonlyQuizzesListMultilineTextbox.TextChanged += new System.EventHandler(this.commonStatusChangeforTextOrCheckboxChangeEvent);
            // 
            // dropHighestLowestMarkCheckbox
            // 
            this.dropHighestLowestMarkCheckbox.AutoSize = true;
            this.dropHighestLowestMarkCheckbox.Enabled = false;
            this.dropHighestLowestMarkCheckbox.Location = new System.Drawing.Point(164, 221);
            this.dropHighestLowestMarkCheckbox.Name = "dropHighestLowestMarkCheckbox";
            this.dropHighestLowestMarkCheckbox.Size = new System.Drawing.Size(244, 21);
            this.dropHighestLowestMarkCheckbox.TabIndex = 3;
            this.dropHighestLowestMarkCheckbox.Text = "&Drop Highest and Lowest Quizzes";
            this.dropHighestLowestMarkCheckbox.UseVisualStyleBackColor = true;
            this.dropHighestLowestMarkCheckbox.CheckedChanged += new System.EventHandler(this.commonStatusChangeforTextOrCheckboxChangeEvent);
            // 
            // resetQuizMarksButton
            // 
            this.resetQuizMarksButton.Location = new System.Drawing.Point(89, 89);
            this.resetQuizMarksButton.Name = "resetQuizMarksButton";
            this.resetQuizMarksButton.Size = new System.Drawing.Size(141, 31);
            this.resetQuizMarksButton.TabIndex = 2;
            this.resetQuizMarksButton.Text = "R&eset Quiz Marks";
            this.resetQuizMarksButton.UseVisualStyleBackColor = true;
            this.resetQuizMarksButton.Click += new System.EventHandler(this.resetQuizMarksButton_Click);
            // 
            // midtermMarkLabel
            // 
            this.midtermMarkLabel.AutoSize = true;
            this.midtermMarkLabel.Location = new System.Drawing.Point(164, 253);
            this.midtermMarkLabel.Name = "midtermMarkLabel";
            this.midtermMarkLabel.Size = new System.Drawing.Size(97, 17);
            this.midtermMarkLabel.TabIndex = 0;
            this.midtermMarkLabel.Text = "Midterm Mark:";
            this.midtermMarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // midtermMarkTextbox
            // 
            this.midtermMarkTextbox.Location = new System.Drawing.Point(267, 251);
            this.midtermMarkTextbox.Name = "midtermMarkTextbox";
            this.midtermMarkTextbox.Size = new System.Drawing.Size(100, 22);
            this.midtermMarkTextbox.TabIndex = 4;
            this.midtermMarkTextbox.TextChanged += new System.EventHandler(this.commonStatusChangeforTextOrCheckboxChangeEvent);
            // 
            // finalMarkLabel
            // 
            this.finalMarkLabel.AutoSize = true;
            this.finalMarkLabel.Location = new System.Drawing.Point(146, 282);
            this.finalMarkLabel.Name = "finalMarkLabel";
            this.finalMarkLabel.Size = new System.Drawing.Size(115, 17);
            this.finalMarkLabel.TabIndex = 0;
            this.finalMarkLabel.Text = "Final Exam Mark:";
            this.finalMarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // finalMarkTextbox
            // 
            this.finalMarkTextbox.Location = new System.Drawing.Point(267, 282);
            this.finalMarkTextbox.Name = "finalMarkTextbox";
            this.finalMarkTextbox.Size = new System.Drawing.Size(100, 22);
            this.finalMarkTextbox.TabIndex = 5;
            this.finalMarkTextbox.TextChanged += new System.EventHandler(this.commonStatusChangeforTextOrCheckboxChangeEvent);
            // 
            // calculateGradesButton
            // 
            this.calculateGradesButton.Location = new System.Drawing.Point(127, 317);
            this.calculateGradesButton.Name = "calculateGradesButton";
            this.calculateGradesButton.Size = new System.Drawing.Size(134, 29);
            this.calculateGradesButton.TabIndex = 6;
            this.calculateGradesButton.Text = "&Calculate Grades";
            this.calculateGradesButton.UseVisualStyleBackColor = true;
            this.calculateGradesButton.Click += new System.EventHandler(this.calculateGradesButton_Click);
            // 
            // readonlyCalculatedFinalMarkTextbox
            // 
            this.readonlyCalculatedFinalMarkTextbox.Location = new System.Drawing.Point(267, 320);
            this.readonlyCalculatedFinalMarkTextbox.Name = "readonlyCalculatedFinalMarkTextbox";
            this.readonlyCalculatedFinalMarkTextbox.ReadOnly = true;
            this.readonlyCalculatedFinalMarkTextbox.Size = new System.Drawing.Size(45, 22);
            this.readonlyCalculatedFinalMarkTextbox.TabIndex = 15;
            this.readonlyCalculatedFinalMarkTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // readonlyCalculatedLetterMarkTextbox
            // 
            this.readonlyCalculatedLetterMarkTextbox.Location = new System.Drawing.Point(322, 320);
            this.readonlyCalculatedLetterMarkTextbox.Name = "readonlyCalculatedLetterMarkTextbox";
            this.readonlyCalculatedLetterMarkTextbox.ReadOnly = true;
            this.readonlyCalculatedLetterMarkTextbox.Size = new System.Drawing.Size(45, 22);
            this.readonlyCalculatedLetterMarkTextbox.TabIndex = 15;
            this.readonlyCalculatedLetterMarkTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reserAllMarksButton
            // 
            this.reserAllMarksButton.Location = new System.Drawing.Point(127, 352);
            this.reserAllMarksButton.Name = "reserAllMarksButton";
            this.reserAllMarksButton.Size = new System.Drawing.Size(134, 29);
            this.reserAllMarksButton.TabIndex = 7;
            this.reserAllMarksButton.Text = "&Reset All Marks";
            this.reserAllMarksButton.UseVisualStyleBackColor = true;
            this.reserAllMarksButton.Click += new System.EventHandler(this.resetAllMarksButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(127, 387);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(134, 29);
            this.quitButton.TabIndex = 8;
            this.quitButton.Text = "&Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 437);
            this.Controls.Add(this.readonlyCalculatedLetterMarkTextbox);
            this.Controls.Add(this.readonlyCalculatedFinalMarkTextbox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.reserAllMarksButton);
            this.Controls.Add(this.calculateGradesButton);
            this.Controls.Add(this.finalMarkTextbox);
            this.Controls.Add(this.finalMarkLabel);
            this.Controls.Add(this.midtermMarkTextbox);
            this.Controls.Add(this.midtermMarkLabel);
            this.Controls.Add(this.resetQuizMarksButton);
            this.Controls.Add(this.dropHighestLowestMarkCheckbox);
            this.Controls.Add(this.readonlyQuizzesListMultilineTextbox);
            this.Controls.Add(this.quizMarkTransferButton);
            this.Controls.Add(this.quizMarkTextbox);
            this.Controls.Add(this.quizMarkLabel);
            this.Controls.Add(this.quizzesListLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quizzesListLabel;
        private System.Windows.Forms.Label quizMarkLabel;
        private System.Windows.Forms.TextBox quizMarkTextbox;
        private System.Windows.Forms.Button quizMarkTransferButton;
        private System.Windows.Forms.TextBox readonlyQuizzesListMultilineTextbox;
        private System.Windows.Forms.CheckBox dropHighestLowestMarkCheckbox;
        private System.Windows.Forms.Button resetQuizMarksButton;
        private System.Windows.Forms.Label midtermMarkLabel;
        private System.Windows.Forms.TextBox midtermMarkTextbox;
        private System.Windows.Forms.Label finalMarkLabel;
        private System.Windows.Forms.TextBox finalMarkTextbox;
        private System.Windows.Forms.Button calculateGradesButton;
        private System.Windows.Forms.TextBox readonlyCalculatedFinalMarkTextbox;
        private System.Windows.Forms.TextBox readonlyCalculatedLetterMarkTextbox;
        private System.Windows.Forms.Button reserAllMarksButton;
        private System.Windows.Forms.Button quitButton;
    }
}

