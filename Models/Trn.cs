using System;
using System.Collections.Generic;

namespace API_ABS.Models
{
    public partial class Trn
    {
        public long Itrnnum { get; set; }
        public long Itrnanum { get; set; }
        public DateTime? Dtrntran { get; set; }
        public DateTime Dtrncreate { get; set; }
        public string Ctrnaccd { get; set; } = null!;
        public string Ctrncur { get; set; } = null!;
        public string Ctrnaccc { get; set; } = null!;
        public string Ctrncurc { get; set; } = null!;
        public decimal Mtrnsum { get; set; }
        public decimal Mtrnrsum { get; set; }
        public decimal Mtrnsumc { get; set; }
        public string Itrntype { get; set; }
        public string? Itrnsop { get; set; }
        public string? Itrnbatnum { get; set; }
        public long? Itrndocnum { get; set; }
        public DateTime? Dtrndoc { get; set; }
        public DateTime? Dtrnval { get; set; }
        public DateTime? Dtrnshadow { get; set; }
        public string? Ctrnmfoo { get; set; }
        public string? Ctrncoracco { get; set; }
        public string? CtrnclientInn { get; set; }
        public string? CtrnclientKpp { get; set; }
        public string? CtrnclientName { get; set; }
        public int? Itrnsbcodea { get; set; }
        public string? Ctrnmfoa { get; set; }
        public string? Ctrncoracca { get; set; }
        public string? Ctrnbnamea { get; set; }
        public string? Ctrnacca { get; set; }
        public string? Ctrninna { get; set; }
        public string? Ctrnkppa { get; set; }
        public string? Ctrnowna { get; set; }
        public string? Ctrnpurp { get; set; }
        public long? Itrnnumanc { get; set; }
        public long? Itrnanumanc { get; set; }
        public string? Itrncocode { get; set; }
        public string? Ctrnstate1 { get; set; }
        public string? Ctrnstate2 { get; set; }
        public string? Ctrnstate3 { get; set; }
        public string? Ctrnstate4 { get; set; }
        public string? Ctrnstate5 { get; set; }
        public string? Ctrnstate8 { get; set; }
        public string? Ctrntext1 { get; set; }
        public string? Ctrntext2 { get; set; }
        public string? Ctrntext3 { get; set; }
        public string? Ctrntext4 { get; set; }
        public bool? Itrnpriority { get; set; }
        public string? Ctrnvo { get; set; }
        public string? Ctrndway { get; set; }
        public string? Ctrnref { get; set; }
        public string? Ctrnzakob { get; set; }
        public string? Itrnpnum { get; set; }
        public string Itrnba2d { get; set; }
        public string Itrnba2c { get; set; }
        public long? Itrnbnkid { get; set; }
        public string? Itrnsubsys { get; set; }
        public string? Itrnsscreg { get; set; }
        public string? Ctrnidopen { get; set; }
        public string? Ctrnidaffirm { get; set; }
        public string? CtrnctrlType { get; set; }
        public string? Ctrnemptytran { get; set; }
        public string? Ctrndnvproc { get; set; }
        public string? CtrnclientAcc { get; set; }
        public string Idsmr { get; set; } = null!;
        public decimal? Itrnannexdoc { get; set; }
        public decimal? Itrnannexleaf { get; set; }

        public virtual Acc Acc { get; set; } = null!;
        public virtual Acc AccNavigation { get; set; } = null!;
    }
}
