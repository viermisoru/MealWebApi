//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMenuItem
    {
        public tblMenuItem()
        {
            this.tblUserMenus = new HashSet<tblUserMenu>();
        }
    
        public long MenuItemID { get; set; }
        public Nullable<long> MenuID { get; set; }
        public Nullable<long> ProviderMenuItemID { get; set; }
        public Nullable<int> SortIndex { get; set; }
    
        public virtual tblMenu tblMenu { get; set; }
        public virtual tblProviderMenuItem tblProviderMenuItem { get; set; }
        public virtual ICollection<tblUserMenu> tblUserMenus { get; set; }
    }
}
