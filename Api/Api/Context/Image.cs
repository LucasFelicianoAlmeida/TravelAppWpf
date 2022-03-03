using System;
using System.Collections.Generic;

#nullable disable

namespace Api.Context
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
