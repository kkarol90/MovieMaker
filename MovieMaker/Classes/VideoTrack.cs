using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieMaker.Classes
{
    internal class VideoTrack : ITrack
    {
        VideoCapture cap;
        Mat matrix;
        double startPoint;
        double endPoint;
        double lastReadFrame = -2;

        public VideoTrack(double startPoint, VideoCapture cap)
        {
            matrix = new Mat();
            this.cap = cap;
            cap.Read(matrix);
            this.startPoint = startPoint;
            Location = startPoint;
            EndPoint = startPoint + LengthInFrames;
        }

        public double StartPoint
        {
            get { return startPoint; }
            set
            {
                if (Location <= value && value < EndPoint)
                    startPoint = value;
            }
        }
        public double EndPoint
        {
            get { return endPoint; }
            set
            {
                if (StartPoint < value && value <= StartPoint + LengthInFrames)
                    endPoint = value;
            }
        }
        public double Location { get; set; }
        public double LengthInFrames { get => Cap.Get(Emgu.CV.CvEnum.CapProp.FrameCount); }
        public double Duration => EndPoint - StartPoint;
        public VideoCapture Cap { get => cap; set => cap = value; }
        public Bitmap Image { get => matrix.ToBitmap(); }

        public bool IsImgCaught { get; }

        public bool Read(double frame)
        {
            bool isRead = false;
            if (lastReadFrame + 1 != frame)
            {
                cap.Set(Emgu.CV.CvEnum.CapProp.PosFrames, frame);
                lastReadFrame = frame;
            }
            else
            {
                lastReadFrame++;
            }
            cap.Read(matrix);
            if (!matrix.IsEmpty)
            {
                matrix.ToBitmap();
                isRead = true;
            }
            return isRead;
        }
    }
}
