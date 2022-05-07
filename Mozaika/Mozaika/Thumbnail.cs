using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozaika
{
    class Thumbnail
    {
        private string fileName;
        private Bitmap bitmap;
        private Color avgColor;
        List<Point> usingLocations;
        public Thumbnail(string fileName, Size size)
        {
            this.fileName = fileName;
            Image image = Image.FromFile(fileName);
            bitmap = new Bitmap(image, size);
            avgColor = GetAvgColor();
            usingLocations = new List<Point>();
        }

        private Color GetAvgColor()
        {
            int red = 0;
            int green = 0;
            int blue = 0;
            for(int y=0; y<bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color c = bitmap.GetPixel(x, y);
                    red += c.R;
                    green += c.G;
                    blue += c.B;
                }
            }
            int pixelsCount = bitmap.Width * bitmap.Height;
            return Color.FromArgb(red / pixelsCount, green/ pixelsCount, blue/ pixelsCount);
        }

        public void AddUsingLocation(Point location)
        {
            usingLocations.Add(location);
        }

        public int CalculateUnmatchingPoints(Color color, Point location)
        {
            int colorDistance = CalculateColorDistance(color);
            int distance = CalculateMinDistance(location);

            if(distance>1000)
            {
                distance = 1000;
            }

            return colorDistance + (1000 - distance);
        }


        public Color this[int x, int y]
        {
            get
            {
                return bitmap.GetPixel(x, y);
            }
        }

        private int CalculateColorDistance(Color color)
        {
            int distanceR = Math.Abs(avgColor.R - color.R);
            int distanceG = Math.Abs(avgColor.G - color.G);
            int distanceB = Math.Abs(avgColor.B - color.B);
            return Math.Max(Math.Max(distanceR, distanceG), distanceB);
        }

        private int CalculateMinDistance(Point location)
        {
            int minDistance = int.MaxValue;
            foreach(Point point in usingLocations)
            {
                int distance = (point.X - location.X) * (point.X - location.X) + (point.Y - location.Y) * (point.Y - location.Y);
                if(distance<minDistance)
                {
                    minDistance = distance;
                }
            }
            return minDistance;
        }
    }
}
