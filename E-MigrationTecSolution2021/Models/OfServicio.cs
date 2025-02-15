﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_MigrationTecSolution2021.Models
{
    public class OfServicio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NombreDelServicio { get; set; }
        [Required]
        public int MaximoNumeroDeMigrantes { get; set; }
        [Required]
        public string FechaDeInicio { get; set; }
        [Required]
        public string FechaDeFinalizacion { get; set; }
        [Required]
        public string EstadoServicio { get; set; }
    }
}
