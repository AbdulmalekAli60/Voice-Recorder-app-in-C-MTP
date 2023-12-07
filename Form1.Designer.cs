namespace Voice_Recorder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TimerLabel = new System.Windows.Forms.Label();
            this.playPictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filesPictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.startRecordingPictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pauseRecordingPictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stopRecordingPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recoringStatusLable = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startRecordingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseRecordingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopRecordingPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TimerLabel.Location = new System.Drawing.Point(904, 39);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(42, 46);
            this.TimerLabel.TabIndex = 4;
            this.TimerLabel.Text = "0";
            // 
            // playPictureBox
            // 
            this.playPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playPictureBox.BackgroundImage")));
            this.playPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playPictureBox.Location = new System.Drawing.Point(440, 603);
            this.playPictureBox.Name = "playPictureBox";
            this.playPictureBox.Size = new System.Drawing.Size(127, 78);
            this.playPictureBox.TabIndex = 6;
            this.playPictureBox.TabStop = false;
            this.playPictureBox.Click += new System.EventHandler(this.playPictureBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(485, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Play";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(1349, 562);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Files";
            // 
            // filesPictureBox
            // 
            this.filesPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("filesPictureBox.BackgroundImage")));
            this.filesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.filesPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filesPictureBox.Location = new System.Drawing.Point(1324, 603);
            this.filesPictureBox.Name = "filesPictureBox";
            this.filesPictureBox.Size = new System.Drawing.Size(100, 78);
            this.filesPictureBox.TabIndex = 8;
            this.filesPictureBox.TabStop = false;
            this.filesPictureBox.Click += new System.EventHandler(this.filesPictureBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(1089, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Start recording";
            // 
            // startRecordingPictureBox
            // 
            this.startRecordingPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startRecordingPictureBox.BackgroundImage")));
            this.startRecordingPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.startRecordingPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startRecordingPictureBox.Location = new System.Drawing.Point(1107, 603);
            this.startRecordingPictureBox.Name = "startRecordingPictureBox";
            this.startRecordingPictureBox.Size = new System.Drawing.Size(110, 78);
            this.startRecordingPictureBox.TabIndex = 10;
            this.startRecordingPictureBox.TabStop = false;
            this.startRecordingPictureBox.Click += new System.EventHandler(this.startRecordingPictureBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(667, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pause";
            // 
            // pauseRecordingPictureBox
            // 
            this.pauseRecordingPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseRecordingPictureBox.BackgroundImage")));
            this.pauseRecordingPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pauseRecordingPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pauseRecordingPictureBox.Location = new System.Drawing.Point(653, 603);
            this.pauseRecordingPictureBox.Name = "pauseRecordingPictureBox";
            this.pauseRecordingPictureBox.Size = new System.Drawing.Size(118, 78);
            this.pauseRecordingPictureBox.TabIndex = 12;
            this.pauseRecordingPictureBox.TabStop = false;
            this.pauseRecordingPictureBox.Click += new System.EventHandler(this.pauseRecordingPictureBox_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stopRecordingPictureBox
            // 
            this.stopRecordingPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopRecordingPictureBox.BackgroundImage")));
            this.stopRecordingPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stopRecordingPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopRecordingPictureBox.Location = new System.Drawing.Point(876, 603);
            this.stopRecordingPictureBox.Name = "stopRecordingPictureBox";
            this.stopRecordingPictureBox.Size = new System.Drawing.Size(114, 78);
            this.stopRecordingPictureBox.TabIndex = 14;
            this.stopRecordingPictureBox.TabStop = false;
            this.stopRecordingPictureBox.Click += new System.EventHandler(this.stopRecordingPictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(907, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "stop";
            // 
            // recoringStatusLable
            // 
            this.recoringStatusLable.AutoSize = true;
            this.recoringStatusLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoringStatusLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.recoringStatusLable.Location = new System.Drawing.Point(459, 39);
            this.recoringStatusLable.Name = "recoringStatusLable";
            this.recoringStatusLable.Size = new System.Drawing.Size(133, 46);
            this.recoringStatusLable.TabIndex = 16;
            this.recoringStatusLable.Text = "Status";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(-2, 85);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(394, 629);
            this.listBox1.TabIndex = 17;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 84);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(67, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Previus Recordings ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1471, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.recoringStatusLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopRecordingPictureBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pauseRecordingPictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startRecordingPictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filesPictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playPictureBox);
            this.Controls.Add(this.TimerLabel);
            this.Name = "Form1";
            this.Text = "Voice Recorder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startRecordingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseRecordingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopRecordingPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.PictureBox playPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox filesPictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox startRecordingPictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pauseRecordingPictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox stopRecordingPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label recoringStatusLable;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

