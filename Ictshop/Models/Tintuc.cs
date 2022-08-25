using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial; 

    [Table("Tintuc")]
    public partial class Tintuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tintuc()
        {
            
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Tieude { get; set; }

        public string Noidung { get; set; }
        public string Hinhanh { get; set; }

        public int? MaNguoidung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        

        public virtual Nguoidung Nguoidung { get; set; }

    }
}