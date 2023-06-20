using System;
using System.Collections.Generic;

namespace PjTiendaVideojuego.Models;

public partial class Producto
{
    public string? IdProducto { get; set; }

    public string? NombreProd { get; set; }

    public string? DescripcionProd { get; set; }

    public double? PrecioProduc { get; set; }
}
