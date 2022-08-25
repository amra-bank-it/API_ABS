using System;
using System.Collections.Generic;

namespace API_ABS.Models
{
    public partial class Acc
    {
        public Acc()
        {
            TrnAccNavigations = new HashSet<Trn>();
            TrnAccs = new HashSet<Trn>();
        }

        public string? Iaccnum { get; set; }
        public long Iacccus { get; set; }
        public string Iaccbs2 { get; set; }
        public string Caccap { get; set; } = null!;
        public string Caccbvb { get; set; } = null!;
        public string Caccprizn { get; set; } = null!;
        public string Cacccusban { get; set; } = null!;
        public DateTime Daccopen { get; set; }
        public DateTime? Daccedit { get; set; }
        public DateTime? Dacclastoper { get; set; }
        public DateTime? Dacclastvyp { get; set; }
        public string? Caccidopen { get; set; }
        public string? Caccidedit { get; set; }
        public string? Caccname { get; set; }
        public string Cacccur { get; set; } = null!;
        public DateTime? Dacccap { get; set; }
        public string? Caccdelta { get; set; }
        public string? Iaccbs22 { get; set; }
        public string? Caccsio { get; set; }
        public string? Caccreceiptsm { get; set; }
        public string Cacc2fillin { get; set; } = null!;
        public string? Iaccwaitaffirm { get; set; }
        public string? Caccphys { get; set; }
        public string Iaccbs3 { get; set; }
        public string Iaccbs4 { get; set; }
        public string Iaccbs5 { get; set; }
        public string Iaccplannum { get; set; }
        public string? Caccmail { get; set; }
        public string? Iaccprofit { get; set; }
        public string? Iaccbudget { get; set; }
        public string? IaccbudGr { get; set; }
        public string? IaccbudSubsym { get; set; }
        public string? IaccbudPr { get; set; }
        public DateTime Daccclose { get; set; }
        public string? IaccprofitSber { get; set; }
        public string Iaccotd { get; set; }
        public string? Caccclsb { get; set; }
        public string? Iaccter { get; set; }
        public DateTime? Daccpens { get; set; }
        public DateTime? Daccmed { get; set; }
        public bool? Iacccheck { get; set; }
        public string? Caccparse { get; set; }
        public string? CaccnameSh { get; set; }
        public string Caccacc { get; set; } = null!;
        public string? Caccdog { get; set; }
        public DateTime? Daccgraphcard { get; set; }
        public bool? Iaccrezerv { get; set; }
        public string Caccbnkpay { get; set; } = null!;
        public string Idsmr { get; set; } = null!;
        public string? CacccurEqv { get; set; }
        public string? Caccideditm { get; set; }
        public string? CacccurNr { get; set; }
        public decimal Iaccid { get; set; }

        public virtual Cu IacccusNavigation { get; set; } = null!;
        public virtual ICollection<Trn> TrnAccNavigations { get; set; }
        public virtual ICollection<Trn> TrnAccs { get; set; }
    }
}
