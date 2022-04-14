namespace MovieMaker.Controls
{
    partial class MediaOrganizer
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
            this.lbl_media = new System.Windows.Forms.Label();
            this.sc_media = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_media = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sc_media)).BeginInit();
            this.sc_media.Panel1.SuspendLayout();
            this.sc_media.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Location = new System.Drawing.Point(3, 5);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(40, 13);
            this.lbl_media.TabIndex = 0;
            this.lbl_media.Text = "Tracks";
            // 
            // sc_media
            // 
            this.sc_media.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_media.Location = new System.Drawing.Point(0, 0);
            this.sc_media.Name = "sc_media";
            this.sc_media.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_media.Panel1
            // 
            this.sc_media.Panel1.Controls.Add(this.panel4);
            this.sc_media.Panel1.Controls.Add(this.panel3);
            this.sc_media.Size = new System.Drawing.Size(119, 496);
            this.sc_media.SplitterDistance = 465;
            this.sc_media.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lb_media);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 444);
            this.panel4.TabIndex = 1;
            // 
            // lb_media
            // 
            this.lb_media.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_media.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_media.FormattingEnabled = true;
            this.lb_media.ItemHeight = 12;
            this.lb_media.Location = new System.Drawing.Point(0, 0);
            this.lb_media.Name = "lb_media";
            this.lb_media.Size = new System.Drawing.Size(119, 444);
            this.lb_media.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_media);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 21);
            this.panel3.TabIndex = 0;
            // 
            // MediaOrganizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sc_media);
            this.Name = "MediaOrganizer";
            this.Size = new System.Drawing.Size(119, 496);
            this.sc_media.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_media)).EndInit();
            this.sc_media.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.SplitContainer sc_media;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox lb_media;
        private System.Windows.Forms.Panel panel3;
    }
}
