using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class BrushTool : Tool
    {
        public string Name { get; set; } = "Brush";

        public void mouseDown()
        {
            Console.WriteLine("--> Selected Brush");
        }

        public void mouseUp()
        {
            Console.WriteLine("--> Draw a line");
        }
    }
}
