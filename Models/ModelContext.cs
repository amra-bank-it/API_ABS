using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API_ABS.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acc> Accs { get; set; } = null!;
        public virtual DbSet<Cu> Cus { get; set; } = null!;
        public virtual DbSet<Trn> Trns { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.55.33.23)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=odb12)));Persist Security Info=True;User Id=XXI;Password=NEW8I;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("XXI");

            modelBuilder.Entity<Acc>(entity =>
            {
                entity.HasKey(e => new { e.Caccacc, e.Cacccur, e.Idsmr })
                    .HasName("P_ACC_ACC_CUR");

                entity.ToTable("acc");

                entity.HasIndex(e => new { e.Iaccbs2, e.Caccbvb }, "I_ACC_BS2_BVB");

                entity.HasIndex(e => new { e.Iaccbs2, e.Caccidedit }, "I_ACC_BS2_IDEDIT");

                entity.HasIndex(e => new { e.Iaccbs2, e.Iaccplannum, e.Cacccur }, "I_ACC_BS2_PLANNUM");

                entity.HasIndex(e => new { e.Iaccbudget, e.IaccbudGr, e.IaccbudSubsym }, "I_ACC_BUDGET_GR_SUBSYM");

                entity.HasIndex(e => e.IaccbudPr, "I_ACC_BUD_PR");

                entity.HasIndex(e => e.CacccurNr, "I_ACC_CACCCUR_NR")
                    .HasFilter("CASE  WHEN \"CACCCUR\"='RUR' THEN NULL ELSE \"CACCCUR\" END ");

                entity.HasIndex(e => e.Daccopen, "I_ACC_OPEN");

                entity.HasIndex(e => e.Caccidedit, "I_ACC_OTVETISP");

                entity.HasIndex(e => e.IaccprofitSber, "I_ACC_PROFIT_SBER");

                entity.HasIndex(e => e.Caccidopen, "I_CACCIDOPEN");

                entity.HasIndex(e => e.Iaccbs2, "I_IACCBS2");

                entity.HasIndex(e => e.Iacccus, "I_IACCCUS");

                entity.HasIndex(e => e.Iaccprofit, "I_IACCPROFIT");

                entity.HasIndex(e => e.Iaccid, "UK_ACC_IACCID")
                    .IsUnique();

                entity.Property(e => e.Caccacc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCACC");

                entity.Property(e => e.Cacccur)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCCUR")
                    .IsFixedLength();

                entity.Property(e => e.Idsmr)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("IDSMR")
                    .HasDefaultValueSql("SYS_CONTEXT ('B21', 'IDSmr') ");

                entity.Property(e => e.Cacc2fillin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACC2FILLIN")
                    .HasDefaultValueSql("'N' ")
                    .IsFixedLength();

                entity.Property(e => e.Caccap)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCAP");

                entity.Property(e => e.Caccbnkpay)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCBNKPAY")
                    .HasDefaultValueSql("'N' ")
                    .IsFixedLength();

                entity.Property(e => e.Caccbvb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCBVB")
                    .IsFixedLength();

                entity.Property(e => e.Caccclsb)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCCLSB");

                entity.Property(e => e.CacccurEqv)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCCUR_EQV");

                entity.Property(e => e.CacccurNr)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CACCCUR_NR")
                    .HasComputedColumnSql("CASE  WHEN \"CACCCUR\"='RUR' THEN NULL ELSE \"CACCCUR\" END ", false)
                    .IsFixedLength();

                entity.Property(e => e.Cacccusban)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCCUSBAN")
                    .IsFixedLength();

                entity.Property(e => e.Caccdelta)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCDELTA");

                entity.Property(e => e.Caccdog)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCDOG");

                entity.Property(e => e.Caccidedit)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCIDEDIT");

                entity.Property(e => e.Caccideditm)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCIDEDITM");

                entity.Property(e => e.Caccidopen)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCIDOPEN")
                    .HasDefaultValueSql("user");

                entity.Property(e => e.Caccmail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCMAIL")
                    .IsFixedLength();

                entity.Property(e => e.Caccname)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCNAME");

                entity.Property(e => e.CaccnameSh)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCNAME_SH");

                entity.Property(e => e.Caccparse)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCPARSE");

                entity.Property(e => e.Caccphys)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCPHYS")
                    .IsFixedLength();

                entity.Property(e => e.Caccprizn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCPRIZN")
                    .IsFixedLength();

                entity.Property(e => e.Caccreceiptsm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCRECEIPTSM")
                    .HasDefaultValueSql("'L'")
                    .IsFixedLength();

                entity.Property(e => e.Caccsio)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CACCSIO");

                entity.Property(e => e.Dacccap)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DACCCAP");

                entity.Property(e => e.Daccclose)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DACCCLOSE");

                entity.Property(e => e.Daccedit)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DACCEDIT");

                entity.Property(e => e.Daccgraphcard)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DACCGRAPHCARD");

                entity.Property(e => e.Dacclastoper)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DACCLASTOPER");

                entity.Property(e => e.Dacclastvyp)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DACCLASTVYP");

                entity.Property(e => e.Daccmed)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DACCMED");

                entity.Property(e => e.Daccopen)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DACCOPEN");

                entity.Property(e => e.Daccpens)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DACCPENS");

                entity.Property(e => e.Iaccbs2)
                    .HasPrecision(5)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCBS2");

                entity.Property(e => e.Iaccbs22)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCBS2_2")
                    .IsFixedLength();

                entity.Property(e => e.Iaccbs3)
                    .HasPrecision(2)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCBS3")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Iaccbs4)
                    .HasPrecision(2)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCBS4")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Iaccbs5)
                    .HasPrecision(2)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCBS5")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.IaccbudGr)
                    .HasPrecision(2)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCBUD_GR");

                entity.Property(e => e.IaccbudPr)
                    .HasPrecision(2)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCBUD_PR");

                entity.Property(e => e.IaccbudSubsym)
                    .HasPrecision(2)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCBUD_SUBSYM");

                entity.Property(e => e.Iaccbudget)
                    .HasPrecision(5)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCBUDGET");

                entity.Property(e => e.Iacccheck)
                    .HasPrecision(1)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCCHECK");

                entity.Property(e => e.Iacccus)
                    .HasPrecision(12)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCCUS");

                entity.Property(e => e.Iaccid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedNever()
                    .HasColumnName("IACCID");

                entity.Property(e => e.Iaccnum)
                    .HasPrecision(3)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCNUM");

                entity.Property(e => e.Iaccotd)
                    .HasPrecision(4)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCOTD");

                entity.Property(e => e.Iaccplannum)
                    .HasPrecision(2)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCPLANNUM")
                    .HasDefaultValueSql("1 ");

                entity.Property(e => e.Iaccprofit)
                    .HasPrecision(5)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCPROFIT");

                entity.Property(e => e.IaccprofitSber)
                    .HasPrecision(5)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCPROFIT_SBER");

                entity.Property(e => e.Iaccrezerv)
                    .IsRequired()
                    .HasPrecision(1)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCREZERV")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Iaccter)
                    .HasPrecision(2)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCTER");

                entity.Property(e => e.Iaccwaitaffirm)
                    .HasPrecision(3)
                    .ValueGeneratedNever()
                    .HasColumnName("IACCWAITAFFIRM");

                entity.HasOne(d => d.IacccusNavigation)
                    .WithMany(p => p.Accs)
                    .HasForeignKey(d => d.Iacccus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("F_IACCCUS");
            });

            modelBuilder.Entity<Cu>(entity =>
            {
                entity.HasKey(e => e.Icusnum)
                    .HasName("P_ICUSNUM");

                entity.ToTable("cus");

                entity.HasIndex(e => e.Icuscum, "F_CUS_CUM");

                entity.HasIndex(e => e.Icuscup, "F_CUS_CUP");

                entity.HasIndex(e => e.Icustaxnum, "F_CUS_TAX");

                entity.HasIndex(e => e.Dcusbirthday, "I_CUS_BIRTHDAY");

                entity.HasIndex(e => e.Ccuscountry1, "I_CUS_COUNTRY1");

                entity.HasIndex(e => e.Ccuscountry2, "I_CUS_COUNTRY2");

                entity.HasIndex(e => e.Ccusflag, "I_CUS_FLAG");

                entity.HasIndex(e => e.Ccusiin, "I_CUS_IIN");

                entity.HasIndex(e => e.Ccusksiva, "I_CUS_KSIVA");

                entity.HasIndex(e => e.Ccusnumnal, "I_CUS_NUMNAL");

                entity.HasIndex(e => e.Dcusopen, "I_CUS_OPEN");

                entity.HasIndex(e => e.CcusregnOld, "I_CUS_REGN_OLD");

                entity.HasIndex(e => e.Ccussubbox, "I_CUS_SUBBOX");

                entity.Property(e => e.Icusnum)
                    .HasPrecision(12)
                    .HasColumnName("ICUSNUM");

                entity.Property(e => e.CcusaddrEnglish)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSADDR_ENGLISH");

                entity.Property(e => e.Ccusclsb)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSCLSB");

                entity.Property(e => e.Ccuscoato)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSCOATO");

                entity.Property(e => e.Ccuscountry1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSCOUNTRY1");

                entity.Property(e => e.Ccuscountry2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSCOUNTRY2");

                entity.Property(e => e.Ccuscumregnum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSCUMREGNUM");

                entity.Property(e => e.Ccuscupregnum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSCUPREGNUM");

                entity.Property(e => e.Ccusein)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSEIN");

                entity.Property(e => e.Ccusemail)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSEMAIL");

                entity.Property(e => e.Ccusename)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSENAME");

                entity.Property(e => e.CcusfirstName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSFIRST_NAME");

                entity.Property(e => e.Ccusflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Ccusfulldoc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSFULLDOC")
                    .HasDefaultValueSql("'0'")
                    .IsFixedLength();

                entity.Property(e => e.CcusgovCert)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSGOV_CERT");

                entity.Property(e => e.Ccusidopen)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSIDOPEN")
                    .HasDefaultValueSql("user ");

                entity.Property(e => e.Ccusiin)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSIIN");

                entity.Property(e => e.Ccusind)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSIND")
                    .IsFixedLength();

                entity.Property(e => e.CcusinvoInfo)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSINVO_INFO");

                entity.Property(e => e.Ccuskfc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSKFC");

                entity.Property(e => e.Ccuskopf)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSKOPF");

                entity.Property(e => e.Ccuskopfm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CCUSKOPFM");

                entity.Property(e => e.Ccuskpp)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSKPP");

                entity.Property(e => e.Ccusksiva)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSKSIVA");

                entity.Property(e => e.CcuslastName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSLAST_NAME");

                entity.Property(e => e.Ccuslicence)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSLICENCE");

                entity.Property(e => e.CcusmagicWord)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSMAGIC_WORD");

                entity.Property(e => e.CcusmiddleName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSMIDDLE_NAME");

                entity.Property(e => e.CcusnalSert)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSNAL_SERT");

                entity.Property(e => e.Ccusname)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSNAME");

                entity.Property(e => e.CcusnameSh)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSNAME_SH");

                entity.Property(e => e.Ccusnumnal)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSNUMNAL");

                entity.Property(e => e.Ccusoktmo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSOKTMO");

                entity.Property(e => e.Ccusokved)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSOKVED");

                entity.Property(e => e.Ccusokved2)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSOKVED2");

                entity.Property(e => e.Ccusprim)
                    .HasMaxLength(132)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSPRIM");

                entity.Property(e => e.Ccusregagency)
                    .HasMaxLength(510)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSREGAGENCY");

                entity.Property(e => e.CcusregnOld)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSREGN_OLD");

                entity.Property(e => e.Ccusregplace)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSREGPLACE");

                entity.Property(e => e.Ccusrez)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSREZ")
                    .IsFixedLength();

                entity.Property(e => e.Ccussnils)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSSNILS");

                entity.Property(e => e.Ccussoogu)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSSOOGU");

                entity.Property(e => e.Ccussubbox)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSSUBBOX");

                entity.Property(e => e.Ccuswww)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CCUSWWW");

                entity.Property(e => e.Dcusbirthday)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DCUSBIRTHDAY");

                entity.Property(e => e.Dcusedit)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DCUSEDIT");

                entity.Property(e => e.DcuslicDate)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DCUSLIC_DATE");

                entity.Property(e => e.Dcusopen)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DCUSOPEN")
                    .HasDefaultValueSql("sysdate ");

                entity.Property(e => e.Dcusregdate)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DCUSREGDATE");

                entity.Property(e => e.Icuscum)
                    .HasPrecision(6)
                    .ValueGeneratedNever()
                    .HasColumnName("ICUSCUM");

                entity.Property(e => e.Icuscup)
                    .HasPrecision(6)
                    .ValueGeneratedNever()
                    .HasColumnName("ICUSCUP");

                entity.Property(e => e.Icusfwt)
                    .HasColumnType("NUMBER(4,2)")
                    .ValueGeneratedNever()
                    .HasColumnName("ICUSFWT")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Icusokonx)
                    .HasPrecision(5)
                    .ValueGeneratedNever()
                    .HasColumnName("ICUSOKONX");

                entity.Property(e => e.Icusokpo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("ICUSOKPO");

                entity.Property(e => e.Icusotd)
                    .HasPrecision(4)
                    .ValueGeneratedNever()
                    .HasColumnName("ICUSOTD")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Icusstatus)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever()
                    .HasColumnName("ICUSSTATUS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Icustaxnum)
                    .HasPrecision(6)
                    .ValueGeneratedNever()
                    .HasColumnName("ICUSTAXNUM");

                entity.Property(e => e.Idsmr)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("IDSMR")
                    .HasDefaultValueSql("SYS_CONTEXT('B21','IDSmr') ");
            });

            modelBuilder.Entity<Trn>(entity =>
            {
                entity.HasKey(e => new { e.Itrnnum, e.Itrnanum })
                    .HasName("P_TRN_NUM_ANUM");

                entity.ToTable("trn");

                entity.HasIndex(e => new { e.Ctrnaccc, e.Ctrncurc, e.Idsmr }, "I_TRN_ACC_CRED");

                entity.HasIndex(e => new { e.Ctrnaccd, e.Ctrncur, e.Idsmr }, "I_TRN_ACC_DEB");

                entity.HasIndex(e => new { e.Itrnbatnum, e.Dtrncreate }, "I_TRN_BATCH");

                entity.HasIndex(e => e.Ctrndnvproc, "I_TRN_CTRNDNVPROC");

                entity.HasIndex(e => e.Ctrnemptytran, "I_TRN_CTRNEMPTYTRAN");

                entity.HasIndex(e => e.Ctrnref, "I_TRN_CTRNREF");

                entity.HasIndex(e => e.Dtrncreate, "I_TRN_DCREATE");

                entity.HasIndex(e => new { e.Dtrndoc, e.Mtrnsum }, "I_TRN_DDOC_SUM");

                entity.HasIndex(e => e.Dtrntran, "I_TRN_DTRAN");

                entity.HasIndex(e => e.Dtrnval, "I_TRN_DVAL");

                entity.HasIndex(e => new { e.Itrnnumanc, e.Itrnanumanc }, "I_TRN_NUM_ANUM_ANC");

                entity.Property(e => e.Itrnnum)
                    .HasPrecision(12)
                    .ValueGeneratedNever()
                    .HasColumnName("ITRNNUM");

                entity.Property(e => e.Itrnanum)
                    .HasPrecision(12)
                    .ValueGeneratedNever()
                    .HasColumnName("ITRNANUM");

                entity.Property(e => e.Ctrnacca)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNACCA");

                entity.Property(e => e.Ctrnaccc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNACCC");

                entity.Property(e => e.Ctrnaccd)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNACCD");

                entity.Property(e => e.Ctrnbnamea)
                    .HasMaxLength(160)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNBNAMEA");

                entity.Property(e => e.CtrnclientAcc)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNCLIENT_ACC");

                entity.Property(e => e.CtrnclientInn)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNCLIENT_INN");

                entity.Property(e => e.CtrnclientKpp)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNCLIENT_KPP");

                entity.Property(e => e.CtrnclientName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNCLIENT_NAME");

                entity.Property(e => e.Ctrncoracca)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNCORACCA");

                entity.Property(e => e.Ctrncoracco)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNCORACCO");

                entity.Property(e => e.CtrnctrlType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNCTRL_TYPE")
                    .IsFixedLength();

                entity.Property(e => e.Ctrncur)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNCUR")
                    .IsFixedLength();

                entity.Property(e => e.Ctrncurc)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNCURC")
                    .IsFixedLength();

                entity.Property(e => e.Ctrndnvproc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNDNVPROC")
                    .IsFixedLength();

                entity.Property(e => e.Ctrndway)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNDWAY");

                entity.Property(e => e.Ctrnemptytran)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNEMPTYTRAN")
                    .IsFixedLength();

                entity.Property(e => e.Ctrnidaffirm)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNIDAFFIRM");

                entity.Property(e => e.Ctrnidopen)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNIDOPEN");

                entity.Property(e => e.Ctrninna)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNINNA");

                entity.Property(e => e.Ctrnkppa)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNKPPA");

                entity.Property(e => e.Ctrnmfoa)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNMFOA");

                entity.Property(e => e.Ctrnmfoo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNMFOO");

                entity.Property(e => e.Ctrnowna)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNOWNA");

                entity.Property(e => e.Ctrnpurp)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNPURP");

                entity.Property(e => e.Ctrnref)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNREF");

                entity.Property(e => e.Ctrnstate1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNSTATE1")
                    .IsFixedLength();

                entity.Property(e => e.Ctrnstate2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNSTATE2")
                    .IsFixedLength();

                entity.Property(e => e.Ctrnstate3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNSTATE3")
                    .IsFixedLength();

                entity.Property(e => e.Ctrnstate4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNSTATE4")
                    .IsFixedLength();

                entity.Property(e => e.Ctrnstate5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNSTATE5")
                    .IsFixedLength();

                entity.Property(e => e.Ctrnstate8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNSTATE8")
                    .IsFixedLength();

                entity.Property(e => e.Ctrntext1)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNTEXT1");

                entity.Property(e => e.Ctrntext2)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNTEXT2");

                entity.Property(e => e.Ctrntext3)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNTEXT3");

                entity.Property(e => e.Ctrntext4)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNTEXT4");

                entity.Property(e => e.Ctrnvo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNVO");

                entity.Property(e => e.Ctrnzakob)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("CTRNZAKOB")
                    .IsFixedLength();

                entity.Property(e => e.Dtrncreate)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DTRNCREATE");

                entity.Property(e => e.Dtrndoc)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DTRNDOC");

                entity.Property(e => e.Dtrnshadow)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DTRNSHADOW");

                entity.Property(e => e.Dtrntran)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DTRNTRAN");

                entity.Property(e => e.Dtrnval)
                    .HasColumnType("DATE")
                    .ValueGeneratedNever()
                    .HasColumnName("DTRNVAL");

                entity.Property(e => e.Idsmr)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("IDSMR")
                    .HasDefaultValueSql("NULL ");

                entity.Property(e => e.Itrnannexdoc)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ITRNANNEXDOC");

                entity.Property(e => e.Itrnannexleaf)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ITRNANNEXLEAF");

                entity.Property(e => e.Itrnanumanc)
                    .HasPrecision(12)
                    .HasColumnName("ITRNANUMANC");

                entity.Property(e => e.Itrnba2c)
                    .HasPrecision(5)
                    .ValueGeneratedNever()
                    .HasColumnName("ITRNBA2C");

                entity.Property(e => e.Itrnba2d)
                    .HasPrecision(5)
                    .ValueGeneratedNever()
                    .HasColumnName("ITRNBA2D");

                entity.Property(e => e.Itrnbatnum)
                    .HasPrecision(4)
                    .ValueGeneratedNever()
                    .HasColumnName("ITRNBATNUM");

                entity.Property(e => e.Itrnbnkid)
                    .HasPrecision(12)
                    .HasColumnName("ITRNBNKID");

                entity.Property(e => e.Itrncocode)
                    .HasPrecision(3)
                    .ValueGeneratedNever()
                    .HasColumnName("ITRNCOCODE");

                entity.Property(e => e.Itrndocnum)
                    .HasPrecision(16)
                    .ValueGeneratedNever()
                    .HasColumnName("ITRNDOCNUM");

                entity.Property(e => e.Itrnnumanc)
                    .HasPrecision(12)
                    .HasColumnName("ITRNNUMANC");

                entity.Property(e => e.Itrnpnum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever()
                    .HasColumnName("ITRNPNUM")
                    .IsFixedLength();

                entity.Property(e => e.Itrnpriority)
                    .HasPrecision(1)
                    .ValueGeneratedNever()
                    .HasColumnName("ITRNPRIORITY");

                entity.Property(e => e.Itrnsbcodea)
                    .HasPrecision(10)
                    .HasColumnName("ITRNSBCODEA");

                entity.Property(e => e.Itrnsop)
                    .HasPrecision(3)
                    .ValueGeneratedNever()
                    .HasColumnName("ITRNSOP");

                entity.Property(e => e.Itrnsscreg)
                    .HasPrecision(3)
                    .HasColumnName("ITRNSSCREG");

                entity.Property(e => e.Itrnsubsys)
                    .HasPrecision(3)
                    .HasColumnName("ITRNSUBSYS");

                entity.Property(e => e.Itrntype)
                    .HasPrecision(3)
                    .ValueGeneratedNever()
                    .HasColumnName("ITRNTYPE");

                entity.Property(e => e.Mtrnrsum)
                    .HasColumnType("NUMBER(16,2)")
                    .ValueGeneratedNever()
                    .HasColumnName("MTRNRSUM");

                entity.Property(e => e.Mtrnsum)
                    .HasColumnType("NUMBER(16,2)")
                    .ValueGeneratedNever()
                    .HasColumnName("MTRNSUM");

                entity.Property(e => e.Mtrnsumc)
                    .HasColumnType("NUMBER(16,2)")
                    .ValueGeneratedNever()
                    .HasColumnName("MTRNSUMC");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.TrnAccs)
                    .HasForeignKey(d => new { d.Ctrnaccc, d.Ctrncurc, d.Idsmr })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRN_ACC_CUR_CRED");

                entity.HasOne(d => d.AccNavigation)
                    .WithMany(p => p.TrnAccNavigations)
                    .HasForeignKey(d => new { d.Ctrnaccd, d.Ctrncur, d.Idsmr })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRN_ACC_CUR_DEB");
            });

            modelBuilder.HasSequence("AB_FORM_DATASETS_SEQ");

            modelBuilder.HasSequence("AB_FORM_ERRORS_SEQ");

            modelBuilder.HasSequence("AB_PARSERS_SEQ");

            modelBuilder.HasSequence("AB_SCRIPTS_SEQ");

            modelBuilder.HasSequence("ARC_S_DATES_INNUM_ID");

            modelBuilder.HasSequence("ARC_S_DIMPM_ID");

            modelBuilder.HasSequence("ARC_S_DOC_ID");

            modelBuilder.HasSequence("ARC_S_DSPR_ID");

            modelBuilder.HasSequence("ARC_S_FILENAME_ID");

            modelBuilder.HasSequence("ARC_S_OINFO_ID");

            modelBuilder.HasSequence("ARC_S_PDPD_ID");

            modelBuilder.HasSequence("ARC_S_RPRM_ID");

            modelBuilder.HasSequence("ARC_S_SREP_ID");

            modelBuilder.HasSequence("ARC_S_TACT_ID");

            modelBuilder.HasSequence("ARC_S_TCK_ID");

            modelBuilder.HasSequence("BATCH_JOB_EXECUTION_SEQ");

            modelBuilder.HasSequence("BATCH_JOB_SEQ");

            modelBuilder.HasSequence("BATCH_STEP_EXECUTION_SEQ");

            modelBuilder.HasSequence("BCONVERT_HD_SEQ");

            modelBuilder.HasSequence("CBS_SEQCDACT");

            modelBuilder.HasSequence("CBS_WCTMPCID");

            modelBuilder.HasSequence("CBS_WCTMPPK");

            modelBuilder.HasSequence("CBSBUS_CORID").IsCyclic();

            modelBuilder.HasSequence("CBSBUS_GATEID").IsCyclic();

            modelBuilder.HasSequence("CBSBUS_LOGID").IsCyclic();

            modelBuilder.HasSequence("COG_IDGEN");

            modelBuilder.HasSequence("CUST_SEQ");

            modelBuilder.HasSequence("DC_S_TARIFID");

            modelBuilder.HasSequence("DC_S_VEDACCID");

            modelBuilder.HasSequence("DC_S_VEDID");

            modelBuilder.HasSequence("DESC_SEQ");

            modelBuilder.HasSequence("DEST_SEQ");

            modelBuilder.HasSequence("DIMG_SEQ");

            modelBuilder.HasSequence("DJ_GRP_ID");

            modelBuilder.HasSequence("DJ_OPTS_ID");

            modelBuilder.HasSequence("DJ_REP_CACHE_SEQUENCE").IsCyclic();

            modelBuilder.HasSequence("DJ_S_AU_ACTION");

            modelBuilder.HasSequence("DJ_S_QDP");

            modelBuilder.HasSequence("DJ_S_ZAGR");

            modelBuilder.HasSequence("DJ_SEQ_ITEMS");

            modelBuilder.HasSequence("DOCUMENT_UID");

            modelBuilder.HasSequence("EDS_S_OUTED_ID");

            modelBuilder.HasSequence("EDS_S_OUTF_ID");

            modelBuilder.HasSequence("EVENT_SEQ");

            modelBuilder.HasSequence("EXT_ACTION_SEQ");

            modelBuilder.HasSequence("EXT_BATCH_SEQ");

            modelBuilder.HasSequence("EXT_CARDPROD_SEQ");

            modelBuilder.HasSequence("EXT_HANDLER_SEQ");

            modelBuilder.HasSequence("EXT_PARAM_SEQ");

            modelBuilder.HasSequence("EXT_PRODUCT_SEQ");

            modelBuilder.HasSequence("EXT_SBLCLILOG_SEQ");

            modelBuilder.HasSequence("EXT_SHOPPP_SEQ");

            modelBuilder.HasSequence("FR_QUERIES_SEQ");

            modelBuilder.HasSequence("GR_IDFILE").IsCyclic();

            modelBuilder.HasSequence("GR_KOM1");

            modelBuilder.HasSequence("GR_NAMEFILE").IsCyclic();

            modelBuilder.HasSequence("GR_NUMDOCREIS").IsCyclic();

            modelBuilder.HasSequence("GR_VKL_FILE");

            modelBuilder.HasSequence("IBG_TIME_MEASUREMENT_SEQ");

            modelBuilder.HasSequence("IK_BPC_REESTR_ID");

            modelBuilder.HasSequence("MSG_SEQ");

            modelBuilder.HasSequence("NEXTDISK");

            modelBuilder.HasSequence("ON_S_PASSP_ID");

            modelBuilder.HasSequence("ON_S_PAYMENTS_ID");

            modelBuilder.HasSequence("OV_PURP_CAT_SEQ");

            modelBuilder.HasSequence("OV_REESTR_SVO_SEQ");

            modelBuilder.HasSequence("OV_SEQ_OV_CASSIMB");

            modelBuilder.HasSequence("PFR_REPS_MASSIV");

            modelBuilder.HasSequence("PL_IK_BPC_DF8003");

            modelBuilder.HasSequence("PL_IK_BPC_DF8007");

            modelBuilder.HasSequence("PL_IK_BPC_DF801D");

            modelBuilder.HasSequence("PL_IK_BPC_DF8041");

            modelBuilder.HasSequence("PL_IK_BPC_DF8117");

            modelBuilder.HasSequence("PL_IK_BTRT08_ID");

            modelBuilder.HasSequence("PLSQL_PROFILER_RUNNUMBER");

            modelBuilder.HasSequence("PRC_STA_SEQ");

            modelBuilder.HasSequence("S_ACC_ID");

            modelBuilder.HasSequence("S_ACC_INFO_ID_FILE");

            modelBuilder.HasSequence("S_ACC_NUM");

            modelBuilder.HasSequence("S_ACC_REZ_PRTF_ID");

            modelBuilder.HasSequence("S_ACC_TP_ID").IncrementsBy(-1);

            modelBuilder.HasSequence("S_ACC_V_LIST_ID");

            modelBuilder.HasSequence("S_ACK_ID");

            modelBuilder.HasSequence("S_AD_HOC_12");

            modelBuilder.HasSequence("S_AF_ID");

            modelBuilder.HasSequence("S_AL_ID_ACC_LIST_SAVED");

            modelBuilder.HasSequence("S_ANC");

            modelBuilder.HasSequence("S_AOS_INT_ID");

            modelBuilder.HasSequence("S_AP_ID");

            modelBuilder.HasSequence("S_AR");

            modelBuilder.HasSequence("S_ARC_PRMD_ID");

            modelBuilder.HasSequence("S_ASV_CM_BNK");

            modelBuilder.HasSequence("S_ASV_CM_CTR");

            modelBuilder.HasSequence("S_ASV_CM_DEP");

            modelBuilder.HasSequence("S_ASV_CM_DEP_1");

            modelBuilder.HasSequence("S_ASV_CM_DEP_2");

            modelBuilder.HasSequence("S_ASV_CM_FIL");

            modelBuilder.HasSequence("S_ASV_CM_FL");

            modelBuilder.HasSequence("S_ASV_CM_INV");

            modelBuilder.HasSequence("S_ASV_CM_INV_1");

            modelBuilder.HasSequence("S_ASV_CM_INV_2");

            modelBuilder.HasSequence("S_ASV_CM_INV_3");

            modelBuilder.HasSequence("S_ASV_CM_INV_INFO");

            modelBuilder.HasSequence("S_ASV_CM_LD");

            modelBuilder.HasSequence("S_ASV_CM_LG");

            modelBuilder.HasSequence("S_ASV_CM_RT");

            modelBuilder.HasSequence("S_ASV_CM_SSV");

            modelBuilder.HasSequence("S_ASV_CM_ST");

            modelBuilder.HasSequence("S_ASV_CM_STD");

            modelBuilder.HasSequence("S_ASV_OPTS_MF_ID");

            modelBuilder.HasSequence("S_ATR");

            modelBuilder.HasSequence("S_ATR_EXT");

            modelBuilder.HasSequence("S_ATR_LST");

            modelBuilder.HasSequence("S_ATR_VAL");

            modelBuilder.HasSequence("S_AU_ACTION");

            modelBuilder.HasSequence("S_AU_FORM_ACT_SESSION");

            modelBuilder.HasSequence("S_AU_GLOSSARY");

            modelBuilder.HasSequence("S_AU_SESSION");

            modelBuilder.HasSequence("S_AUT_GROUP").IsCyclic();

            modelBuilder.HasSequence("S_AV");

            modelBuilder.HasSequence("S_AXLE");

            modelBuilder.HasSequence("S_B3");

            modelBuilder.HasSequence("S_BCH_DOC");

            modelBuilder.HasSequence("S_BCH_INQ");

            modelBuilder.HasSequence("S_BDC_RT");

            modelBuilder.HasSequence("S_BDC_RW");

            modelBuilder.HasSequence("S_BDC_ST");

            modelBuilder.HasSequence("S_BDC_TRC");

            modelBuilder.HasSequence("S_BDOV");

            modelBuilder.HasSequence("S_BE_AVAL_CODE");

            modelBuilder.HasSequence("S_BE_BIL_CODE");

            modelBuilder.HasSequence("S_BE_BIT_NUMACTION");

            modelBuilder.HasSequence("S_BE_DOG_NUM");

            modelBuilder.HasSequence("S_BE_IDLINK");

            modelBuilder.HasSequence("S_BE_KONTR_CODE");

            modelBuilder.HasSequence("S_BE_LINKAVAL_CODE");

            modelBuilder.HasSequence("S_BE_ROWBIL_SESS");

            modelBuilder.HasSequence("S_BFAK_SIGN");

            modelBuilder.HasSequence("S_BFPR_IN_BOOK");

            modelBuilder.HasSequence("S_BICDU$LOG").IsCyclic();

            modelBuilder.HasSequence("S_BIL_AGR");

            modelBuilder.HasSequence("S_BIL_CONT_INFO");

            modelBuilder.HasSequence("S_BIL_CUR");

            modelBuilder.HasSequence("S_BIL_FLUC");

            modelBuilder.HasSequence("S_BIL_NI_FILES_INT_ID");

            modelBuilder.HasSequence("S_BIL_NI_ROWNUM");

            modelBuilder.HasSequence("S_BIL_OSR");

            modelBuilder.HasSequence("S_BIL_OSUM");

            modelBuilder.HasSequence("S_BIL_OTCH");

            modelBuilder.HasSequence("S_BIL_PRC");

            modelBuilder.HasSequence("S_BIL_SVZAKLAD_ID");

            modelBuilder.HasSequence("S_BIL_VEK_443P_ID");

            modelBuilder.HasSequence("S_BK_FLD");

            modelBuilder.HasSequence("S_BK_RW");

            modelBuilder.HasSequence("S_BNKR_CZ");

            modelBuilder.HasSequence("S_BNKR_FL");

            modelBuilder.HasSequence("S_BO_ID");

            modelBuilder.HasSequence("S_BP_VA_PAIR_ID");

            modelBuilder.HasSequence("S_BPA_ORDERS");

            modelBuilder.HasSequence("S_BPA_REG");

            modelBuilder.HasSequence("S_BPA_SUM");

            modelBuilder.HasSequence("S_BPP_DEF");

            modelBuilder.HasSequence("S_BR_MAIN");

            modelBuilder.HasSequence("S_BS_A_FR");

            modelBuilder.HasSequence("S_BS_A_RULITEM");

            modelBuilder.HasSequence("S_BS_ATP");

            modelBuilder.HasSequence("S_BS_ATTR");

            modelBuilder.HasSequence("S_BS_AU_EVT");

            modelBuilder.HasSequence("S_BS_AU_SUMEVT");

            modelBuilder.HasSequence("S_BS_AU_TBL");

            modelBuilder.HasSequence("S_BS_BPCELL");

            modelBuilder.HasSequence("S_BS_BPCOL");

            modelBuilder.HasSequence("S_BS_BPROW");

            modelBuilder.HasSequence("S_BS_BREP");

            modelBuilder.HasSequence("S_BS_CAT");

            modelBuilder.HasSequence("S_BS_CAT_UD").IncrementsBy(-1);

            modelBuilder.HasSequence("S_BS_CBL");

            modelBuilder.HasSequence("S_BS_CID");

            modelBuilder.HasSequence("S_BS_CLS").IncrementsBy(-1);

            modelBuilder.HasSequence("S_BS_DOC");

            modelBuilder.HasSequence("S_BS_EA_ATTR");

            modelBuilder.HasSequence("S_BS_EA_LINK");

            modelBuilder.HasSequence("S_BS_EA_VAL");

            modelBuilder.HasSequence("S_BS_GTWPRT");

            modelBuilder.HasSequence("S_BS_HD");

            modelBuilder.HasSequence("S_BS_HUS");

            modelBuilder.HasSequence("S_BS_M_ATTR");

            modelBuilder.HasSequence("S_BS_M_ENT");

            modelBuilder.HasSequence("S_BS_M_EVENT");

            modelBuilder.HasSequence("S_BS_M_PROP");

            modelBuilder.HasSequence("S_BS_MARK_I");

            modelBuilder.HasSequence("S_BS_PROP");

            modelBuilder.HasSequence("S_BS_RATE");

            modelBuilder.HasSequence("S_BS_RTTP");

            modelBuilder.HasSequence("S_BS_RTVLBL");

            modelBuilder.HasSequence("S_BS_STORED_FILES");

            modelBuilder.HasSequence("S_BS_STORED_RPT");

            modelBuilder.HasSequence("S_BS_TPLCOL");

            modelBuilder.HasSequence("S_BS_TUNE");

            modelBuilder.HasSequence("S_BS_UIR");

            modelBuilder.HasSequence("S_BS_VSSOT");

            modelBuilder.HasSequence("S_BSN_ACC");

            modelBuilder.HasSequence("S_BSN_ATH");

            modelBuilder.HasSequence("S_BSN_DG");

            modelBuilder.HasSequence("S_BSN_PAY");

            modelBuilder.HasSequence("S_BSN_SG");

            modelBuilder.HasSequence("S_BSN_SP");

            modelBuilder.HasSequence("S_BSN_T2A");

            modelBuilder.HasSequence("S_BSN_TF");

            modelBuilder.HasSequence("S_BSN_TRM");

            modelBuilder.HasSequence("S_BSN_ZN");

            modelBuilder.HasSequence("S_BUS_UTIL");

            modelBuilder.HasSequence("S_BZPL_BOBT");

            modelBuilder.HasSequence("S_CA");

            modelBuilder.HasSequence("S_CAF_GROUPS_IDGROUP");

            modelBuilder.HasSequence("S_CALISO_MAP_ID");

            modelBuilder.HasSequence("S_CASH_REG_IROWID");

            modelBuilder.HasSequence("S_CASH_REG3");

            modelBuilder.HasSequence("S_CBH");

            modelBuilder.HasSequence("S_CBS_EXT_EVENT_ID");

            modelBuilder.HasSequence("S_CBS_ST_TEMP_ID");

            modelBuilder.HasSequence("S_CBSFCS");

            modelBuilder.HasSequence("S_CD_BKI_IC_FILE").IsCyclic();

            modelBuilder.HasSequence("S_CD_BKI_IC_MSG").IsCyclic();

            modelBuilder.HasSequence("S_CD_CDE_CES");

            modelBuilder.HasSequence("S_CD_CHCK");

            modelBuilder.HasSequence("S_CD_DOC");

            modelBuilder.HasSequence("S_CD_GRP");

            modelBuilder.HasSequence("S_CD_INTD");

            modelBuilder.HasSequence("S_CD_INTDM");

            modelBuilder.HasSequence("S_CD_MD");

            modelBuilder.HasSequence("S_CD_REM").IsCyclic();

            modelBuilder.HasSequence("S_CD_ROWVERSION").IsCyclic();

            modelBuilder.HasSequence("S_CD_RPS");

            modelBuilder.HasSequence("S_CD_TMTRTABLE").IsCyclic();

            modelBuilder.HasSequence("S_CD_XLIMPORTSQ").IsCyclic();

            modelBuilder.HasSequence("S_CD$_CAT");

            modelBuilder.HasSequence("S_CDA");

            modelBuilder.HasSequence("S_CDA_FDOC_ID_FILE");

            modelBuilder.HasSequence("S_CDADDITREF");

            modelBuilder.HasSequence("S_CDADDITREFVAL");

            modelBuilder.HasSequence("S_CDAU_ACTION");

            modelBuilder.HasSequence("S_CDCNT_FDOC_ID_FILE");

            modelBuilder.HasSequence("S_CDCUSTBL");

            modelBuilder.HasSequence("S_CDDCEXP");

            modelBuilder.HasSequence("S_CDDEP");

            modelBuilder.HasSequence("S_CDIFRS_CDAEV");

            modelBuilder.HasSequence("S_CDINSUR");

            modelBuilder.HasSequence("S_CDINSUR_ATTOBJ");

            modelBuilder.HasSequence("S_CDINSURPR");

            modelBuilder.HasSequence("S_CDINSURPR_ACC");

            modelBuilder.HasSequence("S_CDINSZOST");

            modelBuilder.HasSequence("S_CDL");

            modelBuilder.HasSequence("S_CDLAW_SUIT_ID").IsCyclic();

            modelBuilder.HasSequence("S_CDMO_GRP");

            modelBuilder.HasSequence("S_CDMO_GUARANT").IncrementsBy(5);

            modelBuilder.HasSequence("S_CDMO_LOG");

            modelBuilder.HasSequence("S_CDMO_PR_ID");

            modelBuilder.HasSequence("S_CDMO_SCDOC_ID_FILE");

            modelBuilder.HasSequence("S_CDMO_Z").IncrementsBy(5);

            modelBuilder.HasSequence("S_CDMO_Z_CDOC");

            modelBuilder.HasSequence("S_CDMO_Z_DOC");

            modelBuilder.HasSequence("S_CDMOP");

            modelBuilder.HasSequence("S_CDOFFC");

            modelBuilder.HasSequence("S_CDOP");

            modelBuilder.HasSequence("S_CDOP_CL");

            modelBuilder.HasSequence("S_CDPP");

            modelBuilder.HasSequence("S_CDPP_M");

            modelBuilder.HasSequence("S_CDPTHEADID");

            modelBuilder.HasSequence("S_CDSECURLIST");

            modelBuilder.HasSequence("S_CDTD");

            modelBuilder.HasSequence("S_CDTP");

            modelBuilder.HasSequence("S_CEC_CRF_RES");

            modelBuilder.HasSequence("S_CEC_PCR_ACC");

            modelBuilder.HasSequence("S_CEC_PCR_CL");

            modelBuilder.HasSequence("S_CEC_PCR_PERS");

            modelBuilder.HasSequence("S_CEC_PCR_REQ");

            modelBuilder.HasSequence("S_CEC_PCR_RES");

            modelBuilder.HasSequence("S_CEC_PCR_SEC");

            modelBuilder.HasSequence("S_CHECK_PREFS");

            modelBuilder.HasSequence("S_CHECKVAL_DJ_JOBS").IsCyclic();

            modelBuilder.HasSequence("S_CLIENT");

            modelBuilder.HasSequence("S_CM_EXCHS_ID");

            modelBuilder.HasSequence("S_CMB_ID");

            modelBuilder.HasSequence("S_CMESSAGES");

            modelBuilder.HasSequence("S_CMK");

            modelBuilder.HasSequence("S_CNQB_FILENAME");

            modelBuilder.HasSequence("S_CNQC_FILENAME");

            modelBuilder.HasSequence("S_CNQD_FILENAME");

            modelBuilder.HasSequence("S_CNTR_AGRE_ID");

            modelBuilder.HasSequence("S_CNTR_ID_ADDR");

            modelBuilder.HasSequence("S_CNTR_ID_ATR");

            modelBuilder.HasSequence("S_CNTR_ID_ATR_VAL");

            modelBuilder.HasSequence("S_CNTR_ID_CALL");

            modelBuilder.HasSequence("S_CNTR_ID_DOCUM");

            modelBuilder.HasSequence("S_CNTR_ID_EVENT");

            modelBuilder.HasSequence("S_CNTR_ID_HD");

            modelBuilder.HasSequence("S_CNTR_ID_LICENCE");

            modelBuilder.HasSequence("S_CNTR_ID_LNK");

            modelBuilder.HasSequence("S_CNTR_ID_NS");

            modelBuilder.HasSequence("S_CNTR_ID_OPINFO");

            modelBuilder.HasSequence("S_CNTR_ID_ORGAN");

            modelBuilder.HasSequence("S_CNTR_ID_PHONE");

            modelBuilder.HasSequence("S_CNTR_ID_POST");

            modelBuilder.HasSequence("S_CNTR_ID_RSN");

            modelBuilder.HasSequence("S_CNTR_ID_RSV");

            modelBuilder.HasSequence("S_CNTR_IMAGE_INT_ID");

            modelBuilder.HasSequence("S_CNTR_IMP_LIST");

            modelBuilder.HasSequence("S_CNTR_INFO_ID_FILE");

            modelBuilder.HasSequence("S_CNTR_LST_ORGAN_INT_ID");

            modelBuilder.HasSequence("S_CNTR_LST_POST_INT_ID");

            modelBuilder.HasSequence("S_CNTR_MRK_ID");

            modelBuilder.HasSequence("S_CNTR_THEME_ID");

            modelBuilder.HasSequence("S_COM_SUM_INT_ID");

            modelBuilder.HasSequence("S_COST");

            modelBuilder.HasSequence("S_CP");

            modelBuilder.HasSequence("S_CPARTY");

            modelBuilder.HasSequence("S_CPOZ");

            modelBuilder.HasSequence("S_CPRP");

            modelBuilder.HasSequence("S_CRC_ORDERS");

            modelBuilder.HasSequence("S_CRC_RATES");

            modelBuilder.HasSequence("S_CTRL").IsCyclic();

            modelBuilder.HasSequence("S_CUS_AGRE_ID");

            modelBuilder.HasSequence("S_CUS_BUSINESS");

            modelBuilder.HasSequence("S_CUS_EMAIL_ID");

            modelBuilder.HasSequence("S_CUS_EXTR_ACC_INT_ID");

            modelBuilder.HasSequence("S_CUS_EXTR_CONTROL_INT_ID");

            modelBuilder.HasSequence("S_CUS_GL_AGREE_INT_ID");

            modelBuilder.HasSequence("S_CUS_ID_ADDR");

            modelBuilder.HasSequence("S_CUS_ID_CALL");

            modelBuilder.HasSequence("S_CUS_ID_DOCUM");

            modelBuilder.HasSequence("S_CUS_ID_EVENT");

            modelBuilder.HasSequence("S_CUS_ID_HD");

            modelBuilder.HasSequence("S_CUS_ID_LNK");

            modelBuilder.HasSequence("S_CUS_ID_ORGAN");

            modelBuilder.HasSequence("S_CUS_ID_PHONE");

            modelBuilder.HasSequence("S_CUS_ID_POST");

            modelBuilder.HasSequence("S_CUS_IMAGE_INT_ID");

            modelBuilder.HasSequence("S_CUS_IMP_LIST");

            modelBuilder.HasSequence("S_CUS_INFO_ID_FILE");

            modelBuilder.HasSequence("S_CUS_LST_ORGAN_INT_ID");

            modelBuilder.HasSequence("S_CUS_LST_POST_INT_ID");

            modelBuilder.HasSequence("S_CUS_MRK_ID");

            modelBuilder.HasSequence("S_CUS_NDFL_ID");

            modelBuilder.HasSequence("S_CUS_NDFL_ID_EC");

            modelBuilder.HasSequence("S_CUS_SMS_ID");

            modelBuilder.HasSequence("S_CUS_THEME_ID");

            modelBuilder.HasSequence("S_CV_DOCID");

            modelBuilder.HasSequence("S_CZH");

            modelBuilder.HasSequence("S_CZHFC").IncrementsBy(5);

            modelBuilder.HasSequence("S_CZHFC_FDOC_ID_FILE");

            modelBuilder.HasSequence("S_CZHM").IncrementsBy(5);

            modelBuilder.HasSequence("S_CZHMSFO");

            modelBuilder.HasSequence("S_CZO");

            modelBuilder.HasSequence("S_CZO_FDOC_ID_FILE");

            modelBuilder.HasSequence("S_CZOPDH");

            modelBuilder.HasSequence("S_CZOST_FDOC_ID_FILE");

            modelBuilder.HasSequence("S_CZV");

            modelBuilder.HasSequence("S_CZW");

            modelBuilder.HasSequence("S_CZWW");

            modelBuilder.HasSequence("S_D3");

            modelBuilder.HasSequence("S_DE_COMS_ID");

            modelBuilder.HasSequence("S_DE_MAK_ID");

            modelBuilder.HasSequence("S_DEALRURPO").IsCyclic();

            modelBuilder.HasSequence("S_DEBUG_ROWS");

            modelBuilder.HasSequence("S_DEPOSITORS_DEP_NUM");

            modelBuilder.HasSequence("S_DJ_ACC");

            modelBuilder.HasSequence("S_DJ_AN_GROUP");

            modelBuilder.HasSequence("S_DJ_AN_LINK");

            modelBuilder.HasSequence("S_DJ_DOCD");

            modelBuilder.HasSequence("S_DJ_FORMULE");

            modelBuilder.HasSequence("S_DJ_GLOBAL");

            modelBuilder.HasSequence("S_DJ_JOBID");

            modelBuilder.HasSequence("S_DJ_MD1").IsCyclic();

            modelBuilder.HasSequence("S_DJ_MD2");

            modelBuilder.HasSequence("S_DJ_MULTI");

            modelBuilder.HasSequence("S_DJ_OFFICIAL");

            modelBuilder.HasSequence("S_DJ_PERIOD");

            modelBuilder.HasSequence("S_DJ_PREV");

            modelBuilder.HasSequence("S_DJ_PRINT");

            modelBuilder.HasSequence("S_DJ_PRINT_PAK");

            modelBuilder.HasSequence("S_DJ_PRODUCT");

            modelBuilder.HasSequence("S_DJ_QEC_CACHE_HEAD").IsCyclic();

            modelBuilder.HasSequence("S_DJ_RATIO");

            modelBuilder.HasSequence("S_DJ_REDO").IsCyclic();

            modelBuilder.HasSequence("S_DJ_REDO_PART").IsCyclic();

            modelBuilder.HasSequence("S_DJ_RULES");

            modelBuilder.HasSequence("S_DJ_SWIFT_LOG_MT320_ID");

            modelBuilder.HasSequence("S_DJ_TRACE").IsCyclic();

            modelBuilder.HasSequence("S_DJ_TRUST");

            modelBuilder.HasSequence("S_DM_CG_I_CGID");

            modelBuilder.HasSequence("S_DOCRKO");

            modelBuilder.HasSequence("S_DOMAIN_ID");

            modelBuilder.HasSequence("S_DOMAIN_VAL_ID");

            modelBuilder.HasSequence("S_DR_ID");

            modelBuilder.HasSequence("S_DSKCOD");

            modelBuilder.HasSequence("S_DZ");

            modelBuilder.HasSequence("S_DZ_ALT_DATA");

            modelBuilder.HasSequence("S_DZ_CON_COMM");

            modelBuilder.HasSequence("S_DZ_CON_PAYSUM");

            modelBuilder.HasSequence("S_DZ_CONTRACTS");

            modelBuilder.HasSequence("S_DZ_CONV");

            modelBuilder.HasSequence("S_DZ_CUS_A");

            modelBuilder.HasSequence("S_DZ_FORMULE");

            modelBuilder.HasSequence("S_DZ_GROUP");

            modelBuilder.HasSequence("S_DZ_SCHEME");

            modelBuilder.HasSequence("S_DZ_SCHEME_PROV");

            modelBuilder.HasSequence("S_DZ_SCHEME_SUM");

            modelBuilder.HasSequence("S_DZ_TARIFFS");

            modelBuilder.HasSequence("S_DZ_TAXS");

            modelBuilder.HasSequence("S_DZ_TYPE_ACC_DEP");

            modelBuilder.HasSequence("S_DZ_TYPE_CON");

            modelBuilder.HasSequence("S_EC_CL_MCH");

            modelBuilder.HasSequence("S_EC_MVK_DS");

            modelBuilder.HasSequence("S_EC_MVK_SA");

            modelBuilder.HasSequence("S_EC_MVK_SD");

            modelBuilder.HasSequence("S_EC_MVK_SJ");

            modelBuilder.HasSequence("S_EC_PROMU");

            modelBuilder.HasSequence("S_EF_SYN_ID").IsCyclic();

            modelBuilder.HasSequence("S_EF_WORD_ID");

            modelBuilder.HasSequence("S_EF3_FND_ID");

            modelBuilder.HasSequence("S_EFRSB_CRDES");

            modelBuilder.HasSequence("S_EFRSB_DEB");

            modelBuilder.HasSequence("S_EFRSB_LOG");

            modelBuilder.HasSequence("S_EFRSB_REP");

            modelBuilder.HasSequence("S_EOD_RPRTF_AUDIT");

            modelBuilder.HasSequence("S_ERR1708");

            modelBuilder.HasSequence("S_EXCEPT_LIST");

            modelBuilder.HasSequence("S_EXECREPNUM");

            modelBuilder.HasSequence("S_EXPF");

            modelBuilder.HasSequence("S_EXPF_RID");

            modelBuilder.HasSequence("S_EXR_CL");

            modelBuilder.HasSequence("S_EXR_CUR");

            modelBuilder.HasSequence("S_EXR_ORDERS");

            modelBuilder.HasSequence("S_EXR_RATES");

            modelBuilder.HasSequence("S_EXR_SCALES");

            modelBuilder.HasSequence("S_EXT_2KRNL");

            modelBuilder.HasSequence("S_EXT_2XML_SEQ");

            modelBuilder.HasSequence("S_EXT_API_LOG_DJ_BNK");

            modelBuilder.HasSequence("S_EXT_API_LOG_DJ_CLS");

            modelBuilder.HasSequence("S_EXT_API_LOG_DJ_SMS");

            modelBuilder.HasSequence("S_EXT_OUTPUT_STORE");

            modelBuilder.HasSequence("S_F110_RES_ID");

            modelBuilder.HasSequence("S_F127_SAVE_LIST_ID");

            modelBuilder.HasSequence("S_F155_ID");

            modelBuilder.HasSequence("S_F251_SAVE_LIST_ID");

            modelBuilder.HasSequence("S_F257_SAVE_LIST_ID");

            modelBuilder.HasSequence("S_F302_SAVE_LIST_ID");

            modelBuilder.HasSequence("S_F401N_ID_BA2");

            modelBuilder.HasSequence("S_F401N_ID_REP");

            modelBuilder.HasSequence("S_F401N_ID_ROW");

            modelBuilder.HasSequence("S_F601_ID_REP");

            modelBuilder.HasSequence("S_F601_ID_RES");

            modelBuilder.HasSequence("S_F601_ID_ROW");

            modelBuilder.HasSequence("S_F601_ID_SHAP");

            modelBuilder.HasSequence("S_F711_ID_RES");

            modelBuilder.HasSequence("S_FC_BANKDOC");

            modelBuilder.HasSequence("S_FC_CATALOGUE");

            modelBuilder.HasSequence("S_FC_COMMS");

            modelBuilder.HasSequence("S_FC_COMMS_PRESET");

            modelBuilder.HasSequence("S_FC_DIVISION");

            modelBuilder.HasSequence("S_FC_DOCUMENT");

            modelBuilder.HasSequence("S_FC_FACTURE_PAY");

            modelBuilder.HasSequence("S_FC_GOODS");

            modelBuilder.HasSequence("S_FC_HOLDING");

            modelBuilder.HasSequence("S_FC_IFRS_RESERVE_ID");

            modelBuilder.HasSequence("S_FC_JOURNAL");

            modelBuilder.HasSequence("S_FC_LIST");

            modelBuilder.HasSequence("S_FC_OPERGROUP");

            modelBuilder.HasSequence("S_FC_PAY");

            modelBuilder.HasSequence("S_FC_PAYABLE");

            modelBuilder.HasSequence("S_FC_REGRESS");

            modelBuilder.HasSequence("S_FC_RESERVE_HISTORY");

            modelBuilder.HasSequence("S_FC_SH_WORD");

            modelBuilder.HasSequence("S_FC_SUPPLY");

            modelBuilder.HasSequence("S_FC_TASK_EVENT_ID");

            modelBuilder.HasSequence("S_FC_TASK_ID");

            modelBuilder.HasSequence("S_FC_TYPIFICATION");

            modelBuilder.HasSequence("S_FC_UTIL");

            modelBuilder.HasSequence("S_FC_XML");

            modelBuilder.HasSequence("S_FC_XMLCOMMAND");

            modelBuilder.HasSequence("S_FID_ACC").IsCyclic();

            modelBuilder.HasSequence("S_FID_CARD").IsCyclic();

            modelBuilder.HasSequence("S_FID_INN").IsCyclic();

            modelBuilder.HasSequence("S_FID_PASP").IsCyclic();

            modelBuilder.HasSequence("S_FID_PHONE").IsCyclic();

            modelBuilder.HasSequence("S_FID_SNILS").IsCyclic();

            modelBuilder.HasSequence("S_FID_WALLET").IsCyclic();

            modelBuilder.HasSequence("S_FL_BONUS_EVENT");

            modelBuilder.HasSequence("S_FL_BONUS_PROD");

            modelBuilder.HasSequence("S_FL_CH");

            modelBuilder.HasSequence("S_FL_DOG");

            modelBuilder.HasSequence("S_FL_DOG_SYS");

            modelBuilder.HasSequence("S_FL_OP");

            modelBuilder.HasSequence("S_FL_OP_REC");

            modelBuilder.HasSequence("S_FL_OP_S");

            modelBuilder.HasSequence("S_FL_P");

            modelBuilder.HasSequence("S_FL_PLE");

            modelBuilder.HasSequence("S_FL_PROD");

            modelBuilder.HasSequence("S_FL_SESSION");

            modelBuilder.HasSequence("S_FLONOSTRO_SAVE_LIST_ID");

            modelBuilder.HasSequence("S_FMS_PASS_REQUESTS");

            modelBuilder.HasSequence("S_FNST");

            modelBuilder.HasSequence("S_FRM_FILTER_ID");

            modelBuilder.HasSequence("S_FSSP_BFILE");

            modelBuilder.HasSequence("S_FSSP_LOAD_DCK");

            modelBuilder.HasSequence("S_FSSP_LOAD_PCK");

            modelBuilder.HasSequence("S_FSSP_RFE_ACC");

            modelBuilder.HasSequence("S_FSSP_RFE_REQUESTS");

            modelBuilder.HasSequence("S_FSSP_RFE_RESP_TRN");

            modelBuilder.HasSequence("S_FSSP_RFE_RESPONSES");

            modelBuilder.HasSequence("S_FSSP_SEND_DCK");

            modelBuilder.HasSequence("S_FSSP_SEND_PCK");

            modelBuilder.HasSequence("S_FSSP_SPI_REQ");

            modelBuilder.HasSequence("S_FSSP_SPI_RES");

            modelBuilder.HasSequence("S_FSTRATC_ID");

            modelBuilder.HasSequence("S_FUNC_ORDER_ID");

            modelBuilder.HasSequence("S_FUNCTION");

            modelBuilder.HasSequence("S_GC");

            modelBuilder.HasSequence("S_GEM_DOC_GID");

            modelBuilder.HasSequence("S_GEM_DOC_RT");

            modelBuilder.HasSequence("S_GL_AGREE_TEMPL_ACC_INT_ID");

            modelBuilder.HasSequence("S_GL_AGREE_TEMPL_INT_ID");

            modelBuilder.HasSequence("S_GPP_BUFF_ID").IsCyclic();

            modelBuilder.HasSequence("S_GPP_MSG_ID").IsCyclic();

            modelBuilder.HasSequence("S_GSM_DRIVER");

            modelBuilder.HasSequence("S_GSM_FCARD");

            modelBuilder.HasSequence("S_GSM_FLM");

            modelBuilder.HasSequence("S_GSM_FLM_H");

            modelBuilder.HasSequence("S_GSM_FLT");

            modelBuilder.HasSequence("S_GSM_FOFF_ACC");

            modelBuilder.HasSequence("S_GSM_FS");

            modelBuilder.HasSequence("S_GSM_LOG");

            modelBuilder.HasSequence("S_GSM_NORMTF");

            modelBuilder.HasSequence("S_GSM_PIT");

            modelBuilder.HasSequence("S_GSM_PTR");

            modelBuilder.HasSequence("S_GSM_RT");

            modelBuilder.HasSequence("S_GSM_RTITEM");

            modelBuilder.HasSequence("S_GSM_TFI");

            modelBuilder.HasSequence("S_GSM_TFO");

            modelBuilder.HasSequence("S_GSM_TSB");

            modelBuilder.HasSequence("S_GSM_TSM");

            modelBuilder.HasSequence("S_GSM_TST");

            modelBuilder.HasSequence("S_GSM_WB");

            modelBuilder.HasSequence("S_IAOCACCID");

            modelBuilder.HasSequence("S_IAP1ID");

            modelBuilder.HasSequence("S_IBE_BACT_ID");

            modelBuilder.HasSequence("S_IBE_DACT_ID");

            modelBuilder.HasSequence("S_IBI3_ID");

            modelBuilder.HasSequence("S_IBIACT_ID");

            modelBuilder.HasSequence("S_IBIB_RDF_ID");

            modelBuilder.HasSequence("S_IBIBID");

            modelBuilder.HasSequence("S_IBIL_ACC_ID");

            modelBuilder.HasSequence("S_IBIL_AU_ID");

            modelBuilder.HasSequence("S_IBIL_AUGLOSS_ID");

            modelBuilder.HasSequence("S_IBIL_CALFIL_ID");

            modelBuilder.HasSequence("S_IBIL_GREG_ID");

            modelBuilder.HasSequence("S_IBIL_SVA_ID");

            modelBuilder.HasSequence("S_IBIL_UREG_ID");

            modelBuilder.HasSequence("S_IBILCODE");

            modelBuilder.HasSequence("S_IBILR_REES");

            modelBuilder.HasSequence("S_IBINCODE");

            modelBuilder.HasSequence("S_IBIT_ID");

            modelBuilder.HasSequence("S_IBLKD_ID");

            modelBuilder.HasSequence("S_IBLOT_ID");

            modelBuilder.HasSequence("S_IBNKID");

            modelBuilder.HasSequence("S_IBOUT_ID");

            modelBuilder.HasSequence("S_ICAPID").IsCyclic();

            modelBuilder.HasSequence("S_ICAUID").IsCyclic();

            modelBuilder.HasSequence("S_ICD_BKI_REPORT_ID");

            modelBuilder.HasSequence("S_ICD_BKI_REPORT_IDREQ");

            modelBuilder.HasSequence("S_ICDCNTID");

            modelBuilder.HasSequence("S_ICDCNTIDP");

            modelBuilder.HasSequence("S_ICDEEVENTID");

            modelBuilder.HasSequence("S_ICDSALEID");

            modelBuilder.HasSequence("S_ICDTID");

            modelBuilder.HasSequence("S_ICMEEVENTID");

            modelBuilder.HasSequence("S_ICMFID");

            modelBuilder.HasSequence("S_ICMRID");

            modelBuilder.HasSequence("S_ICMSID");

            modelBuilder.HasSequence("S_ICOLID");

            modelBuilder.HasSequence("S_ICTTNUM");

            modelBuilder.HasSequence("S_ICUMID");

            modelBuilder.HasSequence("S_ICUPID");

            modelBuilder.HasSequence("S_ICZOSTDH");

            modelBuilder.HasSequence("S_ICZOSTDID");

            modelBuilder.HasSequence("S_ICZOSTH");

            modelBuilder.HasSequence("S_ICZOSTID");

            modelBuilder.HasSequence("S_ICZOSTVH");

            modelBuilder.HasSequence("S_ICZOSTVID");

            modelBuilder.HasSequence("S_IDCTDOCNUM");

            modelBuilder.HasSequence("S_IDE_DOGID");

            modelBuilder.HasSequence("S_IDPTID");

            modelBuilder.HasSequence("S_IDRLNUM");

            modelBuilder.HasSequence("S_IE_ID");

            modelBuilder.HasSequence("S_IIPCNUM");

            modelBuilder.HasSequence("S_IKAANUM");

            modelBuilder.HasSequence("S_ILDNID").IsCyclic();

            modelBuilder.HasSequence("S_IM_ACC_REQ");

            modelBuilder.HasSequence("S_IM_DOC_ID");

            modelBuilder.HasSequence("S_IM_STM_TP");

            modelBuilder.HasSequence("S_IMD1NUM");

            modelBuilder.HasSequence("S_IMNBID");

            modelBuilder.HasSequence("S_IMOA_ID");

            modelBuilder.HasSequence("S_IN3CNUM");

            modelBuilder.HasSequence("S_INCASS_LIST");

            modelBuilder.HasSequence("S_INF_TO_TAX_INF_ID");

            modelBuilder.HasSequence("S_INRC_ID");

            modelBuilder.HasSequence("S_INRE_ID");

            modelBuilder.HasSequence("S_INRG_ID");

            modelBuilder.HasSequence("S_INST1_NUM");

            modelBuilder.HasSequence("S_INUM_ACTION").IsCyclic();

            modelBuilder.HasSequence("S_INVO_PROCEED");

            modelBuilder.HasSequence("S_IOBRID").IsCyclic();

            modelBuilder.HasSequence("S_IOBSID").IsCyclic();

            modelBuilder.HasSequence("S_IOBVID").IsCyclic();

            modelBuilder.HasSequence("S_IP_SESSION");

            modelBuilder.HasSequence("S_IPDTID");

            modelBuilder.HasSequence("S_IPLEEVENTID");

            modelBuilder.HasSequence("S_IPOTID");

            modelBuilder.HasSequence("S_IPRA_COMFORT_ID");

            modelBuilder.HasSequence("S_IPRAID");

            modelBuilder.HasSequence("S_IPRR_COMFORT_ID");

            modelBuilder.HasSequence("S_IPRRID");

            modelBuilder.HasSequence("S_IPRTID");

            modelBuilder.HasSequence("S_IPTFID");

            modelBuilder.HasSequence("S_IPTFID_COMFORT");

            modelBuilder.HasSequence("S_IPVDCNUM");

            modelBuilder.HasSequence("S_IR_ID");

            modelBuilder.HasSequence("S_IRBDID");

            modelBuilder.HasSequence("S_IRBSID");

            modelBuilder.HasSequence("S_IREF");

            modelBuilder.HasSequence("S_IREFCDID");

            modelBuilder.HasSequence("S_IROUCOMISSIONS");

            modelBuilder.HasSequence("S_IS$RPROCESSID");

            modelBuilder.HasSequence("S_ISO_20022_ACCOUNT_STATEMENT");

            modelBuilder.HasSequence("S_ISO_20022_PROCESS");

            modelBuilder.HasSequence("S_ISO_20022_PROCESS_SCHEDULE");

            modelBuilder.HasSequence("S_ISQ1ID");

            modelBuilder.HasSequence("S_ISRPID");

            modelBuilder.HasSequence("S_ISTATE");

            modelBuilder.HasSequence("S_ISTP_ID");

            modelBuilder.HasSequence("S_ISVPID").IsCyclic();

            modelBuilder.HasSequence("S_ISW0ID");

            modelBuilder.HasSequence("S_ISWA_ID");

            modelBuilder.HasSequence("S_ISWB_ID");

            modelBuilder.HasSequence("S_ISWE_ID");

            modelBuilder.HasSequence("S_ISWF_ID");

            modelBuilder.HasSequence("S_ISWH_ID");

            modelBuilder.HasSequence("S_ISWIID");

            modelBuilder.HasSequence("S_ISWMID");

            modelBuilder.HasSequence("S_ISWP_ID");

            modelBuilder.HasSequence("S_ISWQ_ID");

            modelBuilder.HasSequence("S_ISWV_ID");

            modelBuilder.HasSequence("S_ISWX_ID");

            modelBuilder.HasSequence("S_ISWY_ID");

            modelBuilder.HasSequence("S_ISWZ_ID");

            modelBuilder.HasSequence("S_ISXB_ID");

            modelBuilder.HasSequence("S_ISXE_ID");

            modelBuilder.HasSequence("S_ISZA_ID");

            modelBuilder.HasSequence("S_ISZC_ID");

            modelBuilder.HasSequence("S_ISZH_ID");

            modelBuilder.HasSequence("S_ISZT_ID");

            modelBuilder.HasSequence("S_ISZV_ID");

            modelBuilder.HasSequence("S_ITCBNUM");

            modelBuilder.HasSequence("S_ITCDID");

            modelBuilder.HasSequence("S_ITDJ$NUM");

            modelBuilder.HasSequence("S_ITDJNUM");

            modelBuilder.HasSequence("S_ITDLNUM");

            modelBuilder.HasSequence("S_ITDXNUM");

            modelBuilder.HasSequence("S_ITEDID");

            modelBuilder.HasSequence("S_ITEKNUM");

            modelBuilder.HasSequence("S_ITEPID");

            modelBuilder.HasSequence("S_ITFNNUM");

            modelBuilder.HasSequence("S_ITLRID");

            modelBuilder.HasSequence("S_ITRN$NUM");

            modelBuilder.HasSequence("S_ITRNDOCNUM_4_1").IsCyclic();

            modelBuilder.HasSequence("S_ITRNNUM");

            modelBuilder.HasSequence("S_ITTFNUM");

            modelBuilder.HasSequence("S_ITVOID");

            modelBuilder.HasSequence("S_IUSERID");

            modelBuilder.HasSequence("S_IV_ACC");

            modelBuilder.HasSequence("S_IV_DATE");

            modelBuilder.HasSequence("S_IV_RATE");

            modelBuilder.HasSequence("S_IV_SCALE");

            modelBuilder.HasSequence("S_IV_TMP");

            modelBuilder.HasSequence("S_IVCDFNUM");

            modelBuilder.HasSequence("S_IVFCNUM");

            modelBuilder.HasSequence("S_IVFINUM");

            modelBuilder.HasSequence("S_IVKNID");

            modelBuilder.HasSequence("S_IVURNUM");

            modelBuilder.HasSequence("S_IWHA_ID");

            modelBuilder.HasSequence("S_IWHB_ID");

            modelBuilder.HasSequence("S_IWHC_ID");

            modelBuilder.HasSequence("S_IWHK_ID");

            modelBuilder.HasSequence("S_IWHZ_ID");

            modelBuilder.HasSequence("S_IWQCID");

            modelBuilder.HasSequence("S_IZWAIEVTID");

            modelBuilder.HasSequence("S_KBNK_CUS_ID");

            modelBuilder.HasSequence("S_KBNK_ID");

            modelBuilder.HasSequence("S_KD").IsCyclic();

            modelBuilder.HasSequence("S_KP_IST_ID");

            modelBuilder.HasSequence("S_KP_POST_ID");

            modelBuilder.HasSequence("S_KP_VED_ID");

            modelBuilder.HasSequence("S_KRN_3462_REQ_ID");

            modelBuilder.HasSequence("S_KU");

            modelBuilder.HasSequence("S_KZ");

            modelBuilder.HasSequence("S_KZ_CHARGES");

            modelBuilder.HasSequence("S_KZ_OL_AUTOPROCESS");

            modelBuilder.HasSequence("S_KZ_OL_PORTION");

            modelBuilder.HasSequence("S_KZ_OL_TRN");

            modelBuilder.HasSequence("S_KZ_SENDED_MESSAGES");

            modelBuilder.HasSequence("S_KZ_TR_PORTION");

            modelBuilder.HasSequence("S_L_FILE_ID").IsCyclic();

            modelBuilder.HasSequence("S_LA_NUM").IsCyclic();

            modelBuilder.HasSequence("S_LAAA_ID");

            modelBuilder.HasSequence("S_LAAB_ID");

            modelBuilder.HasSequence("S_LAAE_ID");

            modelBuilder.HasSequence("S_LAAG_H_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAAG_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAAH_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAAI_ID");

            modelBuilder.HasSequence("S_LAAJ_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAAK_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAAM_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAAN_ID");

            modelBuilder.HasSequence("S_LAAO_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAAP_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAAQ_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAAR_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAAX_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAAY_CHAIN_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAAY_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAAZ_ID").IsCyclic();

            modelBuilder.HasSequence("S_LABG_ID").IsCyclic();

            modelBuilder.HasSequence("S_LABH_ID").IsCyclic();

            modelBuilder.HasSequence("S_LABJ_ID").IsCyclic();

            modelBuilder.HasSequence("S_LABK_ID").IsCyclic();

            modelBuilder.HasSequence("S_LABL_ID");

            modelBuilder.HasSequence("S_LABM_ID");

            modelBuilder.HasSequence("S_LABN_ID").IsCyclic();

            modelBuilder.HasSequence("S_LABQ_ID").IsCyclic();

            modelBuilder.HasSequence("S_LABS_ID");

            modelBuilder.HasSequence("S_LABT_ID").IsCyclic();

            modelBuilder.HasSequence("S_LABU_ID").IsCyclic();

            modelBuilder.HasSequence("S_LABV_ID").IsCyclic();

            modelBuilder.HasSequence("S_LABW_ID").IsCyclic();

            modelBuilder.HasSequence("S_LABY_ID").IsCyclic();

            modelBuilder.HasSequence("S_LABZ_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACB_ID");

            modelBuilder.HasSequence("S_LACC_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACE_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACF_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACG_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACH_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACI_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACJ_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACK_446P_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACK_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACM_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACN_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACN_TMP_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACQ_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACR_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACT_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACU_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACX_ID").IsCyclic();

            modelBuilder.HasSequence("S_LACY_ID").IsCyclic();

            modelBuilder.HasSequence("S_LADE_ID").IsCyclic();

            modelBuilder.HasSequence("S_LADG_ID").IsCyclic();

            modelBuilder.HasSequence("S_LADH_ID").IsCyclic();

            modelBuilder.HasSequence("S_LADJ_ID").IsCyclic();

            modelBuilder.HasSequence("S_LADM_ID").IsCyclic();

            modelBuilder.HasSequence("S_LADN_ID").IsCyclic();

            modelBuilder.HasSequence("S_LADP_ID").IsCyclic();

            modelBuilder.HasSequence("S_LADY_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAEA_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAEB_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAED_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAEG_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAEH_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAEJ_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAEJ_TMP_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAEM_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAEN_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAEN_TMP_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAFB_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAFC_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAFD_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAFE_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAFF_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAFG_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAFH_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAFI_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGC_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGE_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGF_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGH_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGI_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGJ_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGK_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGL_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGM_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGN_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGQ_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGS_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGT_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGU_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGV_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGW_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGX_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGY_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAGZ_ID").IsCyclic();

            modelBuilder.HasSequence("S_LAHD_ID").IsCyclic();

            modelBuilder.HasSequence("S_LC_ID_MAKET");

            modelBuilder.HasSequence("S_LC_NUM");

            modelBuilder.HasSequence("S_LC_UTIL");

            modelBuilder.HasSequence("S_LCAE_ID");

            modelBuilder.HasSequence("S_LCAH_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCAL_ID");

            modelBuilder.HasSequence("S_LCAM_ID");

            modelBuilder.HasSequence("S_LCAS_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCAU");

            modelBuilder.HasSequence("S_LCAX_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCAY_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCBA_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCBZ_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCCK_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCCM_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCCN_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCED_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCEH_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCEM_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCEN_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCEN_TMP_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCHC_ID");

            modelBuilder.HasSequence("S_LCHD_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCHE_ID");

            modelBuilder.HasSequence("S_LCHF_ID");

            modelBuilder.HasSequence("S_LCHH_ID");

            modelBuilder.HasSequence("S_LCHM_ID");

            modelBuilder.HasSequence("S_LCHN_ID");

            modelBuilder.HasSequence("S_LCHN_STATE");

            modelBuilder.HasSequence("S_LCHP_ID");

            modelBuilder.HasSequence("S_LCHQ_ID");

            modelBuilder.HasSequence("S_LCHR");

            modelBuilder.HasSequence("S_LCHR_ID");

            modelBuilder.HasSequence("S_LCHS_ID");

            modelBuilder.HasSequence("S_LCHT_ID");

            modelBuilder.HasSequence("S_LCHU_ID");

            modelBuilder.HasSequence("S_LCHV_ID");

            modelBuilder.HasSequence("S_LCHW_ID");

            modelBuilder.HasSequence("S_LCHX");

            modelBuilder.HasSequence("S_LCHX_ID");

            modelBuilder.HasSequence("S_LCHY_ID");

            modelBuilder.HasSequence("S_LCHZ");

            modelBuilder.HasSequence("S_LCHZ_ID");

            modelBuilder.HasSequence("S_LCIA_ID");

            modelBuilder.HasSequence("S_LCIB_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCID_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCJD_ID");

            modelBuilder.HasSequence("S_LCJH_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCJI_ID");

            modelBuilder.HasSequence("S_LCJJ_ID");

            modelBuilder.HasSequence("S_LCJK_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCJL_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCJM_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCJO_ID").IsCyclic();

            modelBuilder.HasSequence("S_LCJP_ID").IsCyclic();

            modelBuilder.HasSequence("S_LG");

            modelBuilder.HasSequence("S_LIM_CUS_ID");

            modelBuilder.HasSequence("S_LIM_GRP_ICB_INT_ID");

            modelBuilder.HasSequence("S_LIM_GRP_ID");

            modelBuilder.HasSequence("S_LIM_GRP_INF_ICB_INT_ID");

            modelBuilder.HasSequence("S_LOB_DATA");

            modelBuilder.HasSequence("S_MARKER");

            modelBuilder.HasSequence("S_MC_FOTO");

            modelBuilder.HasSequence("S_MC_ZAJAV_IK");

            modelBuilder.HasSequence("S_MKB");

            modelBuilder.HasSequence("S_ML2_TEXT_ID");

            modelBuilder.HasSequence("S_MP");

            modelBuilder.HasSequence("S_MP1_ID");

            modelBuilder.HasSequence("S_MP2_ID");

            modelBuilder.HasSequence("S_MP3_ID");

            modelBuilder.HasSequence("S_MP4_ID");

            modelBuilder.HasSequence("S_MSD_INCOMING");

            modelBuilder.HasSequence("S_MSD_PAY");

            modelBuilder.HasSequence("S_N3D");

            modelBuilder.HasSequence("S_N3D_EXT");

            modelBuilder.HasSequence("S_N3D_STP");

            modelBuilder.HasSequence("S_N3D_TRN");

            modelBuilder.HasSequence("S_NAME_TYPE_ID");

            modelBuilder.HasSequence("S_NCDLIST_ID");

            modelBuilder.HasSequence("S_ND_CUS_INT_ID");

            modelBuilder.HasSequence("S_ND_MOD_MOD_ID");

            modelBuilder.HasSequence("S_ND_PROFIT_INT_ID");

            modelBuilder.HasSequence("S_ND_TAG_INT_ID");

            modelBuilder.HasSequence("S_ND6_CUS_ICUSNUM");

            modelBuilder.HasSequence("S_ND6_CUS_ME_INT_ID");

            modelBuilder.HasSequence("S_ND6_FILE_INT_ID");

            modelBuilder.HasSequence("S_ND6_FILEINFO_INT_ID");

            modelBuilder.HasSequence("S_ND6_MOD_MOD_ID");

            modelBuilder.HasSequence("S_ND6_PROFIT_INT_ID");

            modelBuilder.HasSequence("S_ND6_TAG_INT_ID");

            modelBuilder.HasSequence("S_NI_IIA_BASE_ID");

            modelBuilder.HasSequence("S_NI_IIA_OFFICIALS_ID");

            modelBuilder.HasSequence("S_NI_ROWNUM");

            modelBuilder.HasSequence("S_NL");

            modelBuilder.HasSequence("S_NL_REPORTS");

            modelBuilder.HasSequence("S_NLG_ALLOC");

            modelBuilder.HasSequence("S_NLG_ALLOC_PARAM");

            modelBuilder.HasSequence("S_NLG_ALLOC_VALUE");

            modelBuilder.HasSequence("S_NLG_CALC_DATA_NDS");

            modelBuilder.HasSequence("S_NLG_CORR_BASE");

            modelBuilder.HasSequence("S_NLG_DEC_ADDR");

            modelBuilder.HasSequence("S_NLG_DEC_CALC");

            modelBuilder.HasSequence("S_NLG_DEC_CALC_ADDIT");

            modelBuilder.HasSequence("S_NLG_DEC_COMPANY");

            modelBuilder.HasSequence("S_NLG_DEC_DATA");

            modelBuilder.HasSequence("S_NLG_DEC_DIVIDEND");

            modelBuilder.HasSequence("S_NLG_DEC_LOAD_XML");

            modelBuilder.HasSequence("S_NLG_DEC_NDFL");

            modelBuilder.HasSequence("S_NLG_DEC_NDFL_SUM");

            modelBuilder.HasSequence("S_NLG_DEC_PERIOD");

            modelBuilder.HasSequence("S_NLG_DEC_PERSON");

            modelBuilder.HasSequence("S_NLG_DEC_XML_STRUCT");

            modelBuilder.HasSequence("S_NLG_DEF_ACC_SET");

            modelBuilder.HasSequence("S_NLG_DEF_ATTR");

            modelBuilder.HasSequence("S_NLG_DEF_DATA");

            modelBuilder.HasSequence("S_NLG_DOC");

            modelBuilder.HasSequence("S_NLG_INVOICE");

            modelBuilder.HasSequence("S_NLG_KNIG");

            modelBuilder.HasSequence("S_NLG_LIST");

            modelBuilder.HasSequence("S_NLG_MASK");

            modelBuilder.HasSequence("S_NLG_REG_DATA");

            modelBuilder.HasSequence("S_NLG_REG_DATA_NDS");

            modelBuilder.HasSequence("S_NLG_REG_DC");

            modelBuilder.HasSequence("S_NLG_REG_PRD");

            modelBuilder.HasSequence("S_NLG_REP");

            modelBuilder.HasSequence("S_NLG_REP_DATA_NDS");

            modelBuilder.HasSequence("S_NLG_REP_GRP_CELL_VAL");

            modelBuilder.HasSequence("S_NLG_REP_LIST");

            modelBuilder.HasSequence("S_NLG_TAX_BASE");

            modelBuilder.HasSequence("S_NLG_TRNS");

            modelBuilder.HasSequence("S_NLG_TRNS_GRP");

            modelBuilder.HasSequence("S_NOR_KRF_ID");

            modelBuilder.HasSequence("S_NOR21_ID").IsCyclic();

            modelBuilder.HasSequence("S_NP_ID");

            modelBuilder.HasSequence("S_NPI");

            modelBuilder.HasSequence("S_NPI_AGR_FACT");

            modelBuilder.HasSequence("S_NPI_AGR_FACTNUM");

            modelBuilder.HasSequence("S_NPI_AGREEMENTS");

            modelBuilder.HasSequence("S_NPI_AGRNUMBERS");

            modelBuilder.HasSequence("S_NPI_BLOCKS");

            modelBuilder.HasSequence("S_NPI_CREATE_FACT_RULES");

            modelBuilder.HasSequence("S_NPI_GEN_SHEETS");

            modelBuilder.HasSequence("S_NPI_GENSHNUMBERS");

            modelBuilder.HasSequence("S_NPI_INVOICES");

            modelBuilder.HasSequence("S_NPI_IVCNUMBERS");

            modelBuilder.HasSequence("S_NPI_PC");

            modelBuilder.HasSequence("S_NPI_SCHED_HISTORY_PKID");

            modelBuilder.HasSequence("S_NPI_SCHED_PKID");

            modelBuilder.HasSequence("S_NPI_SERVICE_TYPES");

            modelBuilder.HasSequence("S_NPI_SERVICES");

            modelBuilder.HasSequence("S_NPI_SHEETS");

            modelBuilder.HasSequence("S_NPI_SHNUMBERS");

            modelBuilder.HasSequence("S_NPI_TARIFFS");

            modelBuilder.HasSequence("S_NPI_UNITS");

            modelBuilder.HasSequence("S_NPLEDGE_NOTARIES");

            modelBuilder.HasSequence("S_NPLEDGE_NOTF");

            modelBuilder.HasSequence("S_NPLEDGE_NOTF_SD");

            modelBuilder.HasSequence("S_NPLEDGE_NOTF_SD_PE");

            modelBuilder.HasSequence("S_NPLEDGE_NOTF_SD_PO");

            modelBuilder.HasSequence("S_NPLEDGE_NOTF_SD_PP");

            modelBuilder.HasSequence("S_NTC");

            modelBuilder.HasSequence("S_NTK_ID");

            modelBuilder.HasSequence("S_NUM_DOC");

            modelBuilder.HasSequence("S_NUM_OUTFILE");

            modelBuilder.HasSequence("S_OBG_GRP_ID");

            modelBuilder.HasSequence("S_OBJRECD");

            modelBuilder.HasSequence("S_OBN_INT_ID");

            modelBuilder.HasSequence("S_ODB");

            modelBuilder.HasSequence("S_ODB_BFILE_NUM");

            modelBuilder.HasSequence("S_OFFICIALS_INT_ID");

            modelBuilder.HasSequence("S_ON_AGENT");

            modelBuilder.HasSequence("S_ON_BASE_B");

            modelBuilder.HasSequence("S_ON_BS_ISB");

            modelBuilder.HasSequence("S_ON_DECL_BACK_R");

            modelBuilder.HasSequence("S_ON_ERRORS");

            modelBuilder.HasSequence("S_ON_EVENT_R");

            modelBuilder.HasSequence("S_ON_GROUP_B");

            modelBuilder.HasSequence("S_ON_IMP_FOLDER");

            modelBuilder.HasSequence("S_ON_IN_DOC");

            modelBuilder.HasSequence("S_ON_INSTALL2_ID");

            modelBuilder.HasSequence("S_ON_NEW_DOC");

            modelBuilder.HasSequence("S_ON_NEW_DOG");

            modelBuilder.HasSequence("S_ON_NEW_PAY");

            modelBuilder.HasSequence("S_ON_NEW_VIO");

            modelBuilder.HasSequence("S_ON_PS_C");

            modelBuilder.HasSequence("S_ON_PS_C_CONT");

            modelBuilder.HasSequence("S_ON_PS_C_IC");

            modelBuilder.HasSequence("S_ON_PS_C_NR");

            modelBuilder.HasSequence("S_ON_PS_C_OC");

            modelBuilder.HasSequence("S_ON_PS_C_OP");

            modelBuilder.HasSequence("S_ON_PS_C_PD");

            modelBuilder.HasSequence("S_ON_PS_C_R");

            modelBuilder.HasSequence("S_ON_PS_C_RS");

            modelBuilder.HasSequence("S_ON_PS_D_AC");

            modelBuilder.HasSequence("S_ON_PS_D_CD");

            modelBuilder.HasSequence("S_ON_PS_D_SH");

            modelBuilder.HasSequence("S_ON_PS_D_TR");

            modelBuilder.HasSequence("S_ON_PS_NRLIST");

            modelBuilder.HasSequence("S_ON_REZERV_BACK_R");

            modelBuilder.HasSequence("S_ON_REZERV_R");

            modelBuilder.HasSequence("S_ON_VIO_B");

            modelBuilder.HasSequence("S_OTD_SETS_ID");

            modelBuilder.HasSequence("S_OUS_ACCESS");

            modelBuilder.HasSequence("S_OV_CASH_IDCNUM");

            modelBuilder.HasSequence("S_OV_CRM");

            modelBuilder.HasSequence("S_OV_CURS");

            modelBuilder.HasSequence("S_OV_DEAL");

            modelBuilder.HasSequence("S_OV_DECREE");

            modelBuilder.HasSequence("S_OV_GC_ARM");

            modelBuilder.HasSequence("S_OV_HCS_BATCH_ID");

            modelBuilder.HasSequence("S_OV_HCS_ERROR_LOG_ENTRY_ID");

            modelBuilder.HasSequence("S_OV_HCS_ORDER_KEY_ID");

            modelBuilder.HasSequence("S_OV_HCS_RUN_ID");

            modelBuilder.HasSequence("S_OV_LID_EXTERNAL_ID");

            modelBuilder.HasSequence("S_OV_LOG");

            modelBuilder.HasSequence("S_OV_MG_POINTS");

            modelBuilder.HasSequence("S_OV_OV_BOPER_IDBOPER");

            modelBuilder.HasSequence("S_OV_OV_COM_IDCOM");

            modelBuilder.HasSequence("S_P3");

            modelBuilder.HasSequence("S_PC");

            modelBuilder.HasSequence("S_PEP_COUNTRY");

            modelBuilder.HasSequence("S_PEP_LIST_IDENT");

            modelBuilder.HasSequence("S_PEP_LIST_LNK");

            modelBuilder.HasSequence("S_PEP_LIST_POST");

            modelBuilder.HasSequence("S_PEP_LIST_SANCTION");

            modelBuilder.HasSequence("S_PEP_LIST_SRC");

            modelBuilder.HasSequence("S_PEP_LOADS");

            modelBuilder.HasSequence("S_PFR");

            modelBuilder.HasSequence("S_PFR_AO");

            modelBuilder.HasSequence("S_PFR_CR");

            modelBuilder.HasSequence("S_PFR_ENR");

            modelBuilder.HasSequence("S_PFR_LST");

            modelBuilder.HasSequence("S_PFR_ORD");

            modelBuilder.HasSequence("S_PFR_ORG");

            modelBuilder.HasSequence("S_PFR_PAY");

            modelBuilder.HasSequence("S_PFR_RES");

            modelBuilder.HasSequence("S_PFREPS");

            modelBuilder.HasSequence("S_PL_250_1_ID");

            modelBuilder.HasSequence("S_PL_250_2_ID");

            modelBuilder.HasSequence("S_PL_250_3_ID");

            modelBuilder.HasSequence("S_PL_250_ID");

            modelBuilder.HasSequence("S_PL_APPLICAT");

            modelBuilder.HasSequence("S_PL_ATM_PARAM");

            modelBuilder.HasSequence("S_PL_AZ_LOAD");

            modelBuilder.HasSequence("S_PL_CH");

            modelBuilder.HasSequence("S_PL_CODE_ID");

            modelBuilder.HasSequence("S_PL_CSTT");

            modelBuilder.HasSequence("S_PL_CUS_PROC");

            modelBuilder.HasSequence("S_PL_DOINGS");

            modelBuilder.HasSequence("S_PL_EVENT_GRP");

            modelBuilder.HasSequence("S_PL_EVENT_GRP_M").IncrementsBy(2);

            modelBuilder.HasSequence("S_PL_FILE_IN");

            modelBuilder.HasSequence("S_PL_FILE_OUT");

            modelBuilder.HasSequence("S_PL_GCC");

            modelBuilder.HasSequence("S_PL_GCD");

            modelBuilder.HasSequence("S_PL_GCR");

            modelBuilder.HasSequence("S_PL_GRP");

            modelBuilder.HasSequence("S_PL_GSR");

            modelBuilder.HasSequence("S_PL_JOBS");

            modelBuilder.HasSequence("S_PL_LOAD_SAVE");

            modelBuilder.HasSequence("S_PL_LOADVED");

            modelBuilder.HasSequence("S_PL_LOADVEDST");

            modelBuilder.HasSequence("S_PL_LOG_SAVE");

            modelBuilder.HasSequence("S_PL_MD");

            modelBuilder.HasSequence("S_PL_MSG_ABS");

            modelBuilder.HasSequence("S_PL_MSG_ABS_AC");

            modelBuilder.HasSequence("S_PL_MSG_APPLICAT");

            modelBuilder.HasSequence("S_PL_MSG_FINANS");

            modelBuilder.HasSequence("S_PL_MSG_INFO");

            modelBuilder.HasSequence("S_PL_MSG_MERCH");

            modelBuilder.HasSequence("S_PL_MSG_ONLINE");

            modelBuilder.HasSequence("S_PL_MSG_PROC");

            modelBuilder.HasSequence("S_PL_OP_REC");

            modelBuilder.HasSequence("S_PL_OP_REC_M");

            modelBuilder.HasSequence("S_PL_PACK");

            modelBuilder.HasSequence("S_PL_PACK_REC");

            modelBuilder.HasSequence("S_PL_PACK_REC_M").IncrementsBy(2);

            modelBuilder.HasSequence("S_PL_PARAM_ID");

            modelBuilder.HasSequence("S_PL_PLA_ADD");

            modelBuilder.HasSequence("S_PL_PLT");

            modelBuilder.HasSequence("S_PL_PSMS_ID");

            modelBuilder.HasSequence("S_PL_RECEIVE");

            modelBuilder.HasSequence("S_PL_SCHED_LOG_SAVE");

            modelBuilder.HasSequence("S_PL_SEND");

            modelBuilder.HasSequence("S_PL_SERVICE_ID");

            modelBuilder.HasSequence("S_PL_TARIF");

            modelBuilder.HasSequence("S_PL_TARIF_MOD");

            modelBuilder.HasSequence("S_PL_TASKS");

            modelBuilder.HasSequence("S_PL_TRUST");

            modelBuilder.HasSequence("S_PLA_ID");

            modelBuilder.HasSequence("S_PLA_M_ID");

            modelBuilder.HasSequence("S_PLACE");

            modelBuilder.HasSequence("S_PLC_ID");

            modelBuilder.HasSequence("S_PLE_M_ID");

            modelBuilder.HasSequence("S_PLE_PROC");

            modelBuilder.HasSequence("S_PLLOG_ID");

            modelBuilder.HasSequence("S_PLT_MNG");

            modelBuilder.HasSequence("S_PPO24");

            modelBuilder.HasSequence("S_PRC_A_ROW");

            modelBuilder.HasSequence("S_PRC_A_VED");

            modelBuilder.HasSequence("S_PRIZMA");

            modelBuilder.HasSequence("S_PRK_ACC");

            modelBuilder.HasSequence("S_PRK_DG");

            modelBuilder.HasSequence("S_PRK_LG");

            modelBuilder.HasSequence("S_PRK_PAY");

            modelBuilder.HasSequence("S_PRK_SG");

            modelBuilder.HasSequence("S_PRK_SP");

            modelBuilder.HasSequence("S_PRK_TF");

            modelBuilder.HasSequence("S_PRK_TRM");

            modelBuilder.HasSequence("S_PRK_ZN");

            modelBuilder.HasSequence("S_PRM");

            modelBuilder.HasSequence("S_PROCESS");

            modelBuilder.HasSequence("S_PROMU_ADDR");

            modelBuilder.HasSequence("S_PROMU_CTZN");

            modelBuilder.HasSequence("S_PROMU_DOC");

            modelBuilder.HasSequence("S_PRS_BILL_ID");

            modelBuilder.HasSequence("S_PRS_BOOK_ID");

            modelBuilder.HasSequence("S_PRS_COUPON_ID");

            modelBuilder.HasSequence("S_PRS_PRESENT_ID");

            modelBuilder.HasSequence("S_PRS_PRESENT_LIST_ID");

            modelBuilder.HasSequence("S_PS");

            modelBuilder.HasSequence("S_PS_PP");

            modelBuilder.HasSequence("S_PSR_COMFORT");

            modelBuilder.HasSequence("S_PUD_ID");

            modelBuilder.HasSequence("S_PUN_ID");

            modelBuilder.HasSequence("S_QD_DOCID");

            modelBuilder.HasSequence("S_QDG");

            modelBuilder.HasSequence("S_QDP");

            modelBuilder.HasSequence("S_QDR");

            modelBuilder.HasSequence("S_QDS_ID");

            modelBuilder.HasSequence("S_QEA_S");

            modelBuilder.HasSequence("S_QETID");

            modelBuilder.HasSequence("S_QEV");

            modelBuilder.HasSequence("S_RA_ALIST_ID");

            modelBuilder.HasSequence("S_RA_LEVEL_ID");

            modelBuilder.HasSequence("S_RATES");

            modelBuilder.HasSequence("S_RCN");

            modelBuilder.HasSequence("S_REP");

            modelBuilder.HasSequence("S_REP_EXP_ROWS");

            modelBuilder.HasSequence("S_RG_A_SEQ_ID");

            modelBuilder.HasSequence("S_RG_AXIS_ID");

            modelBuilder.HasSequence("S_RG_CALC_ID");

            modelBuilder.HasSequence("S_RG_CELL_ID");

            modelBuilder.HasSequence("S_RG_EXEC_TEXT_ID");

            modelBuilder.HasSequence("S_RG_EXT_VIEW_ID");

            modelBuilder.HasSequence("S_RG_F303_ID");

            modelBuilder.HasSequence("S_RG_F345_IDCALC");

            modelBuilder.HasSequence("S_RG_F634_ID");

            modelBuilder.HasSequence("S_RG_FIX_ID");

            modelBuilder.HasSequence("S_RG_FUNC_ID");

            modelBuilder.HasSequence("S_RG_GR_ID");

            modelBuilder.HasSequence("S_RG_REP_CHAPTER_ID");

            modelBuilder.HasSequence("S_RG_REPORT_GROUP_ID");

            modelBuilder.HasSequence("S_RG_REPORT_ID");

            modelBuilder.HasSequence("S_RG_REZ_RKO_DATE_ID");

            modelBuilder.HasSequence("S_RG_SAVE_ID");

            modelBuilder.HasSequence("S_RG_STORE_VAL_ID");

            modelBuilder.HasSequence("S_RG_SV_IDCALC");

            modelBuilder.HasSequence("S_RM_JOB");

            modelBuilder.HasSequence("S_RP_EXT_ACC_ID");

            modelBuilder.HasSequence("S_RP_F120_1_GRP_ID");

            modelBuilder.HasSequence("S_RP_F155");

            modelBuilder.HasSequence("S_RP_GN6_PLAN_TR_ID");

            modelBuilder.HasSequence("S_RPA_NUM");

            modelBuilder.HasSequence("S_RR_FACTOR_ACT_ID");

            modelBuilder.HasSequence("S_RR_TOOL_ID");

            modelBuilder.HasSequence("S_RS");

            modelBuilder.HasSequence("S_RST");

            modelBuilder.HasSequence("S_RVC_ESIDNUM").IsCyclic();

            modelBuilder.HasSequence("S_RZK_PAY");

            modelBuilder.HasSequence("S_RZK_PREG");

            modelBuilder.HasSequence("S_S12_STORE_ID").IsCyclic();

            modelBuilder.HasSequence("S_SCR_BKI_DATA");

            modelBuilder.HasSequence("S_SCR_BKI_DATA_ACC");

            modelBuilder.HasSequence("S_SCR_BKI_DATA_ACC_PAY");

            modelBuilder.HasSequence("S_SCR_BKI_DATA_FICO");

            modelBuilder.HasSequence("S_SCR_BKI_DATA_INQUIRY");

            modelBuilder.HasSequence("S_SCR_CARD");

            modelBuilder.HasSequence("S_SCR_CARD_ITEM");

            modelBuilder.HasSequence("S_SCR_CARD_ITEM_COND");

            modelBuilder.HasSequence("S_SCR_COND");

            modelBuilder.HasSequence("S_SCR_COND_GRP");

            modelBuilder.HasSequence("S_SCR_COND_GRP_ITEM");

            modelBuilder.HasSequence("S_SCR_COND_ITEM");

            modelBuilder.HasSequence("S_SCR_CRIT");

            modelBuilder.HasSequence("S_SCR_CRIT_ITEM");

            modelBuilder.HasSequence("S_SCR_FORM_FACTOR");

            modelBuilder.HasSequence("S_SCR_MATRIX");

            modelBuilder.HasSequence("S_SCR_MATRIX_SET");

            modelBuilder.HasSequence("S_SCR_OKB_DATA");

            modelBuilder.HasSequence("S_SCR_OKB_DATA_CAIS");

            modelBuilder.HasSequence("S_SCR_OKB_DATA_CAIS_HIS");

            modelBuilder.HasSequence("S_SCR_OKB_DATA_CAPS");

            modelBuilder.HasSequence("S_SCR_OKB_DATA_CONS");

            modelBuilder.HasSequence("S_SCR_PARAM");

            modelBuilder.HasSequence("S_SCR_SCHEME");

            modelBuilder.HasSequence("S_SCR_SCHEME_ITEM");

            modelBuilder.HasSequence("S_SCR_SCHEME_ITEM_COND");

            modelBuilder.HasSequence("S_SCR_STAGE");

            modelBuilder.HasSequence("S_SCR_STAGE_ITEM");

            modelBuilder.HasSequence("S_SFRM");

            modelBuilder.HasSequence("S_SG_OPR_ID");

            modelBuilder.HasSequence("S_SG_PCRT_ID");

            modelBuilder.HasSequence("S_SG_SSTORE_ID");

            modelBuilder.HasSequence("S_SM_003_LIC");

            modelBuilder.HasSequence("S_SM_003_LNK");

            modelBuilder.HasSequence("S_SM_003_R");

            modelBuilder.HasSequence("S_SM_003_REG");

            modelBuilder.HasSequence("S_SM_006_AS");

            modelBuilder.HasSequence("S_SM_006_TRN");

            modelBuilder.HasSequence("S_SM_ADDR");

            modelBuilder.HasSequence("S_SM_AUTO");

            modelBuilder.HasSequence("S_SM_BATCH");

            modelBuilder.HasSequence("S_SM_ENTRY");

            modelBuilder.HasSequence("S_SM_LOG");

            modelBuilder.HasSequence("S_SM_NAT");

            modelBuilder.HasSequence("S_SNN_REQ");

            modelBuilder.HasSequence("S_SR_ADDRESSES");

            modelBuilder.HasSequence("S_SR_DOCUMENTS");

            modelBuilder.HasSequence("S_SR_DQ");

            modelBuilder.HasSequence("S_SR_HIST");

            modelBuilder.HasSequence("S_SR_LICENSES");

            modelBuilder.HasSequence("S_SR_LNK");

            modelBuilder.HasSequence("S_SR_OKVED");

            modelBuilder.HasSequence("S_SR_PLOG");

            modelBuilder.HasSequence("S_SR_REG");

            modelBuilder.HasSequence("S_SR_REQUESTS");

            modelBuilder.HasSequence("S_SS_SYSTEM_ID");

            modelBuilder.HasSequence("S_SUSPECT_LOG_ID");

            modelBuilder.HasSequence("S_SW_ADVICE");

            modelBuilder.HasSequence("S_SW_INVEST");

            modelBuilder.HasSequence("S_SW_INVEST_COMM");

            modelBuilder.HasSequence("S_SW_NQE");

            modelBuilder.HasSequence("S_SW_NQF");

            modelBuilder.HasSequence("S_SW_PER");

            modelBuilder.HasSequence("S_SW_ROUTER2");

            modelBuilder.HasSequence("S_SW_SWJ");

            modelBuilder.HasSequence("S_SW_SWP");

            modelBuilder.HasSequence("S_SW_SWP_NUM");

            modelBuilder.HasSequence("S_SW_SXA");

            modelBuilder.HasSequence("S_SW_UTIL");

            modelBuilder.HasSequence("S_SXE_DOC");

            modelBuilder.HasSequence("S_SXM_ID");

            modelBuilder.HasSequence("S_T_BS_MSG");

            modelBuilder.HasSequence("S_T2A_INT_ID");

            modelBuilder.HasSequence("S_TEMLP_ED11X");

            modelBuilder.HasSequence("S_TKN");

            modelBuilder.HasSequence("S_TR_DICTIONARY");

            modelBuilder.HasSequence("S_TR_ID");

            modelBuilder.HasSequence("S_TR_METHOD");

            modelBuilder.HasSequence("S_TR_REF");

            modelBuilder.HasSequence("S_TRC_3D_NUM");

            modelBuilder.HasSequence("S_TRN_ATTR_LST_ID");

            modelBuilder.HasSequence("S_TRP_AGREE_INT_ID");

            modelBuilder.HasSequence("S_TRP_FILE_ID");

            modelBuilder.HasSequence("S_TRP_GRANTEE_INT_ID");

            modelBuilder.HasSequence("S_TRP_LIST_INT_ID");

            modelBuilder.HasSequence("S_TRP_PRIVS_LST_INT_ID");

            modelBuilder.HasSequence("S_TRP_TYPES_INT_ID");

            modelBuilder.HasSequence("S_TX1");

            modelBuilder.HasSequence("S_TYP_ID");

            modelBuilder.HasSequence("S_UF_ED11X");

            modelBuilder.HasSequence("S_UF_ED429");

            modelBuilder.HasSequence("S_UF_ED429_DEPO");

            modelBuilder.HasSequence("S_UF_ED429_SEC");

            modelBuilder.HasSequence("S_UF_ED433");

            modelBuilder.HasSequence("S_UF_ED434");

            modelBuilder.HasSequence("S_UPLF");

            modelBuilder.HasSequence("S_UPLF_REQUEST");

            modelBuilder.HasSequence("S_USR_BLK_PER");

            modelBuilder.HasSequence("S_USR_CASHIERID");

            modelBuilder.HasSequence("S_VALUE");

            modelBuilder.HasSequence("S_VALUE_TYPE");

            modelBuilder.HasSequence("S_VED");

            modelBuilder.HasSequence("S_VNC");

            modelBuilder.HasSequence("S_W_GRP_ID");

            modelBuilder.HasSequence("S_W4");

            modelBuilder.HasSequence("S_WASH_ACC7");

            modelBuilder.HasSequence("S_WASH_BASES");

            modelBuilder.HasSequence("S_WASH_BASES3");

            modelBuilder.HasSequence("S_WASH_BASES321");

            modelBuilder.HasSequence("S_WASH_BASES321_CC");

            modelBuilder.HasSequence("S_WASH_BASES4");

            modelBuilder.HasSequence("S_WASH_BASES5");

            modelBuilder.HasSequence("S_WASH_BASES6");

            modelBuilder.HasSequence("S_WASH_CARD7");

            modelBuilder.HasSequence("S_WASH_FREQ321");

            modelBuilder.HasSequence("S_WASH_KV_ERR7");

            modelBuilder.HasSequence("S_WASH_KV7");

            modelBuilder.HasSequence("S_WASH_PL7");

            modelBuilder.HasSequence("S_WASH_REQTYPES7");

            modelBuilder.HasSequence("S_WASH_REQUESTS7");

            modelBuilder.HasSequence("S_WASH_RESPONSES7");

            modelBuilder.HasSequence("S_WASH_RH_FILES7");

            modelBuilder.HasSequence("S_WASH_RH7");

            modelBuilder.HasSequence("S_WASH_ROW_NUMB").IsCyclic();

            modelBuilder.HasSequence("S_WASH_ROW_NUMB321").IsCyclic();

            modelBuilder.HasSequence("S_WASH_ROWS");

            modelBuilder.HasSequence("S_WASH_ROWS3");

            modelBuilder.HasSequence("S_WASH_ROWS321");

            modelBuilder.HasSequence("S_WASH_ROWS321_CC");

            modelBuilder.HasSequence("S_WASH_ROWS4");

            modelBuilder.HasSequence("S_WASH_ROWS5");

            modelBuilder.HasSequence("S_WASH_ROWS6");

            modelBuilder.HasSequence("S_WASH_SIGNATURES321");

            modelBuilder.HasSequence("S_WASH10_BS");

            modelBuilder.HasSequence("S_WASH10_CD");

            modelBuilder.HasSequence("S_WASH10_DC");

            modelBuilder.HasSequence("S_WASH10_DM");

            modelBuilder.HasSequence("S_WASH10_FL");

            modelBuilder.HasSequence("S_WASH10_FT");

            modelBuilder.HasSequence("S_WASH10_ISC");

            modelBuilder.HasSequence("S_WASH10_PD");

            modelBuilder.HasSequence("S_WASH10_PHN");

            modelBuilder.HasSequence("S_WASH10_PZ");

            modelBuilder.HasSequence("S_WASH10_RW");

            modelBuilder.HasSequence("S_WASH10_TF");

            modelBuilder.HasSequence("S_WASH10_TF_PVN");

            modelBuilder.HasSequence("S_WASH10_UA");

            modelBuilder.HasSequence("S_WASH10_UD");

            modelBuilder.HasSequence("S_WASH10_UX");

            modelBuilder.HasSequence("S_WASH10_VPN");

            modelBuilder.HasSequence("S_WASH5_FL");

            modelBuilder.HasSequence("S_WASH5_OPM");

            modelBuilder.HasSequence("S_WASH6_FL");

            modelBuilder.HasSequence("S_WASH8_BS");

            modelBuilder.HasSequence("S_WASH8_ISC");

            modelBuilder.HasSequence("S_WASH8_OK");

            modelBuilder.HasSequence("S_WASH8_PD");

            modelBuilder.HasSequence("S_WASH8_PZ");

            modelBuilder.HasSequence("S_WASH8_RR");

            modelBuilder.HasSequence("S_WASH8_RS");

            modelBuilder.HasSequence("S_WASH8_RW");

            modelBuilder.HasSequence("S_WASH8_UA");

            modelBuilder.HasSequence("S_WASH8_UD");

            modelBuilder.HasSequence("S_WASH8_UX");

            modelBuilder.HasSequence("S_WASH9_ERR");

            modelBuilder.HasSequence("S_WASH9_FL");

            modelBuilder.HasSequence("S_WASH9_ISC");

            modelBuilder.HasSequence("S_WASH9_LD");

            modelBuilder.HasSequence("S_WASH9_PD");

            modelBuilder.HasSequence("S_WASH9_PZ");

            modelBuilder.HasSequence("S_WASH9_RC");

            modelBuilder.HasSequence("S_WASH9_RR");

            modelBuilder.HasSequence("S_WASH9_RW");

            modelBuilder.HasSequence("S_WASH9_UA");

            modelBuilder.HasSequence("S_WASH9_UD");

            modelBuilder.HasSequence("S_WASH9_UX");

            modelBuilder.HasSequence("S_WUC_ID");

            modelBuilder.HasSequence("S_WUD_ID");

            modelBuilder.HasSequence("S_XD_GROUP");

            modelBuilder.HasSequence("S_XD_NEWS");

            modelBuilder.HasSequence("S_XD_PROD");

            modelBuilder.HasSequence("S_XD_TASK");

            modelBuilder.HasSequence("S_XL_A");

            modelBuilder.HasSequence("S_XL_AA");

            modelBuilder.HasSequence("S_XL_ACC");

            modelBuilder.HasSequence("S_XL_ACT");

            modelBuilder.HasSequence("S_XL_ACTCTL");

            modelBuilder.HasSequence("S_XL_ACTZ");

            modelBuilder.HasSequence("S_XL_AI");

            modelBuilder.HasSequence("S_XL_AP");

            modelBuilder.HasSequence("S_XL_ATR");

            modelBuilder.HasSequence("S_XL_ATRD");

            modelBuilder.HasSequence("S_XL_AU");

            modelBuilder.HasSequence("S_XL_BACC");

            modelBuilder.HasSequence("S_XL_CAT");

            modelBuilder.HasSequence("S_XL_CG");

            modelBuilder.HasSequence("S_XL_DA");

            modelBuilder.HasSequence("S_XL_DB");

            modelBuilder.HasSequence("S_XL_DCT");

            modelBuilder.HasSequence("S_XL_DMCX");

            modelBuilder.HasSequence("S_XL_ENT");

            modelBuilder.HasSequence("S_XL_FLCOLDEFS");

            modelBuilder.HasSequence("S_XL_FLCONTENT");

            modelBuilder.HasSequence("S_XL_FLLOAD");

            modelBuilder.HasSequence("S_XL_FLTYPE");

            modelBuilder.HasSequence("S_XL_GPP");

            modelBuilder.HasSequence("S_XL_GPPD");

            modelBuilder.HasSequence("S_XL_GPR");

            modelBuilder.HasSequence("S_XL_LOVX");

            modelBuilder.HasSequence("S_XL_NPP");

            modelBuilder.HasSequence("S_XL_P");

            modelBuilder.HasSequence("S_XL_PFI");

            modelBuilder.HasSequence("S_XL_QW_INFO_AGR");

            modelBuilder.HasSequence("S_XL_QW_INFO_GPP");

            modelBuilder.HasSequence("S_XL_QW_INFO_GPPT");

            modelBuilder.HasSequence("S_XL_QW_INFO_SPMT");

            modelBuilder.HasSequence("S_XL_R");

            modelBuilder.HasSequence("S_XL_RH");

            modelBuilder.HasSequence("S_XL_RI");

            modelBuilder.HasSequence("S_XL_SC");

            modelBuilder.HasSequence("S_XL_SCCX");

            modelBuilder.HasSequence("S_XL_SCR");

            modelBuilder.HasSequence("S_XL_SP");

            modelBuilder.HasSequence("S_XL_SPA");

            modelBuilder.HasSequence("S_XL_SPASC");

            modelBuilder.HasSequence("S_XL_SPS");

            modelBuilder.HasSequence("S_XL_SQL");

            modelBuilder.HasSequence("S_XL_SRVL");

            modelBuilder.HasSequence("S_XL_SRVLOG");

            modelBuilder.HasSequence("S_XL_SRVR");

            modelBuilder.HasSequence("S_XL_TACC");

            modelBuilder.HasSequence("S_XL_TACT");

            modelBuilder.HasSequence("S_XL_TADM");

            modelBuilder.HasSequence("S_XL_TASC");

            modelBuilder.HasSequence("S_XL_TATR");

            modelBuilder.HasSequence("S_XL_TATRS");

            modelBuilder.HasSequence("S_XL_TAU");

            modelBuilder.HasSequence("S_XL_TLC");

            modelBuilder.HasSequence("S_XL_TXD");

            modelBuilder.HasSequence("S_XL_USRSET");

            modelBuilder.HasSequence("S_XL_XD");

            modelBuilder.HasSequence("S_XP");

            modelBuilder.HasSequence("S_ZP_BDPC");

            modelBuilder.HasSequence("S_ZP_DGPH");

            modelBuilder.HasSequence("S_ZP_NUM_ROWVERSION").IsCyclic();

            modelBuilder.HasSequence("SA_SEQUENCE");

            modelBuilder.HasSequence("SDJOPTS");

            modelBuilder.HasSequence("SEQ_251");

            modelBuilder.HasSequence("SEQ_BDISPAYORDER");

            modelBuilder.HasSequence("SEQ_BNKT_R").IsCyclic();

            modelBuilder.HasSequence("SEQ_FPC").IsCyclic();

            modelBuilder.HasSequence("SEQ_FPC_SPR").IsCyclic();

            modelBuilder.HasSequence("SEQ_ID_ATR_ACC");

            modelBuilder.HasSequence("SEQ_ID_ATR_CUS");

            modelBuilder.HasSequence("SEQ_ID_DJ_CHANGE_836");

            modelBuilder.HasSequence("SEQ_ID_DJ_SLICE_ERROR_LOG");

            modelBuilder.HasSequence("SEQ_ID_FIL_CHECK_LIST");

            modelBuilder.HasSequence("SEQ_ID_SL_ACC");

            modelBuilder.HasSequence("SEQ_ID_SL_LIST");

            modelBuilder.HasSequence("SEQ_ID_VALUE_ATR_ACC");

            modelBuilder.HasSequence("SEQ_ID_VALUE_ATR_ACF");

            modelBuilder.HasSequence("SEQ_ID_VALUE_ATR_CUS");

            modelBuilder.HasSequence("SEQ_ID_VALUE_ATR_DJ");

            modelBuilder.HasSequence("SEQ_ID_VISITORS");

            modelBuilder.HasSequence("SEQ_NI_FILES_INT_ID");

            modelBuilder.HasSequence("SEQ_NL_SUMS_ID");

            modelBuilder.HasSequence("SEQ_NPI_MO");

            modelBuilder.HasSequence("SEQ_NPI_RIB");

            modelBuilder.HasSequence("SEQ_NPI_ROB");

            modelBuilder.HasSequence("SEQ_NPI_RSIB");

            modelBuilder.HasSequence("SEQ_NPI_RVSIB");

            modelBuilder.HasSequence("SEQ_NPI_VIB");

            modelBuilder.HasSequence("SEQ_NPI_VOB");

            modelBuilder.HasSequence("SEQ_PERC_PSV_TAR");

            modelBuilder.HasSequence("SEQ_REESTR_PAY");

            modelBuilder.HasSequence("SEQ_SW_ACC_MT940_CLIENT");

            modelBuilder.HasSequence("SEQ_ZB_ID_GRP");

            modelBuilder.HasSequence("SEQ_ZP_BDPA");

            modelBuilder.HasSequence("SEQ_ZP_BODY_LIST_BONUS");

            modelBuilder.HasSequence("SEQ_ZP_BONUS");

            modelBuilder.HasSequence("SEQ_ZP_DISCOUNT_LIST_KODZPDL");

            modelBuilder.HasSequence("SEQ_ZP_DISCOUNT_PERC_KODZPDP");

            modelBuilder.HasSequence("SEQ_ZP_EXTRA_DEDUCT");

            modelBuilder.HasSequence("SEQ_ZP_HEAD_LIST_BONUS");

            modelBuilder.HasSequence("SEQ_ZP_string_BENEFITS");

            modelBuilder.HasSequence("SEQB001");

            modelBuilder.HasSequence("SEQB002");

            modelBuilder.HasSequence("SEQB003");

            modelBuilder.HasSequence("SEQB004");

            modelBuilder.HasSequence("SEQB005");

            modelBuilder.HasSequence("SEQBABR");

            modelBuilder.HasSequence("SEQBACO");

            modelBuilder.HasSequence("SEQBADP");

            modelBuilder.HasSequence("SEQBADR");

            modelBuilder.HasSequence("SEQBANP");

            modelBuilder.HasSequence("SEQBAOS");

            modelBuilder.HasSequence("SEQBASH");

            modelBuilder.HasSequence("SEQBATT");

            modelBuilder.HasSequence("SEQBB12");

            modelBuilder.HasSequence("SEQBBLN");

            modelBuilder.HasSequence("SEQBCCA");

            modelBuilder.HasSequence("SEQBCGR");

            modelBuilder.HasSequence("SEQBCON");

            modelBuilder.HasSequence("SEQBCOP");

            modelBuilder.HasSequence("SEQBCRD");

            modelBuilder.HasSequence("SEQBCSH");

            modelBuilder.HasSequence("SEQBCSP");

            modelBuilder.HasSequence("SEQBDAC");

            modelBuilder.HasSequence("SEQBDBH");

            modelBuilder.HasSequence("SEQBDBR");

            modelBuilder.HasSequence("SEQBDBZ");

            modelBuilder.HasSequence("SEQBDDO");

            modelBuilder.HasSequence("SEQBDIZ");

            modelBuilder.HasSequence("SEQBDKN");

            modelBuilder.HasSequence("SEQBDMP");

            modelBuilder.HasSequence("SEQBDOC");

            modelBuilder.HasSequence("SEQBDOG");

            modelBuilder.HasSequence("SEQBDOL");

            modelBuilder.HasSequence("SEQBDPD");

            modelBuilder.HasSequence("SEQBDRM");

            modelBuilder.HasSequence("SEQBDUN");

            modelBuilder.HasSequence("SEQBDVP");

            modelBuilder.HasSequence("SEQBDVR");

            modelBuilder.HasSequence("SEQBDXO");

            modelBuilder.HasSequence("SEQBDXS");

            modelBuilder.HasSequence("SEQBEDI");

            modelBuilder.HasSequence("SEQBEPY");

            modelBuilder.HasSequence("SEQBESD");

            modelBuilder.HasSequence("SEQBESP");

            modelBuilder.HasSequence("SEQBF_B");

            modelBuilder.HasSequence("SEQBFAK");

            modelBuilder.HasSequence("SEQBFAM");

            modelBuilder.HasSequence("SEQBFID");

            modelBuilder.HasSequence("SEQBFNM");

            modelBuilder.HasSequence("SEQBFPR");

            modelBuilder.HasSequence("SEQBFRZ");

            modelBuilder.HasSequence("SEQBGRD");

            modelBuilder.HasSequence("SEQBGRR");

            modelBuilder.HasSequence("SEQBHDG");

            modelBuilder.HasSequence("SEQBHLG");

            modelBuilder.HasSequence("SEQBIDF");

            modelBuilder.HasSequence("SEQBIGO");

            modelBuilder.HasSequence("SEQBINV");

            modelBuilder.HasSequence("SEQBKMC");

            modelBuilder.HasSequence("SEQBKME");

            modelBuilder.HasSequence("SEQBKMN");

            modelBuilder.HasSequence("SEQBKOK");

            modelBuilder.HasSequence("SEQBKOM");

            modelBuilder.HasSequence("SEQBKOS");

            modelBuilder.HasSequence("SEQBKPS");

            modelBuilder.HasSequence("SEQBLGT");

            modelBuilder.HasSequence("SEQBLNS");

            modelBuilder.HasSequence("SEQBMAM");

            modelBuilder.HasSequence("SEQBMBC");

            modelBuilder.HasSequence("SEQBMBS");

            modelBuilder.HasSequence("SEQBMOS");

            modelBuilder.HasSequence("SEQBMPR");

            modelBuilder.HasSequence("SEQBMPU");

            modelBuilder.HasSequence("SEQBN11");

            modelBuilder.HasSequence("SEQBNAC");

            modelBuilder.HasSequence("SEQBNLG");

            modelBuilder.HasSequence("SEQBNOM");

            modelBuilder.HasSequence("SEQBNSH");

            modelBuilder.HasSequence("SEQBOAC");

            modelBuilder.HasSequence("SEQBOBD");

            modelBuilder.HasSequence("SEQBOBR");

            modelBuilder.HasSequence("SEQBOMH");

            modelBuilder.HasSequence("SEQBOSA");

            modelBuilder.HasSequence("SEQBOSB");

            modelBuilder.HasSequence("SEQBOSD");

            modelBuilder.HasSequence("SEQBOSN");

            modelBuilder.HasSequence("SEQBOTD");

            modelBuilder.HasSequence("SEQBOTP");

            modelBuilder.HasSequence("SEQBPER");

            modelBuilder.HasSequence("SEQBPFT");

            modelBuilder.HasSequence("SEQBPGA");

            modelBuilder.HasSequence("SEQBPGB");

            modelBuilder.HasSequence("SEQBPGR");

            modelBuilder.HasSequence("SEQBPIN");

            modelBuilder.HasSequence("SEQBPOB");

            modelBuilder.HasSequence("SEQBPOD");

            modelBuilder.HasSequence("SEQBPOR");

            modelBuilder.HasSequence("SEQBPOS");

            modelBuilder.HasSequence("SEQBPOT");

            modelBuilder.HasSequence("SEQBPRB");

            modelBuilder.HasSequence("SEQBPRF");

            modelBuilder.HasSequence("SEQBPRK");

            modelBuilder.HasSequence("SEQBPRP");

            modelBuilder.HasSequence("SEQBPRU");

            modelBuilder.HasSequence("SEQBPSO");

            modelBuilder.HasSequence("SEQBPSP");

            modelBuilder.HasSequence("SEQBPTZ");

            modelBuilder.HasSequence("SEQBPZA");

            modelBuilder.HasSequence("SEQBPZP");

            modelBuilder.HasSequence("SEQBPZR");

            modelBuilder.HasSequence("SEQBQUA");

            modelBuilder.HasSequence("SEQBR_C");

            modelBuilder.HasSequence("SEQBRES");

            modelBuilder.HasSequence("SEQBRGO");

            modelBuilder.HasSequence("SEQBRMC");

            modelBuilder.HasSequence("SEQBROP");

            modelBuilder.HasSequence("SEQBROS");

            modelBuilder.HasSequence("SEQBRPY");

            modelBuilder.HasSequence("SEQBRSH").IsCyclic();

            modelBuilder.HasSequence("SEQBRSP");

            modelBuilder.HasSequence("SEQBRVD");

            modelBuilder.HasSequence("SEQBRVN");

            modelBuilder.HasSequence("SEQBSAT");

            modelBuilder.HasSequence("SEQBSAZ");

            modelBuilder.HasSequence("SEQBSBN");

            modelBuilder.HasSequence("SEQBSBR");

            modelBuilder.HasSequence("SEQBSCH");

            modelBuilder.HasSequence("SEQBSDG");

            modelBuilder.HasSequence("SEQBSDI");

            modelBuilder.HasSequence("SEQBSEM");

            modelBuilder.HasSequence("SEQBSEV");

            modelBuilder.HasSequence("SEQBSFO");

            modelBuilder.HasSequence("SEQBSHP");

            modelBuilder.HasSequence("SEQBSHT");

            modelBuilder.HasSequence("SEQBSKN");

            modelBuilder.HasSequence("SEQBSKP");

            modelBuilder.HasSequence("SEQBSKR");

            modelBuilder.HasSequence("SEQBSLG");

            modelBuilder.HasSequence("SEQBSLN");

            modelBuilder.HasSequence("SEQBSLV");

            modelBuilder.HasSequence("SEQBSMN");

            modelBuilder.HasSequence("SEQBSNP");

            modelBuilder.HasSequence("SEQBSOF");

            modelBuilder.HasSequence("SEQBSOK");

            modelBuilder.HasSequence("SEQBSOP");

            modelBuilder.HasSequence("SEQBSOS");

            modelBuilder.HasSequence("SEQBSOT");

            modelBuilder.HasSequence("SEQBSPC");

            modelBuilder.HasSequence("SEQBSPF");

            modelBuilder.HasSequence("SEQBSPL");

            modelBuilder.HasSequence("SEQBSPY");

            modelBuilder.HasSequence("SEQBSRK");

            modelBuilder.HasSequence("SEQBSRO");

            modelBuilder.HasSequence("SEQBSRV");

            modelBuilder.HasSequence("SEQBSTR");

            modelBuilder.HasSequence("SEQBSTT");

            modelBuilder.HasSequence("SEQBSUV");

            modelBuilder.HasSequence("SEQBSVO");

            modelBuilder.HasSequence("SEQBSVZ");

            modelBuilder.HasSequence("SEQBSXO");

            modelBuilder.HasSequence("SEQBSXP");

            modelBuilder.HasSequence("SEQBTAK");

            modelBuilder.HasSequence("SEQBTAR");

            modelBuilder.HasSequence("SEQBTAS");

            modelBuilder.HasSequence("SEQBTBH");

            modelBuilder.HasSequence("SEQBTBL");

            modelBuilder.HasSequence("SEQBTHR");

            modelBuilder.HasSequence("SEQBTPA");

            modelBuilder.HasSequence("SEQBTPR");

            modelBuilder.HasSequence("SEQBTPS");

            modelBuilder.HasSequence("SEQBTRN");

            modelBuilder.HasSequence("SEQBTRO");

            modelBuilder.HasSequence("SEQBTRR");

            modelBuilder.HasSequence("SEQBTRS");

            modelBuilder.HasSequence("SEQBTTN");

            modelBuilder.HasSequence("SEQBTTS");

            modelBuilder.HasSequence("SEQBUDL");

            modelBuilder.HasSequence("SEQBUTR");

            modelBuilder.HasSequence("SEQBVDO");

            modelBuilder.HasSequence("SEQBVZO");

            modelBuilder.HasSequence("SEQBVZS");

            modelBuilder.HasSequence("SEQBWGD");

            modelBuilder.HasSequence("SEQBWGR");

            modelBuilder.HasSequence("SEQBWKT");

            modelBuilder.HasSequence("SEQBWRK");

            modelBuilder.HasSequence("SEQBWSO");

            modelBuilder.HasSequence("SEQBWTP");

            modelBuilder.HasSequence("SEQBWZV");

            modelBuilder.HasSequence("SEQBZAC");

            modelBuilder.HasSequence("SEQBZAN");

            modelBuilder.HasSequence("SEQBZAR");

            modelBuilder.HasSequence("SEQBZBL");

            modelBuilder.HasSequence("SEQFAVTNUM2");

            modelBuilder.HasSequence("SEQHOBG");

            modelBuilder.HasSequence("SEQTRACE").IsCyclic();

            modelBuilder.HasSequence("SEQUCHOFACT");

            modelBuilder.HasSequence("SEQUCHOPER");

            modelBuilder.HasSequence("SEQYBGS");

            modelBuilder.HasSequence("SEQYBLD");

            modelBuilder.HasSequence("SEQYBLI");

            modelBuilder.HasSequence("SEQYBLN");

            modelBuilder.HasSequence("SEQYBMK");

            modelBuilder.HasSequence("SEQYBRG");

            modelBuilder.HasSequence("SEQYBRS");

            modelBuilder.HasSequence("SEQYCBS");

            modelBuilder.HasSequence("SEQYCOM");

            modelBuilder.HasSequence("SEQYCON");

            modelBuilder.HasSequence("SEQYDBS");

            modelBuilder.HasSequence("SEQYDBZ");

            modelBuilder.HasSequence("SEQYDEP");

            modelBuilder.HasSequence("SEQYDLV");

            modelBuilder.HasSequence("SEQYDOC");

            modelBuilder.HasSequence("SEQYDSD");

            modelBuilder.HasSequence("SEQYEMT");

            modelBuilder.HasSequence("SEQYEXA");

            modelBuilder.HasSequence("SEQYEXC");

            modelBuilder.HasSequence("SEQYEXE");

            modelBuilder.HasSequence("SEQYEXL");

            modelBuilder.HasSequence("SEQYFAL");

            modelBuilder.HasSequence("SEQYFAN");

            modelBuilder.HasSequence("SEQYGMB");

            modelBuilder.HasSequence("SEQYGPS");

            modelBuilder.HasSequence("SEQYGRP");

            modelBuilder.HasSequence("SEQYHHE");

            modelBuilder.HasSequence("SEQYIFL");

            modelBuilder.HasSequence("SEQYIFS");

            modelBuilder.HasSequence("SEQYINK");

            modelBuilder.HasSequence("SEQYJAK");

            modelBuilder.HasSequence("SEQYJKB");

            modelBuilder.HasSequence("SEQYKPS");

            modelBuilder.HasSequence("SEQYKSP");

            modelBuilder.HasSequence("SEQYKST");

            modelBuilder.HasSequence("SEQYMAA");

            modelBuilder.HasSequence("SEQYMAB");

            modelBuilder.HasSequence("SEQYMAD");

            modelBuilder.HasSequence("SEQYMAI");

            modelBuilder.HasSequence("SEQYMAO");

            modelBuilder.HasSequence("SEQYMAP");

            modelBuilder.HasSequence("SEQYMAR");

            modelBuilder.HasSequence("SEQYMAW");

            modelBuilder.HasSequence("SEQYMBL");

            modelBuilder.HasSequence("SEQYMBR");

            modelBuilder.HasSequence("SEQYMPD");

            modelBuilder.HasSequence("SEQYMTS");

            modelBuilder.HasSequence("SEQYNDX");

            modelBuilder.HasSequence("SEQYOPB");

            modelBuilder.HasSequence("SEQYPIB");

            modelBuilder.HasSequence("SEQYPIN");

            modelBuilder.HasSequence("SEQYPIT");

            modelBuilder.HasSequence("SEQYPRB");

            modelBuilder.HasSequence("SEQYPRL");

            modelBuilder.HasSequence("SEQYPRS");

            modelBuilder.HasSequence("SEQYPST");

            modelBuilder.HasSequence("SEQYRKC").IsCyclic();

            modelBuilder.HasSequence("SEQYSCU");

            modelBuilder.HasSequence("SEQYSDA");

            modelBuilder.HasSequence("SEQYSDO");

            modelBuilder.HasSequence("SEQYSDS");

            modelBuilder.HasSequence("SEQYSEC");

            modelBuilder.HasSequence("SEQYSKK");

            modelBuilder.HasSequence("SEQYSKP");

            modelBuilder.HasSequence("SEQYSMN");

            modelBuilder.HasSequence("SEQYSMP");

            modelBuilder.HasSequence("SEQYSMR");

            modelBuilder.HasSequence("SEQYSNP");

            modelBuilder.HasSequence("SEQYSPA");

            modelBuilder.HasSequence("SEQYSRP");

            modelBuilder.HasSequence("SEQYSRS");

            modelBuilder.HasSequence("SEQYSSD");

            modelBuilder.HasSequence("SEQYTBL");

            modelBuilder.HasSequence("SEQYTMP");

            modelBuilder.HasSequence("SEQYTMT");

            modelBuilder.HasSequence("SEQYTRA");

            modelBuilder.HasSequence("SEQYTRS");

            modelBuilder.HasSequence("SEQYTTU");

            modelBuilder.HasSequence("SEQYVNB");

            modelBuilder.HasSequence("SEQYWBE");

            modelBuilder.HasSequence("SEQYWBI");

            modelBuilder.HasSequence("SEQYXRD");

            modelBuilder.HasSequence("SEQYXRN");

            modelBuilder.HasSequence("SEQYZAA");

            modelBuilder.HasSequence("SEQYZAL");

            modelBuilder.HasSequence("SEQYZAY");

            modelBuilder.HasSequence("SEQYZEA");

            modelBuilder.HasSequence("SEQYZTU");

            modelBuilder.HasSequence("SEQZFP4");

            modelBuilder.HasSequence("SQ_BHDP");

            modelBuilder.HasSequence("SQ_BPLN").IsCyclic();

            modelBuilder.HasSequence("SQ_NTC_IUVDNUM").IsCyclic();

            modelBuilder.HasSequence("SQBHAA");

            modelBuilder.HasSequence("SQBHCS");

            modelBuilder.HasSequence("SQBPAK");

            modelBuilder.HasSequence("STATE_SEQ");

            modelBuilder.HasSequence("SV_SEQ");

            modelBuilder.HasSequence("TCS_UPDATES_SEQ");

            modelBuilder.HasSequence("TRIP_SEQ");

            modelBuilder.HasSequence("TX_SEQ");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
