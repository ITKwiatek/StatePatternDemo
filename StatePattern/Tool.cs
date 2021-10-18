using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public interface Tool
    {
        string Name { get; set; }
        void mouseUp();
        void mouseDown();
    }
}
