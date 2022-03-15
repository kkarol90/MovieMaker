using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using MovieMaker.Classes;
using MovieMaker.Controls;

namespace MovieMaker
{
    public partial class Form1 : Form
    {
        public bool IsRun;
        private List<TrackLine> trackLineList = new List<TrackLine>();

        public Form1()
        {
            InitializeComponent();
            MovieBuilder.Monitor = panel_monitor;
            splitContainer1.Panel2.Controls.Add(MovieBuilder.GetMovieBuilder());
            splitContainer1.Panel2.Controls[0].Dock = DockStyle.Fill;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            VideoCapture cap;
            cap = GetVideoCaptureFromFile();
            if (cap != null)
            {               
                int lineNumber;
                if (int.TryParse(tb_test1.Text, out lineNumber))
                {
                    int startPos = 0;
                    int.TryParse(tb_test2.Text, out startPos);
                    VideoTrack tr = (VideoTrack)TrackCreator.GetTrackCreator().CreateTrack(startPos, cap);
                    TrackControl trackControl = new TrackControl(tr);
                    MovieBuilder.GetMovieBuilder().AddTrackControlToLine(lineNumber, trackControl, startPos);
                }
            }

        }
        private void btn_addLine_Click(object sender, EventArgs e)
        {
            TrackLine tLine = new TrackLine();
            trackLineList.Add(tLine);
            //flp_tracks.Controls.Add(tLine);
        }

        private VideoCapture GetVideoCaptureFromFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string path = "";
            ofd.Filter = "Video Files |*.mp4";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                return new VideoCapture(path);
            }
            else return null;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            //if (trackLineList[0].Tracks[0].Cap == null) return;
            //try
            //{
            //    IsRun = true;
            //    while (IsRun)
            //    {
            //        trackLineList[0].Tracks[0].Read();
            //        if (!trackLineList[0].Tracks[0].Matrix.IsEmpty)
            //        {                     
            //            trackLineList[0].Tracks[0].Box.Image = trackLineList[0].Tracks[0].Matrix.ToBitmap();
            //            int fps = (int)trackLineList[0].Tracks[0].Cap.Get(Emgu.CV.CvEnum.CapProp.Fps);
            //            await Task.Delay(1000/fps);
            //            tb_test2.Text = trackLineList[0].Tracks[0].Cap.Get(Emgu.CV.CvEnum.CapProp.PosFrames).ToString();
            //        }
            //        else break;
            //    }
            //}
            //catch (Exception)
            //{
            //    throw;
            //}          
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            IsRun = false;
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            InstructionExecutor.Get().Undo();
        }

        private void btn_rendo_Click(object sender, EventArgs e)
        {
            InstructionExecutor.Get().Retry();
        }
    }
}
