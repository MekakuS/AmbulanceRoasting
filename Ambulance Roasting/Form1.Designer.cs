namespace Assignment3
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
            this.label1 = new System.Windows.Forms.Label();
            this.Officers = new System.Windows.Forms.Button();
            this.Ambulances = new System.Windows.Forms.Button();
            this.CheckRosters = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ambulance Staff Rostering System";
            // 
            // Officers
            // 
            this.Officers.BackColor = System.Drawing.Color.RoyalBlue;
            this.Officers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Officers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Officers.Location = new System.Drawing.Point(12, 55);
            this.Officers.Name = "Officers";
            this.Officers.Size = new System.Drawing.Size(243, 58);
            this.Officers.TabIndex = 1;
            this.Officers.Text = "Officers";
            this.Officers.UseVisualStyleBackColor = false;
            this.Officers.Click += new System.EventHandler(this.Officers_Click);
            // 
            // Ambulances
            // 
            this.Ambulances.BackColor = System.Drawing.Color.RoyalBlue;
            this.Ambulances.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Ambulances.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ambulances.Location = new System.Drawing.Point(12, 119);
            this.Ambulances.Name = "Ambulances";
            this.Ambulances.Size = new System.Drawing.Size(243, 58);
            this.Ambulances.TabIndex = 2;
            this.Ambulances.Text = "Ambulances";
            this.Ambulances.UseVisualStyleBackColor = false;
            this.Ambulances.Click += new System.EventHandler(this.Ambulances_Click);
            // 
            // CheckRosters
            // 
            this.CheckRosters.BackColor = System.Drawing.Color.RoyalBlue;
            this.CheckRosters.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.CheckRosters.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CheckRosters.Location = new System.Drawing.Point(12, 183);
            this.CheckRosters.Name = "CheckRosters";
            this.CheckRosters.Size = new System.Drawing.Size(243, 58);
            this.CheckRosters.TabIndex = 3;
            this.CheckRosters.Text = "Check Rosters";
            this.CheckRosters.UseVisualStyleBackColor = false;
            this.CheckRosters.Click += new System.EventHandler(this.CheckRosters_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.RoyalBlue;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(272, 233);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(243, 58);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(527, 303);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CheckRosters);
            this.Controls.Add(this.Ambulances);
            this.Controls.Add(this.Officers);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Officers;
        private System.Windows.Forms.Button Ambulances;
        private System.Windows.Forms.Button CheckRosters;
        private System.Windows.Forms.Button Exit;
    }
}

