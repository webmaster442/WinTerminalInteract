using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webmaster442.WinTerminalInteract
{
    /// <summary>
    /// This sets how the profile reacts to termination or failure to launch. "graceful" will close the profile when exit is typed or when the process exits normally. "always" will always close the profile and "never" will never close the profile. true and false are accepted as synonyms for "graceful" and "never", respectively.
    /// </summary>
    public enum CloseOnExit
    {
        Graceful,
        Always,
        Never,
        True,
        False,
    }
}
