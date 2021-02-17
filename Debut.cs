//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChessOpening
{
    using System;
    using System.Collections.Generic;
    
    public partial class Debut
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Debut()
        {
            this.Games = new HashSet<Game>();
        }
    
        public int DebutID { get; set; }
        public string TitleDebut { get; set; }
        public byte NumberMoves { get; set; }
        public string ListMoves { get; set; }
        public int NumberGames { get; set; }
        public int NumberWinsWhite { get; set; }
        public int NumberWinsBlack { get; set; }
        public int NumberDraw { get; set; }
        public Nullable<int> PercentWinsWhite { get; set; }
        public Nullable<int> PercentWinsBlack { get; set; }
        public Nullable<int> PercentDraw { get; set; }
        public string Comment { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game> Games { get; set; }
    }
}