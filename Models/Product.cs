using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace TugasCRUDMVC.Models
{
    public partial class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public int? Price { get; set; }
        public string Description { get; set; }
        public Guid ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
    }
}
