using System.Drawing;

namespace MovieMaker.Classes
{
    public interface ITrack
    {
        double StartPoint { get; set; }
        double EndPoint { get; set; }
        double Duration { get; }
        Bitmap Image { get; }
        bool Read(double frame);
    }
}