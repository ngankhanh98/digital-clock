namespace digital_clock
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Resume = new System.Windows.Forms.Button();
            this.nUD_min = new System.Windows.Forms.NumericUpDown();
            this.nUD_sec = new System.Windows.Forms.NumericUpDown();
            this.clock = new digital_clock.DigitalClock();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_sec)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(30, 190);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(133, 190);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Location = new System.Drawing.Point(230, 190);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(75, 23);
            this.btn_Pause.TabIndex = 2;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Resume
            // 
            this.btn_Resume.Location = new System.Drawing.Point(334, 190);
            this.btn_Resume.Name = "btn_Resume";
            this.btn_Resume.Size = new System.Drawing.Size(75, 23);
            this.btn_Resume.TabIndex = 3;
            this.btn_Resume.Text = "Resume";
            this.btn_Resume.UseVisualStyleBackColor = true;
            this.btn_Resume.Click += new System.EventHandler(this.btn_Resume_Click);
            // 
            // nUD_min
            // 
            this.nUD_min.Location = new System.Drawing.Point(141, 42);
            this.nUD_min.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nUD_min.Name = "nUD_min";
            this.nUD_min.Size = new System.Drawing.Size(39, 20);
            this.nUD_min.TabIndex = 5;
            // 
            // nUD_sec
            // 
            this.nUD_sec.Location = new System.Drawing.Point(225, 42);
            this.nUD_sec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nUD_sec.Name = "nUD_sec";
            this.nUD_sec.Size = new System.Drawing.Size(39, 20);
            this.nUD_sec.TabIndex = 6;
            // 
            // clock
            // 
            this.clock.Location = new System.Drawing.Point(135, 78);
            this.clock.Minute = 0;
            this.clock.Name = "clock";
            this.clock.Second = 0;
            this.clock.Size = new System.Drawing.Size(170, 44);
            this.clock.TabIndex = 4;
            this.clock.Value = "0:0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "sec";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nUD_sec);
            this.Controls.Add(this.nUD_min);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.btn_Resume);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_sec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Resume;
        private DigitalClock clock;
        private System.Windows.Forms.NumericUpDown nUD_min;
        private System.Windows.Forms.NumericUpDown nUD_sec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

