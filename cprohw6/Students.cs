using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cprohw6
{
    static class Students
    {
        private static List<string> _Students = new List<string>();

        public static List<string> students { get { return _Students; } }

        public static string FindStudent(string studentName)
        {
            string origName = string.Empty;
            bool success = false;

            foreach (string student in _Students)
            {
                bool contains = student.ToLower().Contains(studentName.ToLower());
                if (contains)
                {
                    origName = student;
                    success = true;
                }
            }
            return origName;
        }

        public static void AddStudent(string studentName)
        {
            _Students.Add(studentName);
        }

        public static bool RemoveStudent(string contactName)
        {
            string Student = FindStudent(contactName);
            if (Student != string.Empty)
                _Students.Remove(Student);

            return Student != string.Empty;
        }
    }
}
