using ApisDB.Models;
using Microsoft.EntityFrameworkCore;

namespace ApisDB.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Timovimientodetalle> Timovimientodetalles { get; set; }

        public virtual DbSet<Timovimientoencab> Timovimientoencabs { get; set; }

        public virtual DbSet<Titiposdocumento> Titiposdocumentos { get; set; }

        public virtual DbSet<VistaPrueba> VistaPruebas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Timovimientodetalle>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("TIMOVIMIENTODETALLE");

                entity.HasIndex(e => new { e.Mv2Artic, e.Mv2Bodega1, e.Mv2Fch }, "IMOVDET_ARTICULO_BD1_FECHA_I");

                entity.HasIndex(e => new { e.Mv2Artic, e.Mv2Bodega1 }, "IMOVDET_ARTICULO_BD1_I");

                entity.HasIndex(e => new { e.Mv2Artic, e.Mv2Bodega2, e.Mv2Fch }, "IMOVDET_ARTICULO_BD2_FECHA_I");

                entity.HasIndex(e => new { e.Mv2Artic, e.Mv2Bodega2 }, "IMOVDET_ARTICULO_BD2_I");

                entity.HasIndex(e => new { e.Mv2Artic, e.Mv2Fch, e.Mv2Tipo, e.Mv2Num }, "IMOVDET_ARTICULO_FECHA_I");

                entity.HasIndex(e => e.Mv2Artic, "IMOVDET_ARTICULO_I");

                entity.HasIndex(e => new { e.Mv2Fch, e.Mv2Artic, e.Mv2Bodega1 }, "IMOVDET_FECHA_ARTICULO_BD1_I");

                entity.HasIndex(e => new { e.Mv2Fch, e.Mv2Artic, e.Mv2Bodega2 }, "IMOVDET_FECHA_ARTICULO_BD2_I");

                entity.HasIndex(e => new { e.Mv2Fch, e.Mv2Artic }, "IMOVDET_FECHA_ARTICULO_I");

                entity.HasIndex(e => new { e.Mv2Tipo, e.Mv2Num, e.Mv2Seq }, "ITIMOVIMIENTODETALLE0")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.Mv2Artic, e.Mv2Fch, e.Mv2Tipo, e.Mv2Num }, "ITIMOVIMIENTODETALLE1");

                entity.HasIndex(e => new { e.Mv2Pedido, e.Mv2SeqPed, e.Mv2Fch, e.Mv2Tipo, e.Mv2Num, e.Mv2Seq }, "ITIMOVIMIENTODETALLE2");

                entity.HasIndex(e => new { e.Mv2Zona, e.Mv2Cod, e.Mv2Seqk, e.Mv2Artic, e.Mv2Fch, e.Mv2Tipo, e.Mv2Num }, "ITIMOVIMIENTODETALLE3");

                entity.HasIndex(e => new { e.Mv2Zonap, e.Mv2Codp, e.Mv2Seqp, e.Mv2Artic, e.Mv2Fch, e.Mv2Tipo, e.Mv2Num }, "ITIMOVIMIENTODETALLE4");

                entity.Property(e => e.Mv2Anulado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_ANULADO");
                entity.Property(e => e.Mv2Artic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MV2_ARTIC");
                entity.Property(e => e.Mv2Asentado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_ASENTADO");
                entity.Property(e => e.Mv2Bodega1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV2_BODEGA1");
                entity.Property(e => e.Mv2Bodega2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV2_BODEGA2");
                entity.Property(e => e.Mv2CCosto)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("MV2_C_COSTO");
                entity.Property(e => e.Mv2Cant1)
                    .HasColumnType("decimal(12, 3)")
                    .HasColumnName("MV2_CANT1");
                entity.Property(e => e.Mv2Cant2)
                    .HasColumnType("decimal(12, 3)")
                    .HasColumnName("MV2_CANT2");
                entity.Property(e => e.Mv2Cant3)
                    .HasColumnType("decimal(12, 3)")
                    .HasColumnName("MV2_CANT3");
                entity.Property(e => e.Mv2CantHc)
                    .HasColumnType("decimal(12, 3)")
                    .HasColumnName("MV2_CANT_HC");
                entity.Property(e => e.Mv2CantIni)
                    .HasColumnType("decimal(12, 3)")
                    .HasColumnName("MV2_CANT_INI");
                entity.Property(e => e.Mv2CantOf)
                    .HasColumnType("decimal(12, 3)")
                    .HasColumnName("MV2_CANT_OF");
                entity.Property(e => e.Mv2CantRes)
                    .HasColumnType("decimal(12, 3)")
                    .HasColumnName("MV2_CANT_RES");
                entity.Property(e => e.Mv2ClasePed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_CLASE_PED");
                entity.Property(e => e.Mv2ClaseValor)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_CLASE_VALOR");
                entity.Property(e => e.Mv2Cobrar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_COBRAR");
                entity.Property(e => e.Mv2Cod)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("MV2_COD");
                entity.Property(e => e.Mv2CodAf)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV2_COD_AF");
                entity.Property(e => e.Mv2CodCum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MV2_COD_CUM");
                entity.Property(e => e.Mv2Codp)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("MV2_CODP");
                entity.Property(e => e.Mv2ConcDevL)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MV2_CONC_DEV_L");
                entity.Property(e => e.Mv2Conten)
                    .HasColumnType("decimal(8, 3)")
                    .HasColumnName("MV2_CONTEN");
                entity.Property(e => e.Mv2Contrato)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MV2_CONTRATO");
                entity.Property(e => e.Mv2Costo)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_COSTO");
                entity.Property(e => e.Mv2Cuenta)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MV2_CUENTA");
                entity.Property(e => e.Mv2Desc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MV2_DESC");
                entity.Property(e => e.Mv2Detallex)
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("MV2_DETALLEX");
                entity.Property(e => e.Mv2Digitado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_DIGITADO");
                entity.Property(e => e.Mv2Dscto1)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV2_DSCTO1");
                entity.Property(e => e.Mv2Dscto2)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV2_DSCTO2");
                entity.Property(e => e.Mv2Dscto3)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV2_DSCTO3");
                entity.Property(e => e.Mv2Dscto4)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV2_DSCTO4");
                entity.Property(e => e.Mv2EstClaseProc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_EST_CLASE_PROC");
                entity.Property(e => e.Mv2EstaProg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_ESTA_PROG");
                entity.Property(e => e.Mv2EstadoOrdhc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_ESTADO_ORDHC");
                entity.Property(e => e.Mv2Estatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_ESTATUS");
                entity.Property(e => e.Mv2EstatusFin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_ESTATUS_FIN");
                entity.Property(e => e.Mv2EstatusIni)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_ESTATUS_INI");
                entity.Property(e => e.Mv2EventoPaq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_EVENTO_PAQ");
                entity.Property(e => e.Mv2Factura)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("MV2_FACTURA");
                entity.Property(e => e.Mv2Fch)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("MV2_FCH");
                entity.Property(e => e.Mv2FchDig)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("MV2_FCH_DIG");
                entity.Property(e => e.Mv2FchLote)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("MV2_FCH_LOTE");
                entity.Property(e => e.Mv2FchPedido)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("MV2_FCH_PEDIDO");
                entity.Property(e => e.Mv2FchVence)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("MV2_FCH_VENCE");
                entity.Property(e => e.Mv2Futuro1)
                    .HasMaxLength(3778)
                    .IsUnicode(false)
                    .HasColumnName("MV2_FUTURO1");
                entity.Property(e => e.Mv2Futuro2)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("MV2_FUTURO2");
                entity.Property(e => e.Mv2Futuro3)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("MV2_FUTURO3");
                entity.Property(e => e.Mv2Futuro4)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("MV2_FUTURO4");
                entity.Property(e => e.Mv2HhF)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MV2_HH_F");
                entity.Property(e => e.Mv2HhI)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MV2_HH_I");
                entity.Property(e => e.Mv2HojaC)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV2_HOJA_C");
                entity.Property(e => e.Mv2Hora)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("MV2_HORA");
                entity.Property(e => e.Mv2Impreso)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_IMPRESO");
                entity.Property(e => e.Mv2Iva)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV2_IVA");
                entity.Property(e => e.Mv2Lote)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MV2_LOTE");
                entity.Property(e => e.Mv2Maquina)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MV2_MAQUINA");
                entity.Property(e => e.Mv2MarcaAnt)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MV2_MARCA_ANT");
                entity.Property(e => e.Mv2MargenRent)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV2_MARGEN_RENT");
                entity.Property(e => e.Mv2Medico)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("MV2_MEDICO");
                entity.Property(e => e.Mv2MmF)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MV2_MM_F");
                entity.Property(e => e.Mv2MmI)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MV2_MM_I");
                entity.Property(e => e.Mv2Num)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("MV2_NUM");
                entity.Property(e => e.Mv2OacodTarifa)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MV2_OACOD_TARIFA");
                entity.Property(e => e.Mv2OestComadi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_OEST_COMADI");
                entity.Property(e => e.Mv2OestGrupoMayor)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_OEST_GRUPO_MAYOR");
                entity.Property(e => e.Mv2OnumRollo)
                    .HasColumnType("decimal(3, 0)")
                    .HasColumnName("MV2_ONUM_ROLLO");
                entity.Property(e => e.Mv2OporcDsctoa)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV2_OPORC_DSCTOA");
                entity.Property(e => e.Mv2Pedido)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("MV2_PEDIDO");
                entity.Property(e => e.Mv2Peso)
                    .HasColumnType("decimal(8, 3)")
                    .HasColumnName("MV2_PESO");
                entity.Property(e => e.Mv2Presen)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MV2_PRESEN");
                entity.Property(e => e.Mv2PrimerProf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_PRIMER_PROF");
                entity.Property(e => e.Mv2Procesado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_PROCESADO");
                entity.Property(e => e.Mv2RelBano)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MV2_REL_BANO");
                entity.Property(e => e.Mv2Saldo)
                    .HasColumnType("decimal(12, 3)")
                    .HasColumnName("MV2_SALDO");
                entity.Property(e => e.Mv2Seq)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("MV2_SEQ");
                entity.Property(e => e.Mv2SeqComp)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("MV2_SEQ_COMP");
                entity.Property(e => e.Mv2SeqCum)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("MV2_SEQ_CUM");
                entity.Property(e => e.Mv2SeqPed)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("MV2_SEQ_PED");
                entity.Property(e => e.Mv2Seqk)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MV2_SEQK");
                entity.Property(e => e.Mv2Seqp)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MV2_SEQP");
                entity.Property(e => e.Mv2Tipo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV2_TIPO");
                entity.Property(e => e.Mv2TipoAtencion)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("MV2_TIPO_ATENCION");
                entity.Property(e => e.Mv2Tipof)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV2_TIPOF");
                entity.Property(e => e.Mv2Tipop)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV2_TIPOP");
                entity.Property(e => e.Mv2UnidadFuncional)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("MV2_UNIDAD_FUNCIONAL");
                entity.Property(e => e.Mv2Usuario)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MV2_USUARIO");
                entity.Property(e => e.Mv2ViaAcceso)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV2_VIA_ACCESO");
                entity.Property(e => e.Mv2Volumen)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("MV2_VOLUMEN");
                entity.Property(e => e.Mv2VrAsumir)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MV2_VR_ASUMIR");
                entity.Property(e => e.Mv2VrCastigo)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_CASTIGO");
                entity.Property(e => e.Mv2VrCastigoExp)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV2_VR_CASTIGO_EXP");
                entity.Property(e => e.Mv2VrCastigoExp2)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_CASTIGO_EXP_2");
                entity.Property(e => e.Mv2VrCastigoExpp)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_CASTIGO_EXPP");
                entity.Property(e => e.Mv2VrCopago)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_COPAGO");
                entity.Property(e => e.Mv2VrCostoB1)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_COSTO_B1");
                entity.Property(e => e.Mv2VrCostoPh)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_COSTO_PH");
                entity.Property(e => e.Mv2VrCostoPr)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_COSTO_PR");
                entity.Property(e => e.Mv2VrCostotDb)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_COSTOT_DB");
                entity.Property(e => e.Mv2VrCostouDb)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_COSTOU_DB");
                entity.Property(e => e.Mv2VrDsctoPl)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_DSCTO_PL");
                entity.Property(e => e.Mv2VrDsctoPv)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_DSCTO_PV");
                entity.Property(e => e.Mv2VrDsctos)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_DSCTOS");
                entity.Property(e => e.Mv2VrDsctosExp)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV2_VR_DSCTOS_EXP");
                entity.Property(e => e.Mv2VrDsctosExp2)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_DSCTOS_EXP_2");
                entity.Property(e => e.Mv2VrDsctosExpp)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_DSCTOS_EXPP");
                entity.Property(e => e.Mv2VrIva)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_IVA");
                entity.Property(e => e.Mv2VrIvaExp)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV2_VR_IVA_EXP");
                entity.Property(e => e.Mv2VrIvaExp2)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_IVA_EXP_2");
                entity.Property(e => e.Mv2VrIvaExpp)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_IVA_EXPP");
                entity.Property(e => e.Mv2VrOtros)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_OTROS");
                entity.Property(e => e.Mv2VrPedido)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_PEDIDO");
                entity.Property(e => e.Mv2VrPepsEnt)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_PEPS_ENT");
                entity.Property(e => e.Mv2VrPublLote)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_PUBL_LOTE");
                entity.Property(e => e.Mv2VrPublico)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_PUBLICO");
                entity.Property(e => e.Mv2VrReal)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_REAL");
                entity.Property(e => e.Mv2VrSinEmb)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_SIN_EMB");
                entity.Property(e => e.Mv2VrTotal)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_TOTAL");
                entity.Property(e => e.Mv2VrVenta)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_VENTA");
                entity.Property(e => e.Mv2VrVentaExp)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV2_VR_VENTA_EXP");
                entity.Property(e => e.Mv2VrVentaExp2)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_VENTA_EXP_2");
                entity.Property(e => e.Mv2VrVentaExpp)
                    .HasColumnType("decimal(16, 3)")
                    .HasColumnName("MV2_VR_VENTA_EXPP");
                entity.Property(e => e.Mv2Zona)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV2_ZONA");
                entity.Property(e => e.Mv2Zonap)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV2_ZONAP");
            });

            modelBuilder.Entity<Timovimientoencab>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("TIMOVIMIENTOENCAB");

                entity.HasIndex(e => new { e.MvTipo, e.MvNum }, "ITIMOVIMIENTOENCAB0")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.MvFch, e.MvHora, e.MvTipo, e.MvNum }, "ITIMOVIMIENTOENCAB1");

                entity.HasIndex(e => new { e.MvZona, e.MvCod, e.MvSeqk, e.MvFch, e.MvTipo, e.MvNum }, "ITIMOVIMIENTOENCAB2");

                entity.HasIndex(e => new { e.MvZonap, e.MvCodp, e.MvSeqkp, e.MvFch, e.MvTipo, e.MvNum }, "ITIMOVIMIENTOENCAB3");

                entity.HasIndex(e => new { e.MvVended, e.MvFch, e.MvTipo, e.MvNum }, "ITIMOVIMIENTOENCAB4");

                entity.HasIndex(e => new { e.MvClaseDoc, e.MvFch, e.MvTipo, e.MvNum }, "ITIMOVIMIENTOENCAB5");

                entity.Property(e => e.MvAgrupoRem)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_AGRUPO_REM");
                entity.Property(e => e.MvAnexoCorr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_ANEXO_CORR");
                entity.Property(e => e.MvAnulado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_ANULADO");
                entity.Property(e => e.MvBarrio)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MV_BARRIO");
                entity.Property(e => e.MvCCosto)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("MV_C_COSTO");
                entity.Property(e => e.MvCant)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("MV_CANT");
                entity.Property(e => e.MvCantFact)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("MV_CANT_FACT");
                entity.Property(e => e.MvCerrado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_CERRADO");
                entity.Property(e => e.MvCiue)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MV_CIUE");
                entity.Property(e => e.MvClasSal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_CLAS_SAL");
                entity.Property(e => e.MvClaseDoc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_CLASE_DOC");
                entity.Property(e => e.MvClasePed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_CLASE_PED");
                entity.Property(e => e.MvClaseValor)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_CLASE_VALOR");
                entity.Property(e => e.MvCod)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("MV_COD");
                entity.Property(e => e.MvCodInterf)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MV_COD_INTERF");
                entity.Property(e => e.MvCodReten1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_COD_RETEN1");
                entity.Property(e => e.MvCodReten11)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_COD_RETEN_1");
                entity.Property(e => e.MvCodReten2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_COD_RETEN_2");
                entity.Property(e => e.MvCodReten3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_COD_RETEN_3");
                entity.Property(e => e.MvCodReten4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_COD_RETEN_4");
                entity.Property(e => e.MvCodReten5)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_COD_RETEN_5");
                entity.Property(e => e.MvCodReten6)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_COD_RETEN_6");
                entity.Property(e => e.MvCodUsu)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MV_COD_USU");
                entity.Property(e => e.MvCodeudor)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("MV_CODEUDOR");
                entity.Property(e => e.MvCodeudor1)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("MV_CODEUDOR1");
                entity.Property(e => e.MvCodeudor2)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("MV_CODEUDOR2");
                entity.Property(e => e.MvCodp)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("MV_CODP");
                entity.Property(e => e.MvComis)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_COMIS");
                entity.Property(e => e.MvConceptoDev)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MV_CONCEPTO_DEV");
                entity.Property(e => e.MvContab)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_CONTAB");
                entity.Property(e => e.MvContrato)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MV_CONTRATO");
                entity.Property(e => e.MvCorreria)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("MV_CORRERIA");
                entity.Property(e => e.MvCuenta)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MV_CUENTA");
                entity.Property(e => e.MvDire)
                    .HasMaxLength(54)
                    .IsUnicode(false)
                    .HasColumnName("MV_DIRE");
                entity.Property(e => e.MvDscto1)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV_DSCTO_1");
                entity.Property(e => e.MvDscto2)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV_DSCTO_2");
                entity.Property(e => e.MvDsctoPp1)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV_DSCTO_PP_1");
                entity.Property(e => e.MvDsctoPp2)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV_DSCTO_PP_2");
                entity.Property(e => e.MvDsctoPp3)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV_DSCTO_PP_3");
                entity.Property(e => e.MvDsctoPp4)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV_DSCTO_PP_4");
                entity.Property(e => e.MvFactorRastra)
                    .HasColumnType("decimal(3, 0)")
                    .HasColumnName("MV_FACTOR_RASTRA");
                entity.Property(e => e.MvFactura)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("MV_FACTURA");
                entity.Property(e => e.MvFch)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("MV_FCH");
                entity.Property(e => e.MvFchDig)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("MV_FCH_DIG");
                entity.Property(e => e.MvFchLlega)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("MV_FCH_LLEGA");
                entity.Property(e => e.MvFchVence)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("MV_FCH_VENCE");
                entity.Property(e => e.MvFormaPago)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_FORMA_PAGO");
                entity.Property(e => e.MvFuturo1)
                    .HasMaxLength(3865)
                    .IsUnicode(false)
                    .HasColumnName("MV_FUTURO1");
                entity.Property(e => e.MvFuturo2)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("MV_FUTURO2");
                entity.Property(e => e.MvFuturo3)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("MV_FUTURO3");
                entity.Property(e => e.MvFuturo4)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("MV_FUTURO4");
                entity.Property(e => e.MvGenCart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_GEN_CART");
                entity.Property(e => e.MvGenPresup)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_GEN_PRESUP");
                entity.Property(e => e.MvGenSis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_GEN_SIS");
                entity.Property(e => e.MvGeneroSaf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_GENERO_SAF");
                entity.Property(e => e.MvHora)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("MV_HORA");
                entity.Property(e => e.MvHoraDig)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("MV_HORA_DIG");
                entity.Property(e => e.MvImpreso)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_IMPRESO");
                entity.Property(e => e.MvImpreso2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_IMPRESO2");
                entity.Property(e => e.MvInteres)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_INTERES");
                entity.Property(e => e.MvIva)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_IVA");
                entity.Property(e => e.MvLibras)
                    .HasColumnType("decimal(12, 3)")
                    .HasColumnName("MV_LIBRAS");
                entity.Property(e => e.MvNegocio)
                    .HasColumnType("decimal(3, 0)")
                    .HasColumnName("MV_NEGOCIO");
                entity.Property(e => e.MvNomFp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MV_NOM_FP");
                entity.Property(e => e.MvNum)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("MV_NUM");
                entity.Property(e => e.MvNumCuotas)
                    .HasColumnType("decimal(3, 0)")
                    .HasColumnName("MV_NUM_CUOTAS");
                entity.Property(e => e.MvNumOrden)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("MV_NUM_ORDEN");
                entity.Property(e => e.MvNumTarjeta)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MV_NUM_TARJETA");
                entity.Property(e => e.MvObra)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MV_OBRA");
                entity.Property(e => e.MvOestFactura)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MV_OEST_FACTURA");
                entity.Property(e => e.MvOestImprotu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_OEST_IMPROTU");
                entity.Property(e => e.MvPedido)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("MV_PEDIDO");
                entity.Property(e => e.MvPlazo1)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("MV_PLAZO_1");
                entity.Property(e => e.MvPlazo2)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("MV_PLAZO_2");
                entity.Property(e => e.MvPlazo3)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("MV_PLAZO_3");
                entity.Property(e => e.MvPlazo4)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("MV_PLAZO_4");
                entity.Property(e => e.MvPlazo5)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("MV_PLAZO_5");
                entity.Property(e => e.MvPlazo6)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("MV_PLAZO_6");
                entity.Property(e => e.MvPlazoCuotas)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("MV_PLAZO_CUOTAS");
                entity.Property(e => e.MvPorcComis)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV_PORC_COMIS");
                entity.Property(e => e.MvPorcCopago)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV_PORC_COPAGO");
                entity.Property(e => e.MvPorcIva)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV_PORC_IVA");
                entity.Property(e => e.MvPorcSeguro)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("MV_PORC_SEGURO");
                entity.Property(e => e.MvRecibo)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("MV_RECIBO");
                entity.Property(e => e.MvReqPoliza)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_REQ_POLIZA");
                entity.Property(e => e.MvRuta)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MV_RUTA");
                entity.Property(e => e.MvSeqk)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MV_SEQK");
                entity.Property(e => e.MvSeqkp)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MV_SEQKP");
                entity.Property(e => e.MvSucursal)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_SUCURSAL");
                entity.Property(e => e.MvTele)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MV_TELE");
                entity.Property(e => e.MvTercero)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("MV_TERCERO");
                entity.Property(e => e.MvTerminal)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_TERMINAL");
                entity.Property(e => e.MvTipo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_TIPO");
                entity.Property(e => e.MvTipoContrato)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_TIPO_CONTRATO");
                entity.Property(e => e.MvTipoGarantia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MV_TIPO_GARANTIA");
                entity.Property(e => e.MvTipoTarjeta)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_TIPO_TARJETA");
                entity.Property(e => e.MvTipof)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_TIPOF");
                entity.Property(e => e.MvTipoo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_TIPOO");
                entity.Property(e => e.MvTipop)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_TIPOP");
                entity.Property(e => e.MvTipor)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_TIPOR");
                entity.Property(e => e.MvTrans)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_TRANS");
                entity.Property(e => e.MvValor)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VALOR");
                entity.Property(e => e.MvValorExp)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VALOR_EXP");
                entity.Property(e => e.MvVended)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MV_VENDED");
                entity.Property(e => e.MvVrAnticipos)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_ANTICIPOS");
                entity.Property(e => e.MvVrAsumir)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MV_VR_ASUMIR");
                entity.Property(e => e.MvVrBaseRet1)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_BASE_RET_1");
                entity.Property(e => e.MvVrBaseRet2)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_BASE_RET_2");
                entity.Property(e => e.MvVrBaseRet3)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_BASE_RET_3");
                entity.Property(e => e.MvVrBaseRet4)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_BASE_RET_4");
                entity.Property(e => e.MvVrBaseRet5)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_BASE_RET_5");
                entity.Property(e => e.MvVrBaseRet6)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_BASE_RET_6");
                entity.Property(e => e.MvVrCambio)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_CAMBIO");
                entity.Property(e => e.MvVrCheques)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_CHEQUES");
                entity.Property(e => e.MvVrClub)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_CLUB");
                entity.Property(e => e.MvVrConversion)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_CONVERSION");
                entity.Property(e => e.MvVrCuota)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_CUOTA");
                entity.Property(e => e.MvVrDsctoE)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_DSCTO_E");
                entity.Property(e => e.MvVrDsctoEExp)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_DSCTO_E_EXP");
                entity.Property(e => e.MvVrDsctoG)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_DSCTO_G");
                entity.Property(e => e.MvVrDsctoGExp)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_DSCTO_G_EXP");
                entity.Property(e => e.MvVrDsctoPv)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_DSCTO_PV");
                entity.Property(e => e.MvVrEfectivo)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_EFECTIVO");
                entity.Property(e => e.MvVrExcedFavor)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_EXCED_FAVOR");
                entity.Property(e => e.MvVrExcluido)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_EXCLUIDO");
                entity.Property(e => e.MvVrExcluidoExp)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_EXCLUIDO_EXP");
                entity.Property(e => e.MvVrExento)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_EXENTO");
                entity.Property(e => e.MvVrExentoExp)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_EXENTO_EXP");
                entity.Property(e => e.MvVrExtras)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_EXTRAS");
                entity.Property(e => e.MvVrFinancia)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_FINANCIA");
                entity.Property(e => e.MvVrFletes)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_FLETES");
                entity.Property(e => e.MvVrGravado)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_GRAVADO");
                entity.Property(e => e.MvVrGravadoExp)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_GRAVADO_EXP");
                entity.Property(e => e.MvVrIncio)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_INCIO");
                entity.Property(e => e.MvVrInicial)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_INICIAL");
                entity.Property(e => e.MvVrInteres)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_INTERES");
                entity.Property(e => e.MvVrIva)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_IVA");
                entity.Property(e => e.MvVrIvaExp)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_IVA_EXP");
                entity.Property(e => e.MvVrIvaRet)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_IVA_RET");
                entity.Property(e => e.MvVrIvaRetExp)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_IVA_RET_EXP");
                entity.Property(e => e.MvVrLey33)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_LEY_33");
                entity.Property(e => e.MvVrNetoC)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_NETO_C");
                entity.Property(e => e.MvVrOtrasDed)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_OTRAS_DED");
                entity.Property(e => e.MvVrOtrosImp)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_OTROS_IMP");
                entity.Property(e => e.MvVrReten)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_RETEN");
                entity.Property(e => e.MvVrRetenExp)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_RETEN_EXP");
                entity.Property(e => e.MvVrSeguro)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_SEGURO");
                entity.Property(e => e.MvVrTarjeta)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_TARJETA");
                entity.Property(e => e.MvVrTimbre)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VR_TIMBRE");
                entity.Property(e => e.MvVrsGravado1)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_GRAVADO_1");
                entity.Property(e => e.MvVrsGravado2)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_GRAVADO_2");
                entity.Property(e => e.MvVrsGravado3)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_GRAVADO_3");
                entity.Property(e => e.MvVrsGravado4)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_GRAVADO_4");
                entity.Property(e => e.MvVrsGravado5)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_GRAVADO_5");
                entity.Property(e => e.MvVrsGravado6)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_GRAVADO_6");
                entity.Property(e => e.MvVrsIva1)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_IVA_1");
                entity.Property(e => e.MvVrsIva2)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_IVA_2");
                entity.Property(e => e.MvVrsIva3)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_IVA_3");
                entity.Property(e => e.MvVrsIva4)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_IVA_4");
                entity.Property(e => e.MvVrsIva5)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_IVA_5");
                entity.Property(e => e.MvVrsIva6)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_IVA_6");
                entity.Property(e => e.MvVrsReten1)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_RETEN_1");
                entity.Property(e => e.MvVrsReten2)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_RETEN_2");
                entity.Property(e => e.MvVrsReten3)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_RETEN_3");
                entity.Property(e => e.MvVrsReten4)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_RETEN_4");
                entity.Property(e => e.MvVrsReten5)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_RETEN_5");
                entity.Property(e => e.MvVrsReten6)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("MV_VRS_RETEN_6");
                entity.Property(e => e.MvZona)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_ZONA");
                entity.Property(e => e.MvZonap)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MV_ZONAP");
            });

            modelBuilder.Entity<Titiposdocumento>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("TITIPOSDOCUMENTOS");

                entity.HasIndex(e => e.TaTipoDoc, "ITITIPOSDOCUMENTOS0")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.TaNom, "ITITIPOSDOCUMENTOS1");

                entity.Property(e => e.Ta3decVrUnit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_3DEC_VR_UNIT");
                entity.Property(e => e.TaAcTallas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_AC_TALLAS");
                entity.Property(e => e.TaAccidenteTran)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ACCIDENTE_TRAN");
                entity.Property(e => e.TaAfecBodAlotes)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFEC_BOD_ALOTES");
                entity.Property(e => e.TaAfectarCompo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFECTAR_COMPO");
                entity.Property(e => e.TaAfecte)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFECTE");
                entity.Property(e => e.TaAfecteHojaC)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFECTE_HOJA_C");
                entity.Property(e => e.TaAftArticPpal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_ARTIC_PPAL");
                entity.Property(e => e.TaAftCants1)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_CANTS1");
                entity.Property(e => e.TaAftCants2)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_CANTS2");
                entity.Property(e => e.TaAftCantsBd1)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_CANTS_BD1");
                entity.Property(e => e.TaAftCantsBd2)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_CANTS_BD2");
                entity.Property(e => e.TaAftCantsBo1)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_CANTS_BO1");
                entity.Property(e => e.TaAftCantsBo2)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_CANTS_BO2");
                entity.Property(e => e.TaAftCantsL1)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_CANTS_L1");
                entity.Property(e => e.TaAftCantsL2)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_CANTS_L2");
                entity.Property(e => e.TaAftFchs)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_FCHS");
                entity.Property(e => e.TaAftFchsBd)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_FCHS_BD");
                entity.Property(e => e.TaAftFchsBo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_FCHS_BO");
                entity.Property(e => e.TaAftFchsL)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_FCHS_L");
                entity.Property(e => e.TaAftVrs1)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_VRS1");
                entity.Property(e => e.TaAftVrs2)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_VRS2");
                entity.Property(e => e.TaAftVrsBd1)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_VRS_BD1");
                entity.Property(e => e.TaAftVrsBd2)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_VRS_BD2");
                entity.Property(e => e.TaAftVrsBo1)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_VRS_BO1");
                entity.Property(e => e.TaAftVrsBo2)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_VRS_BO2");
                entity.Property(e => e.TaAftVrsL1)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_VRS_L1");
                entity.Property(e => e.TaAftVrsL2)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("TA_AFT_VRS_L2");
                entity.Property(e => e.TaAgruparAut)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_AGRUPAR_AUT");
                entity.Property(e => e.TaAgruparHosp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_AGRUPAR_HOSP");
                entity.Property(e => e.TaAnchoTirilla)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_ANCHO_TIRILLA");
                entity.Property(e => e.TaAnulado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ANULADO");
                entity.Property(e => e.TaAplicarAnt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_APLICAR_ANT");
                entity.Property(e => e.TaAplicarConv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_APLICAR_CONV");
                entity.Property(e => e.TaAproximaPeso)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_APROXIMA_PESO");
                entity.Property(e => e.TaAsigCantPed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ASIG_CANT_PED");
                entity.Property(e => e.TaAsignAntNeg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ASIGN_ANT_NEG");
                entity.Property(e => e.TaAsignarCodTel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ASIGNAR_COD_TEL");
                entity.Property(e => e.TaAsignarExis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ASIGNAR_EXIS");
                entity.Property(e => e.TaAsignarLoteFch)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ASIGNAR_LOTE_FCH");
                entity.Property(e => e.TaAsumirBodArt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ASUMIR_BOD_ART");
                entity.Property(e => e.TaAsumirCostoArt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ASUMIR_COSTO_ART");
                entity.Property(e => e.TaAsumirPrPublico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ASUMIR_PR_PUBLICO");
                entity.Property(e => e.TaAsumirVr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ASUMIR_VR");
                entity.Property(e => e.TaBodExist)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_BOD_EXIST");
                entity.Property(e => e.TaBodega1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_BODEGA1");
                entity.Property(e => e.TaBodega1N)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_BODEGA1_N");
                entity.Property(e => e.TaBodega2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_BODEGA2");
                entity.Property(e => e.TaBodega2N)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_BODEGA2_N");
                entity.Property(e => e.TaBodegaPartes)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_BODEGA_PARTES");
                entity.Property(e => e.TaBodegaPrd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_BODEGA_PRD");
                entity.Property(e => e.TaBorAjenos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_BOR_AJENOS");
                entity.Property(e => e.TaBorrarCompras)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_BORRAR_COMPRAS");
                entity.Property(e => e.TaCCosto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_C_COSTO");
                entity.Property(e => e.TaCCostod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_C_COSTOD");
                entity.Property(e => e.TaCajon)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CAJON");
                entity.Property(e => e.TaCalcularVenta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CALCULAR_VENTA");
                entity.Property(e => e.TaCant1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CANT1");
                entity.Property(e => e.TaCant2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CANT2");
                entity.Property(e => e.TaCantAsumir)
                    .HasColumnType("decimal(5, 0)")
                    .HasColumnName("TA_CANT_ASUMIR");
                entity.Property(e => e.TaCantZeros)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CANT_ZEROS");
                entity.Property(e => e.TaCantidadApr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CANTIDAD_APR");
                entity.Property(e => e.TaCantsFacturar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CANTS_FACTURAR");
                entity.Property(e => e.TaCaptComp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CAPT_COMP");
                entity.Property(e => e.TaCaptCompmp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CAPT_COMPMP");
                entity.Property(e => e.TaCaptDetalle)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CAPT_DETALLE");
                entity.Property(e => e.TaCaptDosis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CAPT_DOSIS");
                entity.Property(e => e.TaCaptFactLin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CAPT_FACT_LIN");
                entity.Property(e => e.TaCaptLoteprov)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CAPT_LOTEPROV");
                entity.Property(e => e.TaCatastrofe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CATASTROFE");
                entity.Property(e => e.TaCentun)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CENTUN");
                entity.Property(e => e.TaCerrarDocto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CERRAR_DOCTO");
                entity.Property(e => e.TaClase)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TA_CLASE");
                entity.Property(e => e.TaClaseDocProd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_CLASE_DOC_PROD");
                entity.Property(e => e.TaClaseHoja)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_CLASE_HOJA");
                entity.Property(e => e.TaClaseInterf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CLASE_INTERF");
                entity.Property(e => e.TaClasePed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CLASE_PED");
                entity.Property(e => e.TaClave)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TA_CLAVE");
                entity.Property(e => e.TaClaveAnular)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CLAVE_ANULAR");
                entity.Property(e => e.TaClaveBorrar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CLAVE_BORRAR");
                entity.Property(e => e.TaCliProv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CLI_PROV");
                entity.Property(e => e.TaCodAfNormal)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_COD_AF_NORMAL");
                entity.Property(e => e.TaCodAfecteRec)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_COD_AFECTE_REC");
                entity.Property(e => e.TaCodAlt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_COD_ALT");
                entity.Property(e => e.TaCodAtencion)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("TA_COD_ATENCION");
                entity.Property(e => e.TaCodCc2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TA_COD_CC2");
                entity.Property(e => e.TaCodDocto)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TA_COD_DOCTO");
                entity.Property(e => e.TaCodDocto2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TA_COD_DOCTO2");
                entity.Property(e => e.TaCodInterf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_COD_INTERF");
                entity.Property(e => e.TaCodReten)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_COD_RETEN");
                entity.Property(e => e.TaCodRetenN)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_COD_RETEN_N");
                entity.Property(e => e.TaComandoCajon)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TA_COMANDO_CAJON");
                entity.Property(e => e.TaComandoDisplay)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TA_COMANDO_DISPLAY");
                entity.Property(e => e.TaConcDevL)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CONC_DEV_L");
                entity.Property(e => e.TaConcep)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CONCEP");
                entity.Property(e => e.TaConcep2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CONCEP2");
                entity.Property(e => e.TaConceptoDev)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CONCEPTO_DEV");
                entity.Property(e => e.TaConcurrencia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CONCURRENCIA");
                entity.Property(e => e.TaConfigProd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CONFIG_PROD");
                entity.Property(e => e.TaConfiguracion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CONFIGURACION");
                entity.Property(e => e.TaConsec)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_CONSEC");
                entity.Property(e => e.TaConsecAutom)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CONSEC_AUTOM");
                entity.Property(e => e.TaConsecInf)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("TA_CONSEC_INF");
                entity.Property(e => e.TaConsecInf1)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("TA_CONSEC_INF1");
                entity.Property(e => e.TaConsecSup)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("TA_CONSEC_SUP");
                entity.Property(e => e.TaConsecSup1)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("TA_CONSEC_SUP1");
                entity.Property(e => e.TaConstruccion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CONSTRUCCION");
                entity.Property(e => e.TaConsultaArt)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TA_CONSULTA_ART");
                entity.Property(e => e.TaContratoCli)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CONTRATO_CLI");
                entity.Property(e => e.TaContratos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CONTRATOS");
                entity.Property(e => e.TaCorreria)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CORRERIA");
                entity.Property(e => e.TaCortarPapel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CORTAR_PAPEL");
                entity.Property(e => e.TaCostear)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_COSTEAR");
                entity.Property(e => e.TaCosteoPrPart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_COSTEO_PR_PART");
                entity.Property(e => e.TaCotizar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_COTIZAR");
                entity.Property(e => e.TaCrearCliente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CREAR_CLIENTE");
                entity.Property(e => e.TaCtaParcial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CTA_PARCIAL");
                entity.Property(e => e.TaCuenta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CUENTA");
                entity.Property(e => e.TaCuentae)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CUENTAE");
                entity.Property(e => e.TaCupoValidado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_CUPO_VALIDADO");
                entity.Property(e => e.TaDecCantHc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DEC_CANT_HC");
                entity.Property(e => e.TaDecDscto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DEC_DSCTO");
                entity.Property(e => e.TaDecVrs)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DEC_VRS");
                entity.Property(e => e.TaDetalle)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DETALLE");
                entity.Property(e => e.TaDiaSem)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("TA_DIA_SEM");
                entity.Property(e => e.TaDiasFact)
                    .HasColumnType("decimal(3, 0)")
                    .HasColumnName("TA_DIAS_FACT");
                entity.Property(e => e.TaDiasVBono)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("TA_DIAS_V_BONO");
                entity.Property(e => e.TaDigAsignada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DIG_ASIGNADA");
                entity.Property(e => e.TaDigitTipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DIGIT_TIPO");
                entity.Property(e => e.TaDirE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DIR_E");
                entity.Property(e => e.TaDisplayExt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DISPLAY_EXT");
                entity.Property(e => e.TaDobleTirilla)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DOBLE_TIRILLA");
                entity.Property(e => e.TaDoctoBono)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_DOCTO_BONO");
                entity.Property(e => e.TaDoctoCorte)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DOCTO_CORTE");
                entity.Property(e => e.TaDoctoD)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_DOCTO_D");
                entity.Property(e => e.TaDoctoEps2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DOCTO_EPS2");
                entity.Property(e => e.TaDoctoSaf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DOCTO_SAF");
                entity.Property(e => e.TaDoctoZona)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_DOCTO_ZONA");
                entity.Property(e => e.TaDscto1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DSCTO1");
                entity.Property(e => e.TaDscto2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DSCTO2");
                entity.Property(e => e.TaDscto3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DSCTO3");
                entity.Property(e => e.TaDsctoAntesIva)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DSCTO_ANTES_IVA");
                entity.Property(e => e.TaDsctoInclIva)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DSCTO_INCL_IVA");
                entity.Property(e => e.TaDsctoIvaIncluido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DSCTO_IVA_INCLUIDO");
                entity.Property(e => e.TaDsctoLIncl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DSCTO_L_INCL");
                entity.Property(e => e.TaDsctoPl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DSCTO_PL");
                entity.Property(e => e.TaDsctoPvl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DSCTO_PVL");
                entity.Property(e => e.TaDsctoVrUnitario)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DSCTO_VR_UNITARIO");
                entity.Property(e => e.TaDsctop1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_DSCTOP1");
                entity.Property(e => e.TaEmbalaje)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EMBALAJE");
                entity.Property(e => e.TaEnfermedad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ENFERMEDAD");
                entity.Property(e => e.TaEntSal)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TA_ENT_SAL");
                entity.Property(e => e.TaEspCorte)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_ESP_CORTE");
                entity.Property(e => e.TaEspecialidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ESPECIALIDAD");
                entity.Property(e => e.TaEstActivKc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_ACTIV_KC");
                entity.Property(e => e.TaEstAfeccpeso)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_AFECCPESO");
                entity.Property(e => e.TaEstAftCupo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_AFT_CUPO");
                entity.Property(e => e.TaEstAftPuntos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_AFT_PUNTOS");
                entity.Property(e => e.TaEstAnulCon)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_ANUL_CON");
                entity.Property(e => e.TaEstApliDto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_APLI_DTO");
                entity.Property(e => e.TaEstArmarobs)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_ARMAROBS");
                entity.Property(e => e.TaEstAsuDscto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_ASU_DSCTO");
                entity.Property(e => e.TaEstCanalVta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_CANAL_VTA");
                entity.Property(e => e.TaEstCaptRollo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_CAPT_ROLLO");
                entity.Property(e => e.TaEstCaptbase)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_CAPTBASE");
                entity.Property(e => e.TaEstCaptest)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_CAPTEST");
                entity.Property(e => e.TaEstCargaPpal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_CARGA_PPAL");
                entity.Property(e => e.TaEstCargarpp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_CARGARPP");
                entity.Property(e => e.TaEstConsol)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_CONSOL");
                entity.Property(e => e.TaEstConsulbd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_CONSULBD");
                entity.Property(e => e.TaEstConsumo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_CONSUMO");
                entity.Property(e => e.TaEstCotiza)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_COTIZA");
                entity.Property(e => e.TaEstCum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_CUM");
                entity.Property(e => e.TaEstDatComp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_DAT_COMP");
                entity.Property(e => e.TaEstDoctoHoja)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_DOCTO_HOJA");
                entity.Property(e => e.TaEstDoctocm1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_DOCTOCM1");
                entity.Property(e => e.TaEstEstam)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_ESTAM");
                entity.Property(e => e.TaEstFactorC)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_FACTOR_C");
                entity.Property(e => e.TaEstFactorInt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_FACTOR_INT");
                entity.Property(e => e.TaEstFchLeg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_FCH_LEG");
                entity.Property(e => e.TaEstFormaPago2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_FORMA_PAGO2");
                entity.Property(e => e.TaEstGencorreo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_GENCORREO");
                entity.Property(e => e.TaEstGrabarestv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_GRABARESTV");
                entity.Property(e => e.TaEstLectura)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_LECTURA");
                entity.Property(e => e.TaEstLegrem)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_LEGREM");
                entity.Property(e => e.TaEstManbonos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_MANBONOS");
                entity.Property(e => e.TaEstMaquina)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_MAQUINA");
                entity.Property(e => e.TaEstMedico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_MEDICO");
                entity.Property(e => e.TaEstNumMillon)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_NUM_MILLON");
                entity.Property(e => e.TaEstOtrosProd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_OTROS_PROD");
                entity.Property(e => e.TaEstPedCod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_PED_COD");
                entity.Property(e => e.TaEstPedirPyp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_PEDIR_PYP");
                entity.Property(e => e.TaEstPosArancel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_POS_ARANCEL");
                entity.Property(e => e.TaEstPosVr)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_EST_POS_VR");
                entity.Property(e => e.TaEstPriordscto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_PRIORDSCTO");
                entity.Property(e => e.TaEstPriorprV)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_PRIORPR_V");
                entity.Property(e => e.TaEstSerial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_SERIAL");
                entity.Property(e => e.TaEstSubensam)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_SUBENSAM");
                entity.Property(e => e.TaEstSugCodeu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_SUG_CODEU");
                entity.Property(e => e.TaEstSusp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_SUSP");
                entity.Property(e => e.TaEstTamVr)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_EST_TAM_VR");
                entity.Property(e => e.TaEstTopeAdm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_TOPE_ADM");
                entity.Property(e => e.TaEstUbicacion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_UBICACION");
                entity.Property(e => e.TaEstValAntini)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_VAL_ANTINI");
                entity.Property(e => e.TaEstValExis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_VAL_EXIS");
                entity.Property(e => e.TaEstValRentab)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_VAL_RENTAB");
                entity.Property(e => e.TaEstVendArt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_VEND_ART");
                entity.Property(e => e.TaEstVerMv2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_VER_MV2");
                entity.Property(e => e.TaEstVrBonif)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EST_VR_BONIF");
                entity.Property(e => e.TaEstadoNormFact)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ESTADO_NORM_FACT");
                entity.Property(e => e.TaEstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ESTATUS");
                entity.Property(e => e.TaExclArticGr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_EXCL_ARTIC_GR");
                entity.Property(e => e.TaFactCont)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FACT_CONT");
                entity.Property(e => e.TaFactIni)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FACT_INI");
                entity.Property(e => e.TaFactLin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FACT_LIN");
                entity.Property(e => e.TaFactUnica)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FACT_UNICA");
                entity.Property(e => e.TaFactUnica2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FACT_UNICA2");
                entity.Property(e => e.TaFactorConv2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FACTOR_CONV2");
                entity.Property(e => e.TaFactorDscto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FACTOR_DSCTO");
                entity.Property(e => e.TaFactura)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FACTURA");
                entity.Property(e => e.TaFch)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FCH");
                entity.Property(e => e.TaFchLlega)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FCH_LLEGA");
                entity.Property(e => e.TaFchSisCart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FCH_SIS_CART");
                entity.Property(e => e.TaFchVence)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FCH_VENCE");
                entity.Property(e => e.TaFechaSale)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FECHA_SALE");
                entity.Property(e => e.TaFechaSaleD)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FECHA_SALE_D");
                entity.Property(e => e.TaFiador)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FIADOR");
                entity.Property(e => e.TaFiador1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FIADOR1");
                entity.Property(e => e.TaFiador2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FIADOR2");
                entity.Property(e => e.TaFletesCosto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FLETES_COSTO");
                entity.Property(e => e.TaFondoFijo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FONDO_FIJO");
                entity.Property(e => e.TaFormaPago)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FORMA_PAGO");
                entity.Property(e => e.TaFormaPagoN)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_FORMA_PAGO_N");
                entity.Property(e => e.TaFormatoImpr)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("TA_FORMATO_IMPR");
                entity.Property(e => e.TaFormatoImpr2)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("TA_FORMATO_IMPR2");
                entity.Property(e => e.TaFuturo1)
                    .HasMaxLength(3997)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO1");
                entity.Property(e => e.TaFuturo2)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO2");
                entity.Property(e => e.TaFuturo3)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO3");
                entity.Property(e => e.TaFuturoRec1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_REC1");
                entity.Property(e => e.TaFuturoRec2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_REC2");
                entity.Property(e => e.TaFuturoRec3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_REC3");
                entity.Property(e => e.TaFuturoRec4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_REC4");
                entity.Property(e => e.TaFuturoRec5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_REC5");
                entity.Property(e => e.TaFuturoTir1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_TIR1");
                entity.Property(e => e.TaFuturoTir10)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_TIR10");
                entity.Property(e => e.TaFuturoTir11)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_TIR11");
                entity.Property(e => e.TaFuturoTir12)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_TIR12");
                entity.Property(e => e.TaFuturoTir2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_TIR2");
                entity.Property(e => e.TaFuturoTir3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_TIR3");
                entity.Property(e => e.TaFuturoTir4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_TIR4");
                entity.Property(e => e.TaFuturoTir5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_TIR5");
                entity.Property(e => e.TaFuturoTir6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_TIR6");
                entity.Property(e => e.TaFuturoTir7)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_TIR7");
                entity.Property(e => e.TaFuturoTir8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_TIR8");
                entity.Property(e => e.TaFuturoTir9)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_FUTURO_TIR9");
                entity.Property(e => e.TaGenBono)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_GEN_BONO");
                entity.Property(e => e.TaGenCart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_GEN_CART");
                entity.Property(e => e.TaGenCliCart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_GEN_CLI_CART");
                entity.Property(e => e.TaGirador)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_GIRADOR");
                entity.Property(e => e.TaGuia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_GUIA");
                entity.Property(e => e.TaHojasC)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_HOJAS_C");
                entity.Property(e => e.TaHoraf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_HORAF");
                entity.Property(e => e.TaHorai)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_HORAI");
                entity.Property(e => e.TaHoras)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_HORAS");
                entity.Property(e => e.TaIgnSucPedidos)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IGN_SUC_PEDIDOS");
                entity.Property(e => e.TaIgnorarBase)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IGNORAR_BASE");
                entity.Property(e => e.TaImpFletes)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IMP_FLETES");
                entity.Property(e => e.TaImpMarca)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IMP_MARCA");
                entity.Property(e => e.TaImpSeguro)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IMP_SEGURO");
                entity.Property(e => e.TaImprCajero)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IMPR_CAJERO");
                entity.Property(e => e.TaImprCli)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IMPR_CLI");
                entity.Property(e => e.TaImprDesc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IMPR_DESC");
                entity.Property(e => e.TaImprDifPed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IMPR_DIF_PED");
                entity.Property(e => e.TaImprDocto2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IMPR_DOCTO2");
                entity.Property(e => e.TaImprEmp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IMPR_EMP");
                entity.Property(e => e.TaImprHora)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IMPR_HORA");
                entity.Property(e => e.TaImprParcial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IMPR_PARCIAL");
                entity.Property(e => e.TaImprPropia)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TA_IMPR_PROPIA");
                entity.Property(e => e.TaImprTerminal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IMPR_TERMINAL");
                entity.Property(e => e.TaImpresionObl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IMPRESION_OBL");
                entity.Property(e => e.TaImprimir)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IMPRIMIR");
                entity.Property(e => e.TaImpuesto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IMPUESTO");
                entity.Property(e => e.TaIncFletesRet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_INC_FLETES_RET");
                entity.Property(e => e.TaIncapacidad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_INCAPACIDAD");
                entity.Property(e => e.TaInicTipoPlaca)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_INIC_TIPO_PLACA");
                entity.Property(e => e.TaInvenExist)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_INVEN_EXIST");
                entity.Property(e => e.TaInvenRc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_INVEN_RC");
                entity.Property(e => e.TaIva)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IVA");
                entity.Property(e => e.TaIvaDscto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IVA_DSCTO");
                entity.Property(e => e.TaIvaInclCosto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IVA_INCL_COSTO");
                entity.Property(e => e.TaIvaLinea)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IVA_LINEA");
                entity.Property(e => e.TaIvaRc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_IVA_RC");
                entity.Property(e => e.TaLetra01)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TA_LETRA_01");
                entity.Property(e => e.TaLetra02)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TA_LETRA_02");
                entity.Property(e => e.TaLetra03)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TA_LETRA_03");
                entity.Property(e => e.TaLetra04)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TA_LETRA_04");
                entity.Property(e => e.TaLetra05)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TA_LETRA_05");
                entity.Property(e => e.TaLifoFifo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_LIFO_FIFO");
                entity.Property(e => e.TaLiqDef)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_LIQ_DEF");
                entity.Property(e => e.TaLotes)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_LOTES");
                entity.Property(e => e.TaLotesArt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_LOTES_ART");
                entity.Property(e => e.TaLotesVenc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_LOTES_VENC");
                entity.Property(e => e.TaMadera)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_MADERA");
                entity.Property(e => e.TaManejaBalanza)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_MANEJA_BALANZA");
                entity.Property(e => e.TaMaxLin)
                    .HasColumnType("decimal(3, 0)")
                    .HasColumnName("TA_MAX_LIN");
                entity.Property(e => e.TaMedicoMv2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_MEDICO_MV2");
                entity.Property(e => e.TaModFpago)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_MOD_FPAGO");
                entity.Property(e => e.TaModifDocto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_MODIF_DOCTO");
                entity.Property(e => e.TaModifPrCli)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_MODIF_PR_CLI");
                entity.Property(e => e.TaModifVr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_MODIF_VR");
                entity.Property(e => e.TaMostrarVenta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_MOSTRAR_VENTA");
                entity.Property(e => e.TaMultiploClub)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TA_MULTIPLO_CLUB");
                entity.Property(e => e.TaNegLotes)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_NEG_LOTES");
                entity.Property(e => e.TaNom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TA_NOM");
                entity.Property(e => e.TaNumAutoriza)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_NUM_AUTORIZA");
                entity.Property(e => e.TaNumClub)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_NUM_CLUB");
                entity.Property(e => e.TaNumCuoIni)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_NUM_CUO_INI");
                entity.Property(e => e.TaNumFacturap)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_NUM_FACTURAP");
                entity.Property(e => e.TaNumFaseFin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_NUM_FASE_FIN");
                entity.Property(e => e.TaOacodCCosto)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("TA_OACOD_C_COSTO");
                entity.Property(e => e.TaOacodConsulkc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TA_OACOD_CONSULKC");
                entity.Property(e => e.TaOacodVended2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OACOD_VENDED2");
                entity.Property(e => e.TaObservaciones)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TA_OBSERVACIONES");
                entity.Property(e => e.TaOestActivo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_ACTIVO");
                entity.Property(e => e.TaOestAmbito1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_AMBITO1");
                entity.Property(e => e.TaOestAmbito2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_AMBITO2");
                entity.Property(e => e.TaOestAmbito3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_AMBITO3");
                entity.Property(e => e.TaOestBorrarLin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_BORRAR_LIN");
                entity.Property(e => e.TaOestCalorden)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_CALORDEN");
                entity.Property(e => e.TaOestCantMv)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_OEST_CANT_MV");
                entity.Property(e => e.TaOestCaptCompad)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_CAPT_COMPAD");
                entity.Property(e => e.TaOestCodIntInv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_COD_INT_INV");
                entity.Property(e => e.TaOestCodbarra)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_CODBARRA");
                entity.Property(e => e.TaOestCodpref)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_CODPREF");
                entity.Property(e => e.TaOestColores)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_COLORES");
                entity.Property(e => e.TaOestConfCrear)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_CONF_CREAR");
                entity.Property(e => e.TaOestContalinea)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_CONTALINEA");
                entity.Property(e => e.TaOestFacAuto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_FAC_AUTO");
                entity.Property(e => e.TaOestFactMed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_FACT_MED");
                entity.Property(e => e.TaOestFactproc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_FACTPROC");
                entity.Property(e => e.TaOestFinanexed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_FINANEXED");
                entity.Property(e => e.TaOestFpcrepos)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_FPCREPOS");
                entity.Property(e => e.TaOestGenEpsFaceUsu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_GEN_EPS_FACE_USU");
                entity.Property(e => e.TaOestGrabaDscto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_GRABA_DSCTO");
                entity.Property(e => e.TaOestImprpro2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_IMPRPRO2");
                entity.Property(e => e.TaOestImprrotul)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_IMPRROTUL");
                entity.Property(e => e.TaOestIntPro)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_INT_PRO");
                entity.Property(e => e.TaOestLiquCiru)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_LIQU_CIRU");
                entity.Property(e => e.TaOestMifactor)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_MIFACTOR");
                entity.Property(e => e.TaOestModnrocuo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_MODNROCUO");
                entity.Property(e => e.TaOestMoneda)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_MONEDA");
                entity.Property(e => e.TaOestMostfra)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_MOSTFRA");
                entity.Property(e => e.TaOestMoverpro)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_MOVERPRO");
                entity.Property(e => e.TaOestNrocub)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_NROCUB");
                entity.Property(e => e.TaOestNroped)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_NROPED");
                entity.Property(e => e.TaOestNumCont)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_NUM_CONT");
                entity.Property(e => e.TaOestNumExp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_NUM_EXP");
                entity.Property(e => e.TaOestNumMin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_NUM_MIN");
                entity.Property(e => e.TaOestOtrasDed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_OTRAS_DED");
                entity.Property(e => e.TaOestPagootr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_PAGOOTR");
                entity.Property(e => e.TaOestPlaca)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_PLACA");
                entity.Property(e => e.TaOestPorcDivi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_PORC_DIVI");
                entity.Property(e => e.TaOestPosart)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_OEST_POSART");
                entity.Property(e => e.TaOestPoscant)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_OEST_POSCANT");
                entity.Property(e => e.TaOestPreciob)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("TA_OEST_PRECIOB");
                entity.Property(e => e.TaOestPrecioc)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("TA_OEST_PRECIOC");
                entity.Property(e => e.TaOestPrgrotul)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_PRGROTUL");
                entity.Property(e => e.TaOestRedival)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_REDIVAL");
                entity.Property(e => e.TaOestTalona)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_TALONA");
                entity.Property(e => e.TaOestTamart)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_OEST_TAMART");
                entity.Property(e => e.TaOestTamcant)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_OEST_TAMCANT");
                entity.Property(e => e.TaOestTipoEps)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_TIPO_EPS");
                entity.Property(e => e.TaOestTipoEpsFaceUsu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_TIPO_EPS_FACE_USU");
                entity.Property(e => e.TaOestTipoFac)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_TIPO_FAC");
                entity.Property(e => e.TaOestTipoNcr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_TIPO_NCR");
                entity.Property(e => e.TaOestTipped)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_TIPPED");
                entity.Property(e => e.TaOestValCama)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_VAL_CAMA");
                entity.Property(e => e.TaOestValCupob)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_VAL_CUPOB");
                entity.Property(e => e.TaOestValPorcd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_VAL_PORCD");
                entity.Property(e => e.TaOestVales)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_VALES");
                entity.Property(e => e.TaOestVdrut)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_VDRUT");
                entity.Property(e => e.TaOestVrprop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OEST_VRPROP");
                entity.Property(e => e.TaOferta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OFERTA");
                entity.Property(e => e.TaOnomCaptPubl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ONOM_CAPT_PUBL");
                entity.Property(e => e.TaOtrosImpIncl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OTROS_IMP_INCL");
                entity.Property(e => e.TaOtrosImpRc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OTROS_IMP_RC");
                entity.Property(e => e.TaOtrosImpl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_OTROS_IMPL");
                entity.Property(e => e.TaPedido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_PEDIDO");
                entity.Property(e => e.TaPedidoE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_PEDIDO_E");
                entity.Property(e => e.TaPermBorrar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_PERM_BORRAR");
                entity.Property(e => e.TaPermCopias)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_PERM_COPIAS");
                entity.Property(e => e.TaPermSinPedido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_PERM_SIN_PEDIDO");
                entity.Property(e => e.TaPeso)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_PESO");
                entity.Property(e => e.TaPorcBono)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("TA_PORC_BONO");
                entity.Property(e => e.TaPorcCopago)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_PORC_COPAGO");
                entity.Property(e => e.TaPorcIvae)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_PORC_IVAE");
                entity.Property(e => e.TaPorcSeguro)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_PORC_SEGURO");
                entity.Property(e => e.TaPosBodBarras)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_POS_BOD_BARRAS");
                entity.Property(e => e.TaPrCostoRc)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("TA_PR_COSTO_RC");
                entity.Property(e => e.TaPrPublico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_PR_PUBLICO");
                entity.Property(e => e.TaPrVentaMin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_PR_VENTA_MIN");
                entity.Property(e => e.TaPrVentaRc)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("TA_PR_VENTA_RC");
                entity.Property(e => e.TaPrecioVenta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_PRECIO_VENTA");
                entity.Property(e => e.TaPrecioVentaL)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_PRECIO_VENTA_L");
                entity.Property(e => e.TaPrefijoSaf)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("TA_PREFIJO_SAF");
                entity.Property(e => e.TaPresup)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_PRESUP");
                entity.Property(e => e.TaProcesoNro)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_PROCESO_NRO");
                entity.Property(e => e.TaPuertoImp)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TA_PUERTO_IMP");
                entity.Property(e => e.TaRecalcularVrs)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_RECALCULAR_VRS");
                entity.Property(e => e.TaRecibo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_RECIBO");
                entity.Property(e => e.TaRedondeoL)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_REDONDEO_L");
                entity.Property(e => e.TaRedondeoRc)
                    .HasColumnType("decimal(1, 0)")
                    .HasColumnName("TA_REDONDEO_RC");
                entity.Property(e => e.TaRegimenComun)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_REGIMEN_COMUN");
                entity.Property(e => e.TaRengIniciales)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_RENG_INICIALES");
                entity.Property(e => e.TaRepetirArtic)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_REPETIR_ARTIC");
                entity.Property(e => e.TaReqAprobCart)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_REQ_APROB_CART");
                entity.Property(e => e.TaResolucionDian)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TA_RESOLUCION_DIAN");
                entity.Property(e => e.TaRestriccionImp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_RESTRICCION_IMP");
                entity.Property(e => e.TaRetIvaInf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_RET_IVA_INF");
                entity.Property(e => e.TaRubro)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_RUBRO");
                entity.Property(e => e.TaRutas)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_RUTAS");
                entity.Property(e => e.TaSaldoPed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_SALDO_PED");
                entity.Property(e => e.TaSalidPartes)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_SALID_PARTES");
                entity.Property(e => e.TaSart)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_SART");
                entity.Property(e => e.TaSdesc)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_SDESC");
                entity.Property(e => e.TaSegundaEps)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_SEGUNDA_EPS");
                entity.Property(e => e.TaSeguroInf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_SEGURO_INF");
                entity.Property(e => e.TaSeparados)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_SEPARADOS");
                entity.Property(e => e.TaSigArtic)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_SIG_ARTIC");
                entity.Property(e => e.TaSignoAfectelp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_SIGNO_AFECTELP");
                entity.Property(e => e.TaSignoAnt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_SIGNO_ANT");
                entity.Property(e => e.TaSignoTalla)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_SIGNO_TALLA");
                entity.Property(e => e.TaSignoVrs)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_SIGNO_VRS");
                entity.Property(e => e.TaSostArtic)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_SOST_ARTIC");
                entity.Property(e => e.TaSostCliente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_SOST_CLIENTE");
                entity.Property(e => e.TaSostDscto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_SOST_DSCTO");
                entity.Property(e => e.TaSostDsctoArt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_SOST_DSCTO_ART");
                entity.Property(e => e.TaStatPed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_STAT_PED");
                entity.Property(e => e.TaStir)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_STIR");
                entity.Property(e => e.TaTamBarras)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_TAM_BARRAS");
                entity.Property(e => e.TaTipoAtencion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_TIPO_ATENCION");
                entity.Property(e => e.TaTipoDoc)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_TIPO_DOC");
                entity.Property(e => e.TaTipoFac)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_TIPO_FAC");
                entity.Property(e => e.TaTipoFacl)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_TIPO_FACL");
                entity.Property(e => e.TaTipoGarantia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_TIPO_GARANTIA");
                entity.Property(e => e.TaTipoPago)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_TIPO_PAGO");
                entity.Property(e => e.TaTipoPed)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_TIPO_PED");
                entity.Property(e => e.TaTipoPresup)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_TIPO_PRESUP");
                entity.Property(e => e.TaTipoRec)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_TIPO_REC");
                entity.Property(e => e.TaTipoValor)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_TIPO_VALOR");
                entity.Property(e => e.TaTirillaCb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_TIRILLA_CB");
                entity.Property(e => e.TaTitulo1)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TA_TITULO1");
                entity.Property(e => e.TaTitulo10)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TA_TITULO10");
                entity.Property(e => e.TaTitulo2)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TA_TITULO2");
                entity.Property(e => e.TaTitulo3)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TA_TITULO3");
                entity.Property(e => e.TaTitulo4)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TA_TITULO4");
                entity.Property(e => e.TaTitulo5)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TA_TITULO5");
                entity.Property(e => e.TaTitulo6)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TA_TITULO6");
                entity.Property(e => e.TaTitulo7)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TA_TITULO7");
                entity.Property(e => e.TaTitulo8)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TA_TITULO8");
                entity.Property(e => e.TaTitulo9)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TA_TITULO9");
                entity.Property(e => e.TaTituloFra)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_TITULO_FRA");
                entity.Property(e => e.TaTransporte)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_TRANSPORTE");
                entity.Property(e => e.TaTtlsNegat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_TTLS_NEGAT");
                entity.Property(e => e.TaUtilRc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_UTIL_RC");
                entity.Property(e => e.TaValDiasFre)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VAL_DIAS_FRE");
                entity.Property(e => e.TaValidaHosp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VALIDA_HOSP");
                entity.Property(e => e.TaValidarCupo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VALIDAR_CUPO");
                entity.Property(e => e.TaValidarFact)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VALIDAR_FACT");
                entity.Property(e => e.TaValidarOferta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VALIDAR_OFERTA");
                entity.Property(e => e.TaValidarTalla)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VALIDAR_TALLA");
                entity.Property(e => e.TaValor1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VALOR1");
                entity.Property(e => e.TaValor2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VALOR2");
                entity.Property(e => e.TaVarios)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VARIOS");
                entity.Property(e => e.TaVended)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VENDED");
                entity.Property(e => e.TaVendedN)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TA_VENDED_N");
                entity.Property(e => e.TaVentanaVrs)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VENTANA_VRS");
                entity.Property(e => e.TaVersionGen)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VERSION_GEN");
                entity.Property(e => e.TaVrAsignarPed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_ASIGNAR_PED");
                entity.Property(e => e.TaVrAsumir)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TA_VR_ASUMIR");
                entity.Property(e => e.TaVrCheques)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_CHEQUES");
                entity.Property(e => e.TaVrCliente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_CLIENTE");
                entity.Property(e => e.TaVrDscto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_DSCTO");
                entity.Property(e => e.TaVrDsctoPv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_DSCTO_PV");
                entity.Property(e => e.TaVrEfectivo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_EFECTIVO");
                entity.Property(e => e.TaVrExento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_EXENTO");
                entity.Property(e => e.TaVrFactConv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_FACT_CONV");
                entity.Property(e => e.TaVrFinancia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_FINANCIA");
                entity.Property(e => e.TaVrFletes)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_FLETES");
                entity.Property(e => e.TaVrGravado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_GRAVADO");
                entity.Property(e => e.TaVrIva)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_IVA");
                entity.Property(e => e.TaVrOblig)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_OBLIG");
                entity.Property(e => e.TaVrOtrosImp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_OTROS_IMP");
                entity.Property(e => e.TaVrPublico)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_PUBLICO");
                entity.Property(e => e.TaVrRetencion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_RETENCION");
                entity.Property(e => e.TaVrSeguro)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_SEGURO");
                entity.Property(e => e.TaVrSeparados)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_SEPARADOS");
                entity.Property(e => e.TaVrTarjeta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VR_TARJETA");
                entity.Property(e => e.TaVrsLinea)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_VRS_LINEA");
                entity.Property(e => e.TaZonaAs)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TA_ZONA_AS");
                entity.Property(e => e.TaZonaN)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TA_ZONA_N");
            });

            modelBuilder.Entity<VistaPrueba>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("VISTA_PRUEBA");

                entity.Property(e => e.Clase)
                    .HasMaxLength(2)
                    .IsUnicode(false);
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Numero).HasColumnType("decimal(10, 0)");
                entity.Property(e => e.Producto)
                    .HasMaxLength(20)
                    .IsUnicode(false);
                entity.Property(e => e.Tipo)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

        }

        

    }
}
