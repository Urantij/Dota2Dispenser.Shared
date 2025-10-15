using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dota2Dispenser.Shared.Consts;

public class Dota2DispenserParams
{
    /// <summary>
    /// Айди матча в базе
    /// </summary>
    public const string dispenserMatchIdFilter = "dmatchid";

    /// <summary>
    /// Айди матча в доте
    /// </summary>
    public const string matchIdFilter = "matchid";

    /// <summary>
    /// 64
    /// </summary>
    public const string steamIdFilter = "steamid";

    /// <summary>
    /// Unix Seconds
    /// </summary>
    public const string afterDateTimeFilter = "after";

    /// <summary>
    /// Максимальное количество матчей. Не больше 20.
    /// </summary>
    public const string limitFilter = "limit";

    /// <summary>
    /// Включить только матчи, чей айди (не матч айди) больше либо равен параметру.
    /// </summary>
    public const string sinceIdFilter = "sinceid";

    /// <summary>
    /// Включить только матчи, чей айди (не матч айди) меньше параметра. 
    /// </summary>
    public const string beforeIdFilter = "beforeid";

    /// <summary>
    /// Имя хедера, куда класть свой айди
    /// </summary>
    public const string idHeader = "Id";
}