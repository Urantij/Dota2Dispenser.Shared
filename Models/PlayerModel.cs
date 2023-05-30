using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2Dispenser.Shared.Models;

public class PlayerModel
{
    public int Id { get; set; }

    /// <summary>
    /// 64<br/>
    /// Если нет айди, значение будет 76561202255233023 или может быть 76561202255233022, я не уверен. Но вроде бы первое.
    /// </summary>
    public ulong SteamId { get; set; }

    /// <summary>
    /// 0, если инфы нет. герои становятся доступны через 2 минуты как их пикнут (дилей)
    /// </summary>
    public uint HeroId { get; set; }

    /// <summary>
    /// Становится доступен, когда игра успешно завершается
    /// https://wiki.teamfortress.com/wiki/WebAPI/GetMatchDetails
    /// 0 - NONE - finished match, no abandon.
    /// 1 - DISCONNECTED - player DC, no abandon.
    /// 2 - DISCONNECTED_TOO_LONG - player DC > 5min, abandoned.
    /// 3 - ABANDONED - player DC, clicked leave, abandoned.
    /// 4 - AFK - player AFK, abandoned.
    /// 5 - NEVER_CONNECTED - player never connected, no abandon.
    /// 6 - NEVER_CONNECTED_TOO_LONG - player took too long to connect, no abandon.
    /// </summary>
    public int? LeaverStatus { get; set; }

    /// <summary>
    /// Становится доступен, когда игра успешно завершается.
    /// По моим наблюдениям, 0 - редиант.
    /// </summary>
    public int? TeamNumber { get; set; }

    /// <summary>
    /// Становится доступен, когда игра успешно завершается.
    /// 0-4
    /// </summary>
    public int? TeamSlot { get; set; }

    /// <summary>
    /// В рамках одного матча одинаковый индекс = пати
    /// </summary>
    public int? PartyIndex { get; set; }

    public PlayerModel(int id, ulong steamId, uint heroId, int? leaverStatus, int? partyIndex)
    {
        Id = id;
        SteamId = steamId;
        HeroId = heroId;
        LeaverStatus = leaverStatus;
        PartyIndex = partyIndex;
    }

    public static bool IsAbandonStatus(int status)
        => status switch
        {
            2 or 3 or 4 => true,
            _ => false,
        };
}
