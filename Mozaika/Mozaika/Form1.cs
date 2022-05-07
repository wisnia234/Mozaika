using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mozaika
{
    public partial class Form1 : Form
    {
        MozaikaProperties properties;
        BigPicture bigPicture;
        public Form1()
        {
            InitializeComponent();
            properties = new MozaikaProperties();
            comboBoxFormats.Items.AddRange(properties.Format);
            comboBoxThumbnailFormats.Items.AddRange(properties.ThumbnailFormat);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listBoxLayout.SelectedIndex == 0)
            {
                properties.Layout = Format.Layout.horizontal;
            }
            else
            {
                properties.Layout = Format.Layout.vertical;
            }
            if(comboBoxFormats.SelectedIndex != -1)
            {
                properties.SelectedIndexFormat = comboBoxFormats.SelectedIndex;
            }
            if (comboBoxThumbnailFormats.SelectedIndex != -1)
            {
                properties.SelectedIndexThumbnailFormat = comboBoxThumbnailFormats.SelectedIndex;
            }


            properties.FileName = "domek.bmp";
            //properties.HeightInThumbnail = 100;
            //properties.WidthInThumbnail = 100;
            //properties.HeightThumbnail = 60;
            //properties.WidthThumbnail = 80;
            properties.ThumbnailsPath = @"D:\Kolorowanki\miniautki\wooden house1";
            bigPicture = new BigPicture(properties);
            this.progressBar.Maximum = bigPicture.PartsCount;
            this.progressBarInitialize.Maximum = bigPicture.PartsCount;
            
            timer1.Start();
            bigPicture.Work();
            
            
        }

        private void comboBoxFormats_SelectedIndexChanged(object sender, EventArgs e)
        {
            properties.SelectedIndexFormat = comboBoxFormats.SelectedIndex;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar.Value = bigPicture.Progress;
            this.progressBarInitialize.Value = bigPicture.InitializeProgress;
        }
    }
}
