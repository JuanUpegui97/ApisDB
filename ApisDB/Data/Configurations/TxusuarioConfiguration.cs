using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApisDB.Models;


namespace ApisDB.Data.Configurations
{
    public class TxusuarioConfiguration : IEntityTypeConfiguration<Txusuario>
    {
        public void Configure(EntityTypeBuilder<Txusuario> entity)
        {
            entity
                .HasNoKey()
                .ToTable("TXUSUARIOS", tb => tb.HasTrigger("TRG_Auditar_TXUSUARIOS"));

            entity.HasIndex(e => e.UxCod, "ITXUSUARIOS0")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => e.UxNom, "ITXUSUARIOS1");

            entity.Property(e => e.UxActivosFijos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_ACTIVOS_FIJOS");
            entity.Property(e => e.UxBase)
                .HasColumnType("decimal(15, 0)")
                .HasColumnName("UX_BASE");
            entity.Property(e => e.UxCCostoFin)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("UX_C_COSTO_FIN");
            entity.Property(e => e.UxCCostoIni)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("UX_C_COSTO_INI");
            entity.Property(e => e.UxCancelarProc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_CANCELAR_PROC");
            entity.Property(e => e.UxCartera)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_CARTERA");
            entity.Property(e => e.UxCarteraCoop)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_CARTERA_COOP");
            entity.Property(e => e.UxCarteraFin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_CARTERA_FIN");
            entity.Property(e => e.UxCharBusq)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_CHAR_BUSQ");
            entity.Property(e => e.UxClave)
                .HasColumnType("decimal(6, 0)")
                .HasColumnName("UX_CLAVE");
            entity.Property(e => e.UxClave2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("UX_CLAVE2");
            entity.Property(e => e.UxClaveAut)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("UX_CLAVE_AUT");
            entity.Property(e => e.UxCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("UX_COD");
            entity.Property(e => e.UxCodImpr)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("UX_COD_IMPR");
            entity.Property(e => e.UxCodTerminal)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("UX_COD_TERMINAL");
            entity.Property(e => e.UxConsecAutom)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_CONSEC_AUTOM");
            entity.Property(e => e.UxContab)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_CONTAB");
            entity.Property(e => e.UxCostos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_COSTOS");
            entity.Property(e => e.UxEmp)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("UX_EMP");
            entity.Property(e => e.UxEstActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_EST_ACTIVO");
            entity.Property(e => e.UxEstAyd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_EST_AYD");
            entity.Property(e => e.UxEstCaptPaga)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_EST_CAPT_PAGA");
            entity.Property(e => e.UxEstPerfilrol)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_EST_PERFILROL");
            entity.Property(e => e.UxEstPrecios)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_EST_PRECIOS");
            entity.Property(e => e.UxEstVeri)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_EST_VERI");
            entity.Property(e => e.UxFacturaHospit)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_FACTURA_HOSPIT");
            entity.Property(e => e.UxFchVence)
                .HasColumnType("decimal(8, 0)")
                .HasColumnName("UX_FCH_VENCE");
            entity.Property(e => e.UxFuturo1)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("UX_FUTURO1");
            entity.Property(e => e.UxFuturo2)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("UX_FUTURO2");
            entity.Property(e => e.UxFuturo3)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("UX_FUTURO3");
            entity.Property(e => e.UxFuturo4)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("UX_FUTURO4");
            entity.Property(e => e.UxGrabaF5)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_GRABA_F5");
            entity.Property(e => e.UxImpr)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("UX_IMPR");
            entity.Property(e => e.UxInven)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_INVEN");
            entity.Property(e => e.UxMenu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_MENU");
            entity.Property(e => e.UxModuloNormal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_MODULO_NORMAL");
            entity.Property(e => e.UxNom)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("UX_NOM");
            entity.Property(e => e.UxNomina)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_NOMINA");
            entity.Property(e => e.UxOestCostos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_OEST_COSTOS");
            entity.Property(e => e.UxOestCuadrot)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_OEST_CUADROT");
            entity.Property(e => e.UxOestGlosas)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_OEST_GLOSAS");
            entity.Property(e => e.UxOestHiscli)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_OEST_HISCLI");
            entity.Property(e => e.UxOtrosMeses)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_OTROS_MESES");
            entity.Property(e => e.UxPerfilUsu)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("UX_PERFIL_USU");
            entity.Property(e => e.UxPrefer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_PREFER");
            entity.Property(e => e.UxPresupuesto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_PRESUPUESTO");
            entity.Property(e => e.UxPrg)
                .HasColumnType("decimal(4, 0)")
                .HasColumnName("UX_PRG");
            entity.Property(e => e.UxPrgUnico)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_PRG_UNICO");
            entity.Property(e => e.UxProduccion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_PRODUCCION");
            entity.Property(e => e.UxPuntoVenta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_PUNTO_VENTA");
            entity.Property(e => e.UxRango1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_RANGO1");
            entity.Property(e => e.UxRango2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_RANGO2");
            entity.Property(e => e.UxRecursoHum)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_RECURSO_HUM");
            entity.Property(e => e.UxSalCta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_SAL_CTA");
            entity.Property(e => e.UxTerm)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UX_TERM");
            entity.Property(e => e.UxTesoreria)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_TESORERIA");
            entity.Property(e => e.UxTipoa)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UX_TIPOA");
            entity.Property(e => e.UxTipof)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UX_TIPOF");
            entity.Property(e => e.UxTipor)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UX_TIPOR");
            entity.Property(e => e.UxUtilitarios)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UX_UTILITARIOS");
        }
    
    }
}
