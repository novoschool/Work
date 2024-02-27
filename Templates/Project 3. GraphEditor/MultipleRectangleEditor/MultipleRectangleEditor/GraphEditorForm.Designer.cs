namespace MultipleRectangleEditor
{
    partial class GraphEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphEditorForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddRectangleButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteRectangleButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.toolStripContainer1.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphEditorForm_Paint);
            this.toolStripContainer1.ContentPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GraphEditorForm_MouseDown);
            this.toolStripContainer1.ContentPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraphEditorForm_MouseMove);
            this.toolStripContainer1.ContentPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GraphEditorForm_MouseUp);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRectangleButton,
            this.toolStripSeparator1,
            this.DeleteRectangleButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(136, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.CheckOnClick = true;
            this.AddRectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("AddRectangleButton.Image")));
            this.AddRectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(63, 22);
            this.AddRectangleButton.Text = "Добавить";
            this.AddRectangleButton.CheckedChanged += new System.EventHandler(this.AddRectangleButton_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // DeleteRectangleButton
            // 
            this.DeleteRectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRectangleButton.Image")));
            this.DeleteRectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteRectangleButton.Name = "DeleteRectangleButton";
            this.DeleteRectangleButton.Size = new System.Drawing.Size(55, 22);
            this.DeleteRectangleButton.Text = "Удалить";
            this.DeleteRectangleButton.Click += new System.EventHandler(this.DeleteRectangleButton_Click);
            // 
            // GraphEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "GraphEditorForm";
            this.Text = "Графический редактор";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphEditorForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GraphEditorForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraphEditorForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GraphEditorForm_MouseUp);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddRectangleButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton DeleteRectangleButton;
    }
}

