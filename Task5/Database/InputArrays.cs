//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task5.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class InputArrays
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InputArrays()
        {
            this.SortedArrays = new HashSet<SortedArrays>();
        }
    
        public int iInputArrayId { get; set; }
        public int iNumberOfRows { get; set; }
        public int iNumberOfColumns { get; set; }
        public string vcInputArrayContent { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SortedArrays> SortedArrays { get; set; }
    }
}
