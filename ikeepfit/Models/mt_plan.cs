//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ikeepfit.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class mt_plan
    {
        public mt_plan()
        {
            this.mt_planday = new HashSet<mt_planday>();
            this.mt_planmark = new HashSet<mt_planmark>();
        }
    
        public string mt_plan_id { get; set; }
        public string mt_plan_name { get; set; }
        public string mt_plan_title { get; set; }
        public string mt_plan_remarks { get; set; }
        public string mt_plan_week { get; set; }
        public Nullable<int> mt_plan_day { get; set; }
        public string mt_plan_strength { get; set; }
    
        public virtual ICollection<mt_planday> mt_planday { get; set; }
        public virtual ICollection<mt_planmark> mt_planmark { get; set; }
    }
}