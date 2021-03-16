
namespace CollegeTournament
{
    partial class IndividualForm
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
            this.txt_importData = new System.Windows.Forms.Button();
            this.btn_exportData = new System.Windows.Forms.Button();
            this.btn_switchToTeam = new System.Windows.Forms.Button();
            this.btn_calculateWinner = new System.Windows.Forms.Button();
            this.btn_resetScores = new System.Windows.Forms.Button();
            this.lbl_teamScores = new System.Windows.Forms.Label();
            this.lbl_individualNames = new System.Windows.Forms.Label();
            this.txt_individualName_4 = new System.Windows.Forms.TextBox();
            this.txt_individualName_3 = new System.Windows.Forms.TextBox();
            this.txt_individualName_2 = new System.Windows.Forms.TextBox();
            this.txt_individualName_1 = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_individualName_8 = new System.Windows.Forms.TextBox();
            this.txt_individualName_7 = new System.Windows.Forms.TextBox();
            this.txt_individualName_6 = new System.Windows.Forms.TextBox();
            this.txt_individualName_5 = new System.Windows.Forms.TextBox();
            this.txt_individualName_10 = new System.Windows.Forms.TextBox();
            this.txt_individualName_9 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_importData
            // 
            this.txt_importData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_importData.Location = new System.Drawing.Point(469, 612);
            this.txt_importData.Name = "txt_importData";
            this.txt_importData.Size = new System.Drawing.Size(128, 62);
            this.txt_importData.TabIndex = 43;
            this.txt_importData.Text = "Import Data";
            this.txt_importData.UseVisualStyleBackColor = true;
            this.txt_importData.Click += new System.EventHandler(this.txt_importData_Click);
            // 
            // btn_exportData
            // 
            this.btn_exportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportData.Location = new System.Drawing.Point(319, 612);
            this.btn_exportData.Name = "btn_exportData";
            this.btn_exportData.Size = new System.Drawing.Size(128, 62);
            this.btn_exportData.TabIndex = 42;
            this.btn_exportData.Text = "Export Data";
            this.btn_exportData.UseVisualStyleBackColor = true;
            this.btn_exportData.Click += new System.EventHandler(this.btn_exportData_Click);
            // 
            // btn_switchToTeam
            // 
            this.btn_switchToTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_switchToTeam.Location = new System.Drawing.Point(1091, 612);
            this.btn_switchToTeam.Name = "btn_switchToTeam";
            this.btn_switchToTeam.Size = new System.Drawing.Size(155, 62);
            this.btn_switchToTeam.TabIndex = 41;
            this.btn_switchToTeam.Text = "Team\r\nEvents";
            this.btn_switchToTeam.UseVisualStyleBackColor = true;
            this.btn_switchToTeam.Click += new System.EventHandler(this.btn_switchToTeam_Click);
            // 
            // btn_calculateWinner
            // 
            this.btn_calculateWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculateWinner.Location = new System.Drawing.Point(169, 612);
            this.btn_calculateWinner.Name = "btn_calculateWinner";
            this.btn_calculateWinner.Size = new System.Drawing.Size(128, 62);
            this.btn_calculateWinner.TabIndex = 40;
            this.btn_calculateWinner.Text = "Calculate Winner";
            this.btn_calculateWinner.UseVisualStyleBackColor = true;
            this.btn_calculateWinner.Click += new System.EventHandler(this.btn_calculateWinner_Click_1);
            // 
            // btn_resetScores
            // 
            this.btn_resetScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetScores.Location = new System.Drawing.Point(19, 612);
            this.btn_resetScores.Name = "btn_resetScores";
            this.btn_resetScores.Size = new System.Drawing.Size(128, 62);
            this.btn_resetScores.TabIndex = 39;
            this.btn_resetScores.Text = "Reset Scores";
            this.btn_resetScores.UseVisualStyleBackColor = true;
            this.btn_resetScores.Click += new System.EventHandler(this.btn_resetScores_Click_1);
            // 
            // lbl_teamScores
            // 
            this.lbl_teamScores.AutoSize = true;
            this.lbl_teamScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(230)))));
            this.lbl_teamScores.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teamScores.Location = new System.Drawing.Point(509, 66);
            this.lbl_teamScores.Name = "lbl_teamScores";
            this.lbl_teamScores.Size = new System.Drawing.Size(391, 39);
            this.lbl_teamScores.TabIndex = 38;
            this.lbl_teamScores.Text = "Scores (Heirachy of Winning)";
            // 
            // lbl_individualNames
            // 
            this.lbl_individualNames.AutoSize = true;
            this.lbl_individualNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(230)))));
            this.lbl_individualNames.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_individualNames.Location = new System.Drawing.Point(56, 66);
            this.lbl_individualNames.Name = "lbl_individualNames";
            this.lbl_individualNames.Size = new System.Drawing.Size(241, 39);
            this.lbl_individualNames.TabIndex = 37;
            this.lbl_individualNames.Text = "Individual Names";
            // 
            // txt_individualName_4
            // 
            this.txt_individualName_4.AcceptsTab = true;
            this.txt_individualName_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_individualName_4.Font = new System.Drawing.Font("Calibri", 18F);
            this.txt_individualName_4.Location = new System.Drawing.Point(63, 246);
            this.txt_individualName_4.MaxLength = 20;
            this.txt_individualName_4.Name = "txt_individualName_4";
            this.txt_individualName_4.Size = new System.Drawing.Size(392, 37);
            this.txt_individualName_4.TabIndex = 36;
            // 
            // txt_individualName_3
            // 
            this.txt_individualName_3.AcceptsTab = true;
            this.txt_individualName_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_individualName_3.Font = new System.Drawing.Font("Calibri", 18F);
            this.txt_individualName_3.Location = new System.Drawing.Point(63, 203);
            this.txt_individualName_3.MaxLength = 20;
            this.txt_individualName_3.Name = "txt_individualName_3";
            this.txt_individualName_3.Size = new System.Drawing.Size(392, 37);
            this.txt_individualName_3.TabIndex = 35;
            // 
            // txt_individualName_2
            // 
            this.txt_individualName_2.AcceptsTab = true;
            this.txt_individualName_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_individualName_2.Font = new System.Drawing.Font("Calibri", 18F);
            this.txt_individualName_2.Location = new System.Drawing.Point(63, 160);
            this.txt_individualName_2.MaxLength = 20;
            this.txt_individualName_2.Name = "txt_individualName_2";
            this.txt_individualName_2.Size = new System.Drawing.Size(392, 37);
            this.txt_individualName_2.TabIndex = 34;
            // 
            // txt_individualName_1
            // 
            this.txt_individualName_1.AcceptsTab = true;
            this.txt_individualName_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_individualName_1.Font = new System.Drawing.Font("Calibri", 18F);
            this.txt_individualName_1.Location = new System.Drawing.Point(63, 117);
            this.txt_individualName_1.MaxLength = 20;
            this.txt_individualName_1.Name = "txt_individualName_1";
            this.txt_individualName_1.Size = new System.Drawing.Size(392, 37);
            this.txt_individualName_1.TabIndex = 33;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(420, 2);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(498, 42);
            this.lbl_title.TabIndex = 32;
            this.lbl_title.Text = "Scoring System - Individual Events";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_individualName_8
            // 
            this.txt_individualName_8.AcceptsTab = true;
            this.txt_individualName_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_individualName_8.Font = new System.Drawing.Font("Calibri", 18F);
            this.txt_individualName_8.Location = new System.Drawing.Point(63, 418);
            this.txt_individualName_8.MaxLength = 20;
            this.txt_individualName_8.Name = "txt_individualName_8";
            this.txt_individualName_8.Size = new System.Drawing.Size(392, 37);
            this.txt_individualName_8.TabIndex = 47;
            // 
            // txt_individualName_7
            // 
            this.txt_individualName_7.AcceptsTab = true;
            this.txt_individualName_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_individualName_7.Font = new System.Drawing.Font("Calibri", 18F);
            this.txt_individualName_7.Location = new System.Drawing.Point(63, 375);
            this.txt_individualName_7.MaxLength = 20;
            this.txt_individualName_7.Name = "txt_individualName_7";
            this.txt_individualName_7.Size = new System.Drawing.Size(392, 37);
            this.txt_individualName_7.TabIndex = 46;
            // 
            // txt_individualName_6
            // 
            this.txt_individualName_6.AcceptsTab = true;
            this.txt_individualName_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_individualName_6.Font = new System.Drawing.Font("Calibri", 18F);
            this.txt_individualName_6.Location = new System.Drawing.Point(63, 332);
            this.txt_individualName_6.MaxLength = 20;
            this.txt_individualName_6.Name = "txt_individualName_6";
            this.txt_individualName_6.Size = new System.Drawing.Size(392, 37);
            this.txt_individualName_6.TabIndex = 45;
            // 
            // txt_individualName_5
            // 
            this.txt_individualName_5.AcceptsTab = true;
            this.txt_individualName_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_individualName_5.Font = new System.Drawing.Font("Calibri", 18F);
            this.txt_individualName_5.Location = new System.Drawing.Point(63, 289);
            this.txt_individualName_5.MaxLength = 20;
            this.txt_individualName_5.Name = "txt_individualName_5";
            this.txt_individualName_5.Size = new System.Drawing.Size(392, 37);
            this.txt_individualName_5.TabIndex = 44;
            // 
            // txt_individualName_10
            // 
            this.txt_individualName_10.AcceptsTab = true;
            this.txt_individualName_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_individualName_10.Font = new System.Drawing.Font("Calibri", 18F);
            this.txt_individualName_10.Location = new System.Drawing.Point(63, 504);
            this.txt_individualName_10.MaxLength = 20;
            this.txt_individualName_10.Name = "txt_individualName_10";
            this.txt_individualName_10.Size = new System.Drawing.Size(392, 37);
            this.txt_individualName_10.TabIndex = 49;
            // 
            // txt_individualName_9
            // 
            this.txt_individualName_9.AcceptsTab = true;
            this.txt_individualName_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_individualName_9.Font = new System.Drawing.Font("Calibri", 18F);
            this.txt_individualName_9.Location = new System.Drawing.Point(63, 461);
            this.txt_individualName_9.MaxLength = 20;
            this.txt_individualName_9.Name = "txt_individualName_9";
            this.txt_individualName_9.Size = new System.Drawing.Size(392, 37);
            this.txt_individualName_9.TabIndex = 48;
            // 
            // IndividualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CollegeTournament.Properties.Resources.UI_Design;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.txt_individualName_10);
            this.Controls.Add(this.txt_individualName_9);
            this.Controls.Add(this.txt_individualName_8);
            this.Controls.Add(this.txt_individualName_7);
            this.Controls.Add(this.txt_individualName_6);
            this.Controls.Add(this.txt_individualName_5);
            this.Controls.Add(this.txt_importData);
            this.Controls.Add(this.btn_exportData);
            this.Controls.Add(this.btn_switchToTeam);
            this.Controls.Add(this.btn_calculateWinner);
            this.Controls.Add(this.btn_resetScores);
            this.Controls.Add(this.lbl_teamScores);
            this.Controls.Add(this.lbl_individualNames);
            this.Controls.Add(this.txt_individualName_4);
            this.Controls.Add(this.txt_individualName_3);
            this.Controls.Add(this.txt_individualName_2);
            this.Controls.Add(this.txt_individualName_1);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IndividualForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scoring System";
            this.Load += new System.EventHandler(this.IndividualForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txt_importData;
        private System.Windows.Forms.Button btn_exportData;
        private System.Windows.Forms.Button btn_switchToTeam;
        private System.Windows.Forms.Button btn_calculateWinner;
        private System.Windows.Forms.Button btn_resetScores;
        private System.Windows.Forms.Label lbl_teamScores;
        private System.Windows.Forms.Label lbl_individualNames;
        private System.Windows.Forms.TextBox txt_individualName_4;
        private System.Windows.Forms.TextBox txt_individualName_3;
        private System.Windows.Forms.TextBox txt_individualName_2;
        private System.Windows.Forms.TextBox txt_individualName_1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_individualName_8;
        private System.Windows.Forms.TextBox txt_individualName_7;
        private System.Windows.Forms.TextBox txt_individualName_6;
        private System.Windows.Forms.TextBox txt_individualName_5;
        private System.Windows.Forms.TextBox txt_individualName_10;
        private System.Windows.Forms.TextBox txt_individualName_9;
    }
}