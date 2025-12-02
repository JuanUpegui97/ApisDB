using System;
using System.Collections.Generic;

namespace ApisDB.Models;

public partial class VistaPrueba
{
    public string Tipo { get; set; } = null!;

    public decimal Numero { get; set; }

    public string? Nombre { get; set; }

    public string? Clase { get; set; }

    public string? Producto { get; set; }

    public string? Descripcion { get; set; }
}
