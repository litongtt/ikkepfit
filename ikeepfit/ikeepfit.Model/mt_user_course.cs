//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ikeepfit.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class mt_user_course
    {
        public string mt_course_id { get; set; }
        public string mt_user_courseid { get; set; }
        public Nullable<int> mt_user_coursekday { get; set; }
        public string mt_usercourse_kmotion { get; set; }
        public string mt_usercourse_ktime { get; set; }
        public string mt_usercourse_kcalorie { get; set; }
        public string mt_user_id { get; set; }
    
        public virtual mt_user mt_user { get; set; }
    }
}
