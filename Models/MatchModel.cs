using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dota2Dispenser.Shared.Consts;

namespace Dota2Dispenser.Shared.Models;

public class MatchModel
{
    /// <summary>
    /// Айди в базе.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// UTC. Если игра сломана или не закончилась, то дата очень примерная.
    /// </summary>
    public DateTime GameDate { get; set; }

    /// <summary>
    /// Тип лобби, полученный из RP. Работает только для обычных игр.
    /// </summary>
    public string? RichPresenceLobbyType { get; set; }

    public MatchResult MatchResult { get; set; }

    public SourceMatchInfo? TvInfo { get; set; }
    public DetailsMatchInfo? DetailsInfo { get; set; }

    public ICollection<PlayerModel> Players { get; set; }

    public MatchModel(int id, DateTime gameDate, string? richPresenceLobbyType, MatchResult matchResult, SourceMatchInfo? tvInfo, DetailsMatchInfo? detailsInfo, ICollection<PlayerModel> players)
    {
        Id = id;
        GameDate = gameDate;
        RichPresenceLobbyType = richPresenceLobbyType;
        MatchResult = matchResult;
        TvInfo = tvInfo;
        DetailsInfo = detailsInfo;
        Players = players;
    }
}
