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
    
    public partial class mt_userlike
    {
        public string mt_userlike_id { get; set; }
        public string mt_article_id { get; set; }
        public string mt_user_id { get; set; }
    
        public virtual mt_user mt_user { get; set; }
    }
}
