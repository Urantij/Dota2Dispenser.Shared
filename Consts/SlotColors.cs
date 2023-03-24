using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2Dispenser.Shared.Consts;

public class SlotColors
{
    // Взято у https://github.com/Hambergo/9kmmrbot/blob/5a27512c3f06f39c8748cb37b3e68dfa34cd5abd/src/dota.ts#L398
    public static readonly string[] colors = new string[] { "Blue", "Teal", "Purple", "Yellow", "Orange", "Pink", "Gray", "Light Blue", "Green", "Brown" };

    public static string? GetColor(int index)
    {
        if (index < 0 || index >= colors.Length)
        {
            return null;
        }

        return colors[index];
    }
}
