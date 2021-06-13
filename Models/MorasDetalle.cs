﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace PrestamosDetalle.Models
{
    public class MorasDetalle
    {

        [Key]
        public int Id { get; set; }
        public int MoraId { get; set; }
        public int PrestamoId { get; set; }
        public string NombrePersona { get; set; }
        public double Valor { get; set; }

    }
}
