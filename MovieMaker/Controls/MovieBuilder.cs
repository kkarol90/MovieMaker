using MovieMaker.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;


namespace MovieMaker.Controls
{    
    public partial class MovieBuilder : UserControl
    {
        private static MovieBuilder instance;
        private List<TrackLine> trackLineList;
        private int indicatorPosition;
        static bool pause = true;
        static bool fromPlayLoop;

        private MovieBuilder()
        {
            InitializeComponent();
            settingControlsPosition();
            TrackLine.FullLengthChange += WhenNewFullLength;
            TrackLine.LastPointChange += CheckVideoLastPoint;
        }

        public static Panel Monitor { get; set; }
        public int IndicatorPosition
        {
            get
            {
                return indicatorPosition;
            }
            private set
            {
                indicatorPosition = value;
                int xPos = panel_tracksAttributes.Width + value - flp_tracks.HorizontalScroll.Value;
                panel_indicator.Location = new Point(xPos, panel_indicator.Location.Y);             
                if(panel_indicator.Location.X < panel_tracksAttributes.Width)
                    panel_indicator.Visible = false;
                else
                    panel_indicator.Visible = true;
            }
        }

        public int VideoLastPoint { get => (int)trackLineList.Max(x => x.EndPoint); }

        private void settingControlsPosition()
        {
            int posX = (this.Width / 2 - panel_buttons.Width / 2);
            panel_buttons.Location = new Point(posX, panel_buttons.Location.Y);
            posX = this.Width / 2 - tb_playVideo.Width / 2;
            tb_playVideo.Location = new Point(posX, tb_playVideo.Location.Y);
            panel_indicator.Height = splitContainer1.Panel2.Height;
            IndicatorPosition = 0;
            trackLineList = new List<TrackLine>();
            Padding p = new Padding();
            p = this.Padding;
            int newBP = SystemInformation.HorizontalScrollBarHeight;
            this.Padding = new Padding(p.Left, p.Top, p.Right, newBP);
            panel_indicator.Height = flp_tracks.Height - newBP;
        }

        private void CheckVideoLastPoint(object sender, EventArgs e)
        {
            tb_playVideo.Maximum = VideoLastPoint;
            pause = true;
            if (VideoLastPoint < IndicatorPosition) IndicatorPosition = VideoLastPoint;
        }

        private void WhenNewFullLength()
        {
            tb_playVideo.Maximum = VideoLastPoint;
            foreach (var trList in trackLineList)
            {
                trList.Width = (int)TrackLine.FullLength;
            }
        }
        public static MovieBuilder GetMovieBuilder()
        {
            if(instance == null) instance = new MovieBuilder();
            return instance;
        }
        public void AddLine()
        {
            TrackLine trackLine = new TrackLine();
            flp_tracks.Controls.Add(trackLine);
            trackLineList.Add(trackLine);
        }
        private void btn_addLine_Click(object sender, EventArgs e)
        {
            AddLine();
        }
        public void AddTrackControlToLine(int listIndex, TrackControl track, double location = 0)
        {
            try
            {
                if (0 < trackLineList.Count && listIndex < trackLineList.Count)
                {
                    int i;
                    for (i = listIndex; i < trackLineList.Count; i++)
                    {
                        if (InstructionExecutor.Get().Execute(new AddTrackComm(track, trackLineList[i], location)))
                        {
                            checkVisibilty(track);
                            return;
                        }
                    }
                }
                AddLine();
                InstructionExecutor.Get().Execute(new AddTrackComm(track, trackLineList[trackLineList.Count - 1], location));
                checkVisibilty(track);
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkVisibilty(TrackControl track)
        {
            if (track.Attributes.EndPoint < IndicatorPosition || IndicatorPosition < track.Attributes.StartPoint)
            {
                track.Picture.Visible = false;
            }
        }

        private void MovieBuilder_Resize(object sender, EventArgs e)
        {
            panel_buttons.Location = new Point(this.Width / 2 - panel_buttons.Width / 2, panel_buttons.Location.Y);
            tb_playVideo.Location = new Point(this.Width / 2 - tb_playVideo.Width / 2, tb_playVideo.Location.Y);
        }

        private void flp_tracks_Resize(object sender, EventArgs e)
        {
            if (flp_tracks.HorizontalScroll.Visible)
                panel_indicator.Height = splitContainer1.Panel2.Height - (SystemInformation.HorizontalScrollBarHeight + 2);
            else
                panel_indicator.Height = splitContainer1.Panel2.Height;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            pause = false;
            playVideo();
        }

        private async void playVideo()
        {
            while (!pause)
            {               
                foreach (var t in trackLineList)
                {
                    t.Read(IndicatorPosition);
                }
                await Task.Delay(30);
                fromPlayLoop = true;
                if (tb_playVideo.Value == tb_playVideo.Maximum)
                {
                    pause = true;
                    break;
                }
                tb_playVideo.Value++;               
            }          
        }

        private void tb_playVideo_ValueChanged(object sender, EventArgs e)
        {           
            IndicatorPosition = tb_playVideo.Value;
            if (!fromPlayLoop) pause = true;
            fromPlayLoop = false;
        }

        private void flp_tracks_Scroll(object sender, ScrollEventArgs e)
        {
            IndicatorPosition = tb_playVideo.Value;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            pause = true;
        }
    }
}
