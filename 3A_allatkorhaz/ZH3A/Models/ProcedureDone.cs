using System;
using System.Collections.Generic;

namespace ZH3A.Models;

public partial class ProcedureDone
{
    public int ProcedureDoneSk { get; set; }

    public int? TreatmentFk { get; set; }

    public int? ProcedureFk { get; set; }

    public virtual Procedure? ProcedureFkNavigation { get; set; }

    public virtual Treatment? TreatmentFkNavigation { get; set; }
}
