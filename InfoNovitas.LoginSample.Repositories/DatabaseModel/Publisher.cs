//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InfoNovitas.LoginSample.Repositories.DatabaseModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Publisher
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public System.DateTimeOffset DateCreated { get; set; }
        public int UserCreated { get; set; }
        public Nullable<System.DateTimeOffset> LastModified { get; set; }
        public Nullable<int> UserLastModified { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
        public virtual UserInfo UserInfo1 { get; set; }
    }
}
