namespace BestPaintFromPicaso
{
    partial class PaintForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPaint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPaint
            // 
            this.buttonPaint.Location = new System.Drawing.Point(724, 2);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(75, 61);
            this.buttonPaint.TabIndex = 0;
            this.buttonPaint.Text = "Go Draw";
            this.buttonPaint.UseVisualStyleBackColor = true;
            this.buttonPaint.Click += new System.EventHandler(this.buttonPaint_Click);
            this.buttonPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonPaint_Paint);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPaint);
            this.Name = "PaintForm";
            this.Text = "Paint";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonPaint;
    }
}