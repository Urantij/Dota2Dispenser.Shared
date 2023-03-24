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

    public int LobbyType { get; set; }
    public int GameMode { get; set; }
    /// <summary>
    /// Доступен только в ранкед играх, очевидно.
    /// </summary>
    public int? AverageMmr { get; set; }

    public SourceMatchInfo(ulong matchId, int lobbyType, int gameMode, int? averageMmr)
    {
        MatchId = matchId;
        LobbyType = lobbyType;
        GameMode = gameMode;
        AverageMmr = averageMmr;
    }
}
