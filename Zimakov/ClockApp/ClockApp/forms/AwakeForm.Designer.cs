namespace ClockApp.forms
{
    partial class AwakeForm
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
            this.AwakeLabel = new System.Windows.Forms.Label();
            this.AwakePictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AwakeTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AwakePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AwakeLabel
            // 
            this.AwakeLabel.BackColor = System.Drawing.Color.Snow;
            this.AwakeLabel.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AwakeLabel.Location = new System.Drawing.Point(0, 0);
            this.AwakeLabel.Name = "AwakeLabel";
            this.AwakeLabel.Size = new System.Drawing.Size(799, 124);
            this.AwakeLabel.TabIndex = 0;
            this.AwakeLabel.Text = "wake up wake up";
            this.AwakeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AwakePictureBox
            // 
            this.AwakePictureBox.Location = new System.Drawing.Point(13, 127);
            this.AwakePictureBox.Name = "AwakePictureBox";
            this.AwakePictureBox.Size = new System.Drawing.Size(775, 329);
            this.AwakePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AwakePictureBox.TabIndex = 1;
            this.AwakePictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(311, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Встал";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AwakeTimer
            // 
            this.AwakeTimer.Enabled = true;
            this.AwakeTimer.Interval = 5000;
            this.AwakeTimer.Tick += new System.EventHandler(this.AwakeTimer_Tick);
            // 
            // AwakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AwakePictureBox);
            this.Controls.Add(this.AwakeLabel);
            this.Name = "AwakeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AwakeForm";
            this.Load += new System.EventHandler(this.AwakeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AwakePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AwakeLabel;
        private System.Windows.Forms.PictureBox AwakePictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer AwakeTimer;
    }
}