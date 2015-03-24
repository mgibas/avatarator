using System.Collections.Generic;
using System.Drawing;

namespace Avatarator
{
    public interface IAvataratorConfig
    {
        IEnumerable<Color> BackgroundColors { get; }

        IAvataratorConfig WithBackgroundColors(IEnumerable<Color> colors);
    }
}
