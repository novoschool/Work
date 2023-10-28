namespace ClockApp
{
    partial class ClockApp
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
            this.displayLabel = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.infoProgramm = new System.Windows.Forms.Button();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.CheckAlarmActive = new System.Windows.Forms.Label();
            this.displayTime = new System.Windows.Forms.Label();
            this.timeKGDbutton = new System.Windows.Forms.Button();
            this.timeEKBbutton = new System.Windows.Forms.Button();
            this.TimeMskButton = new System.Windows.Forms.Button();
            this.timeSAMbutton = new System.Windows.Forms.Button();
            this.timeOMSbutton = new System.Windows.Forms.Button();
            this.timeIRKbutton = new System.Windows.Forms.Button();
            this.LabelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.BackColor = System.Drawing.Color.Black;
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabel.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.displayLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.displayLabel.Location = new System.Drawing.Point(12, 9);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(400, 135);
            this.displayLabel.TabIndex = 0;
            this.displayLabel.Text = "00:00:00";
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Black;
            this.settingsButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.settingsButton.Location = new System.Drawing.Point(418, 9);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(113, 36);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Black;
            this.stopButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.stopButton.Location = new System.Drawing.Point(416, 51);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(113, 51);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // infoProgramm
            // 
            this.infoProgramm.BackColor = System.Drawing.Color.Black;
            this.infoProgramm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoProgramm.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.infoProgramm.Location = new System.Drawing.Point(418, 108);
            this.infoProgramm.Name = "infoProgramm";
            this.infoProgramm.Size = new System.Drawing.Size(113, 36);
            this.infoProgramm.TabIndex = 3;
            this.infoProgramm.Text = "Info";
            this.infoProgramm.UseVisualStyleBackColor = false;
            this.infoProgramm.Click += new System.EventHandler(this.infoProgramm_Click);
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // CheckAlarmActive
            // 
            this.CheckAlarmActive.BackColor = System.Drawing.Color.Red;
            this.CheckAlarmActive.Location = new System.Drawing.Point(539, 10);
            this.CheckAlarmActive.Name = "CheckAlarmActive";
            this.CheckAlarmActive.Size = new System.Drawing.Size(34, 35);
            this.CheckAlarmActive.TabIndex = 4;
            this.CheckAlarmActive.Visible = false;
            // 
            // displayTime
            // 
            this.displayTime.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.displayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTime.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.displayTime.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.displayTime.Location = new System.Drawing.Point(12, 191);
            this.displayTime.Name = "displayTime";
            this.displayTime.Size = new System.Drawing.Size(400, 135);
            this.displayTime.TabIndex = 6;
            this.displayTime.Text = "00:00:00";
            this.displayTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeKGDbutton
            // 
            this.timeKGDbutton.BackColor = System.Drawing.Color.MistyRose;
            this.timeKGDbutton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeKGDbutton.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.timeKGDbutton.Location = new System.Drawing.Point(420, 288);
            this.timeKGDbutton.Name = "timeKGDbutton";
            this.timeKGDbutton.Size = new System.Drawing.Size(113, 36);
            this.timeKGDbutton.TabIndex = 9;
            this.timeKGDbutton.Text = "KGD";
            this.timeKGDbutton.UseVisualStyleBackColor = false;
            this.timeKGDbutton.Click += new System.EventHandler(this.timeKGDbutton_Click);
            // 
            // timeEKBbutton
            // 
            this.timeEKBbutton.BackColor = System.Drawing.Color.MistyRose;
            this.timeEKBbutton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeEKBbutton.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.timeEKBbutton.Location = new System.Drawing.Point(420, 244);
            this.timeEKBbutton.Name = "timeEKBbutton";
            this.timeEKBbutton.Size = new System.Drawing.Size(115, 38);
            this.timeEKBbutton.TabIndex = 8;
            this.timeEKBbutton.Text = "EKB";
            this.timeEKBbutton.UseVisualStyleBackColor = false;
            this.timeEKBbutton.Click += new System.EventHandler(this.timeEKBbutton_Click);
            // 
            // TimeMskButton
            // 
            this.TimeMskButton.BackColor = System.Drawing.Color.MistyRose;
            this.TimeMskButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeMskButton.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.TimeMskButton.Location = new System.Drawing.Point(420, 202);
            this.TimeMskButton.Name = "TimeMskButton";
            this.TimeMskButton.Size = new System.Drawing.Size(113, 36);
            this.TimeMskButton.TabIndex = 7;
            this.TimeMskButton.Text = "MSK";
            this.TimeMskButton.UseVisualStyleBackColor = false;
            this.TimeMskButton.Click += new System.EventHandler(this.TimeMskButton_Click);
            // 
            // timeSAMbutton
            // 
            this.timeSAMbutton.BackColor = System.Drawing.Color.MistyRose;
            this.timeSAMbutton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeSAMbutton.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.timeSAMbutton.Location = new System.Drawing.Point(542, 202);
            this.timeSAMbutton.Name = "timeSAMbutton";
            this.timeSAMbutton.Size = new System.Drawing.Size(113, 36);
            this.timeSAMbutton.TabIndex = 10;
            this.timeSAMbutton.Text = "SAM";
            this.timeSAMbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.timeSAMbutton.UseVisualStyleBackColor = false;
            this.timeSAMbutton.Click += new System.EventHandler(this.timeSAMbutton_Click);
            // 
            // timeOMSbutton
            // 
            this.timeOMSbutton.BackColor = System.Drawing.Color.MistyRose;
            this.timeOMSbutton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeOMSbutton.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.timeOMSbutton.Location = new System.Drawing.Point(542, 244);
            this.timeOMSbutton.Name = "timeOMSbutton";
            this.timeOMSbutton.Size = new System.Drawing.Size(113, 36);
            this.timeOMSbutton.TabIndex = 11;
            this.timeOMSbutton.Text = "OMS";
            this.timeOMSbutton.UseVisualStyleBackColor = false;
            this.timeOMSbutton.Click += new System.EventHandler(this.timeOMSbutton_Click);
            // 
            // timeIRKbutton
            // 
            this.timeIRKbutton.BackColor = System.Drawing.Color.MistyRose;
            this.timeIRKbutton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeIRKbutton.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.timeIRKbutton.Location = new System.Drawing.Point(542, 288);
            this.timeIRKbutton.Name = "timeIRKbutton";
            this.timeIRKbutton.Size = new System.Drawing.Size(113, 36);
            this.timeIRKbutton.TabIndex = 12;
            this.timeIRKbutton.Text = "IRK";
            this.timeIRKbutton.UseVisualStyleBackColor = false;
            this.timeIRKbutton.Click += new System.EventHandler(this.timeIRKbutton_Click);
            // 
            // LabelTime
            // 
            this.LabelTime.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LabelTime.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTime.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.LabelTime.Location = new System.Drawing.Point(13, 192);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(120, 30);
            this.LabelTime.TabIndex = 13;
            this.LabelTime.Text = "defalt ( NSK )";
            this.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClockApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(667, 339);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.timeIRKbutton);
            this.Controls.Add(this.timeOMSbutton);
            this.Controls.Add(this.timeSAMbutton);
            this.Controls.Add(this.timeKGDbutton);
            this.Controls.Add(this.timeEKBbutton);
            this.Controls.Add(this.TimeMskButton);
            this.Controls.Add(this.displayTime);
            this.Controls.Add(this.CheckAlarmActive);
            this.Controls.Add(this.infoProgramm);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.displayLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClockApp";
            this.Text = "Часы - будильник";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button infoProgramm;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label CheckAlarmActive;
        private System.Windows.Forms.Label displayTime;
        private System.Windows.Forms.Button timeKGDbutton;
        private System.Windows.Forms.Button timeEKBbutton;
        private System.Windows.Forms.Button TimeMskButton;
        private System.Windows.Forms.Button timeSAMbutton;
        private System.Windows.Forms.Button timeOMSbutton;
        private System.Windows.Forms.Button timeIRKbutton;
        private System.Windows.Forms.Label LabelTime;
    }
}

