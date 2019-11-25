using System;
using System.Collections.Generic;
using System.Text;

namespace PersonProject
{
    public class Subject
    {
        private String subject = "";
        public void SetSubject(string SubjectToSet)
        {
            subject = SubjectToSet;
        }
        public string GetSubject()
        {
            return subject;
        }
    }

}
