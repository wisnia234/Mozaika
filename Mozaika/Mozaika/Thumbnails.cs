using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozaika
{
    class Thumbnails
    {
        List<Thumbnail> thumbnails;
        


        public Thumbnails(string path, Size size)
        {
            thumbnails = new List<Thumbnail>();
            ReadDirectory(path, size);
        }

        

        public Thumbnail FindBest(Color color, Point location)
        {
            Thumbnail best = null;
            int bestPoints = 300;
            int points;
            foreach(Thumbnail t in thumbnails)
            {
                points = t.CalculateUnmatchingPoints(color, location);
                if(bestPoints>points)
                {
                    best = t;
                    bestPoints = points;
                }
            }
            best.AddUsingLocation(location);
            return best;
        }
        private void ReadDirectory(string path, Size size)
        {
            DirectoryInfo dir = new DirectoryInfo(path);

            foreach (var file in dir.GetFiles())
            {
                Thumbnail t = new Thumbnail(file.FullName, size);
                thumbnails.Add(t);
            }
            foreach (var subDir in dir.GetDirectories())
            {
                ReadDirectory(subDir.FullName, size);
            }
        }

    }
}
