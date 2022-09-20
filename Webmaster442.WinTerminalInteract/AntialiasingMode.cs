using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webmaster442.WinTerminalInteract
{
    /// <summary>
    /// This controls how text is antialiased in the renderer. Note that changing this setting will require starting a new terminal instance.
    /// </summary>
    public enum AntialiasingMode
    {
        Grayscale,
        Cleartype,
        Aliased
    }
}
