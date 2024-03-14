using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission10_API.Data;

public partial class ZtblSkipLabel
{
    [Key]
    public int LabelCount { get; set; }
}
