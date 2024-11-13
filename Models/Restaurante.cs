using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PRIMER_MVC.Models;

public partial class Restaurante
{
    [Key]
    public int IdRestaurante { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public string? Telefono { get; set; }

    public int? Capacidad { get; set; }

    public string? TipoCocina { get; set; }
}
