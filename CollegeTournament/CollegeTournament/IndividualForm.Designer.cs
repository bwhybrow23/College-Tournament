
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
            // 
            // lbl_teamScores
            // 
            this.lbl_teamScores.AutoSize = true;
            this.lbl_teamScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(230)))));
            this.lbl_teamScores.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teamScores.Location = new System.Drawing.Point(511, 103);
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
            this.lbl_individualNames.Location = new System.Drawing.Point(61, 103);
            this.lbl_individualNames.Name = "lbl_individualNames";
            this.lbl_individualNames.Size = new System.Drawing.Size(241, 39);
            this.lbl_individualNames.TabIndex = 37;
            this.lbl_individualNames.Text = "Individual Names";
            // 
            // txt_individualName_4
            // 
            this.txt_individualName_4.AcceptsTab = true;
            this.txt_individualName_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_individualName_4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_individualName_4.Location = new System.Drawing.Point(63, 422);
            this.txt_individualName_4.Name = "txt_individualName_4";
            this.txt_individualName_4.Size = new System.Drawing.Size(392, 47);
            this.txt_individualName_4.TabIndex = 36;
            // 
            // txt_individualName_3
            // 
            this.txt_individualName_3.AcceptsTab = true;
            this.txt_individualName_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_individualName_3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_individualName_3.Location = new System.Drawing.Point(63, 332);
            this.txt_individualName_3.Name = "txt_individualName_3";
            this.txt_individualName_3.Size = new System.Drawing.Size(392, 47);
            this.txt_individualName_3.TabIndex = 35;
            // 
            // txt_individualName_2
            // 
            this.txt_individualName_2.AcceptsTab = true;
            this.txt_individualName_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_individualName_2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_individualName_2.Location = new System.Drawing.Point(63, 242);
            this.txt_individualName_2.Name = "txt_individualName_2";
            this.txt_individualName_2.Size = new System.Drawing.Size(392, 47);
            this.txt_individualName_2.TabIndex = 34;
            // 
            // txt_individualName_1
            // 
            this.txt_individualName_1.AcceptsTab = true;
            this.txt_individualName_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_individualName_1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_individualName_1.Location = new System.Drawing.Point(63, 152);
            this.txt_individualName_1.Name = "txt_individualName_1";
            this.txt_individualName_1.Size = new System.Drawing.Size(392, 47);
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
            // IndividualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CollegeTournament.Properties.Resources.UI_Design;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
    }
}