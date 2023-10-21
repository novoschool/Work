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
            this.TimerButtonStop = new System.Windows.Forms.Button();
            this.AbautButton = new System.Windows.Forms.Button();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            this.TimerButtonOn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DislayLable
            // 
            this.DislayLable.AllowDrop = true;
            this.DislayLable.AutoEllipsis = true;
            this.DislayLable.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DislayLable.Font = new System.Drawing.Font("MS Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DislayLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DislayLable.Location = new System.Drawing.Point(8, 7);
            this.DislayLable.Margin = new System.Windows.Forms.Padding(0);
            this.DislayLable.Name = "DislayLable";
            this.DislayLable.Size = new System.Drawing.Size(362, 137);
            this.DislayLable.TabIndex = 0;
            this.DislayLable.Text = "00:00:00";
            this.DislayLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DislayLable.UseMnemonic = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.OliveDrab;
            this.SettingsButton.Location = new System.Drawing.Point(380, 9);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(129, 30);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // TimerButtonStop
            // 
            this.TimerButtonStop.BackColor = System.Drawing.Color.Maroon;
            this.TimerButtonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerButtonStop.Location = new System.Drawing.Point(380, 52);
            this.TimerButtonStop.Name = "TimerButtonStop";
            this.TimerButtonStop.Size = new System.Drawing.Size(79, 50);
            this.TimerButtonStop.TabIndex = 2;
            this.TimerButtonStop.Text = "Стоп";
            this.TimerButtonStop.UseVisualStyleBackColor = false;
            this.TimerButtonStop.Click += new System.EventHandler(this.TimerButtonStop_Click);
            // 
            // AbautButton
            // 
            this.AbautButton.BackColor = System.Drawing.Color.OliveDrab;
            this.AbautButton.Location = new System.Drawing.Point(380, 115);
            this.AbautButton.Name = "AbautButton";
            this.AbautButton.Size = new System.Drawing.Size(129, 30);
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
            // TimerButtonOn
            // 
            this.TimerButtonOn.BackColor = System.Drawing.Color.Maroon;
            this.TimerButtonOn.Location = new System.Drawing.Point(465, 52);
            this.TimerButtonOn.Name = "TimerButtonOn";
            this.TimerButtonOn.Size = new System.Drawing.Size(44, 50);
            this.TimerButtonOn.TabIndex = 5;
            this.TimerButtonOn.Text = "Вкл Выкл";
            this.TimerButtonOn.UseVisualStyleBackColor = false;
            this.TimerButtonOn.Click += new System.EventHandler(this.TimerButtonOn_Click);
            // 
            // ClockForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(521, 153);
            this.Controls.Add(this.TimerButtonOn);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.AbautButton);
            this.Controls.Add(this.TimerButtonStop);
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
        private System.Windows.Forms.Button TimerButtonStop;
        private System.Windows.Forms.Button AbautButton;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button TimerButtonOn;
    }
}

