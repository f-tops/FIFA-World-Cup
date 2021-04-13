using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Aplikacija.Models
{
    class FilePath
    {
        public const string Path = @".\data.txt";
        public static string GetDefaultPicture()
        {
            var outPutDirectory = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var picPath = System.IO.Path.Combine(outPutDirectory, "Images\\player.png");
            string pic_path = new Uri(picPath).LocalPath;
            return pic_path;
        }


    }
}
