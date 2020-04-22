//  Demonstration Code of Final Grade Calculator
//
//  Author:     Ashkan Soltanieh - All Rights Reserved
//              April 2020
//
//  Purpose:    Assignment 2 - SAIT (Tech Careers)
//                                 CPRG200 - Rapid App Development for OOSD
//
//  Description:            The application will allow the entry of an arbitrary 
//                          number of quiz marks, a single midterm mark and the final 
//                          examination mark. Once these have been entered, a calculate 
//                          button would be pressed produce the final grade, which
//                          will be displayed in the window along with the corresponding 
//                          letter grade. Note that there is no maximum or minimum 
//                          number of quizzes.

//  Requirements:           1)  A final grade cannot be calculated without either a midterm, 
//                              a final examination, or at least one quiz mark.
//                          2)  The application will give the user, if there are 5 or more quiz
//                              marks entered, the option of allowing the lowest and the highest
//                              marks in the quiz category to be dropped before the quiz average 
//                              is calculated.
//                          3)  A reset button must also be included to clear all previously 
//                              entered data so that the grade for the next student can be calculated.
//                          4)  A quit button must be provided to gracefully terminate the program.
//                          5)  If any of the grades are changed, the application must ensure that 
//                              the calculated final grade display is cleared.
//                          6)  Quiz grade are taken into account only when they are pushed to readonly
//                              quiz list box.
//                          7) Entered marks will be always whole number percentages between 0 (zero) 
//                             and 100 (one hundred).
//                          8) Calculated final grade is truncated to an integer by eliminating its
//                             decimal places.
//                          9) Final letter grade are based on following chart and inclusive on the lower
//                             end for each range
//                                  Letter Grade      (Percentage)
//                                  ------------      ------------
//                                      A+              95 – 100
//                                      A               90 –  94
//                                      A-              85 –  89
//                                      B+              80 –  84
//                                      B               75 –  79
//                                      B-              70 –  74
//                                      C+              67 –  69
//                                      C               64 –  66
//                                      C-              60 –  63
//                                      D+              55 –  59
//                                      D               50 –  54
//                                      F                0 –  49
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instructor_s_Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        double quizTotal     = 0;           //will store sum of all entered quizzes
        int quizEntryCounter = 0;           //will count the total number of entered quizzes
        int lowestQuiz       = 100;         //will record the lowest quiz mark; set to 100 which is the maximum possible value for comparison purpose later on.
        int highestQuiz      = 0;           //will record the highest quiz mark; set to 0 which is the minimum possible value for comparison purpose later on.

                           /* On click events for quiz grade transfer button, and calculate grades
                              this method is used to verify the entered value by the user
                              is as expected. it will return false if value is not an 
                              integer between range [0, 100] or if no entry received.
                              the method outputs the in range integer value only if it passes
                              both conditions.*/

        private bool valueVerification(string entry, out int value)
        {
            if (!int.TryParse(entry, out value))
            {
                return false;
            }
            if (value < 0 || value > 100)
            {
                return false;
            }
            return true;
        }
        
                                    // Quit Button click event here

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

                                    // Reset quizzes marks button click event here

        private void resetQuizMarksButton_Click(object sender, EventArgs e)
        {
            quizTotal        = 0;
            quizEntryCounter = 0;
            lowestQuiz       = 100;
            highestQuiz      = 0;
            quizMarkTextbox.Text = "";
            readonlyQuizzesListMultilineTextbox.Text = "";
            dropHighestLowestMarkCheckbox.Checked = false;
            dropHighestLowestMarkCheckbox.Enabled = false;
        }

                                    // Reset all marks button click event here

        private void resetAllMarksButton_Click(object sender, EventArgs e)
        {
            quizTotal = 0;
            quizEntryCounter = 0;
            lowestQuiz = 100;
            highestQuiz = 0;
            quizMarkTextbox.Text = "";
            readonlyQuizzesListMultilineTextbox.Text = "";
            dropHighestLowestMarkCheckbox.Checked = false;
            dropHighestLowestMarkCheckbox.Enabled = false;
            midtermMarkTextbox.Text = "";
            finalMarkTextbox.Text = "";
            readonlyCalculatedFinalMarkTextbox.Text = "";
            readonlyCalculatedLetterMarkTextbox.Text = "";
        }
                                /*this event clears the calculated grades textboxes 
                                 when it checking status of ckeckbox changes or if
                                 there is a text change in readonly quiz list textbox,
                                 midterm textbox, or final exam textbox.*/

        private void commonStatusChangeforTextOrCheckboxChangeEvent(object sender, EventArgs e)
        {
            readonlyCalculatedFinalMarkTextbox.Text = "";
            readonlyCalculatedLetterMarkTextbox.Text = "";
        }

                             /*Quiz mark transfer button transfers already verified data
                                to readonly multiline textbox. it will throw appropriate error
                                if invoking method inside if structure block 
                                returns false. it also records sum of all entered
                                quiz marks as well as their counts. In addition 
                                using if statements it checks and records the highest and lowest
                                quiz mark. After adding each quiz mark the quiz mark textbox is 
                                cleared and cursor moves there to get another quiz entry.*/

        private void quizMarkTransferButton_Click(object sender, EventArgs e)
        {
            if (!valueVerification(quizMarkTextbox.Text, out int quizMark))
            {
                MessageBox.Show("Error: Empty box or invalid quiz mark entry.\nEntry must be an integer in range of [0,100].");
            }
            else
            {
                readonlyQuizzesListMultilineTextbox.AppendText($"{quizMark}" + Environment.NewLine);
                quizTotal += quizMark;
                quizEntryCounter++;
                if(quizEntryCounter >= 5)
                {
                    dropHighestLowestMarkCheckbox.Enabled = true;
                }
                if (quizMark > highestQuiz)
                {
                    highestQuiz = quizMark;
                }
                if (quizMark < lowestQuiz)
                {
                    lowestQuiz = quizMark;
                }
                quizMarkTextbox.Text = "";
            }
            quizMarkTextbox.Select();
        }
                                /*calculate grades button event here.
                                 when the button clicked it checks if there are at least one
                                 entry for quiz and also if methof invoke for midterm mark and final 
                                 exam mark returns true. 
                                 throws error and moves cursor to related textbox if any is missing.
                                 If number of entered quiz marks are equal or greater than 5, the checkbox
                                 will be enabled. if the check box is checked by user 
                                 highest and lowest quiz marks it calculates final
                                 grade based on: (case 1: box checked and 5 or more quizzes exists,
                                 case 2: either box not checked or less than 5 quizzes exists)
                                 case 1 formula: (sum of all quizzes) / (quizzes count) * 0.2 +
                                                    (midterm mark * 0.3) + (final mark * 0.5)
                                 case 2 formula: ((sum of all quizzes) - highest - lowest) / (quizzes count - 2) * 0.2
                                                   + (midterm mark * 0.3) + (final mark * 0.5)
                                 Calculated Grade will be shown on readonly text box in truncated form into whole number
                                 and letter grades are calculated based on the calulated final grade in an if-else latter.
                                 */
        private void calculateGradesButton_Click(object sender, EventArgs e)
        {
            if (readonlyQuizzesListMultilineTextbox.Text == "")
            {
                MessageBox.Show("Error: No Quiz mark added. Please add at least one quiz mark.");
                quizMarkTextbox.Select();
                return;
            }
            if (!valueVerification(midtermMarkTextbox.Text, out int midTermGrade))
            {
                MessageBox.Show("Error: Empty box or invalid Midterm mark entry.\nEntry must be an integer in range of [0,100].");
                midtermMarkTextbox.Select();
                return;
            }
            if (!valueVerification(finalMarkTextbox.Text, out int finalGrade))
            {
                MessageBox.Show("Error: Empty box or invalid Final mark entry.\nEntry must be an integer in range of [0,100].");
                finalMarkTextbox.Select();
                return;
            }
            if (quizMarkTextbox.Text.Trim() != "")
            {
                MessageBox.Show("Error: Please ensure the Quiz mark is pushed to the list, before clicking Calculate Grades button.");
                quizMarkTextbox.Select();
                return;
            }

            double numberGrade;                 //stores calculated final grade

            if(dropHighestLowestMarkCheckbox.Checked == true)
            {
                numberGrade = (quizTotal - highestQuiz - lowestQuiz)  / (quizEntryCounter - 2) * 0.2 + midTermGrade * 0.3 + finalGrade * 0.5;
            }
            else
            {
                numberGrade = quizTotal / quizEntryCounter * 0.2 + midTermGrade * 0.3 + finalGrade * 0.5;
            }
                                                //output final grade ehich is truncated to whole number, and also letter grade corresponding to the final grade

            readonlyCalculatedFinalMarkTextbox.Text = $"{numberGrade:N0}"; 
            
            if(numberGrade >= 95)
            {
                readonlyCalculatedLetterMarkTextbox.Text = "A+";
            }
            else if(numberGrade >= 90)
            {
                readonlyCalculatedLetterMarkTextbox.Text = "A";
            }
            else if (numberGrade >= 85)
            {
                readonlyCalculatedLetterMarkTextbox.Text = "A-";
            }
            else if (numberGrade >= 80)
            {
                readonlyCalculatedLetterMarkTextbox.Text = "B+";
            }
            else if (numberGrade >= 75)
            {
                readonlyCalculatedLetterMarkTextbox.Text = "B";
            }
            else if (numberGrade >= 70)
            {
                readonlyCalculatedLetterMarkTextbox.Text = "B-";
            }
            else if (numberGrade >= 67)
            {
                readonlyCalculatedLetterMarkTextbox.Text = "C+";
            }
            else if (numberGrade >= 64)
            {
                readonlyCalculatedLetterMarkTextbox.Text = "C";
            }
            else if (numberGrade >= 60)
            {
                readonlyCalculatedLetterMarkTextbox.Text = "C-";
            }
            else if (numberGrade >= 55)
            {
                readonlyCalculatedLetterMarkTextbox.Text = "D+";
            }
            else if (numberGrade >= 50)
            {
                readonlyCalculatedLetterMarkTextbox.Text = "D";
            }
            else
            {
                readonlyCalculatedLetterMarkTextbox.Text = "F";
            }
        }
    }
}
