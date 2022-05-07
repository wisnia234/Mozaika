using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozaika.Format
{
    class Formats
    {
        List<FormatInfo> formats;
        FormatInfo selectedFormat;

        public Formats()
        {
            formats = new List<FormatInfo>();
        }

        public void Add(string name, int dim1, int dim2)
        {
            formats.Add(new FormatInfo(name, dim1, dim2));
        }

        public string[] FormatList
        {
            get
            {
                var results = new string[formats.Count];
                for (int i = 0; i < formats.Count; i++)
                {
                    results[i] = formats[i].ToString();
                }

                return results;
            }
        }

        public int SelectedIndexFormat
        {
            set
            {
                selectedFormat = formats[value];
                //todo dodac zabezpieczenie
            }
        }

        public Size SelectedFormatSize
        {
            get
            {
                return selectedFormat.Size;
            }
            
        }
    }
}
