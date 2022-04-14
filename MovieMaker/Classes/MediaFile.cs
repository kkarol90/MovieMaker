using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MovieMaker.Classes
{
    public class MediaFile
    {
        public string Path { get; private set; }
        public string Name { get; private set; }
        public FileType Type { get; private set; }

        public MediaFile() {}

        public MediaFile(string path)
        {
            Path = path;
            SetProperties(path);
        }

        private void SetProperties(string path)
        {
            foreach (string type in Enum.GetNames(typeof(FileType)))
            {
                Regex reg = new Regex(@"\." + $"{type}$", RegexOptions.IgnoreCase);
                if (reg.IsMatch(path))
                {
                    string s = reg.Match(path).Value.Remove(0, 1);
                    Type = (FileType)Enum.Parse(typeof(FileType), s.ToUpper());

                    Name = Regex.Match(path, @"[0-9a-z_-]+\." + $"{type}$", RegexOptions.IgnoreCase).Value;
                }
            }
        }
    }
}
