using System;

namespace digital_clock
{
    partial class DigitalClock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.num1 = new System.Windows.Forms.PictureBox();
            this.num2 = new System.Windows.Forms.PictureBox();
            this.dash = new System.Windows.Forms.PictureBox();
            this.num3 = new System.Windows.Forms.PictureBox();
            this.num4 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).BeginInit();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.Transparent;
            this.num1.Image = global::digital_clock.Properties.Resources._0;
            this.num1.Location = new System.Drawing.Point(0, 0);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(17, 22);
            this.num1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.num1.TabIndex = 0;
            this.num1.TabStop = false;
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.Transparent;
            this.num2.Image = global::digital_clock.Properties.Resources._0;
            this.num2.Location = new System.Drawing.Point(17, 0);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(17, 22);
            this.num2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.num2.TabIndex = 1;
            this.num2.TabStop = false;
            // 
            // dash
            // 
            this.dash.BackColor = System.Drawing.Color.Transparent;
            this.dash.Image = global::digital_clock.Properties.Resources._;
            this.dash.Location = new System.Drawing.Point(34, 0);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(17, 22);
            this.dash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dash.TabIndex = 2;
            this.dash.TabStop = false;
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.Transparent;
            this.num3.Image = global::digital_clock.Properties.Resources._0;
            this.num3.Location = new System.Drawing.Point(51, 0);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(17, 22);
            this.num3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.num3.TabIndex = 3;
            this.num3.TabStop = false;
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.Transparent;
            this.num4.Image = global::digital_clock.Properties.Resources._0;
            this.num4.Location = new System.Drawing.Point(68, 0);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(17, 22);
            this.num4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.num4.TabIndex = 4;
            this.num4.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.dash);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "DigitalClock";
            this.Size = new System.Drawing.Size(111, 42);
            this.Load += new System.EventHandler(this.DigitalClock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            


        }

        #endregion

        private System.Windows.Forms.PictureBox num1;
        private System.Windows.Forms.PictureBox num2;
        private System.Windows.Forms.PictureBox dash;
        private System.Windows.Forms.PictureBox num3;
        private System.Windows.Forms.PictureBox num4;
        private System.Windows.Forms.Timer timer;
        
    }
}
