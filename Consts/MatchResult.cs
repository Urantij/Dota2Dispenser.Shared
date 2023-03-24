namespace Dota2Dispenser.Shared.Consts;

public enum MatchResult
{
    /// <summary>
    /// Матч всё ещё идёт.
    /// </summary>
    None,
    /// <summary>
    /// Матч успешно завершился (успешно = матч дитейлс вернул результат, а есть ли вин это другой вопрос).
    /// </summary>
    Finished,
    /// <summary>
    /// Что-то не даёт получить результат о матче и мы сдались.
    /// </summary>
    Broken,
    /// <summary>
    /// Матч находится до того, как все приняли игру или загрузились. Если он так и не состоялся, то ставим этот тег.
    /// Считай что Broken.
    /// </summary>
    EarlyLeave
}
