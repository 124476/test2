//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NyamNyam.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingredient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingredient()
        {
            this.OneRechept = new HashSet<OneRechept>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Kol { get; set; }
        public string Sum { get; set; }
        public Nullable<int> MainInitId { get; set; }
    
        public virtual MainInit MainInit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OneRechept> OneRechept { get; set; }
    }
}
