using System.Drawing;

namespace MovieMaker.Classes
{
    internal class CalloutTrack : ITrack
    {
        public double StartPoint { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public double LengthInFrames => throw new System.NotImplementedException();

        public Bitmap Image => throw new System.NotImplementedException();

        public double EndPoint { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public double Location { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public double Duration => throw new System.NotImplementedException();

        public bool Read(double frame)
        {
            throw new System.NotImplementedException();
        }
    }
}