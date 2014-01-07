namespace theSnowBallGameGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlrName = new System.Windows.Forms.Button();
            this.txtPlrName = new System.Windows.Forms.TextBox();
            this.lblPlrSnowballs = new System.Windows.Forms.Label();
            this.lblPlrStrength = new System.Windows.Forms.Label();
            this.lblPlr = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRobName = new System.Windows.Forms.Button();
            this.txtRobName = new System.Windows.Forms.TextBox();
            this.lblRobSnowballs = new System.Windows.Forms.Label();
            this.lblRobStrength = new System.Windows.Forms.Label();
            this.lblRobot = new System.Windows.Forms.Label();
            this.lblPlrResponse1 = new System.Windows.Forms.Label();
            this.lblPlrResName = new System.Windows.Forms.Label();
            this.lblRobResName = new System.Windows.Forms.Label();
            this.lblRobResponse1 = new System.Windows.Forms.Label();
            this.lblPlrResponse2 = new System.Windows.Forms.Label();
            this.lblRobResponse2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDistance = new System.Windows.Forms.Label();
            this.btnMakeSnow = new System.Windows.Forms.Button();
            this.btnMoveCloser = new System.Windows.Forms.Button();
            this.btnMoveAway = new System.Windows.Forms.Button();
            this.btnThrowSnow = new System.Windows.Forms.Button();
            this.rtbInstructions = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(128, 24);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(199, 24);
            this.lblMainHeading.TabIndex = 0;
            this.lblMainHeading.Text = "The Snowball Game";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnPlrName);
            this.panel1.Controls.Add(this.txtPlrName);
            this.panel1.Controls.Add(this.lblPlrSnowballs);
            this.panel1.Controls.Add(this.lblPlrStrength);
            this.panel1.Controls.Add(this.lblPlr);
            this.panel1.Location = new System.Drawing.Point(33, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 86);
            this.panel1.TabIndex = 1;
            // 
            // btnPlrName
            // 
            this.btnPlrName.Location = new System.Drawing.Point(146, 5);
            this.btnPlrName.Name = "btnPlrName";
            this.btnPlrName.Size = new System.Drawing.Size(34, 23);
            this.btnPlrName.TabIndex = 4;
            this.btnPlrName.Text = "OK";
            this.btnPlrName.UseVisualStyleBackColor = true;
            this.btnPlrName.Click += new System.EventHandler(this.btnPlrName_Click);
            // 
            // txtPlrName
            // 
            this.txtPlrName.Location = new System.Drawing.Point(62, 7);
            this.txtPlrName.Name = "txtPlrName";
            this.txtPlrName.Size = new System.Drawing.Size(78, 20);
            this.txtPlrName.TabIndex = 3;
            // 
            // lblPlrSnowballs
            // 
            this.lblPlrSnowballs.AutoSize = true;
            this.lblPlrSnowballs.Location = new System.Drawing.Point(12, 60);
            this.lblPlrSnowballs.Name = "lblPlrSnowballs";
            this.lblPlrSnowballs.Size = new System.Drawing.Size(61, 13);
            this.lblPlrSnowballs.TabIndex = 2;
            this.lblPlrSnowballs.Text = "Snowballs: ";
            // 
            // lblPlrStrength
            // 
            this.lblPlrStrength.AutoSize = true;
            this.lblPlrStrength.Location = new System.Drawing.Point(12, 34);
            this.lblPlrStrength.Name = "lblPlrStrength";
            this.lblPlrStrength.Size = new System.Drawing.Size(53, 13);
            this.lblPlrStrength.TabIndex = 1;
            this.lblPlrStrength.Text = "Strength: ";
            // 
            // lblPlr
            // 
            this.lblPlr.AutoSize = true;
            this.lblPlr.Location = new System.Drawing.Point(12, 11);
            this.lblPlr.Name = "lblPlr";
            this.lblPlr.Size = new System.Drawing.Size(48, 13);
            this.lblPlr.TabIndex = 0;
            this.lblPlr.Text = "Player 1:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btnRobName);
            this.panel2.Controls.Add(this.txtRobName);
            this.panel2.Controls.Add(this.lblRobSnowballs);
            this.panel2.Controls.Add(this.lblRobStrength);
            this.panel2.Controls.Add(this.lblRobot);
            this.panel2.Location = new System.Drawing.Point(239, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 86);
            this.panel2.TabIndex = 2;
            // 
            // btnRobName
            // 
            this.btnRobName.Location = new System.Drawing.Point(141, 7);
            this.btnRobName.Name = "btnRobName";
            this.btnRobName.Size = new System.Drawing.Size(34, 23);
            this.btnRobName.TabIndex = 4;
            this.btnRobName.Text = "OK";
            this.btnRobName.UseVisualStyleBackColor = true;
            this.btnRobName.Click += new System.EventHandler(this.btnComName_Click);
            // 
            // txtRobName
            // 
            this.txtRobName.Location = new System.Drawing.Point(59, 8);
            this.txtRobName.Name = "txtRobName";
            this.txtRobName.Size = new System.Drawing.Size(78, 20);
            this.txtRobName.TabIndex = 3;
            // 
            // lblRobSnowballs
            // 
            this.lblRobSnowballs.AutoSize = true;
            this.lblRobSnowballs.Location = new System.Drawing.Point(11, 59);
            this.lblRobSnowballs.Name = "lblRobSnowballs";
            this.lblRobSnowballs.Size = new System.Drawing.Size(61, 13);
            this.lblRobSnowballs.TabIndex = 2;
            this.lblRobSnowballs.Text = "Snowballs: ";
            // 
            // lblRobStrength
            // 
            this.lblRobStrength.AutoSize = true;
            this.lblRobStrength.Location = new System.Drawing.Point(11, 33);
            this.lblRobStrength.Name = "lblRobStrength";
            this.lblRobStrength.Size = new System.Drawing.Size(53, 13);
            this.lblRobStrength.TabIndex = 1;
            this.lblRobStrength.Text = "Strength: ";
            // 
            // lblRobot
            // 
            this.lblRobot.AutoSize = true;
            this.lblRobot.Location = new System.Drawing.Point(11, 10);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(48, 13);
            this.lblRobot.TabIndex = 0;
            this.lblRobot.Text = "Player 2:";
            // 
            // lblPlrResponse1
            // 
            this.lblPlrResponse1.AutoSize = true;
            this.lblPlrResponse1.Location = new System.Drawing.Point(103, 9);
            this.lblPlrResponse1.Name = "lblPlrResponse1";
            this.lblPlrResponse1.Size = new System.Drawing.Size(0, 13);
            this.lblPlrResponse1.TabIndex = 3;
            // 
            // lblPlrResName
            // 
            this.lblPlrResName.AutoSize = true;
            this.lblPlrResName.Location = new System.Drawing.Point(19, 9);
            this.lblPlrResName.Name = "lblPlrResName";
            this.lblPlrResName.Size = new System.Drawing.Size(48, 13);
            this.lblPlrResName.TabIndex = 4;
            this.lblPlrResName.Text = "Player 1:";
            // 
            // lblRobResName
            // 
            this.lblRobResName.AutoSize = true;
            this.lblRobResName.Location = new System.Drawing.Point(18, 11);
            this.lblRobResName.Name = "lblRobResName";
            this.lblRobResName.Size = new System.Drawing.Size(48, 13);
            this.lblRobResName.TabIndex = 5;
            this.lblRobResName.Text = "Player 2:";
            // 
            // lblRobResponse1
            // 
            this.lblRobResponse1.AutoSize = true;
            this.lblRobResponse1.Location = new System.Drawing.Point(102, 11);
            this.lblRobResponse1.Name = "lblRobResponse1";
            this.lblRobResponse1.Size = new System.Drawing.Size(0, 13);
            this.lblRobResponse1.TabIndex = 6;
            // 
            // lblPlrResponse2
            // 
            this.lblPlrResponse2.AutoSize = true;
            this.lblPlrResponse2.Location = new System.Drawing.Point(103, 33);
            this.lblPlrResponse2.Name = "lblPlrResponse2";
            this.lblPlrResponse2.Size = new System.Drawing.Size(0, 13);
            this.lblPlrResponse2.TabIndex = 7;
            // 
            // lblRobResponse2
            // 
            this.lblRobResponse2.AutoSize = true;
            this.lblRobResponse2.Location = new System.Drawing.Point(102, 33);
            this.lblRobResponse2.Name = "lblRobResponse2";
            this.lblRobResponse2.Size = new System.Drawing.Size(0, 13);
            this.lblRobResponse2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPlrResponse2);
            this.panel3.Controls.Add(this.lblPlrResponse1);
            this.panel3.Controls.Add(this.lblPlrResName);
            this.panel3.Location = new System.Drawing.Point(73, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 57);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblRobResponse2);
            this.panel4.Controls.Add(this.lblRobResName);
            this.panel4.Controls.Add(this.lblRobResponse1);
            this.panel4.Location = new System.Drawing.Point(74, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 57);
            this.panel4.TabIndex = 10;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(169, 185);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(61, 15);
            this.lblDistance.TabIndex = 11;
            this.lblDistance.Text = "Distance: ";
            // 
            // btnMakeSnow
            // 
            this.btnMakeSnow.Location = new System.Drawing.Point(33, 383);
            this.btnMakeSnow.Name = "btnMakeSnow";
            this.btnMakeSnow.Size = new System.Drawing.Size(76, 51);
            this.btnMakeSnow.TabIndex = 12;
            this.btnMakeSnow.Text = "Make Snowball";
            this.btnMakeSnow.UseVisualStyleBackColor = true;
            this.btnMakeSnow.Click += new System.EventHandler(this.btnMakeSnow_Click);
            // 
            // btnMoveCloser
            // 
            this.btnMoveCloser.Location = new System.Drawing.Point(140, 383);
            this.btnMoveCloser.Name = "btnMoveCloser";
            this.btnMoveCloser.Size = new System.Drawing.Size(76, 51);
            this.btnMoveCloser.TabIndex = 13;
            this.btnMoveCloser.Text = "Move Closer";
            this.btnMoveCloser.UseVisualStyleBackColor = true;
            this.btnMoveCloser.Click += new System.EventHandler(this.btnMoveCloser_Click);
            // 
            // btnMoveAway
            // 
            this.btnMoveAway.Location = new System.Drawing.Point(240, 383);
            this.btnMoveAway.Name = "btnMoveAway";
            this.btnMoveAway.Size = new System.Drawing.Size(76, 51);
            this.btnMoveAway.TabIndex = 14;
            this.btnMoveAway.Text = "Move Away";
            this.btnMoveAway.UseVisualStyleBackColor = true;
            this.btnMoveAway.Click += new System.EventHandler(this.btnMoveAway_Click);
            // 
            // btnThrowSnow
            // 
            this.btnThrowSnow.Location = new System.Drawing.Point(341, 383);
            this.btnThrowSnow.Name = "btnThrowSnow";
            this.btnThrowSnow.Size = new System.Drawing.Size(76, 51);
            this.btnThrowSnow.TabIndex = 15;
            this.btnThrowSnow.Text = "Throw Snowball";
            this.btnThrowSnow.UseVisualStyleBackColor = true;
            this.btnThrowSnow.Click += new System.EventHandler(this.btnThrowSnow_Click);
            // 
            // rtbInstructions
            // 
            this.rtbInstructions.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInstructions.Location = new System.Drawing.Point(33, 173);
            this.rtbInstructions.Name = "rtbInstructions";
            this.rtbInstructions.Size = new System.Drawing.Size(384, 200);
            this.rtbInstructions.TabIndex = 16;
            this.rtbInstructions.Text = resources.GetString("rtbInstructions.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(450, 464);
            this.Controls.Add(this.rtbInstructions);
            this.Controls.Add(this.btnThrowSnow);
            this.Controls.Add(this.btnMoveAway);
            this.Controls.Add(this.btnMoveCloser);
            this.Controls.Add(this.btnMakeSnow);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMainHeading);
            this.Name = "Form1";
            this.Text = "The Snowball Game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlrSnowballs;
        private System.Windows.Forms.Label lblPlrStrength;
        private System.Windows.Forms.Label lblPlr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRobSnowballs;
        private System.Windows.Forms.Label lblRobStrength;
        private System.Windows.Forms.Label lblRobot;
        private System.Windows.Forms.Label lblPlrResponse1;
        private System.Windows.Forms.Label lblPlrResName;
        private System.Windows.Forms.Label lblRobResName;
        private System.Windows.Forms.Label lblRobResponse1;
        private System.Windows.Forms.Label lblPlrResponse2;
        private System.Windows.Forms.Label lblRobResponse2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Button btnMakeSnow;
        private System.Windows.Forms.Button btnMoveCloser;
        private System.Windows.Forms.Button btnMoveAway;
        private System.Windows.Forms.Button btnThrowSnow;
        private System.Windows.Forms.Button btnPlrName;
        private System.Windows.Forms.TextBox txtPlrName;
        private System.Windows.Forms.Button btnRobName;
        private System.Windows.Forms.TextBox txtRobName;
        private System.Windows.Forms.RichTextBox rtbInstructions;
    }
}

