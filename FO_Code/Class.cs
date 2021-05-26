using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;
using System.IO;

namespace FO_Code
{
    class Tag
    {
        public String Title { set; get; }
        public String Album { set; get; }
        public String Artist { set; get; }
        public String Year { set; get; }
        public String Genre { set; get; }
        public String Comment { set; get; }
        public TimeSpan Duration { set; get; }
        public String Order { set; get; }
    }
    class Get_Data
    {
        public List<string> Get_MP3_Files(string path)
        {
            List<string> files = new List<string>();
            foreach (string file in Directory.GetFiles(path))
            { files.Add(file); }
            return files;
        }
        public Tag getTag(string file_name)
        {
            Tag tag = new Tag();
            TagLib.File f = TagLib.File.Create(file_name, TagLib.ReadStyle.Average);
            tag.Title = f.Tag.Title;
            tag.Artist = f.Tag.FirstPerformer;
            tag.Album = f.Tag.Album;
            tag.Genre = f.Tag.FirstGenre;
            tag.Comment = f.Tag.Comment;
            tag.Year = f.Tag.Year.ToString();
            tag.Duration = f.Properties.Duration;
            return tag;
        }
    }
}
