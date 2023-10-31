namespace AlarmClock._0._1
{
    partial class Form1
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
            this.Старт = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.StopVoz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Старт
            // 
            this.Старт.Location = new System.Drawing.Point(322, 12);
            this.Старт.Name = "Старт";
            this.Старт.Size = new System.Drawing.Size(75, 23);
            this.Старт.TabIndex = 1;
            this.Старт.Text = "Настройки";
            this.Старт.UseVisualStyleBackColor = true;
            this.Старт.Click += new System.EventHandler(this.button1_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(322, 41);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Основания";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(322, 70);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 23);
            this.AboutButton.TabIndex = 3;
            this.AboutButton.Text = "О програме";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ClockLabel
            // 
            this.ClockLabel.BackColor = System.Drawing.Color.Coral;
            this.ClockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClockLabel.Location = new System.Drawing.Point(13, 12);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(303, 81);
            this.ClockLabel.TabIndex = 4;
            this.ClockLabel.Text = "00:00:00";
            this.ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // StopVoz
            // 
            this.StopVoz.Location = new System.Drawing.Point(322, 100);
            this.StopVoz.Name = "StopVoz";
            this.StopVoz.Size = new System.Drawing.Size(75, 23);
            this.StopVoz.TabIndex = 5;
            this.StopVoz.Text = "Секунда мер";
            this.StopVoz.UseVisualStyleBackColor = true;
            this.StopVoz.Click += new System.EventHandler(this.StopVoz_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 126);
            this.Controls.Add(this.StopVoz);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.Старт);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Старт;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Button StopVoz;
    }
}

