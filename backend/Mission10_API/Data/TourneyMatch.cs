﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission10_API.Data;

public partial class TourneyMatch
{
    [Key]
    public int MatchId { get; set; }

    public int? TourneyId { get; set; }

    public string? Lanes { get; set; }

    public int? OddLaneTeamId { get; set; }

    public int? EvenLaneTeamId { get; set; }

    public virtual Team? EvenLaneTeam { get; set; }

    public virtual ICollection<MatchGame> MatchGames { get; set; } = new List<MatchGame>();

    public virtual Team? OddLaneTeam { get; set; }

    public virtual Tournament? Tourney { get; set; }
}
