using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieMaker.Classes;

namespace MovieMakerTests
{
    public class MediaFileTest
    {
        [TestCase("F:\\FileFolder\\FileName.png", FileType.PNG)]
        [TestCase("F:\\FileFolder\\FileName.PNG", FileType.PNG)]
        [TestCase("F:\\FileFolder\\FileName.mp4", FileType.MP4)]
        [TestCase("F:\\FileFolder\\FileName.MP4", FileType.MP4)]
        [TestCase("F:\\FileFolder\\FileName.jpg", FileType.JPG)]
        [TestCase("F:\\FileFolder\\FileName.JPG", FileType.JPG)]
        public void SetProperties_CheckTypeSetting_ShouldReturnCorrectType(string path, FileType type)
        {
            MediaFile mf = new MediaFile(path);

            Assert.AreEqual(mf.Type, type);
        }

        [TestCase("F:\\FileFolder\\FileName.png", "FileName.png")]
        [TestCase("F:\\FileFolder\\FileName.PNG", "FileName.PNG")]
        [TestCase("F:\\FileFolder\\FileName.mp4", "FileName.mp4")]
        [TestCase("F:\\FileFolder\\FileName.MP4", "FileName.MP4")]
        [TestCase("F:\\FileFolder\\FileName.jpg", "FileName.jpg")]
        [TestCase("F:\\FileFolder\\FileName.JPG", "FileName.JPG")]
        public void SetProperties_CheckNameSetting_ShouldReturnCorrectName(string path, string name)
        {
            MediaFile mf = new MediaFile(path);

            Assert.AreEqual(mf.Name, name);
        }
    }
}
