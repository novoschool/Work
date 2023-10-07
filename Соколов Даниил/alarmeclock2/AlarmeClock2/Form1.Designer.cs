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
            this.StopButton = new System.Windows.Forms.Button();
            this.AbautButton = new System.Windows.Forms.Button();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
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
            this.DislayLable.Location = new System.Drawing.Point(12, 9);
            this.DislayLable.Name = "DislayLable";
            this.DislayLable.Size = new System.Drawing.Size(362, 136);
            this.DislayLable.TabIndex = 0;
            this.DislayLable.Text = "00:00:00";
            this.DislayLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DislayLable.Click += new System.EventHandler(this.DislayLable_Click);
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
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Maroon;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopButton.Location = new System.Drawing.Point(380, 53);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(107, 50);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Стоп";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
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
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 152);
            this.Controls.Add(this.AbautButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.DislayLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClockForm";
            this.Text = "Часики";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DislayLable;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button AbautButton;
        private System.Windows.Forms.Timer ClockTimer;
    }
}

