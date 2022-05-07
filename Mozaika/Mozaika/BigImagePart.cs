using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozaika
{
    class BigImagePart
    {
        private int positionXInBigPucture;
        private int positionYInBigPucture;
        private Bitmap bigImage;
        private Size size;
        private Color avgColor;
        private bool finish;
        Thumbnails thumbnails;
        private Point location;
        public BigImagePart(int x, int y, Bitmap bigImage, Size size, Thumbnails thumbnails)
        {
            location = new Point(x, y);
            this.size = size;
            this.bigImage = bigImage;
            this.positionXInBigPucture = x* size.Width;
            this.positionYInBigPucture = y* size.Height;
            avgColor = GetAvgColor();
            this.thumbnails = thumbnails;
        }

        private Color GetAvgColor()
        {
            int red = 0;
            int green = 0;
            int blue = 0;
            for (int y = 0; y < size.Height; y++)
            {
                for (int x = 0; x < size.Width; x++)
                {
                    Color c = bigImage.GetPixel(x+ positionXInBigPucture, y+ positionYInBigPucture);
                    red += c.R;
                    green += c.G;
                    blue += c.B;
                }
            }
            int pixelsCount = size.Width * size.Height;
            return Color.FromArgb(red / pixelsCount, green / pixelsCount, blue / pixelsCount);
        }

        public void Work()
        {
            Thumbnail thumbnail = thumbnails.FindBest(avgColor, location);
            for (int y = 0; y < size.Height; y++)
            {
                for (int x = 0; x < size.Width; x++)
                {
                    bigImage.SetPixel(positionXInBigPucture+x, positionYInBigPucture+y, thumbnail[x,y]);
                }
            }
        }
      

    }
}
