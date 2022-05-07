using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozaika.Format
{
    class FormatInfo
    {
        private int dimBigest;
        private int dimLowest;
        private string name;
        private static Layout layout = Layout.horizontal;
        private const double pixelsInOneMilimetrFor300DPI = 11.81f;
        public FormatInfo(string name, int dim1, int dim2)
        {
            this.name = name;
            
            if(dim1>dim2)
            {
                dimBigest = dim1;
                dimLowest = dim2;
            }
            else
            {
                dimBigest = dim2;
                dimLowest = dim1;
            }

        }

        public static Layout Layout
        {
            set => layout = value;
        }
       
        public Size Size
        {
            get
            {
                if (layout == Layout.horizontal)
                {
                    int width = (int)(pixelsInOneMilimetrFor300DPI * dimBigest + 0.5);
                    int height = (int)(pixelsInOneMilimetrFor300DPI * dimLowest + 0.5);
                    return new Size(width, height);
                }
                else 
                {
                    int width = (int)(pixelsInOneMilimetrFor300DPI * dimLowest + 0.5);
                    int height = (int)(pixelsInOneMilimetrFor300DPI * dimBigest + 0.5);
                    return new Size(width, height);
                }
            }
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}mm x {2}mm",name, dimBigest, dimLowest);
        }

    }
}
