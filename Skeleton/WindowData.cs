using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Skeleton
{
    internal class WindowData
    {
        private int windowId = -1;
        private int windowIndex = -1;
        private string processName = "";
        private string windowName = "";
        private int windowOpacity = 255;

        public WindowData(int windowId = -1, int windowIndex = -1, string processName = "", string windowName = "", int windowOpacity = 255)
        {
            this.windowId = windowId;
            this.windowIndex = windowIndex;
            this.processName = processName;
            this.windowName = windowName;
            this.windowOpacity = windowOpacity;
        }

        public int WindowId { get { return windowId; } }
        public int WindowIndex { get { return windowIndex; } }
        public string ProcessName { get {  return processName; } }
        public string WindowName { get { return windowName; } }
        public int WindowOpacity { get {  return windowOpacity; } }
    }
}
