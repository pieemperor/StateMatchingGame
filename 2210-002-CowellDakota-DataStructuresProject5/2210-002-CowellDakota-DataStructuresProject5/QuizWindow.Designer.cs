namespace _2210_002_CowellDakota_DataStructuresProject5
{
    partial class QuizWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stateNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeRemainingLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statePictureBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.attemptsLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.endGameButton = new System.Windows.Forms.Button();
            this.capitalsListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userFeedbackLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statePictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is the capital of: ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.stateNameLabel);
            this.panel1.Location = new System.Drawing.Point(281, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 48);
            this.panel1.TabIndex = 1;
            // 
            // stateNameLabel
            // 
            this.stateNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateNameLabel.Location = new System.Drawing.Point(0, 0);
            this.stateNameLabel.Name = "stateNameLabel";
            this.stateNameLabel.Size = new System.Drawing.Size(254, 46);
            this.stateNameLabel.TabIndex = 0;
            this.stateNameLabel.Text = "New Hampshire";
            this.stateNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time Remaining";
            // 
            // timeRemainingLabel
            // 
            this.timeRemainingLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeRemainingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeRemainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeRemainingLabel.ForeColor = System.Drawing.Color.Red;
            this.timeRemainingLabel.Location = new System.Drawing.Point(0, 0);
            this.timeRemainingLabel.Name = "timeRemainingLabel";
            this.timeRemainingLabel.Size = new System.Drawing.Size(116, 56);
            this.timeRemainingLabel.TabIndex = 3;
            this.timeRemainingLabel.Text = "20";
            this.timeRemainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Attempts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Correct";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.timeRemainingLabel);
            this.panel2.Location = new System.Drawing.Point(80, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 58);
            this.panel2.TabIndex = 6;
            // 
            // statePictureBox
            // 
            this.statePictureBox.ImageLocation = "";
            this.statePictureBox.InitialImage = null;
            this.statePictureBox.Location = new System.Drawing.Point(281, 174);
            this.statePictureBox.Name = "statePictureBox";
            this.statePictureBox.Size = new System.Drawing.Size(256, 236);
            this.statePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.statePictureBox.TabIndex = 7;
            this.statePictureBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.attemptsLabel);
            this.panel3.Location = new System.Drawing.Point(102, 525);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(79, 44);
            this.panel3.TabIndex = 8;
            // 
            // attemptsLabel
            // 
            this.attemptsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attemptsLabel.Location = new System.Drawing.Point(0, 0);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(77, 42);
            this.attemptsLabel.TabIndex = 0;
            this.attemptsLabel.Text = "0";
            this.attemptsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correctLabel
            // 
            this.correctLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.correctLabel.Location = new System.Drawing.Point(0, 0);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(77, 42);
            this.correctLabel.TabIndex = 0;
            this.correctLabel.Text = "0";
            this.correctLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.correctLabel);
            this.panel4.Location = new System.Drawing.Point(361, 525);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(79, 44);
            this.panel4.TabIndex = 9;
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Location = new System.Drawing.Point(61, 583);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(166, 52);
            this.nextQuestionButton.TabIndex = 10;
            this.nextQuestionButton.Text = "Next Question";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // endGameButton
            // 
            this.endGameButton.Location = new System.Drawing.Point(319, 583);
            this.endGameButton.Name = "endGameButton";
            this.endGameButton.Size = new System.Drawing.Size(166, 52);
            this.endGameButton.TabIndex = 11;
            this.endGameButton.Text = "End Game";
            this.endGameButton.UseVisualStyleBackColor = true;
            this.endGameButton.Click += new System.EventHandler(this.endGameButton_Click);
            // 
            // capitalsListBox
            // 
            this.capitalsListBox.FormattingEnabled = true;
            this.capitalsListBox.ItemHeight = 25;
            this.capitalsListBox.Location = new System.Drawing.Point(570, 108);
            this.capitalsListBox.Name = "capitalsListBox";
            this.capitalsListBox.Size = new System.Drawing.Size(264, 529);
            this.capitalsListBox.TabIndex = 12;
            this.capitalsListBox.SelectedIndexChanged += new System.EventHandler(this.capitalsListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(596, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Select The Capital";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userFeedbackLabel
            // 
            this.userFeedbackLabel.AutoSize = true;
            this.userFeedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFeedbackLabel.Location = new System.Drawing.Point(22, 19);
            this.userFeedbackLabel.Name = "userFeedbackLabel";
            this.userFeedbackLabel.Size = new System.Drawing.Size(812, 42);
            this.userFeedbackLabel.TabIndex = 14;
            this.userFeedbackLabel.Text = "Incorrect! The Correct Answer is Massachusetts";
            this.userFeedbackLabel.Visible = false;
            // 
            // QuizWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 662);
            this.Controls.Add(this.userFeedbackLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.capitalsListBox);
            this.Controls.Add(this.endGameButton);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.statePictureBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuizWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Capitals Quiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuizWindow_FormClosed);
            this.Load += new System.EventHandler(this.QuizWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statePictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label stateNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeRemainingLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox statePictureBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label attemptsLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Button endGameButton;
        private System.Windows.Forms.ListBox capitalsListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label userFeedbackLabel;
    }
}

