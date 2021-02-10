using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExcelUploadDemo
{
    public class PI : User
    {
        private string department;

        public PI(string tuid, string department)
        {
            this.TUID = tuid;
            this.Department = department;
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

    }
}