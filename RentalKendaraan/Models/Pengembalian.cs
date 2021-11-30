using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Pengembalian
    {
        public int IdPemngembalian { get; set; }
        [Required(ErrorMessage = "Tanggal Pengembalian tidak boleh kosong")]
        public DateTime? TglPengembalian { get; set; }
        public int? IdPeminjaman { get; set; }
        public int? IdKondisi { get; set; }
        [Required(ErrorMessage = "Denda tidak boleh kosong")]
        public int? Denda { get; set; }

        public virtual  KondisiKendaraan IdKondisiNavigation { get; set; }
        public virtual Peminjaman IdPeminjamanNavigation { get; set; }
        public int? IdPengembalian { get; internal set; }
    }
}
