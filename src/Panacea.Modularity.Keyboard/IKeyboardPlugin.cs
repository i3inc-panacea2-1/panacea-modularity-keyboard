using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Keyboard
{
    public interface IKeyboardPlugin:IPlugin
    {
        void ShowKeyboard(KeyboardType type);

        void HideKeyboard();
    }
}
