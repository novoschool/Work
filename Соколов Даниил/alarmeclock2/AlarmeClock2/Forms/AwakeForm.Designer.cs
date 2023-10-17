namespace AlarmeClock2.Forms
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
            this.Awakebutton = new System.Windows.Forms.Button();
            this.AwakeLabel = new System.Windows.Forms.Label();
            this.AwakePicture = new System.Windows.Forms.PictureBox();
            this.AwakeTimer = new System.Windows.Forms.Timer(this.components);
            this.PostponeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AwakePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Awakebutton
            // 
            this.Awakebutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Awakebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Awakebutton.Location = new System.Drawing.Point(15, 404);
            this.Awakebutton.Name = "Awakebutton";
            this.Awakebutton.Size = new System.Drawing.Size(280, 102);
            this.Awakebutton.TabIndex = 0;
            this.Awakebutton.Text = "ПОН";
            this.Awakebutton.UseVisualStyleBackColor = true;
            this.Awakebutton.Click += new System.EventHandler(this.Awakebutton_Click);
            // 
            // AwakeLabel
            // 
            this.AwakeLabel.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AwakeLabel.Location = new System.Drawing.Point(12, 9);
            this.AwakeLabel.Name = "AwakeLabel";
            this.AwakeLabel.Size = new System.Drawing.Size(516, 24);
            this.AwakeLabel.TabIndex = 1;
            this.AwakeLabel.Text = "Wake Up";
            // 
            // AwakePicture
            // 
            this.AwakePicture.Location = new System.Drawing.Point(12, 36);
            this.AwakePicture.Name = "AwakePicture";
            this.AwakePicture.Size = new System.Drawing.Size(516, 362);
            this.AwakePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AwakePicture.TabIndex = 2;
            this.AwakePicture.TabStop = false;
            // 
            // AwakeTimer
            // 
            this.AwakeTimer.Enabled = true;
            this.AwakeTimer.Interval = 5000;
            this.AwakeTimer.Tick += new System.EventHandler(this.AwakeTimer_Tick_1);
            // 
            // PostponeButton
            // 
            this.PostponeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostponeButton.Location = new System.Drawing.Point(301, 404);
            this.PostponeButton.Name = "PostponeButton";
            this.PostponeButton.Size = new System.Drawing.Size(227, 102);
            this.PostponeButton.TabIndex = 3;
            this.PostponeButton.Text = "ОТЛОЖИТЬ";
            this.PostponeButton.UseVisualStyleBackColor = true;
            this.PostponeButton.Click += new System.EventHandler(this.PostponeButton_Click);
            // 
            // AwakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 518);
            this.ControlBox = false;
            this.Controls.Add(this.PostponeButton);
            this.Controls.Add(this.AwakePicture);
            this.Controls.Add(this.AwakeLabel);
            this.Controls.Add(this.Awakebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AwakeForm";
            this.Text = "PON";
            this.Load += new System.EventHandler(this.AwakeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AwakePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Awakebutton;
        private System.Windows.Forms.Label AwakeLabel;
        private System.Windows.Forms.PictureBox AwakePicture;
        private System.Windows.Forms.Timer AwakeTimer;
        private System.Windows.Forms.Button PostponeButton;
    }
}