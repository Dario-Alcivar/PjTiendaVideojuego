using System;
using System.Collections.Generic;

namespace PjTiendaVideojuego.Models;

public partial class Cliente
{
    public string? IdCliente { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? Correo { get; set; }

    public DateTime? FechaNac { get; set; }
}
