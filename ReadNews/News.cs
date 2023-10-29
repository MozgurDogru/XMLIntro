using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNews
{
    internal class News
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Url { get; set; }

        public override string ToString() 
        {
            return this.Title;
        }

    }
}
