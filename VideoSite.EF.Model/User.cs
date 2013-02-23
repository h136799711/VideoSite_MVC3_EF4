using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace VideoSite.EF.Model
{
    public class User
    {
        public int userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string extramsg { get; set; }
    }
}
