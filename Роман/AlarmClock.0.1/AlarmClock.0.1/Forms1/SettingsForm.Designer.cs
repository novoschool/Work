namespace AlarmClock._0._1.Forms1
{
    partial class SettingsForm
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
            this.AlarmCheckBox = new System.Windows.Forms.CheckBox();
            this.SoundCheckBox = new System.Windows.Forms.CheckBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.AlarmTimeTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AlarmCheckBox
            // 
            this.AlarmCheckBox.AutoSize = true;
            this.AlarmCheckBox.Location = new System.Drawing.Point(101, 64);
            this.AlarmCheckBox.Name = "AlarmCheckBox";
            this.AlarmCheckBox.Size = new System.Drawing.Size(126, 17);
            this.AlarmCheckBox.TabIndex = 0;
            this.AlarmCheckBox.Text = "Будильник включен";
            this.AlarmCheckBox.UseVisualStyleBackColor = true;
            // 
            // SoundCheckBox
            // 
            this.SoundCheckBox.AutoSize = true;
            this.SoundCheckBox.Location = new System.Drawing.Point(101, 87);
            this.SoundCheckBox.Name = "SoundCheckBox";
            this.SoundCheckBox.Size = new System.Drawing.Size(184, 17);
            this.SoundCheckBox.TabIndex = 1;
            this.SoundCheckBox.Text = "Будильник выключен навсегда";
            this.SoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(218, 124);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(137, 124);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButon_Click);
            // 
            // AlarmTimeTextBox
            // 
            this.AlarmTimeTextBox.Location = new System.Drawing.Point(101, 12);
            this.AlarmTimeTextBox.Name = "AlarmTimeTextBox";
            this.AlarmTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AlarmTimeTextBox.TabIndex = 4;
            this.AlarmTimeTextBox.Text = "апа";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(101, 38);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(192, 20);
            this.MessageTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Время работы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сообщение:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 159);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.AlarmTimeTextBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SoundCheckBox);
            this.Controls.Add(this.AlarmCheckBox);
            this.Name = "SettingsForm";
            this.Text = "Настройка";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AlarmCheckBox;
        private System.Windows.Forms.CheckBox SoundCheckBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox AlarmTimeTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}