﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSiteBanBachHoa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Loai_San_Pham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Loai_San_Pham()
        {
            this.San_Pham = new HashSet<San_Pham>();
        }

        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [Display(Name = "Mã loại sản phẩm")]
        public int id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [Display(Name = "Tên loại sản phẩm")]
        public string tenloaiSP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<San_Pham> San_Pham { get; set; }
    }
}