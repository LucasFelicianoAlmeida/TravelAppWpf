using System;
using System.Collections.Generic;

#nullable disable

namespace Api.Context
{
    public partial class ImageRegion
    {
        public int Id { get; set; }
        public int IdRegion { get; set; }
        public int IdImage { get; set; }

        public virtual Image IdImageNavigation { get; set; }
        public virtual Region IdRegionNavigation { get; set; }
    }
}
