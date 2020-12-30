using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VLab.Models
{
    public class Step
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public HotPicture PictureDefault { get; set; }
        public string PerformVideo { get; set; }
    }
}
