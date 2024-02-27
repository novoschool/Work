namespace AlarmClockApp
{
    partial class ClockForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.ClocklTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.BackColor = System.Drawing.Color.Black;
            this.DisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.DisplayLabel.Location = new System.Drawing.Point(12, 13);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(284, 80);
            this.DisplayLabel.TabIndex = 0;
            this.DisplayLabel.Text = "00:00:00";
            this.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(302, 12);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(91, 23);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Настройка";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(302, 41);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(91, 23);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Остановить";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(302, 70);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(91, 23);
            this.AboutButton.TabIndex = 3;
            this.AboutButton.Text = "О программе";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ClocklTimer
            // 
            this.ClocklTimer.Enabled = true;
            this.ClocklTimer.Interval = 1000;
            this.ClocklTimer.Tick += new System.EventHandler(this.ClocklTimer_Tick);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 107);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.DisplayLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClockForm";
            this.Text = "Часы-будильник";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Timer ClocklTimer;
    }
}

