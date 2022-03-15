using MovieMaker.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMaker.Classes
{
    internal class AddTrackComm : ICommand
    {
        TrackControl trackControl;
        TrackLine trackLine;
        double startPoint;

        public AddTrackComm(TrackControl trackControl, TrackLine line, double startPoint)
        {
            this.trackControl = trackControl;
            this.trackLine = line;
            this.startPoint = startPoint;
        }
        public bool Execute()
        {
            if(trackLine.AddTrack(trackControl, startPoint))
            {
                MovieBuilder.Monitor.Controls.Add(trackControl.Picture);
                return true;
            }
            return false;
        }
        public void Undo()
        {
            trackLine.RemoveTrack(trackControl);
            MovieBuilder.Monitor.Controls.Remove(trackControl.Picture);
        }
    }
}
