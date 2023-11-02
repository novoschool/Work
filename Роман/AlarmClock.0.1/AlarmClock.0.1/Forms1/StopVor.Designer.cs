namespace AlarmClock._0._1.Forms1
{
    partial class StopVor
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
            this.Time = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Location = new System.Drawing.Point(109, 83);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(355, 116);
            this.Time.TabIndex = 0;
            this.Time.Text = "00:00:00";
            this.Time.UseVisualStyleBackColor = true;
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(244, 329);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Стар/Вык";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click_1);
            // 
            // StopVor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 377);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Time);
            this.Name = "StopVor";
            this.Text = "StopVor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Start;
    }
}