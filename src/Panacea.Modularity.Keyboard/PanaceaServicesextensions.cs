using Panacea.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Keyboard
{
    public static class PanaceaServicesextensions
    {
        public static bool TryGetKeyboard(this PanaceaServices core, out IKeyboardPlugin keyboard)
        {
            keyboard = core.PluginLoader.GetPlugins<IKeyboardPlugin>().FirstOrDefault();
            return keyboard != null;
        }
    }
}
