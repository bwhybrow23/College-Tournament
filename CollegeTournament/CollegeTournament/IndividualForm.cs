using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeTournament
{
    public partial class IndividualForm : Form
    {
        DomainUpDown[] ctr_individual;
        const int NUMBEROFBOXES = 50;

        teamForm teamForm;

        public IndividualForm(teamForm form)
        {
            InitializeComponent();
            teamForm = form;
        }

        private void btn_resetScores_Click_1(object sender, EventArgs e)
        {
            // Message pop-up to confirm
            DialogResult dialogresult = MessageBox.Show("Are you sure you would like to reset all scores?", "Reset Scores", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                //If Yes is clicked on the pop-up, reset the scores                
                for (int i = 0; i < NUMBEROFBOXES; i++)
                {
                    ctr_individual[i].SelectedIndex = 0;
                }
            }
            else if (dialogresult == DialogResult.No)
            {
                //Return nothing as the event has been cancelled
                return;
            }
        }

        private void IndividualForm_Load(object sender, EventArgs e)
        {
            //Declaration of values used
            int i, j;
            int yPos;

            ctr_individual = new DomainUpDown[NUMBEROFBOXES];

            //For loop to create all boxes
            for (i = 0; i < NUMBEROFBOXES; i++)
            {
                yPos = 117 + (i / 5 * 43);
                ctr_individual[i] = new DomainUpDown();
                ctr_individual[i].Location = new Point(527 + (90 * (i % 5)), yPos);
                ctr_individual[i].Width = 55;
                ctr_individual[i].Font = new Font("Calibri", 18);

                for (j = 0; j <= 4; j++)
                {
                    ctr_individual[i].Items.Add(j.ToString());
                }

                ctr_individual[i].SelectedIndex = 0;
                ctr_individual[i].Parent = this;
            }
        }

        private void btn_calculateWinner_Click_1(object sender, EventArgs e)
        {
            // Input Validation
            if (txt_individualName_1.Text == "" || txt_individualName_2.Text == "" || txt_individualName_3.Text == "" || txt_individualName_4.Text == "" || txt_individualName_5.Text == "" || txt_individualName_6.Text == "" || txt_individualName_7.Text == "" || txt_individualName_8.Text == "" || txt_individualName_9.Text == "" || txt_individualName_10.Text == "")
            {
                MessageBox.Show("One of the individual names is invalid, please check them.");
                return;
            }

            //Convert individual names to Array
            string[] individualNames = { txt_individualName_1.Text, txt_individualName_2.Text, txt_individualName_3.Text, txt_individualName_4.Text, txt_individualName_5.Text, txt_individualName_6.Text, txt_individualName_7.Text, txt_individualName_8.Text, txt_individualName_9.Text, txt_individualName_10.Text };

            //Setup array for scores
            int[] scores = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int j = 0;

            //For loop for every value
            for (int i = 0; i < NUMBEROFBOXES; i++)
            {
                //Every 5 boxes, move to next row (next individual)
                if (i % 5 == 0)
                {
                    j++;
                }

                //Check if 0
                if (ctr_individual[i].SelectedIndex == 0)
                {
                    MessageBox.Show("None of the values can be 0");
                    return;
                }

                //Input Validation
                string value = ctr_individual[i].SelectedIndex.ToString();

                if (!Regex.IsMatch(value, @"^\d+$"))
                {
                    MessageBox.Show("One of the values is not a number or exceeds the maximum number of 4.");
                    return;
                }

                //Add value of box to individual score
                scores[j] += ctr_individual[i].SelectedIndex;
            }

            //Calculate maximum value and position of said value
            int max = scores.Max();
            int mPos = Array.IndexOf(scores, max);

            //Use the array to gather the winning individual
            string winningIndividual = individualNames[mPos - 1];

            //Output the winning individual and return
            MessageBox.Show("The person " + winningIndividual + " won with a score of " + max.ToString());
            return;

        }

        private void btn_exportData_Click(object sender, EventArgs e)
        {

            //GATHER DATA

            // Input Validation
            if (txt_individualName_1.Text == "" || txt_individualName_2.Text == "" || txt_individualName_3.Text == "" || txt_individualName_4.Text == "" || txt_individualName_5.Text == "" || txt_individualName_6.Text == "" || txt_individualName_7.Text == "" || txt_individualName_8.Text == "" || txt_individualName_9.Text == "" || txt_individualName_10.Text == "")
            {
                MessageBox.Show("One of the individual names is invalid, please check them.");
                return;
            }

            //Convert individual names to Array
            string[] individualNames = { txt_individualName_1.Text, txt_individualName_2.Text, txt_individualName_3.Text, txt_individualName_4.Text, txt_individualName_5.Text, txt_individualName_6.Text, txt_individualName_7.Text, txt_individualName_8.Text, txt_individualName_9.Text, txt_individualName_10.Text };

            //Setup array for scores
            string[] scores = { "", "", "", "", "", "", "", "", "", "", "" };
            int j = 0;

            //For loop for every value
            for (int i = 0; i < NUMBEROFBOXES; i++)
            {
                //Every 5 boxes, move to next row (next individual)
                if (i % 5 == 0)
                {
                    j++;
                }

                //Check if 0
                if (ctr_individual[i].SelectedIndex == 0)
                {
                    MessageBox.Show("Cannot export any scores that contain 0");
                    return;
                }

                //Input Validation
                string value = ctr_individual[i].SelectedIndex.ToString();

                if (!Regex.IsMatch(value, @"^\d+$"))
                {
                    MessageBox.Show("One of the values is not a number or exceeds the maximum number of 4.");
                    return;
                }

                //Add value of box to individual score
                scores[j] = scores[j] + " " + ctr_individual[i].SelectedIndex.ToString();
            }

            // Open output file stream
            try
            {
                FileStream myFile = new FileStream("individual-export.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(myFile);

                //Save each individual name and scores to each line
                sw.WriteLine(individualNames[0]);
                sw.WriteLine(scores[1]);
                sw.WriteLine(individualNames[1]);
                sw.WriteLine(scores[2]);
                sw.WriteLine(individualNames[2]);
                sw.WriteLine(scores[3]);
                sw.WriteLine(individualNames[3]);
                sw.WriteLine(scores[4]);
                sw.WriteLine(individualNames[4]);
                sw.WriteLine(scores[5]);
                sw.WriteLine(individualNames[5]);
                sw.WriteLine(scores[6]);
                sw.WriteLine(individualNames[6]);
                sw.WriteLine(scores[7]);
                sw.WriteLine(individualNames[8]);
                sw.WriteLine(scores[8]);
                sw.WriteLine(individualNames[9]);
                sw.WriteLine(scores[9]);
                sw.WriteLine(individualNames[9]);
                sw.WriteLine(scores[10]);
                sw.Close();
            }
            catch
            {
                // Something went wrong!
                MessageBox.Show("Could not save to file - check file permissions");
                return;
            }

            // Success!
            MessageBox.Show("Data successfully saved to file!");
        }

        private void txt_importData_Click(object sender, EventArgs e)
        {

            //Values to input data onto
            string individualName_1, individualName_2, individualName_3, individualName_4, individualName_5, individualName_6, individualName_7, individualName_8, individualName_9, individualName_10;
            string score_1, score_2, score_3, score_4, score_5, score_6, score_7, score_8, score_9, score_10;

            //Attempt to fetch data from file
            try
            {
                FileStream myFile = new FileStream("individual-export.txt", FileMode.Open);
                StreamReader sr = new StreamReader(myFile);

                //Read each line for the values
                individualName_1 = sr.ReadLine();
                score_1 = sr.ReadLine();
                individualName_2 = sr.ReadLine();
                score_2 = sr.ReadLine();
                individualName_3 = sr.ReadLine();
                score_3 = sr.ReadLine();
                individualName_4 = sr.ReadLine();
                score_4 = sr.ReadLine();
                individualName_5 = sr.ReadLine();
                score_5 = sr.ReadLine();
                individualName_6 = sr.ReadLine();
                score_6= sr.ReadLine();
                individualName_7 = sr.ReadLine();
                score_7 = sr.ReadLine();
                individualName_8 = sr.ReadLine();
                score_8 = sr.ReadLine();
                individualName_9 = sr.ReadLine();
                score_9 = sr.ReadLine();
                individualName_10 = sr.ReadLine();
                score_10 = sr.ReadLine();
                sr.Close();
            }
            catch
            {
                // Something went wrong!
                MessageBox.Show("Could not load data from file - file is missing or corrupt");
                return;
            }

            //Convert scores into array
            string[] scores_1 = score_1.Split(' ');
            string[] scores_2 = score_2.Split(' ');
            string[] scores_3 = score_3.Split(' ');
            string[] scores_4 = score_4.Split(' ');
            string[] scores_5 = score_5.Split(' ');
            string[] scores_6 = score_6.Split(' ');
            string[] scores_7 = score_7.Split(' ');
            string[] scores_8 = score_8.Split(' ');
            string[] scores_9 = score_9.Split(' ');
            string[] scores_10 = score_10.Split(' ');

            // Input data to form
            // Individual Names
            txt_individualName_1.Text = individualName_1;
            txt_individualName_2.Text = individualName_2;
            txt_individualName_3.Text = individualName_3;
            txt_individualName_4.Text = individualName_4;
            txt_individualName_5.Text = individualName_5;
            txt_individualName_6.Text = individualName_6;
            txt_individualName_7.Text = individualName_7;
            txt_individualName_8.Text = individualName_8;
            txt_individualName_9.Text = individualName_9;
            txt_individualName_10.Text = individualName_10;

            //Scores
            int pos = 0;

            //Scores-1
            foreach (string number in scores_1)
            {
                if (number == "")
                {
                    //Do nothing cuz this is an empty string :)
                }
                else
                {
                    ctr_individual[pos].SelectedIndex = Int32.Parse(number);
                    pos++;
                }
            }
            //Scores-2
            foreach (string number in scores_2)
            {
                if (number == "")
                {
                    //Do nothing cuz this is an empty string :)
                }
                else
                {
                    ctr_individual[pos].SelectedIndex = Int32.Parse(number);
                    pos++;
                }
            }
            //Scores-3
            foreach (string number in scores_3)
            {
                if (number == "")
                {
                    //Do nothing cuz this is an empty string :)
                }
                else
                {
                    ctr_individual[pos].SelectedIndex = Int32.Parse(number);
                    pos++;
                }
            }
            //Scores-4
            foreach (string number in scores_4)
            {
                if (number == "")
                {
                    //Do nothing cuz this is an empty string :)
                }
                else
                {
                    ctr_individual[pos].SelectedIndex = Int32.Parse(number);
                    pos++;
                }
            }
            //Scores-5
            foreach (string number in scores_5)
            {
                if (number == "")
                {
                    //Do nothing cuz this is an empty string :)
                }
                else
                {
                    ctr_individual[pos].SelectedIndex = Int32.Parse(number);
                    pos++;
                }
            }
            //Scores-6
            foreach (string number in scores_6)
            {
                if (number == "")
                {
                    //Do nothing cuz this is an empty string :)
                }
                else
                {
                    ctr_individual[pos].SelectedIndex = Int32.Parse(number);
                    pos++;
                }
            }
            //Scores-7
            foreach (string number in scores_7)
            {
                if (number == "")
                {
                    //Do nothing cuz this is an empty string :)
                }
                else
                {
                    ctr_individual[pos].SelectedIndex = Int32.Parse(number);
                    pos++;
                }
            }
            //Scores-8
            foreach (string number in scores_8)
            {
                if (number == "")
                {
                    //Do nothing cuz this is an empty string :)
                }
                else
                {
                    ctr_individual[pos].SelectedIndex = Int32.Parse(number);
                    pos++;
                }
            }
            //Scores-9
            foreach (string number in scores_9)
            {
                if (number == "")
                {
                    //Do nothing cuz this is an empty string :)
                }
                else
                {
                    ctr_individual[pos].SelectedIndex = Int32.Parse(number);
                    pos++;
                }
            }
            //Scores-10
            foreach (string number in scores_10)
            {
                if (number == "")
                {
                    //Do nothing cuz this is an empty string :)
                }
                else
                {
                    ctr_individual[pos].SelectedIndex = Int32.Parse(number);
                    pos++;
                }
            }

            // Successfully read data
            MessageBox.Show("Successfully read data from file");

        }

        private void btn_switchToTeam_Click(object sender, EventArgs e)
        {
            // Message pop-up to confirm
            DialogResult dialogresult = MessageBox.Show("Are you sure you would like to switch to Team Scores? This will erase all data so make sure to export the data.", "Switch to Team Scores", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                //If yes, switch to individual form
                teamForm.Show();
                this.Hide();
            }
            else if (dialogresult == DialogResult.No)
            {
                //Return nothing as the event has been cancelled
                return;
            }
        }
    }
    }
