using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Canvas
    {
        private Tool _currentTool;

        public void mouseDown()
        {
            _currentTool.mouseDown();
        }
        public void mouseUp()
        {
            _currentTool.mouseUp();
        }

        public Tool getSelectedTool()
        {
            return _currentTool;
        }

        public void SetCurrentTool(Tool currentTool)
        {
            Console.WriteLine($"--> Selected new tool: {currentTool.Name}.");
            _currentTool = currentTool;
        }
    }
}
