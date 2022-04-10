namespace MovieMaker.Controls
{
    partial class MovieBuilder
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tb_playVideo = new System.Windows.Forms.TrackBar();
            this.panel_timeline = new System.Windows.Forms.Panel();
            this.panel_indicator = new System.Windows.Forms.Panel();
            this.flp_tracks = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_tracksAttributes = new System.Windows.Forms.Panel();
            this.btn_addLine = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.Btn_backward = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_playVideo)).BeginInit();
            this.panel_timeline.SuspendLayout();
            this.panel_tracksAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb_playVideo);
            this.splitContainer1.Panel1MinSize = 33;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_timeline);
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(821, 423);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // tb_playVideo
            // 
            this.tb_playVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_playVideo.LargeChange = 1;
            this.tb_playVideo.Location = new System.Drawing.Point(71, 2);
            this.tb_playVideo.Margin = new System.Windows.Forms.Padding(0);
            this.tb_playVideo.Maximum = 100;
            this.tb_playVideo.Name = "tb_playVideo";
            this.tb_playVideo.Size = new System.Drawing.Size(690, 45);
            this.tb_playVideo.SmallChange = 10;
            this.tb_playVideo.TabIndex = 3;
            this.tb_playVideo.TickFrequency = 10;
            this.tb_playVideo.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tb_playVideo.ValueChanged += new System.EventHandler(this.tb_playVideo_ValueChanged);
            // 
            // panel_timeline
            // 
            this.panel_timeline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_timeline.Controls.Add(this.panel_indicator);
            this.panel_timeline.Controls.Add(this.flp_tracks);
            this.panel_timeline.Controls.Add(this.panel_tracksAttributes);
            this.panel_timeline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_timeline.Location = new System.Drawing.Point(0, 0);
            this.panel_timeline.Name = "panel_timeline";
            this.panel_timeline.Size = new System.Drawing.Size(821, 343);
            this.panel_timeline.TabIndex = 16;
            // 
            // panel_indicator
            // 
            this.panel_indicator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_indicator.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_indicator.Location = new System.Drawing.Point(352, -1);
            this.panel_indicator.Name = "panel_indicator";
            this.panel_indicator.Size = new System.Drawing.Size(1, 410);
            this.panel_indicator.TabIndex = 5;
            // 
            // flp_tracks
            // 
            this.flp_tracks.AutoScroll = true;
            this.flp_tracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_tracks.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flp_tracks.Location = new System.Drawing.Point(70, 0);
            this.flp_tracks.Name = "flp_tracks";
            this.flp_tracks.Size = new System.Drawing.Size(749, 341);
            this.flp_tracks.TabIndex = 7;
            this.flp_tracks.WrapContents = false;
            this.flp_tracks.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flp_tracks_Scroll);
            this.flp_tracks.Resize += new System.EventHandler(this.flp_tracks_Resize);
            // 
            // panel_tracksAttributes
            // 
            this.panel_tracksAttributes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_tracksAttributes.Controls.Add(this.btn_addLine);
            this.panel_tracksAttributes.Controls.Add(this.trackBar1);
            this.panel_tracksAttributes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_tracksAttributes.Location = new System.Drawing.Point(0, 0);
            this.panel_tracksAttributes.Name = "panel_tracksAttributes";
            this.panel_tracksAttributes.Size = new System.Drawing.Size(70, 341);
            this.panel_tracksAttributes.TabIndex = 3;
            // 
            // btn_addLine
            // 
            this.btn_addLine.Location = new System.Drawing.Point(-1, 33);
            this.btn_addLine.Name = "btn_addLine";
            this.btn_addLine.Size = new System.Drawing.Size(71, 26);
            this.btn_addLine.TabIndex = 1;
            this.btn_addLine.Text = "Add";
            this.btn_addLine.UseVisualStyleBackColor = true;
            this.btn_addLine.Click += new System.EventHandler(this.btn_addLine_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(4, 4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(60, 45);
            this.trackBar1.TabIndex = 0;
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.Btn_backward);
            this.panel_buttons.Controls.Add(this.btn_forward);
            this.panel_buttons.Controls.Add(this.btn_start);
            this.panel_buttons.Controls.Add(this.btn_play);
            this.panel_buttons.Controls.Add(this.btn_stop);
            this.panel_buttons.Location = new System.Drawing.Point(233, 39);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(355, 28);
            this.panel_buttons.TabIndex = 5;
            // 
            // Btn_backward
            // 
            this.Btn_backward.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_backward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_backward.Location = new System.Drawing.Point(66, 3);
            this.Btn_backward.Name = "Btn_backward";
            this.Btn_backward.Size = new System.Drawing.Size(40, 23);
            this.Btn_backward.TabIndex = 4;
            this.Btn_backward.Text = "B";
            this.Btn_backward.UseVisualStyleBackColor = false;
            // 
            // btn_forward
            // 
            this.btn_forward.BackColor = System.Drawing.SystemColors.Control;
            this.btn_forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_forward.Location = new System.Drawing.Point(250, 3);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(40, 23);
            this.btn_forward.TabIndex = 3;
            this.btn_forward.Text = "F";
            this.btn_forward.UseVisualStyleBackColor = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.Control;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.Location = new System.Drawing.Point(112, 3);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(40, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.SystemColors.Control;
            this.btn_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play.Location = new System.Drawing.Point(158, 3);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(40, 23);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.SystemColors.Control;
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop.Location = new System.Drawing.Point(204, 3);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(40, 23);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // MovieBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_buttons);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MovieBuilder";
            this.Size = new System.Drawing.Size(821, 423);
            this.Resize += new System.EventHandler(this.MovieBuilder_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_playVideo)).EndInit();
            this.panel_timeline.ResumeLayout(false);
            this.panel_tracksAttributes.ResumeLayout(false);
            this.panel_tracksAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel_timeline;
        private System.Windows.Forms.Panel panel_indicator;
        private System.Windows.Forms.Panel panel_tracksAttributes;
        private System.Windows.Forms.Button btn_addLine;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar tb_playVideo;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Button Btn_backward;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.FlowLayoutPanel flp_tracks;
    }
}
