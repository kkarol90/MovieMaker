namespace MovieMaker
{
    partial class TrackLine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_line = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_line
            // 
            this.panel_line.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_line.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_line.Location = new System.Drawing.Point(1, 1);
            this.panel_line.Name = "panel_line";
            this.panel_line.Size = new System.Drawing.Size(718, 24);
            this.panel_line.TabIndex = 0;
            // 
            // TrackLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel_line);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TrackLine";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(720, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_line;
    }
}
