﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeguroIntegral.Entidades;

namespace Cobertura.Entidades
{
    public class Cobertura
    {
        public int idCobertura { get; set; }
        public string codigo { get; set; }
        public Formato objFormato { get; set; }
        public DateTime fechaSolicitud { get; set; }
        public DateTime fechaAprobada { get; set; }
        public Double  monto{ get; set; }
        public string observacion { get; set; }
        public bool activo { get; set; }
    }
}
