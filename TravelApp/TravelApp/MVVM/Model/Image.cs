using System;
using System.Collections.Generic;

#nullable disable

namespace TravelApp.MVVM.Model
{
    public partial class Image
    {
        public Image()
        {
            ImageRegions = new HashSet<ImageRegion>();
        }

        public int Id { get; set; }
        public string Img { get; set; }

        public virtual ICollection<ImageRegion> ImageRegions { get; set; }
    }
}
