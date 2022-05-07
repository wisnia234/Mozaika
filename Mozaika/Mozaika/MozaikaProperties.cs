using Mozaika.Format;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozaika
{
    class MozaikaProperties
    {
        Formats formats;
        Formats thumbnailFormats;
        
        public MozaikaProperties()
        {
            formats = new Formats();

            formats.Add("A0", 1189, 841);
            formats.Add("A1", 594, 841);
            formats.Add("B0", 1000, 1414);
            formats.Add("B1", 707, 1000);
            formats.Add("B2", 500, 707);
            formats.Add("C0", 917, 1297);
            formats.Add("C1", 648, 917);
            formats.Add("C2", 458, 648);
            formats.Add("L DL", 99, 210);

            thumbnailFormats = new Formats();
            thumbnailFormats.Add("M1", 10, 14);
            thumbnailFormats.Add("M2", 14, 19);
            thumbnailFormats.Add("M3", 20, 28);
        }

        public string[] Format => formats.FormatList;
        public string[] ThumbnailFormat => thumbnailFormats.FormatList;



        public int SelectedIndexFormat
        {
            set => formats.SelectedIndexFormat = value;
        }
        public int SelectedIndexThumbnailFormat
        {
            set => thumbnailFormats.SelectedIndexFormat = value;
        }

        public Size ThumbnailSize => thumbnailFormats.SelectedFormatSize;
        public Size PictureSize => formats.SelectedFormatSize;

        public string FileName { get; set; }

        public string ThumbnailsPath { get; set; }
               
        public Layout Layout
        {
            set => FormatInfo.Layout = value;
        }
    }
}
