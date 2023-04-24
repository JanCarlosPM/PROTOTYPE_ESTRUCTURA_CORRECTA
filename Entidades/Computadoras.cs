namespace Entidades
{
    
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Computadoras
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Marca { get; set; }

        [Required]
        [StringLength(50)]
        public string Modelo { get; set; }

        [Required]
        [StringLength(50)]
        public string Procesador { get; set; }

        public int MemoriaRam { get; set; }

        public int Almacenamiento { get; set; }

        [Required]
        [StringLength(50)]
        public string SistemaOperativo { get; set; }
    }
}
