namespace AlarmeClock2
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
            this.DislayLable = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.TimerButton = new System.Windows.Forms.Button();
            this.AbautButton = new System.Windows.Forms.Button();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DislayLable
            // 
            this.DislayLable.AllowDrop = true;
            this.DislayLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DislayLable.AutoEllipsis = true;
            this.DislayLable.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DislayLable.Font = new System.Drawing.Font("MS Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DislayLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DislayLable.Location = new System.Drawing.Point(15, 7);
            this.DislayLable.Margin = new System.Windows.Forms.Padding(0);
            this.DislayLable.Name = "DislayLable";
            this.DislayLable.Size = new System.Drawing.Size(362, 137);
            this.DislayLable.TabIndex = 0;
            this.DislayLable.Text = "00:00:00";
            this.DislayLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.OliveDrab;
            this.SettingsButton.Location = new System.Drawing.Point(380, 9);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(107, 30);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // TimerButton
            // 
            this.TimerButton.BackColor = System.Drawing.Color.Maroon;
            this.TimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerButton.Location = new System.Drawing.Point(380, 52);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(107, 50);
            this.TimerButton.TabIndex = 2;
            this.TimerButton.Text = "Старт";
            this.TimerButton.UseVisualStyleBackColor = false;
            this.TimerButton.Click += new System.EventHandler(this.TimerButton_Click);
            // 
            // AbautButton
            // 
            this.AbautButton.BackColor = System.Drawing.Color.OliveDrab;
            this.AbautButton.Location = new System.Drawing.Point(380, 115);
            this.AbautButton.Name = "AbautButton";
            this.AbautButton.Size = new System.Drawing.Size(107, 30);
            this.AbautButton.TabIndex = 3;
            this.AbautButton.Text = "О программе";
            this.AbautButton.UseVisualStyleBackColor = false;
            this.AbautButton.Click += new System.EventHandler(this.AbautButton_Click);
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // TimerLabel
            // 
            this.TimerLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TimerLabel.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TimerLabel.Location = new System.Drawing.Point(253, 115);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(106, 23);
            this.TimerLabel.TabIndex = 4;
            this.TimerLabel.Text = "00:00:00";
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 153);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.AbautButton);
            this.Controls.Add(this.TimerButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.DislayLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Часики";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DislayLable;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button TimerButton;
        private System.Windows.Forms.Button AbautButton;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Label TimerLabel;
    }
}

