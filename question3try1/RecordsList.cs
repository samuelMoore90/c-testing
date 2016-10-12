using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Text.RegularExpressions;

namespace question3try1
{
    
    public class RecordsList
    {
        public List<Records> recordslist = new List<Records>();

        public string Coursecode(string cc)
        {
            string courseReg = "^(PG|UG)[a-zA-Z0-9]{6}$";

            if(Regex.IsMatch(cc, courseReg))
            {
                return "expression is good";
            }
            else
            {
                return "not good";
            }
        }

        public string AddRecord(string coursecode, string fn, string ln, DateTime st, DateTime gy)
        {
            Records r = new Records();
            r.CourseCode = coursecode;
            r.fname = fn;
            r.lname = ln;
            r.StartYear = st;
            r.GraduationYear = gy;
            string courseReg = "^(PG|UG)[a-zA-Z0-9]{6}$";


            if (st > DateTime.Now || gy.Year - st.Year > 6)
            {
                return "Not done";
            }
          
            else
            {
                if(Regex.IsMatch(coursecode, courseReg))
                {
                    recordslist.Add(r);
                    return "Yaaaay REcord Added";
                }
                return "Not done";

            }


        }

        public string DeleteRecord(Records rec)
        {
            // Records r = new Records();
                recordslist.Remove(rec);
           
                return "record removed";

            
        }
    }
}
