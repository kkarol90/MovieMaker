namespace MovieMaker.Controls
{
    partial class TrackControl
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
            this.panel_content = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(1, 1);
            this.panel_content.Margin = new System.Windows.Forms.Padding(0);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(421, 23);
            this.panel_content.TabIndex = 0;
            // 
            // Track
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel_content);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Track";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(423, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_content;
    }
}
