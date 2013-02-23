using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoSite.EF.Model
{
    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public int PopularDegree { get; set; }

        public string Extra { get; set; }
    }
}
