using System;
using System.Collections.Generic;

namespace ApisDB.Models;

public partial class ViiMovitoX01
{
    public string? Documento { get; set; }

    public string Tipo { get; set; } = null!;

    public decimal Numero { get; set; }

    public decimal? Linea { get; set; }

    public string? ClaseDocto { get; set; }

    public decimal? Fecha { get; set; }

    public string? TipoYNumero { get; set; }

    public string Impreso { get; set; } = null!;

    public string? EstadoDocto { get; set; }

    public string ZonaProv { get; set; } = null!;

    public string CodigoProveedor { get; set; } = null!;

    public string SeqProv { get; set; } = null!;

    public string NombreProveedor { get; set; } = null!;

    public string EstRegInvima { get; set; } = null!;

    public string Articulo { get; set; } = null!;

    public string NombreArticulo { get; set; } = null!;

    public string Presentacion { get; set; } = null!;

    public string Bodega1 { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public decimal VrUnitario { get; set; }

    public decimal? ValorLinea { get; set; }

    public decimal CostoUnitario { get; set; }

    public decimal? ValorCosto { get; set; }

    public decimal? ValorUsuario { get; set; }

    public decimal? ValorEntidad { get; set; }

    public decimal? Iva { get; set; }

    public decimal? ValorIVA { get; set; }

    public decimal? TotalIvaLinea { get; set; }

    public string CentroCostosEncabezado { get; set; } = null!;

    public string CentroCostoDetalle { get; set; } = null!;

    public string ConfIvaEnArticulo { get; set; } = null!;

    public string? GrupoArticulo { get; set; }

    public string NoLote { get; set; } = null!;

    public decimal FechaVenceLote { get; set; }

    public string Titular { get; set; } = null!;

    public string RegistroInvima { get; set; } = null!;

    public string? CumMvto { get; set; }

    public string? CumArticulo { get; set; }

    public string? EstadoDelDocumento { get; set; }

    public string? Ano { get; set; }

    public string? Mes { get; set; }

    public string? MesNomb { get; set; }

    public string Trimestre { get; set; } = null!;

    public string? Pedido { get; set; }

    public string? Factura { get; set; }

    public string? ConceptoExt { get; set; }

    public string? InventarioEntSal { get; set; }

    public string Usuario { get; set; } = null!;

    public decimal FechaDigitacion { get; set; }

    public decimal Hora { get; set; }
}
