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

    public partial class Chi_Tiet_Don_Hang
    {
        [Display(Name = "")]
        public int id { get; set; }

        [Display(Name = "Tên Sản Phẩm")]
        public string tenSP { get; set; }

        [Display(Name = "Giá")]
        public Nullable<double> gia { get; set; }

        [Display(Name = "Số lượng")]
        public Nullable<int> soluong { get; set; }

        [Display(Name = "Tổng tiền")]
        public Nullable<double> tonggia { get; set; }

        [Display(Name = "")]
        public int idSP { get; set; }

        [Display(Name = "")]
        public int idDonHang { get; set; }

        
    
        public virtual Don_Hang Don_Hang { get; set; }
        public virtual San_Pham San_Pham { get; set; }
    }
}
