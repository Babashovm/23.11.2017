//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace News_Full.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.News = new HashSet<News>();
        }
    
        public int id { get; set; }
        public string user_name { get; set; }
        public string user_surname { get; set; }
        public string user_email { get; set; }
        public string user_login { get; set; }
        public string user_password { get; set; }
        public int user_is_login { get; set; }
        public int user_level { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<News> News { get; set; }
        public virtual Users_Level Users_Level { get; set; }
    }
}