//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace books.Models.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class book
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string author { get; set; }
        public string editorial { get; set; }
        public string edition { get; set; }
        public string publication { get; set; }
        public decimal id_city { get; set; }
        public string Country { get; set; }
    
        public virtual Ciudad Ciudad { get; set; }
    }
}
