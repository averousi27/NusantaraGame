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
    
    public partial class Player
    {
        public Player()
        {
            this.PlayerSoals = new HashSet<PlayerSoal>();
        }
    
        public int PlayerId { get; set; }
        public Nullable<int> LastNyawa { get; set; }
        public Nullable<int> LastScore { get; set; }
    
        public virtual ICollection<PlayerSoal> PlayerSoals { get; set; }
    }
}
