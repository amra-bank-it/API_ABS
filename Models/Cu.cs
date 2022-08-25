using System;
using System.Collections.Generic;

namespace API_ABS.Models
{
    public partial class Cu
    {
        public Cu()
        {
            Accs = new HashSet<Acc>();
        }

        public long Icusnum { get; set; }
        public string? Ccusflag { get; set; }
        public string? Ccusrez { get; set; }
        public DateTime Dcusopen { get; set; }
        public DateTime? Dcusedit { get; set; }
        public string? Icusokpo { get; set; }
        public string Ccusidopen { get; set; } = null!;
        public string? Ccusname { get; set; }
        public string? Ccusprim { get; set; }
        public int? Icustaxnum { get; set; }
        public string? Ccusnumnal { get; set; }
        public string? Ccusename { get; set; }
        public string? Icusotd { get; set; }
        public string? Ccuscoato { get; set; }
        public string? Ccusksiva { get; set; }
        public string? Ccusind { get; set; }
        public string? Icusokonx { get; set; }
        public string? Ccuskfc { get; set; }
        public string? Ccusfulldoc { get; set; }
        public string? Ccuscountry1 { get; set; }
        public string? Ccuscountry2 { get; set; }
        public decimal Icusfwt { get; set; }
        public string? Ccusemail { get; set; }
        public string? Ccuswww { get; set; }
        public string? Ccussoogu { get; set; }
        public string? Ccuskopf { get; set; }
        public string? Ccusclsb { get; set; }
        public int? Icuscup { get; set; }
        public int? Icuscum { get; set; }
        public string? Ccuskpp { get; set; }
        public string? CcusnameSh { get; set; }
        public DateTime? Dcusbirthday { get; set; }
        public string? Ccusiin { get; set; }
        public DateTime? Dcusregdate { get; set; }
        public string? Ccusregagency { get; set; }
        public DateTime? DcuslicDate { get; set; }
        public string? Ccuslicence { get; set; }
        public string? CcusaddrEnglish { get; set; }
        public string? CcusnalSert { get; set; }
        public string? Ccussubbox { get; set; }
        public string? CcusinvoInfo { get; set; }
        public string? Ccusokved { get; set; }
        public string? CcusgovCert { get; set; }
        public string? CcusregnOld { get; set; }
        public string Idsmr { get; set; } = null!;
        public string? Ccusoktmo { get; set; }
        public string? Ccusregplace { get; set; }
        public string? CcusmagicWord { get; set; }
        public string? Ccusein { get; set; }
        public decimal? Icusstatus { get; set; }
        public string? CcuslastName { get; set; }
        public string? CcusfirstName { get; set; }
        public string? CcusmiddleName { get; set; }
        public string? Ccussnils { get; set; }
        public string? Ccuscupregnum { get; set; }
        public string? Ccuscumregnum { get; set; }
        public string? Ccusokved2 { get; set; }
        public string? Ccuskopfm { get; set; }

        public virtual ICollection<Acc> Accs { get; set; }
    }
}
