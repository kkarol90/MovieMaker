using MovieMaker.Classes;
using MovieMaker.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMaker
{

    public partial class TrackLine : UserControl
    {
        public static readonly double LastPointOffset = 300;
        public static EventHandler LastPointChange;        
        private static double fullLength;
        private static Panel monitor;
        private TrackControl actTrack;       

        public static Action FullLengthChange;

        private List<TrackControl> Tracks { get; set; }

        public static double FullLength
        {
            get => fullLength;
            private set
            {
                fullLength = value;
                FullLengthChange?.Invoke();
            }
        }
        
        public double EndPoint { get; private set; }

        static TrackLine()
        {
            monitor = new Panel();
            FullLength = 1000;
        }

        public TrackLine()
        {
            InitializeComponent();
            Tracks = new List<TrackControl>();
            this.Width = (int)TrackLine.FullLength;
        }

        public static void SetPanelMonitor(Panel panel)
        {
            Panel lastMonitor = monitor;
            monitor = panel;
            foreach (Control item in lastMonitor.Controls)
            {
                monitor.Controls.Add(item);
            }
        }

        private void OnLastPointChange(EventArgs e)
        {
            if (EndPoint + LastPointOffset > FullLength)
            {
                FullLength = EndPoint + LastPointOffset;
            }
            this.Width = (int)FullLength;
            LastPointChange?.Invoke(this, e);
        }

        public bool AddTrack(TrackControl track, double frameStart)
        {
            bool isAdded = false;
            if (!CheckTrackConflict(track, frameStart))
            {
                Tracks.Add(track);
                track.Location = new Point((int)track.Attributes.StartPoint, 0);
                panel_line.Controls.Add(track);
                isAdded = true;
            }
            if (CheckLastPoint()) OnLastPointChange(EventArgs.Empty);
            return isAdded;
        }

        internal void RemoveTrack(TrackControl trackControl)
        {
            Tracks.Remove(trackControl);
            panel_line.Controls.Remove(trackControl);
            if (CheckLastPoint()) OnLastPointChange(EventArgs.Empty);
        }

        private bool CheckLastPoint()
        {
            bool isChanged = false;
            if (Tracks.Count == 0)
            {
                if (EndPoint != 0)
                {
                    EndPoint = 0;
                    isChanged = true;
                    return isChanged;
                }
            }
            double endPoint = Tracks.First().Attributes.EndPoint;
            foreach (var tr in Tracks.Skip(1))
            {
                if (tr.Attributes.EndPoint > endPoint)
                {
                    endPoint = tr.Attributes.EndPoint;
                }
            }
            if (EndPoint != endPoint)
            {
                EndPoint = endPoint;
                isChanged = true;
            }
            return isChanged;
        }

        private bool CheckTrackConflict(TrackControl trAdd, double trAddStart)
        {
            bool isConflict = false;
            if (Tracks.Count != 0)
            {
                foreach (var tr in Tracks)
                {
                    double trAddEnd = trAddStart + trAdd.Attributes.Duration;
                    if ((tr.Attributes.StartPoint <= trAddStart && trAddStart <= tr.Attributes.EndPoint)
                        || (tr.Attributes.StartPoint <= trAddEnd && trAddEnd <= tr.Attributes.EndPoint))
                    {
                        isConflict = true;
                    }
                }
            }
            return isConflict;
        }

        public void Read(double videoFrame)
        {
            TrackControl tc = Tracks.Where(t => t.Attributes.StartPoint <= videoFrame && videoFrame <= t.Attributes.EndPoint).FirstOrDefault();
            if (actTrack != null && actTrack != tc)
            {
                actTrack.Picture.Visible = false;
            }
            actTrack = tc;
            if (tc != null)
            {
                double frame = videoFrame - tc.Attributes.StartPoint;
                tc.Read(frame);
            }           
        }
    }
}
