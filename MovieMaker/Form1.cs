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
