namespace MovieMaker
{
    partial class Form1
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
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_test2 = new System.Windows.Forms.TextBox();
            this.tb_test1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_monitor = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.btn_rendo = new System.Windows.Forms.Button();
            this.btn_undo = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 631);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(992, 27);
            this.panel_bottom.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.panel_buttons);
            this.splitContainer1.Size = new System.Drawing.Size(992, 631);
            this.splitContainer1.SplitterDistance = 428;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tb_test2);
            this.panel4.Controls.Add(this.tb_test1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(792, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 387);
            this.panel4.TabIndex = 15;
            // 
            // tb_test2
            // 
            this.tb_test2.Location = new System.Drawing.Point(4, 33);
            this.tb_test2.Name = "tb_test2";
            this.tb_test2.Size = new System.Drawing.Size(196, 20);
            this.tb_test2.TabIndex = 1;
            // 
            // tb_test1
            // 
            this.tb_test1.Location = new System.Drawing.Point(4, 7);
            this.tb_test1.Name = "tb_test1";
            this.tb_test1.Size = new System.Drawing.Size(196, 20);
            this.tb_test1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_monitor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(166, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(826, 387);
            this.panel3.TabIndex = 14;
            // 
            // panel_monitor
            // 
            this.panel_monitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_monitor.Location = new System.Drawing.Point(20, 17);
            this.panel_monitor.Name = "panel_monitor";
            this.panel_monitor.Size = new System.Drawing.Size(590, 353);
            this.panel_monitor.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer2.Location = new System.Drawing.Point(0, 41);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Size = new System.Drawing.Size(166, 387);
            this.splitContainer2.SplitterDistance = 67;
            this.splitContainer2.TabIndex = 13;
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.btn_rendo);
            this.panel_buttons.Controls.Add(this.btn_undo);
            this.panel_buttons.Controls.Add(this.btn_exit);
            this.panel_buttons.Controls.Add(this.btn_load);
            this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_buttons.Location = new System.Drawing.Point(0, 0);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(992, 41);
            this.panel_buttons.TabIndex = 10;
            // 
            // btn_rendo
            // 
            this.btn_rendo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_rendo.Location = new System.Drawing.Point(153, 0);
            this.btn_rendo.Name = "btn_rendo";
            this.btn_rendo.Size = new System.Drawing.Size(51, 41);
            this.btn_rendo.TabIndex = 3;
            this.btn_rendo.Text = "Rendo";
            this.btn_rendo.UseVisualStyleBackColor = true;
            this.btn_rendo.Click += new System.EventHandler(this.btn_rendo_Click);
            // 
            // btn_undo
            // 
            this.btn_undo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_undo.Location = new System.Drawing.Point(102, 0);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(51, 41);
            this.btn_undo.TabIndex = 2;
            this.btn_undo.Text = "Undo";
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_exit.Location = new System.Drawing.Point(51, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(51, 41);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_load
            // 
            this.btn_load.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_load.Location = new System.Drawing.Point(0, 0);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(51, 41);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 658);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel_bottom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tb_test2;
        private System.Windows.Forms.TextBox tb_test1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_monitor;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_rendo;
        private System.Windows.Forms.Button btn_undo;
    }
}

