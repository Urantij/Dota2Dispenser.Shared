using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dota2Dispenser.Shared.Models;

namespace Dota2Dispenser.Shared.Responses;

public class FindMatchesResponse
{
    public MatchModel[] Matches { get; set; }

    public FindMatchesResponse(MatchModel[] matches)
    {
        Matches = matches;
    }
}
