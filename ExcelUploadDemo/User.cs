using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExcelUploadDemo
{
    public abstract class User
    {
        private string tuid;

        public string TUID
        {
            get { return tuid; }
            set { tuid = value; }
        }
        
    }
}