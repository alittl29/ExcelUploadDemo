using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExcelUploadDemo
{
    public class Student : User
    {
        private string program;

        public Student(string tuid, string program)
        {
            this.TUID = tuid;
            this.Program = program;
        }

        public string Program
        {
            get { return program; }
            set { program = value; }
        }

    }
}