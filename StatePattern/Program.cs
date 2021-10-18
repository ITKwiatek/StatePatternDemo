using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.SetCurrentTool(new SelectionTool());
            canvas.mouseDown();
            canvas.mouseUp();

            canvas.SetCurrentTool(new BrushTool());
            canvas.mouseDown();
            canvas.mouseUp();
        }
    }
}
