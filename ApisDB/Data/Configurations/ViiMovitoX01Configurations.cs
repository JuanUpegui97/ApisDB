using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApisDB.Models;


namespace ApisDB.Data.Configurations
{
    public class ViiMovitoX01Configurations : IEntityTypeConfiguration<ViiMovitoX01>
    {
        public void Configure(EntityTypeBuilder<ViiMovitoX01> entity)
        {
            entity
                    .HasNoKey()
                    .ToView("VII_MOVITO_X01");

            entity.Property(e => e.Ano)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ANO");
            entity.Property(e => e.Articulo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Bodega1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("BODEGA1");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.CentroCostoDetalle)
                .HasMaxLength(73)
                .IsUnicode(false)
                .HasColumnName("CENTRO_COSTO_DETALLE");
            entity.Property(e => e.CentroCostosEncabezado)
                .HasMaxLength(73)
                .IsUnicode(false)
                .HasColumnName("CENTRO_COSTOS_ENCABEZADO");
            entity.Property(e => e.ClaseDocto)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("CLASE_DOCTO");
            entity.Property(e => e.CodigoProveedor)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("CODIGO PROVEEDOR");
            entity.Property(e => e.ConceptoExt)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("CONCEPTO_EXT");
            entity.Property(e => e.ConfIvaEnArticulo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CONF.IVA EN ARTICULO");
            entity.Property(e => e.CostoUnitario)
                .HasColumnType("decimal(16, 3)")
                .HasColumnName("COSTO UNITARIO");
            entity.Property(e => e.CumArticulo)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("CUM_ARTICULO");
            entity.Property(e => e.CumMvto)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("CUM_MVTO");
            entity.Property(e => e.Documento)
                .HasMaxLength(54)
                .IsUnicode(false)
                .HasColumnName("DOCUMENTO");
            entity.Property(e => e.EstRegInvima)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EST. REG.INVIMA");
            entity.Property(e => e.EstadoDelDocumento)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("ESTADO DEL DOCUMENTO");
            entity.Property(e => e.EstadoDocto)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("ESTADO DOCTO");
            entity.Property(e => e.Factura)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("FACTURA");
            entity.Property(e => e.Fecha)
                .HasColumnType("decimal(8, 0)")
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaDigitacion)
                .HasColumnType("decimal(8, 0)")
                .HasColumnName("FECHA_DIGITACION");
            entity.Property(e => e.FechaVenceLote)
                .HasColumnType("decimal(8, 0)")
                .HasColumnName("FECHA VENCE LOTE");
            entity.Property(e => e.GrupoArticulo)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("GRUPO_ARTICULO");
            entity.Property(e => e.Hora)
                .HasColumnType("decimal(8, 0)")
                .HasColumnName("HORA");
            entity.Property(e => e.Impreso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IMPRESO");
            entity.Property(e => e.InventarioEntSal)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("INVENTARIO ENT-SAL");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("% IVA");
            entity.Property(e => e.Linea)
                .HasColumnType("decimal(5, 0)")
                .HasColumnName("LINEA");
            entity.Property(e => e.Mes)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MES");
            entity.Property(e => e.MesNomb)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("MES-NOMB");
            entity.Property(e => e.NoLote)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NO._LOTE");
            entity.Property(e => e.NombreArticulo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_ARTICULO");
            entity.Property(e => e.NombreProveedor)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NOMBRE PROVEEDOR");
            entity.Property(e => e.Numero)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Pedido)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("PEDIDO");
            entity.Property(e => e.Presentacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRESENTACION");
            entity.Property(e => e.RegistroInvima)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("REGISTRO INVIMA");
            entity.Property(e => e.SeqProv)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SEQ PROV");
            entity.Property(e => e.Tipo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.TipoYNumero)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("TIPO Y NUMERO");
            entity.Property(e => e.Titular)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("TITULAR");
            entity.Property(e => e.TotalIvaLinea)
                .HasColumnType("decimal(38, 11)")
                .HasColumnName("TOTAL + IVA LINEA");
            entity.Property(e => e.Trimestre)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("TRIMESTRE");
            entity.Property(e => e.Usuario)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.ValorCosto)
                .HasColumnType("decimal(29, 6)")
                .HasColumnName("VALOR COSTO");
            entity.Property(e => e.ValorEntidad)
                .HasColumnType("decimal(30, 6)")
                .HasColumnName("VALOR ENTIDAD");
            entity.Property(e => e.ValorIVA)
                .HasColumnType("decimal(38, 12)")
                .HasColumnName("VALOR I.V.A");
            entity.Property(e => e.ValorLinea)
                .HasColumnType("decimal(29, 6)")
                .HasColumnName("VALOR LINEA");
            entity.Property(e => e.ValorUsuario)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("VALOR USUARIO");
            entity.Property(e => e.VrUnitario)
                .HasColumnType("decimal(16, 3)")
                .HasColumnName("VR. UNITARIO");
            entity.Property(e => e.ZonaProv)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ZONA PROV");

        }
    }
}
