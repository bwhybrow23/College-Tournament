namespace CollegeTournament
{
    partial class teamForm
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_teamName_1 = new System.Windows.Forms.TextBox();
            this.txt_teamName_2 = new System.Windows.Forms.TextBox();
            this.txt_teamName_3 = new System.Windows.Forms.TextBox();
            this.txt_teamName_4 = new System.Windows.Forms.TextBox();
            this.lbl_teamNames = new System.Windows.Forms.Label();
            this.lbl_teamScores = new System.Windows.Forms.Label();
            this.btn_resetScores = new System.Windows.Forms.Button();
            this.btn_calculateWinner = new System.Windows.Forms.Button();
            this.btn_switchToIndividual = new System.Windows.Forms.Button();
            this.btn_exportData = new System.Windows.Forms.Button();
            this.txt_importData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(420, 2);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(436, 42);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Scoring System - Team Events";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_teamName_1
            // 
            this.txt_teamName_1.AcceptsTab = true;
            this.txt_teamName_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_teamName_1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_teamName_1.Location = new System.Drawing.Point(69, 147);
            this.txt_teamName_1.MaxLength = 20;
            this.txt_teamName_1.Name = "txt_teamName_1";
            this.txt_teamName_1.Size = new System.Drawing.Size(392, 47);
            this.txt_teamName_1.TabIndex = 1;
            // 
            // txt_teamName_2
            // 
            this.txt_teamName_2.AcceptsTab = true;
            this.txt_teamName_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_teamName_2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_teamName_2.Location = new System.Drawing.Point(69, 237);
            this.txt_teamName_2.MaxLength = 20;
            this.txt_teamName_2.Name = "txt_teamName_2";
            this.txt_teamName_2.Size = new System.Drawing.Size(392, 47);
            this.txt_teamName_2.TabIndex = 2;
            // 
            // txt_teamName_3
            // 
            this.txt_teamName_3.AcceptsTab = true;
            this.txt_teamName_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_teamName_3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_teamName_3.Location = new System.Drawing.Point(69, 327);
            this.txt_teamName_3.MaxLength = 20;
            this.txt_teamName_3.Name = "txt_teamName_3";
            this.txt_teamName_3.Size = new System.Drawing.Size(392, 47);
            this.txt_teamName_3.TabIndex = 3;
            // 
            // txt_teamName_4
            // 
            this.txt_teamName_4.AcceptsTab = true;
            this.txt_teamName_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_teamName_4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_teamName_4.Location = new System.Drawing.Point(69, 417);
            this.txt_teamName_4.MaxLength = 20;
            this.txt_teamName_4.Name = "txt_teamName_4";
            this.txt_teamName_4.Size = new System.Drawing.Size(392, 47);
            this.txt_teamName_4.TabIndex = 4;
            // 
            // lbl_teamNames
            // 
            this.lbl_teamNames.AutoSize = true;
            this.lbl_teamNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(230)))));
            this.lbl_teamNames.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teamNames.Location = new System.Drawing.Point(67, 98);
            this.lbl_teamNames.Name = "lbl_teamNames";
            this.lbl_teamNames.Size = new System.Drawing.Size(185, 39);
            this.lbl_teamNames.TabIndex = 5;
            this.lbl_teamNames.Text = "Team Names";
            // 
            // lbl_teamScores
            // 
            this.lbl_teamScores.AutoSize = true;
            this.lbl_teamScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(230)))));
            this.lbl_teamScores.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teamScores.Location = new System.Drawing.Point(517, 98);
            this.lbl_teamScores.Name = "lbl_teamScores";
            this.lbl_teamScores.Size = new System.Drawing.Size(391, 39);
            this.lbl_teamScores.TabIndex = 6;
            this.lbl_teamScores.Text = "Scores (Heirachy of Winning)";
            // 
            // btn_resetScores
            // 
            this.btn_resetScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetScores.Location = new System.Drawing.Point(25, 607);
            this.btn_resetScores.Name = "btn_resetScores";
            this.btn_resetScores.Size = new System.Drawing.Size(128, 62);
            this.btn_resetScores.TabIndex = 27;
            this.btn_resetScores.Text = "Reset Scores";
            this.btn_resetScores.UseVisualStyleBackColor = true;
            this.btn_resetScores.Click += new System.EventHandler(this.btn_resetScores_Click);
            // 
            // btn_calculateWinner
            // 
            this.btn_calculateWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculateWinner.Location = new System.Drawing.Point(175, 607);
            this.btn_calculateWinner.Name = "btn_calculateWinner";
            this.btn_calculateWinner.Size = new System.Drawing.Size(128, 62);
            this.btn_calculateWinner.TabIndex = 28;
            this.btn_calculateWinner.Text = "Calculate Winner";
            this.btn_calculateWinner.UseVisualStyleBackColor = true;
            this.btn_calculateWinner.Click += new System.EventHandler(this.btn_calculateWinner_Click);
            // 
            // btn_switchToIndividual
            // 
            this.btn_switchToIndividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_switchToIndividual.Location = new System.Drawing.Point(1097, 607);
            this.btn_switchToIndividual.Name = "btn_switchToIndividual";
            this.btn_switchToIndividual.Size = new System.Drawing.Size(155, 62);
            this.btn_switchToIndividual.TabIndex = 29;
            this.btn_switchToIndividual.Text = "Individual Events";
            this.btn_switchToIndividual.UseVisualStyleBackColor = true;
            this.btn_switchToIndividual.Click += new System.EventHandler(this.btn_switchToIndividual_Click);
            // 
            // btn_exportData
            // 
            this.btn_exportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportData.Location = new System.Drawing.Point(325, 607);
            this.btn_exportData.Name = "btn_exportData";
            this.btn_exportData.Size = new System.Drawing.Size(128, 62);
            this.btn_exportData.TabIndex = 30;
            this.btn_exportData.Text = "Export Data";
            this.btn_exportData.UseVisualStyleBackColor = true;
            this.btn_exportData.Click += new System.EventHandler(this.btn_exportData_Click);
            // 
            // txt_importData
            // 
            this.txt_importData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_importData.Location = new System.Drawing.Point(475, 607);
            this.txt_importData.Name = "txt_importData";
            this.txt_importData.Size = new System.Drawing.Size(128, 62);
            this.txt_importData.TabIndex = 31;
            this.txt_importData.Text = "Import Data";
            this.txt_importData.UseVisualStyleBackColor = true;
            this.txt_importData.Click += new System.EventHandler(this.txt_importData_Click);
            // 
            // teamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CollegeTournament.Properties.Resources.UI_Design;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.txt_importData);
            this.Controls.Add(this.btn_exportData);
            this.Controls.Add(this.btn_switchToIndividual);
            this.Controls.Add(this.btn_calculateWinner);
            this.Controls.Add(this.btn_resetScores);
            this.Controls.Add(this.lbl_teamScores);
            this.Controls.Add(this.lbl_teamNames);
            this.Controls.Add(this.txt_teamName_4);
            this.Controls.Add(this.txt_teamName_3);
            this.Controls.Add(this.txt_teamName_2);
            this.Controls.Add(this.txt_teamName_1);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "teamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scoring System";
            this.Load += new System.EventHandler(this.teamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_teamName_1;
        private System.Windows.Forms.TextBox txt_teamName_2;
        private System.Windows.Forms.TextBox txt_teamName_3;
        private System.Windows.Forms.TextBox txt_teamName_4;
        private System.Windows.Forms.Label lbl_teamNames;
        private System.Windows.Forms.Label lbl_teamScores;
        private System.Windows.Forms.Button btn_resetScores;
        private System.Windows.Forms.Button btn_calculateWinner;
        private System.Windows.Forms.Button btn_switchToIndividual;
        private System.Windows.Forms.Button btn_exportData;
        private System.Windows.Forms.Button txt_importData;
    }
}

