using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VLab.Models
{
    public class HotPicture
    {
        public String Picture { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public HotArea  HotArea { get; set; }
    }
}
