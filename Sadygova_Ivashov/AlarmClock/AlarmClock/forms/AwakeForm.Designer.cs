namespace AlarmClock.forms
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
            this.AwakeButton = new System.Windows.Forms.Button();
            this.AwakePictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AwakePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AwakeLabel
            // 
            this.AwakeLabel.AutoSize = true;
            this.AwakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AwakeLabel.Location = new System.Drawing.Point(169, 9);
            this.AwakeLabel.Name = "AwakeLabel";
            this.AwakeLabel.Size = new System.Drawing.Size(200, 37);
            this.AwakeLabel.TabIndex = 0;
            this.AwakeLabel.Text = "Просыпайся!";
            this.AwakeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AwakeButton
            // 
            this.AwakeButton.Location = new System.Drawing.Point(223, 546);
            this.AwakeButton.Name = "AwakeButton";
            this.AwakeButton.Size = new System.Drawing.Size(102, 23);
            this.AwakeButton.TabIndex = 1;
            this.AwakeButton.Text = "Я проснулся";
            this.AwakeButton.UseVisualStyleBackColor = true;
            this.AwakeButton.Click += new System.EventHandler(this.AwakeButton_Click);
            // 
            // AwakePictureBox
            // 
            this.AwakePictureBox.Location = new System.Drawing.Point(12, 49);
            this.AwakePictureBox.Name = "AwakePictureBox";
            this.AwakePictureBox.Size = new System.Drawing.Size(527, 491);
            this.AwakePictureBox.TabIndex = 2;
            this.AwakePictureBox.TabStop = false;
            // 
            // AwakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 581);
            this.Controls.Add(this.AwakePictureBox);
            this.Controls.Add(this.AwakeButton);
            this.Controls.Add(this.AwakeLabel);
            this.Name = "AwakeForm";
            this.Text = "AwakeForm";
            this.Load += new System.EventHandler(this.AwakeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AwakePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AwakeLabel;
        private System.Windows.Forms.Button AwakeButton;
        private System.Windows.Forms.PictureBox AwakePictureBox;
        private System.Windows.Forms.Timer timer1;
    }
}