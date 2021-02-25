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
    public partial class teamForm : Form
    {
        DomainUpDown[] ctr_team;
        const int NUMBEROFBOXES = 20;

        //Individual Form
        IndividualForm IndividualForm;

        public teamForm()
        {
            InitializeComponent();
            IndividualForm = new IndividualForm(this);
        }

        private void btn_resetScores_Click(object sender, EventArgs e)
        {
            // Message pop-up to confirm
            DialogResult dialogresult = MessageBox.Show("Are you sure you would like to reset all scores?", "Reset Scores", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                //If Yes is clicked on the pop-up, reset the scores                
                for(int i = 0; i < NUMBEROFBOXES; i++)
                {
                    ctr_team[i].SelectedIndex = 0;
                }
            }
            else if (dialogresult == DialogResult.No)
            {
                //Return nothing as the event has been cancelled
                return;
            }
        }

        private void teamForm_Load(object sender, EventArgs e)
        {
            //Declaration of values used
            int i, j;
            int yPos;

            ctr_team = new DomainUpDown[NUMBEROFBOXES];

            //For loop to create all boxes
                for (i = 0; i < NUMBEROFBOXES; i++)
                {
                yPos = 147 + (i / 5 * 90);
                ctr_team[i] = new DomainUpDown();
                ctr_team[i].Location = new Point(527 + (90 * (i % 5)), yPos);
                ctr_team[i].Width = 55;
                ctr_team[i].Font = new Font("Calibri", 24);

                for (j = 0; j <= 4; j++)
                {
                    ctr_team[i].Items.Add(j.ToString());
                }

                ctr_team[i].SelectedIndex = 0;
                ctr_team[i].Parent = this;
                }
            }

        private void btn_calculateWinner_Click(object sender, EventArgs e)
        {
            // Input Validation
            if(txt_teamName_1.Text == "" || txt_teamName_2.Text == "" || txt_teamName_3.Text == "" || txt_teamName_4.Text == "")
            {
                MessageBox.Show("One of the team names is invalid, please check them.");
                return;
            }

            //Convert TeamNames to Array
            string[] teamNames = { txt_teamName_1.Text, txt_teamName_2.Text, txt_teamName_3.Text, txt_teamName_4.Text };

            //Setup array for scores
            int[] teams = { 0, 0, 0, 0, 0 };
            int j = 0;

            //For loop for every value
            for (int i = 0; i < NUMBEROFBOXES; i++)
            {
                //Every 5 boxes, move to next row (next team)
                if(i % 5 == 0)
                {
                    j++;
                }

                //Check if 0
                if (ctr_team[i].SelectedIndex == 0)
                {
                    MessageBox.Show("None of the values can be 0");
                    return;
                }

                //Input Validation
                string value = ctr_team[i].SelectedIndex.ToString();

                if(!Regex.IsMatch(value, @"^\d+$"))
                {
                    MessageBox.Show("One of the values is not a number or exceeds the maximum number of 4.");
                    return;
                }

                //Add value of box to team score
                teams[j] += ctr_team[i].SelectedIndex;
            }

            //Calculate maximum value and position of said value
            int max = teams.Max();
            int mPos = Array.IndexOf(teams, max);

            //Use the array to gather the winning team
            string winningTeam = teamNames[mPos - 1];

            //Output the winning team and return
            MessageBox.Show("The Team " + winningTeam + " won with a score of " + max.ToString());
            return;

        }

        private void btn_exportData_Click(object sender, EventArgs e)
        {

            //GATHER DATA
            
            // Input Validation
            if (txt_teamName_1.Text == "" || txt_teamName_2.Text == "" || txt_teamName_3.Text == "" || txt_teamName_4.Text == "")
            {
                MessageBox.Show("One of the team names is invalid, please check them.");
                return;
            }

            //Convert TeamNames to Array
            string[] teamNames = { txt_teamName_1.Text, txt_teamName_2.Text, txt_teamName_3.Text, txt_teamName_4.Text };

            //Setup array for scores
            string[] teams = { "", "", "", "", "" };
            int j = 0;

            //For loop for every value
            for (int i = 0; i < NUMBEROFBOXES; i++)
            {
                //Every 5 boxes, move to next row (next team)
                if (i % 5 == 0)
                {
                    j++;
                }

                //Check if 0
                if(ctr_team[i].SelectedIndex == 0)
                {
                    MessageBox.Show("Cannot export any scores that contain 0");
                    return;
                }

                //Input Validation
                string value = ctr_team[i].SelectedIndex.ToString();

                if (!Regex.IsMatch(value, @"^\d+$"))
                {
                    MessageBox.Show("One of the values is not a number or exceeds the maximum number of 4.");
                    return;
                }

                //Add value of box to team score
                teams[j] = teams[j] + " " + ctr_team[i].SelectedIndex.ToString();
            }

            // Open output file stream
            try
            {
                FileStream myFile = new FileStream("teams-export.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(myFile);

                //Save each team name and scores to each line
                sw.WriteLine(teamNames[0]);
                sw.WriteLine(teams[1]);
                sw.WriteLine(teamNames[1]);
                sw.WriteLine(teams[2]);
                sw.WriteLine(teamNames[2]);
                sw.WriteLine(teams[3]);
                sw.WriteLine(teamNames[3]);
                sw.WriteLine(teams[4]);
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
            string teamName_1, teamName_2, teamName_3, teamName_4;
            string teams_1, teams_2, teams_3, teams_4;

            //Attempt to fetch data from file
            try
            {
                FileStream myFile = new FileStream("teams-export.txt", FileMode.Open);
                StreamReader sr = new StreamReader(myFile);

                //Read each line for the values
                teamName_1 = sr.ReadLine();
                teams_1 = sr.ReadLine();
                teamName_2 = sr.ReadLine();
                teams_2 = sr.ReadLine();
                teamName_3 = sr.ReadLine();
                teams_3 = sr.ReadLine();
                teamName_4 = sr.ReadLine();
                teams_4 = sr.ReadLine();
                sr.Close();
            }
            catch
            {
                // Something went wrong!
                MessageBox.Show("Could not load data from file - file is missing or corrupt");
                return;
            }

            //Convert team scores into array
            string[] scores_1 = teams_1.Split(' ');
            string[] scores_2 = teams_2.Split(' ');
            string[] scores_3 = teams_3.Split(' ');
            string[] scores_4 = teams_4.Split(' ');

            // Input data to form
            // Team Names
            txt_teamName_1.Text = teamName_1;
            txt_teamName_2.Text = teamName_2;
            txt_teamName_3.Text = teamName_3;
            txt_teamName_4.Text = teamName_4;

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
                    ctr_team[pos].SelectedIndex = Int32.Parse(number);
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
                    ctr_team[pos].SelectedIndex = Int32.Parse(number);
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
                    ctr_team[pos].SelectedIndex = Int32.Parse(number);
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
                    ctr_team[pos].SelectedIndex = Int32.Parse(number);
                    pos++;
                }
            }

            // Successfully read data
            MessageBox.Show("Successfully read data from file");

        }

        private void btn_switchToIndividual_Click(object sender, EventArgs e)
        {
            // Message pop-up to confirm
            DialogResult dialogresult = MessageBox.Show("Are you sure you would like to switch to Individual Scores? This will erase all data so make sure to export the data.", "Switch to Individual Scores", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                //If yes, switch to individual form
                IndividualForm.Show();
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
