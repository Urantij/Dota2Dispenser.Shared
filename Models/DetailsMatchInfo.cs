using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2Dispenser.Shared.Models;

/// <summary>
/// Доступно только после завершения игры.
/// </summary>
public class DetailsMatchInfo
{
    public bool? RadiantWin { get; set; }

    public TimeSpan Duration { get; set; }

    public DetailsMatchInfo(bool? radiantWin, TimeSpan duration)
    {
        RadiantWin = radiantWin;
        Duration = duration;
    }
}
