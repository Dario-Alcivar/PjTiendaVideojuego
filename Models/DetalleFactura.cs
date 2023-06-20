using System;
using System.Collections.Generic;

namespace PjTiendaVideojuego.Models;

public partial class DetalleFactura
{
    public string? IdDetalleFactura { get; set; }

    public string? IdProducto { get; set; }

    public string? IdCliente { get; set; }

    public decimal? Cantidad { get; set; }

    public double? PrecioUnit { get; set; }
}
