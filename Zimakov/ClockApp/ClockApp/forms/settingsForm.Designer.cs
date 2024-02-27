namespace ClockApp.forms
{
    partial class settingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SoundCheckBox = new System.Windows.Forms.CheckBox();
            this.AlarmTimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AlarmCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время срабатывания";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(551, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SoundCheckBox
            // 
            this.SoundCheckBox.AutoSize = true;
            this.SoundCheckBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SoundCheckBox.Location = new System.Drawing.Point(16, 138);
            this.SoundCheckBox.Name = "SoundCheckBox";
            this.SoundCheckBox.Size = new System.Drawing.Size(171, 26);
            this.SoundCheckBox.TabIndex = 2;
            this.SoundCheckBox.Text = "Звуковой сигнал";
            this.SoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // AlarmTimeTextBox
            // 
            this.AlarmTimeTextBox.Location = new System.Drawing.Point(283, 25);
            this.AlarmTimeTextBox.Name = "AlarmTimeTextBox";
            this.AlarmTimeTextBox.Size = new System.Drawing.Size(230, 20);
            this.AlarmTimeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Напоминание";
            // 
            // AlarmCheckBox
            // 
            this.AlarmCheckBox.AutoSize = true;
            this.AlarmCheckBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlarmCheckBox.Location = new System.Drawing.Point(16, 106);
            this.AlarmCheckBox.Name = "AlarmCheckBox";
            this.AlarmCheckBox.Size = new System.Drawing.Size(207, 26);
            this.AlarmCheckBox.TabIndex = 5;
            this.AlarmCheckBox.Text = "Включить будильник";
            this.AlarmCheckBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(551, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(283, 67);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(230, 20);
            this.MessageTextBox.TabIndex = 7;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 176);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AlarmCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AlarmTimeTextBox);
            this.Controls.Add(this.SoundCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingsForm";
            this.Text = "settingsForm";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox SoundCheckBox;
        private System.Windows.Forms.TextBox AlarmTimeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AlarmCheckBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox MessageTextBox;
    }
}