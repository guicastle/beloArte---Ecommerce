//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace beloArte.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class BA_CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BA_CLIENTE()
        {
            this.BA_ENDERECO = new HashSet<BA_ENDERECO>();
            this.BA_USUARIO = new HashSet<BA_USUARIO>();
        }
    
        public int CODCLIENTE { get; set; }
        public string NOME { get; set; }
        public string EMAIL { get; set; }
        public string SEXO { get; set; }
        public string CPF { get; set; }
        public string TELEFONE { get; set; }
        public Nullable<System.DateTime> DTNASCIMENTO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BA_ENDERECO> BA_ENDERECO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BA_USUARIO> BA_USUARIO { get; set; }
    }
}
