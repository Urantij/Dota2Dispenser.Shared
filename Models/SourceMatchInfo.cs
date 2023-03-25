using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2Dispenser.Shared.Models;

/// <summary>
/// Часть информации доступна только после опроса сурств, что происходит не сразу.
/// </summary>
public class SourceMatchInfo
{
    /// <summary>
    /// Айди в доте.
    /// </summary>
    public ulong MatchId { get; set; }

    public uint LobbyType { get; set; }
    public uint GameMode { get; set; }
    /// <summary>
    /// Доступен только в ранкед играх, очевидно.
    /// </summary>
    public uint? AverageMmr { get; set; }

    public SourceMatchInfo(ulong matchId, uint lobbyType, uint gameMode, uint? averageMmr)
    {
        MatchId = matchId;
        LobbyType = lobbyType;
        GameMode = gameMode;
        AverageMmr = averageMmr;
    }
}
