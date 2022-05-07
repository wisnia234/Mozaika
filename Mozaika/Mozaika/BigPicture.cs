using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mozaika
{
    class BigPicture
    {
        Bitmap bitmap;
        
        BigImagePart[,] parst;
        Thumbnails thumbnails;
        MozaikaProperties properties;


        bool initialized;
        int progress;
        int initializeProgress;

        public BigPicture(MozaikaProperties properties)
        {
            this.properties = properties;
            Image image = Image.FromFile(properties.FileName);

            progress = 0;
            initializeProgress = 0;

            int width = ThumbnailInWidth * properties.ThumbnailSize.Width;
            int height = ThumbnailInHeight * properties.ThumbnailSize.Height;

            bitmap = new Bitmap(image, width, height);
            
            parst = new BigImagePart[ThumbnailInHeight, ThumbnailInWidth];
            initialized = false;
        }

       

        public void Initialize()
        {
            thumbnails = new Thumbnails(properties.ThumbnailsPath, properties.ThumbnailSize);
            for (int y = 0; y < ThumbnailInHeight; y++)
            {
                for (int x = 0; x < ThumbnailInWidth; x++)
                {
                    parst[y, x] = new BigImagePart(x, y, bitmap, properties.ThumbnailSize, thumbnails);
                    initializeProgress++;
                }
            }
            initialized = true;
        }

        public void Work()
        {
            progress = 0;
            Thread thr = new Thread(new ThreadStart(Go));
            thr.Start();
        }

        private void Go()
        {
            if(!initialized)
            {
                Initialize();
            }

            for (int y = 0; y < parst.GetLength(0); y++)
            {
                for (int x = 0; x < parst.GetLength(1); x++)
                {
                    parst[y,x].Work();
                    progress++;
                }
            }
            bitmap.Save("wynik.bmp");
        }

        public int PartsCount => parst.Length;
        public int Progress => progress;

        public int InitializeProgress => initializeProgress;

        private int ThumbnailInHeight
        {
            get
            {
                float thumbnailInHeightAsFloat = properties.PictureSize.Height / properties.ThumbnailSize.Height;
                return (int)(thumbnailInHeightAsFloat + 0.5);
            }
        }
        private int ThumbnailInWidth
        {
            get
            {
                float thumbnailInWidthAsFloat = properties.PictureSize.Width / properties.ThumbnailSize.Width;
                return (int)(thumbnailInWidthAsFloat + 0.5);
            }
        }

    }
}
