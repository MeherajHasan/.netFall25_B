using System;
using System.Collections.Generic;

namespace DBCoreWEBAPI.EF.Models;

public partial class Registration
{
    public int Id { get; set; }

    public string Status { get; set; } = null!;
}
