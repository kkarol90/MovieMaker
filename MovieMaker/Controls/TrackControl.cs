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
using MovieMaker.Classes;

namespace MovieMaker.Controls
{
    public partial class TrackControl : UserControl
    {
        public ITrack Attributes { get; set; }
        public PictureBox Picture { get; set; }
        public bool PictureIsCaught { get; set; }
        Point offset;
        public TrackControl(ITrack trackProp)
        {
            InitializeComponent();
            Attributes = trackProp;
            this.Width = (int)Attributes.Duration;
            PictureInit(trackProp);
        }

        private void PictureInit(ITrack trackProp)
        {
            Picture = new PictureBox();
            Picture.Image = trackProp.Image;
            Picture.MouseUp += picture_MouseUp;
            Picture.MouseDown += picture_MouseDown;
            Picture.MouseMove += picture_MouseMove;
            Picture.Height = Attributes.Image.Height / 4;
            Picture.Width = Attributes.Image.Width / 4;
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture.Image = Attributes.Image;
        }

        public void Read(double frame)
        {
            if (Attributes.Read(frame))
            {
                Picture.Image = Attributes.Image;
                if (Picture.Visible == false) Picture.Visible = true;
            }
        }

        public enum PictureOperation { None, Move, StretchRightLeftSide, StretchTopBottomSide }
        private PictureOperation pictureOperation = PictureOperation.None;
        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;

            if(Picture.Cursor == Cursors.Arrow)
            {
                pictureOperation = PictureOperation.Move;
            }
            else if(Picture.Cursor == Cursors.SizeWE)
            {
                pictureOperation = PictureOperation.StretchRightLeftSide;
            }
            else if (Picture.Cursor == Cursors.SizeNS)
            {
                pictureOperation = PictureOperation.StretchTopBottomSide;
            }
            PictureIsCaught = true;
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            PictureIsCaught = false;
            pictureOperation = PictureOperation.None;
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            Point currentPoint = e.Location;
            PictureBox pb = (PictureBox)sender;

            switch (pictureOperation)
            {
                case PictureOperation.None:
                    break;
                case PictureOperation.Move:
                    currentPoint = movePicture(currentPoint, pb);
                    break;
                case PictureOperation.StretchRightLeftSide:
                    currentPoint = stretchRightLeftSide(currentPoint, pb);
                    break;
                case PictureOperation.StretchTopBottomSide:
                    currentPoint = stretchTopBottomSide(currentPoint, pb);
                    break;
                default:
                    break;
            }
            if (pictureOperation != PictureOperation.None) return;
            setPictureCursor(currentPoint, pb);
        }

        private Point movePicture(Point currentPoint, PictureBox pb)
        {
            pb.Left += currentPoint.X - offset.X;
            pb.Top += currentPoint.Y - offset.Y;
            return currentPoint;
        }

        private Point stretchTopBottomSide(Point currentPoint, PictureBox pb)
        {
            if (currentPoint.Y > pb.Height * 0.5)
            {
                pb.Height += (currentPoint.Y - pb.Height);
            }
            else
            {
                pb.Height -= currentPoint.Y;
                pb.Location = new Point(pb.Location.X, pb.Location.Y + currentPoint.Y);
            }
            return currentPoint;
        }

        private Point stretchRightLeftSide(Point currentPoint, PictureBox pb)
        {
            if (currentPoint.X > pb.Width * 0.5)
            {
                pb.Width += (currentPoint.X - pb.Width);
            }
            else
            {
                pb.Width -= currentPoint.X;
                pb.Location = new Point(pb.Location.X + currentPoint.X, pb.Location.Y);
            }
            return currentPoint;
        }

        private void setPictureCursor(Point currentPoint, PictureBox pb)
        {
            if ((currentPoint.X == 0 || currentPoint.X == pb.Width - 1) && 0 < currentPoint.Y && currentPoint.Y < pb.Height - 1)
            {
                pb.Cursor = Cursors.SizeWE;
            }
            else if ((currentPoint.Y == 0 || currentPoint.Y == pb.Height - 1) && 0 < currentPoint.X && currentPoint.X < pb.Width - 1)
            {
                pb.Cursor = Cursors.SizeNS;
            }
            else
            {
                pb.Cursor = Cursors.Arrow;
            }
        }
    }
}
