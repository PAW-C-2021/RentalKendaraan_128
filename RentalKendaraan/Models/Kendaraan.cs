﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }
        [Required(ErrorMessage = "Nama Kendaraan tidak boleh kosong")]
        public string NamaKendaraan { get; set; }
        [Required(ErrorMessage = "Nomor Polisi tidak boleh kosong")]
        public string NoPolisi { get; set; }
        [Required(ErrorMessage = "Nomor STNK tidak boleh kosong")]
        public string NoStnk { get; set; }
        public int? IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "Ketersediaan tidak boleh kosong")]
        public string Ketersediaan { get; set; }

        public virtual JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public virtual ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
