using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoSite.EF.Model
{
    public class FactoryContext
    {
        public BaseContext create(int type)
        {
            switch (type)
            {
                case 0: return new MySqlContext();
                case 1: return new MSSqlContext();
            }
            return new BaseContext();
        }
    }
}
