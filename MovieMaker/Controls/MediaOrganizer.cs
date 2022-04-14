using MovieMaker.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMaker.Controls
{
    public partial class MediaOrganizer : UserControl
    {
        public MediaOrganizer()
        {
            InitializeComponent();  
        }

        public bool AddMedia(string path)
        {
            bool result = false;
            if(Enum.GetNames(typeof(FileType))
                   .Where(t => Regex.IsMatch(path, @"\." + $"{t}$", RegexOptions.IgnoreCase) == true)
                   .Count() > 0)
            {
                MediaFile mf = new MediaFile(path);
                lb_media.Items.Add(mf);               
                lb_media.DisplayMember = "Name";
                result = true;
            }           
            return result;
        }
    }
}
