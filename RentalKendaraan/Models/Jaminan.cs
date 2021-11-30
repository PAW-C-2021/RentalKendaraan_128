﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Jaminan
    {
        public Jaminan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdJaminan { get; set; }
        [Required(ErrorMessage = "Jaminan tidak boleh kosong")]
        public string NamaJaminan { get; set; }

        public virtual ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
