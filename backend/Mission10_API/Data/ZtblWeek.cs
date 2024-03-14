using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission10_API.Data;

public partial class ZtblWeek
{
    [Key]
    public DateOnly WeekStart { get; set; }

    public DateOnly? WeekEnd { get; set; }
}
