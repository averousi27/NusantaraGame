//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NusantaraGame
{
    using System;
    using System.Collections.Generic;
    
    public partial class Provinsi
    {
        public int SoalId { get; set; }
        public string Soal { get; set; }
        public string UrlGambar { get; set; }
        public Nullable<int> LevelSoal { get; set; }
        public string IbuKota { get; set; }
        public string LuasWilayah { get; set; }
        public string Suku { get; set; }
        public string BahasaDaerah { get; set; }
        public byte[] RumahAdat { get; set; }
        public byte[] BajuAdat { get; set; }
        public string Flora { get; set; }
        public string Fauna { get; set; }
        public string PotensiAlam { get; set; }
        public string TempatWisata { get; set; }
    
        public virtual PlayerSoal PlayerSoal { get; set; }
    }
}
