using MovieMaker.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;

namespace MovieMaker.Classes
{
    internal class TrackCreator
    {
        static TrackCreator instance;
        private TrackCreator()
        {
            // It is Singeltone
        }
        public static TrackCreator GetTrackCreator()
        {
            if (instance == null) instance = new TrackCreator();
            return instance;
        }
        public ITrack CreateTrack(double startPoint, VideoCapture cap)
        {
            ITrack track = new VideoTrack(startPoint, cap);
            return track;
        }
    }
}
