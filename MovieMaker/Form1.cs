using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private Dictionary<string, string> importedImage = new Dictionary<string, string>();
        private Dictionary<string, string> importedVideo = new Dictionary<string, string>();

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
            ofd.Filter = "Video Files|*.mp4" + "|Image Files|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Regex regImg = new Regex(@"\.png|\.jpg");
                Regex regVideo = new Regex(@"\.mp4");
                string name = ofd.SafeFileName;
                path = ofd.FileName;
                //if (regImg.IsMatch(name))
                //{
                //    importedImage.Add(path, name);
                //}
                //else if(regVideo.IsMatch(name))
                //{
                //    importedVideo.Add(path, name);
                //}   
                uc_mediaOrganizer.AddMedia(path);
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
